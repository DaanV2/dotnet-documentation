using System;
using System.Collections.Generic;
using System.IO;
using DaanV2.Documentation.Data;

namespace DaanV2.Documentation.Markdown {
    public partial class AssemblyInfoWriter {
        public void Write() {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TI"></param>
        public void WriteTypeInfo(String ObjectName, List<TypeInfo> TI) {
            (String Namespace, String TypeName) = Extension.GetInfo(ObjectName);

            String Folder = Path.Combine(this.ParentFolder, Namespace.Replace('.', Path.PathSeparator));
            Directory.CreateDirectory(Folder);

            String Filepath = Path.Combine(Folder, TypeName + ".md");

            var Writer = new MarkdownWriter(Filepath);

            //Write header
            Writer.WriteHeader(TypeName);

            Writer.WriteHighLighted(ObjectName);
            Writer.Write("  \n");

            
        }
    }
}
