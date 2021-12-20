using System;
using System.IO;
using DaanV2.Documentation.Data;

namespace DaanV2.Documentation.Markdown {
    ///DOLATER <summary>add description for class: Extension</summary>
    public static partial class Extension {
        /// <summary> Gets the path to the folder of the assembly </summary>
        /// <param name="AIInfo"> The assembly information </param>
        /// <param name="context"> The context </param>
        /// <returns> The folder path </returns>
        public static String GetFolderPath(this AssemblyInfo AInfo, Context context) {
            return Path.Combine(context.OutputFolder, AInfo.Name);
        }


        /// <summary> Gets the filepath to the output document </summary>
        /// <param name="AIInfo"> The assembly information </param>
        /// <param name="context"> The context </param>
        /// <param name="TInfo"> The type information </param>
        /// <returns> The filepath </returns>
        public static String GetFilepath(this TypeInfo TInfo, String Parent, Context context) {
            String ObjectName = TInfo.ObjectName;
            return Path.Combine(Parent, ObjectName, ObjectName + ".md");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FullType"></param>
        /// <returns></returns>
        public static String GetNamespace(String FullType) {
            Int32 Index = FullType.LastIndexOf('.');
            if (Index >= 0) return FullType[0..Index];

            return FullType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FullType"></param>
        /// <returns></returns>
        public static String GetTypeName(String FullType) {
            Int32 Index = FullType.LastIndexOf('.');
            if (Index >= 0) return FullType[(Index + 1)..];

            return FullType;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="FullType"></param>
        /// <returns></returns>
        public static (String Namespace, String TypeName) GetInfo(this TypeInfo TInfo) {
            return GetInfo(TInfo.ObjectName);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="FullType"></param>
        /// <returns></returns>
        public static (String Namespace, String TypeName) GetInfo(String FullType) {
            Int32 Index = FullType.LastIndexOf('.');

            if (Index >= 0) {
                return (FullType[0..Index], FullType[(Index + 1)..]);
            }

            return (FullType, FullType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static String GetMethodName(String name) {
            Int32 Index = name.IndexOf('(');

            if (Index < 0) Index = name.Length;

            ReadOnlySpan<Char> temp = name.AsSpan(0, Index);
            Index = temp.LastIndexOf('.') + 1;

            return temp[Index..].ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static String GetSyntax(String Name) {
            Int32 Index = Name.IndexOf('(');

            if (Index < 0) return String.Empty;

            ReadOnlySpan<Char> temp = Name.AsSpan(0, Index);
            Int32 StartIndex = temp.LastIndexOf('.') + 1;

            if (StartIndex < 0) StartIndex = 0;

            temp = Name.AsSpan(StartIndex);
            Index = temp.LastIndexOf(')');
            if (Index < 0) return temp.ToString();

            return temp[..(Index+1)].ToString();
        }
    }
}
