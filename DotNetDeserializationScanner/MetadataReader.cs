using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Build.Tasks.Deployment.ManifestUtilities
{
    public class NativeMethods
    {
        // Token: 0x06000E2D RID: 3629
        [DllImport("mscorwks.dll", CharSet = CharSet.Unicode, ExactSpelling = true, PreserveSig = false)]
        [return: MarshalAs(UnmanagedType.IUnknown)]
        public static extern object GetAssemblyIdentityFromFile([MarshalAs(UnmanagedType.LPWStr)] [In] string filePath, [In] ref Guid riid);
	}

	// Token: 0x0200009A RID: 154
	[Guid("7DAC8207-D3AE-4c75-9B67-92801A497D44")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	internal interface IMetaDataImport
	{
		// Token: 0x06000760 RID: 1888
		[PreserveSig]
		void CloseEnum();

		// Token: 0x06000761 RID: 1889
		void CountEnum(IntPtr iRef, ref uint ulCount);

		// Token: 0x06000762 RID: 1890
		void ResetEnum();

		// Token: 0x06000763 RID: 1891
		void EnumTypeDefs();

		// Token: 0x06000764 RID: 1892
		void EnumInterfaceImpls();

		// Token: 0x06000765 RID: 1893
		void EnumTypeRefs();

		// Token: 0x06000766 RID: 1894
		void FindTypeDefByName();

		// Token: 0x06000767 RID: 1895
		void GetScopeProps();

		// Token: 0x06000768 RID: 1896
		void GetModuleFromScope();

		// Token: 0x06000769 RID: 1897
		void GetTypeDefProps();

		// Token: 0x0600076A RID: 1898
		void GetInterfaceImplProps();

		// Token: 0x0600076B RID: 1899
		void GetTypeRefProps();

		// Token: 0x0600076C RID: 1900
		void ResolveTypeRef();

		// Token: 0x0600076D RID: 1901
		void EnumMembers();

		// Token: 0x0600076E RID: 1902
		void EnumMembersWithName();

		// Token: 0x0600076F RID: 1903
		void EnumMethods();

		// Token: 0x06000770 RID: 1904
		void EnumMethodsWithName();

		// Token: 0x06000771 RID: 1905
		void EnumFields();

		// Token: 0x06000772 RID: 1906
		void EnumFieldsWithName();

		// Token: 0x06000773 RID: 1907
		void EnumParams();

		// Token: 0x06000774 RID: 1908
		void EnumMemberRefs();

		// Token: 0x06000775 RID: 1909
		void EnumMethodImpls();

		// Token: 0x06000776 RID: 1910
		void EnumPermissionSets();

		// Token: 0x06000777 RID: 1911
		void FindMember();

		// Token: 0x06000778 RID: 1912
		void FindMethod();

		// Token: 0x06000779 RID: 1913
		void FindField();

		// Token: 0x0600077A RID: 1914
		void FindMemberRef();

		// Token: 0x0600077B RID: 1915
		void GetMethodProps();

		// Token: 0x0600077C RID: 1916
		void GetMemberRefProps();

		// Token: 0x0600077D RID: 1917
		void EnumProperties();

		// Token: 0x0600077E RID: 1918
		void EnumEvents();

		// Token: 0x0600077F RID: 1919
		void GetEventProps();

		// Token: 0x06000780 RID: 1920
		void EnumMethodSemantics();

		// Token: 0x06000781 RID: 1921
		void GetMethodSemantics();

		// Token: 0x06000782 RID: 1922
		void GetClassLayout();

		// Token: 0x06000783 RID: 1923
		void GetFieldMarshal();

		// Token: 0x06000784 RID: 1924
		void GetRVA();

		// Token: 0x06000785 RID: 1925
		void GetPermissionSetProps();

		// Token: 0x06000786 RID: 1926
		void GetSigFromToken();

		// Token: 0x06000787 RID: 1927
		void GetModuleRefProps();

		// Token: 0x06000788 RID: 1928
		void EnumModuleRefs();

		// Token: 0x06000789 RID: 1929
		void GetTypeSpecFromToken();

		// Token: 0x0600078A RID: 1930
		void GetNameFromToken();

		// Token: 0x0600078B RID: 1931
		void EnumUnresolvedMethods();

		// Token: 0x0600078C RID: 1932
		void GetUserString();

		// Token: 0x0600078D RID: 1933
		void GetPinvokeMap();

		// Token: 0x0600078E RID: 1934
		void EnumSignatures();

		// Token: 0x0600078F RID: 1935
		void EnumTypeSpecs();

		// Token: 0x06000790 RID: 1936
		void EnumUserStrings();

		// Token: 0x06000791 RID: 1937
		void GetParamForMethodIndex();

		// Token: 0x06000792 RID: 1938
		void EnumCustomAttributes();

		// Token: 0x06000793 RID: 1939
		void GetCustomAttributeProps();

		// Token: 0x06000794 RID: 1940
		void FindTypeRef();

		// Token: 0x06000795 RID: 1941
		void GetMemberProps();

		// Token: 0x06000796 RID: 1942
		void GetFieldProps();

		// Token: 0x06000797 RID: 1943
		void GetPropertyProps();

		// Token: 0x06000798 RID: 1944
		void GetParamProps();

		// Token: 0x06000799 RID: 1945
		void GetCustomAttributeByName();

		// Token: 0x0600079A RID: 1946
		void IsValidToken();

		// Token: 0x0600079B RID: 1947
		void GetNestedClassProps();

		// Token: 0x0600079C RID: 1948
		void GetNativeCallConvFromSig();

		// Token: 0x0600079D RID: 1949
		void IsGlobal();
	}

	// Token: 0x02000098 RID: 152
	[Guid("E5CB7A31-7512-11d2-89CE-0080C792E5D8")]
    [TypeLibType(TypeLibTypeFlags.FCanCreate)]
    [ClassInterface(ClassInterfaceType.None)]
    [ComImport]
    internal class CorMetaDataDispenser
    {
        // Token: 0x0600075C RID: 1884
        //[MethodImpl(MethodImplOptions.InternalCall)]
        //public extern CorMetaDataDispenser();
    }

	// Token: 0x0200009D RID: 157
	[Guid("EE62470B-E94B-424e-9B7C-2F00C9249F93")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IMetaDataAssemblyImport
	{
		// Token: 0x060007E3 RID: 2019
		void GetAssemblyProps(uint mdAsm, out IntPtr pPublicKeyPtr, out uint ucbPublicKeyPtr, out uint uHashAlg, [MarshalAs(UnmanagedType.LPArray)] char[] strName, uint cchNameIn, out uint cchNameRequired, IntPtr amdInfo, out uint dwFlags);

		// Token: 0x060007E4 RID: 2020
		void GetAssemblyRefProps(uint mdAsmRef, out IntPtr ppbPublicKeyOrToken, out uint pcbPublicKeyOrToken, [MarshalAs(UnmanagedType.LPArray)] char[] strName, uint cchNameIn, out uint pchNameOut, IntPtr amdInfo, out IntPtr ppbHashValue, out uint pcbHashValue, out uint pdwAssemblyRefFlags);

		// Token: 0x060007E5 RID: 2021
		void GetFileProps([In] uint mdFile, [MarshalAs(UnmanagedType.LPArray)] char[] strName, uint cchName, out uint cchNameRequired, out IntPtr bHashData, out uint cchHashBytes, out uint dwFileFlags);

		// Token: 0x060007E6 RID: 2022
		void GetExportedTypeProps();

		// Token: 0x060007E7 RID: 2023
		void GetManifestResourceProps();

		// Token: 0x060007E8 RID: 2024
		void EnumAssemblyRefs([In] [Out] ref IntPtr phEnum, [MarshalAs(UnmanagedType.LPArray)] [Out] uint[] asmRefs, uint asmRefCount, out uint iFetched);

		// Token: 0x060007E9 RID: 2025
		void EnumFiles([In] [Out] ref IntPtr phEnum, [MarshalAs(UnmanagedType.LPArray)] [Out] uint[] fileRefs, uint fileRefCount, out uint iFetched);

		// Token: 0x060007EA RID: 2026
		void EnumExportedTypes();

		// Token: 0x060007EB RID: 2027
		void EnumManifestResources();

		// Token: 0x060007EC RID: 2028
		void GetAssemblyFromScope(out uint mdAsm);

		// Token: 0x060007ED RID: 2029
		void FindExportedTypeByName();

		// Token: 0x060007EE RID: 2030
		void FindManifestResourceByName();

		// Token: 0x060007EF RID: 2031
		[PreserveSig]
		void CloseEnum([In] IntPtr phEnum);

		// Token: 0x060007F0 RID: 2032
		void FindAssembliesByName();
	}

	// Token: 0x0200010D RID: 269
	public class MetadataReader : IDisposable
	{
		// Token: 0x06000E16 RID: 3606 RVA: 0x00037C40 File Offset: 0x00035E40
		private MetadataReader(string path)
		{
			this._path = path;
			this._metaDispenser = (MetadataReader.IMetaDataDispenser)new CorMetaDataDispenser();
			object obj;
			if (this._metaDispenser.OpenScope(path, 0u, ref MetadataReader._importerGuid, out obj) == 0)
			{
				this._assemblyImport = (IMetaDataAssemblyImport)obj;
			}
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00037C90 File Offset: 0x00035E90
		public static MetadataReader Create(string path)
		{
			MetadataReader metadataReader = new MetadataReader(path);
			if (metadataReader._assemblyImport != null)
			{
				return metadataReader;
			}
			return null;
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00037CB0 File Offset: 0x00035EB0
		public bool HasAssemblyAttribute(string name)
		{
			uint mdTokenObj;
			this._assemblyImport.GetAssemblyFromScope(out mdTokenObj);
			IMetaDataImport2 metaDataImport = (IMetaDataImport2)this._assemblyImport;
			IntPtr zero = IntPtr.Zero;
			uint num = 0u;
			metaDataImport.GetCustomAttributeByName(mdTokenObj, name, out zero, out num);
			return num > 0u;
		}

		// Token: 0x0200009B RID: 155
		[Guid("FCE5EFA0-8BBA-4f8e-A036-8F2022B08466")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		internal interface IMetaDataImport2
		{
			// Token: 0x0600079E RID: 1950
			void CloseEnum();

			// Token: 0x0600079F RID: 1951
			void CountEnum();

			// Token: 0x060007A0 RID: 1952
			void ResetEnum();

			// Token: 0x060007A1 RID: 1953
			void EnumTypeDefs();

			// Token: 0x060007A2 RID: 1954
			void EnumInterfaceImpls();

			// Token: 0x060007A3 RID: 1955
			void EnumTypeRefs();

			// Token: 0x060007A4 RID: 1956
			void FindTypeDefByName();

			// Token: 0x060007A5 RID: 1957
			void GetScopeProps();

			// Token: 0x060007A6 RID: 1958
			void GetModuleFromScope();

			// Token: 0x060007A7 RID: 1959
			void GetTypeDefProps();

			// Token: 0x060007A8 RID: 1960
			void GetInterfaceImplProps();

			// Token: 0x060007A9 RID: 1961
			void GetTypeRefProps();

			// Token: 0x060007AA RID: 1962
			void ResolveTypeRef();

			// Token: 0x060007AB RID: 1963
			void EnumMembers();

			// Token: 0x060007AC RID: 1964
			void EnumMembersWithName();

			// Token: 0x060007AD RID: 1965
			void EnumMethods();

			// Token: 0x060007AE RID: 1966
			void EnumMethodsWithName();

			// Token: 0x060007AF RID: 1967
			void EnumFields();

			// Token: 0x060007B0 RID: 1968
			void EnumFieldsWithName();

			// Token: 0x060007B1 RID: 1969
			void EnumParams();

			// Token: 0x060007B2 RID: 1970
			void EnumMemberRefs();

			// Token: 0x060007B3 RID: 1971
			void EnumMethodImpls();

			// Token: 0x060007B4 RID: 1972
			void EnumPermissionSets();

			// Token: 0x060007B5 RID: 1973
			void FindMember();

			// Token: 0x060007B6 RID: 1974
			void FindMethod();

			// Token: 0x060007B7 RID: 1975
			void FindField();

			// Token: 0x060007B8 RID: 1976
			void FindMemberRef();

			// Token: 0x060007B9 RID: 1977
			void GetMethodProps();

			// Token: 0x060007BA RID: 1978
			void GetMemberRefProps();

			// Token: 0x060007BB RID: 1979
			void EnumProperties();

			// Token: 0x060007BC RID: 1980
			void EnumEvents();

			// Token: 0x060007BD RID: 1981
			void GetEventProps();

			// Token: 0x060007BE RID: 1982
			void EnumMethodSemantics();

			// Token: 0x060007BF RID: 1983
			void GetMethodSemantics();

			// Token: 0x060007C0 RID: 1984
			void GetClassLayout();

			// Token: 0x060007C1 RID: 1985
			void GetFieldMarshal();

			// Token: 0x060007C2 RID: 1986
			void GetRVA();

			// Token: 0x060007C3 RID: 1987
			void GetPermissionSetProps();

			// Token: 0x060007C4 RID: 1988
			void GetSigFromToken();

			// Token: 0x060007C5 RID: 1989
			void GetModuleRefProps();

			// Token: 0x060007C6 RID: 1990
			void EnumModuleRefs();

			// Token: 0x060007C7 RID: 1991
			void GetTypeSpecFromToken();

			// Token: 0x060007C8 RID: 1992
			void GetNameFromToken();

			// Token: 0x060007C9 RID: 1993
			void EnumUnresolvedMethods();

			// Token: 0x060007CA RID: 1994
			void GetUserString();

			// Token: 0x060007CB RID: 1995
			void GetPinvokeMap();

			// Token: 0x060007CC RID: 1996
			void EnumSignatures();

			// Token: 0x060007CD RID: 1997
			void EnumTypeSpecs();

			// Token: 0x060007CE RID: 1998
			void EnumUserStrings();

			// Token: 0x060007CF RID: 1999
			void GetParamForMethodIndex();

			// Token: 0x060007D0 RID: 2000
			void EnumCustomAttributes();

			// Token: 0x060007D1 RID: 2001
			void GetCustomAttributeProps();

			// Token: 0x060007D2 RID: 2002
			void FindTypeRef();

			// Token: 0x060007D3 RID: 2003
			void GetMemberProps();

			// Token: 0x060007D4 RID: 2004
			void GetFieldProps();

			// Token: 0x060007D5 RID: 2005
			void GetPropertyProps();

			// Token: 0x060007D6 RID: 2006
			void GetParamProps();

			// Token: 0x060007D7 RID: 2007
			[PreserveSig]
			int GetCustomAttributeByName(uint mdTokenObj, [MarshalAs(UnmanagedType.LPWStr)] string szName, out IntPtr ppData, out uint pDataSize);

			// Token: 0x060007D8 RID: 2008
			void IsValidToken();

			// Token: 0x060007D9 RID: 2009
			void GetNestedClassProps();

			// Token: 0x060007DA RID: 2010
			void GetNativeCallConvFromSig();

			// Token: 0x060007DB RID: 2011
			void IsGlobal();

			// Token: 0x060007DC RID: 2012
			void EnumGenericParams();

			// Token: 0x060007DD RID: 2013
			void GetGenericParamProps();

			// Token: 0x060007DE RID: 2014
			void GetMethodSpecProps();

			// Token: 0x060007DF RID: 2015
			void EnumGenericParamConstraints();

			// Token: 0x060007E0 RID: 2016
			void GetGenericParamConstraintProps();

			// Token: 0x060007E1 RID: 2017
			void GetPEKind(out uint pdwPEKind, out uint pdwMachine);

			// Token: 0x060007E2 RID: 2018
			void GetVersionString([MarshalAs(UnmanagedType.LPArray)] char[] pwzBuf, uint ccBufSize, out uint pccBufSize);
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x00037CEF File Offset: 0x00035EEF
		public string Name
		{
			get
			{
				return this.Attributes["Name"];
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00037D01 File Offset: 0x00035F01
		public string Version
		{
			get
			{
				return this.Attributes["Version"];
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x00037D13 File Offset: 0x00035F13
		public string PublicKeyToken
		{
			get
			{
				return this.Attributes["PublicKeyToken"];
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00037D25 File Offset: 0x00035F25
		public string Culture
		{
			get
			{
				return this.Attributes["Culture"];
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x00037D37 File Offset: 0x00035F37
		public string ProcessorArchitecture
		{
			get
			{
				return this.Attributes["ProcessorArchitecture"];
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00037D4C File Offset: 0x00035F4C
		private StringDictionary Attributes
		{
			get
			{
				if (this._attributes == null)
				{
					lock (this)
					{
						if (this._attributes == null)
						{
							this.ImportAttributes();
						}
					}
				}
				return this._attributes;
			}
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00037DA0 File Offset: 0x00035FA0
		public void Close()
		{
			if (this._assemblyImport != null)
			{
				Marshal.ReleaseComObject(this._assemblyImport);
			}
			if (this._metaDispenser != null)
			{
				Marshal.ReleaseComObject(this._metaDispenser);
			}
			this._attributes = null;
			this._metaDispenser = null;
			this._assemblyImport = null;
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00037DE0 File Offset: 0x00035FE0
		private void ImportAttributes()
		{
			MetadataReader.IReferenceIdentity referenceIdentity = (MetadataReader.IReferenceIdentity)NativeMethods.GetAssemblyIdentityFromFile(this._path, ref MetadataReader._refidGuid);
			string attribute = referenceIdentity.GetAttribute(null, "name");
			string attribute2 = referenceIdentity.GetAttribute(null, "version");
			string text = referenceIdentity.GetAttribute(null, "publicKeyToken");
			if (string.Equals(text, "neutral", StringComparison.OrdinalIgnoreCase))
			{
				text = null;
			}
			else if (!string.IsNullOrEmpty(text))
			{
				text = text.ToUpperInvariant();
			}
			string attribute3 = referenceIdentity.GetAttribute(null, "culture");
			string text2 = referenceIdentity.GetAttribute(null, "processorArchitecture");
			if (!string.IsNullOrEmpty(text2))
			{
				text2 = text2.ToLowerInvariant();
			}
			this._attributes = new StringDictionary();
			this._attributes.Add("Name", attribute);
			this._attributes.Add("Version", attribute2);
			this._attributes.Add("PublicKeyToken", text);
			this._attributes.Add("Culture", attribute3);
			this._attributes.Add("ProcessorArchitecture", text2);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00037EDD File Offset: 0x000360DD
		void IDisposable.Dispose()
		{
			this.Close();
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00037EE8 File Offset: 0x000360E8
		public static Guid GetGuidOfType(Type type)
		{
			GuidAttribute guidAttribute = (GuidAttribute)Attribute.GetCustomAttribute(type, typeof(GuidAttribute), false);
			return new Guid(guidAttribute.Value);
		}

		// Token: 0x040005B6 RID: 1462
		private readonly string _path;

		// Token: 0x040005B7 RID: 1463
		private StringDictionary _attributes;

		// Token: 0x040005B8 RID: 1464
		private MetadataReader.IMetaDataDispenser _metaDispenser;

		// Token: 0x040005B9 RID: 1465
		public IMetaDataAssemblyImport _assemblyImport;

		// Token: 0x040005BA RID: 1466
		private static Guid _importerGuid = MetadataReader.GetGuidOfType(typeof(IMetaDataImport));

		// Token: 0x040005BB RID: 1467
		private static Guid _refidGuid = MetadataReader.GetGuidOfType(typeof(MetadataReader.IReferenceIdentity));

		// Token: 0x020001E5 RID: 485
		[Guid("6eaf5ace-7917-4f3c-b129-e046a9704766")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		public interface IReferenceIdentity
		{
			// Token: 0x06001434 RID: 5172
			[return: MarshalAs(UnmanagedType.LPWStr)]
			string GetAttribute([MarshalAs(UnmanagedType.LPWStr)] [In] string Namespace, [MarshalAs(UnmanagedType.LPWStr)] [In] string Name);

			// Token: 0x06001435 RID: 5173
			void SetAttribute();

			// Token: 0x06001436 RID: 5174
			void EnumAttributes();

			// Token: 0x06001437 RID: 5175
			void Clone();
		}

		// Token: 0x020001E6 RID: 486
		[Guid("809c652e-7396-11d2-9771-00a0c9b4d50c")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[TypeLibType(TypeLibTypeFlags.FRestricted)]
		[ComImport]
		private interface IMetaDataDispenser
		{
			// Token: 0x06001438 RID: 5176
			int DefineScope();

			// Token: 0x06001439 RID: 5177
			[PreserveSig]
			int OpenScope([MarshalAs(UnmanagedType.LPWStr)] [In] string szScope, [In] uint dwOpenFlags, [In] ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out object obj);

			// Token: 0x0600143A RID: 5178
			int OpenScopeOnMemory();
		}
	}
}
