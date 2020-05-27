using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dnlib.DotNet;
using Microsoft.Build.Tasks.Deployment.ManifestUtilities;
using Exception = System.Exception;

namespace DotNetDeserializationScanner
{
    class Program
    {
        public delegate void OnProgressFunction(int total);
        public static ProgressBar pb = new ProgressBar();
        public static int processedCount = 0;

        public static void OnProgress(int total)
        {
            pb.Report((double)processedCount / total, $" {processedCount} / {total}");
        }


        static IEnumerable<FileInfo> TraverseDirectory(string rootPath, Func<FileInfo, bool> Pattern, OnProgressFunction onProgress)
        {
            var directoryStack = new Stack<DirectoryInfo>();
            directoryStack.Push(new DirectoryInfo(rootPath));
            int totalCount = 0;
            while (directoryStack.Count > 0)
            {
                var dir = directoryStack.Pop();
                try
                {
                    foreach (var i in dir.GetDirectories())
                        directoryStack.Push(i);
                }
                catch (UnauthorizedAccessException)
                {
                    continue; // We don't have access to this directory, so skip it
                }

                foreach (var f in dir.GetFiles().Where(Pattern)) // "Pattern" is a function
                {
                    totalCount++;
                    onProgress(totalCount);
                    yield return f;
                }
            }
        }

        class MemberReference
        {
            public MemberReference(MemberRef memberRef, string originalAssembly)
            {
                try
                {
                    OriginalAssembly = originalAssembly;
                    AssemblyFullName = memberRef.DeclaringType.DefinitionAssembly.FullName;
                    AssemblyPath = memberRef.DeclaringType.ResolveTypeDef()?.Module.Location;
                    TypeName = memberRef.DeclaringType.FullName;
                    MethodReturnType = memberRef.MethodSig != null ? memberRef.MethodSig.RetType.ToString() : null;
                    MethodName = memberRef.Name;
                    MethodParms = memberRef.MethodSig?.Params;
                    Method = memberRef.FullName;
                }
                catch (Exception e)
                {
                    if (!Regex.IsMatch(originalAssembly, "sharphound", RegexOptions.IgnoreCase))
                    {
                        Console.WriteLine(e);
                    }
                }
            }

            public string OriginalAssembly { get; set; }

            public IList<TypeSig> MethodParms { get; set; }

            public string MethodName { get; set; }

            public string MethodReturnType { get; set; }

            public string Method { get; set; }

            public string TypeName { get; set; }

            public string AssemblyFullName { get; set; }
            public string AssemblyPath { get; set; }
        }

        public static async Task ProcessFile(ModuleContext moduleContext, string path)
        {
            var metadataReader = MetadataReader.Create(path);
            if (metadataReader != null)
            {
                var import = (MetadataReader.IMetaDataImport2)metadataReader._assemblyImport;
            }
            else
            {
                return;
            }


            var module = ModuleDefMD.Load(path, moduleContext);

            foreach (var memberRef in module.GetMemberRefs())
            {
                var member = new MemberReference(memberRef, path);

                var searchTerms = new List<string>
                {
                    "ResourceReader::.ctor",
                    "BinaryFormatter::Deserialize",
                    "NetDataContractSerializer::Deserialize",
                    "ApplicationTrust::FromXml",
                    "ChannelServices::RegisterChannel"
                };
                if (member.Method != null && searchTerms.Any(p => member.Method.Contains(p)))
                {
                    PrintMemberRef(member);
                }
            }

            processedCount++;

        }

        private static void PrintMemberRef(MemberReference member)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"OriginalAssembly:  {member.OriginalAssembly}");
            Console.WriteLine($"AssemblyFullName:  {member.AssemblyFullName}");
            Console.WriteLine($"AssemblyPath:      {member.AssemblyPath}");
            Console.WriteLine($"Type:              {member.TypeName}");
            Console.WriteLine($"Method1:           {member.Method}");

            string paramStr = "";

            if (member.MethodParms != null)
            {
                var paramStrList = member.MethodParms.Select(p => p.ToString());
                paramStr = String.Join(", ", paramStrList);
            }

            Console.WriteLine($"Method2:           {member.MethodName}({paramStr})\n");
        }




        static async Task Main(string[] args)
        {
            var moduleContext = ModuleDefMD.CreateModuleContext();
            var resolver = (AssemblyResolver)moduleContext.AssemblyResolver;
            resolver.EnableTypeDefCache = true;

            //var extensions = new string[] { ".exe", ".dll" };
            var extensions = new string[] { ".exe" };

            Stopwatch sw = new Stopwatch();
            sw.Start();

            int count = 0;
            foreach (var file in TraverseDirectory(@"C:\", f => extensions.Contains(f.Extension), OnProgress))
            {
                try
                {
                    await ProcessFile(moduleContext, file.FullName);
                    count++;
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR processing " + file.FullName);
                    Console.WriteLine(e);
                }

            }

            sw.Stop();

            Console.WriteLine($"Elapsed Time: {sw.Elapsed}");
            Console.WriteLine($"Count: {count}");
        }
    }
}
