using System;
using System.Collections.Generic;
using System.IO;
using DaanV2.Documentation.Data;

namespace DaanV2.Documentation.Markdown {
    public partial class AssemblyInfoWriter {
        public void Write() {
            foreach (KeyValuePair<String, List<TypeInfo>> Item in this.Data.TypeData) {
                this.WriteTypeInfo(Item.Key, Item.Value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TI"></param>
        public void WriteTypeInfo(String ObjectName, List<TypeInfo> TI) {
            var Types = new List<TypeInfo>();
            var Methods = new List<TypeInfo>();
            var Properties = new List<TypeInfo>();
            var Fields = new List<TypeInfo>();

            for (Int32 I = 0; I < TI.Count; I++) {
                TypeInfo Item = TI[I];

                switch (Item.Name[0]) {
                    case 'T':
                        Types.Add(Item);
                        break;

                    case 'M':
                        Methods.Add(Item);
                        break;

                    case 'P':
                        Properties.Add(Item);
                        break;

                    case 'F':
                        Fields.Add(Item);
                        break;

                    default:
                        throw new Exception();
                }
            }


            (String Namespace, String TypeName) = Extension.GetInfo(ObjectName);

            String Folder = Path.Combine(this.ParentFolder, Namespace.Replace('.', Path.DirectorySeparatorChar));
            Directory.CreateDirectory(Folder);

            String Filepath = Path.Combine(Folder, TypeName + ".md");

            var Writer = new MarkdownWriter(Filepath);

            //Write header
            Writer.WriteHeader(TypeName);

            Writer.WriteHighLighted(ObjectName);
            Writer.WriteEndLine();
            Writer.Write("\n");

            //Contents
            Writer.WriteLine("**contents**");
            Writer.Write("- [Summary](#summary)\n");
            if (Fields.Count > 0) Writer.Write("- [Fields](#fields)\n");
            if (Properties.Count > 0) Writer.Write("- [Properties](#properties)\n");
            if (Methods.Count > 0) Writer.Write("- [Methods](#methods)\n");
            Writer.Write("\n");

            Writer.WriteSeperator();

            //Summary
            Writer.WriteHeader("Summary", 1);
            this.WriteSummary(Writer, Types);
            Writer.WriteEndLine();
            Writer.Write("\n");


            //Fields
            if (Fields.Count > 0) {
                Writer.WriteSeperator();
                Writer.WriteHeader("Fields", 1);

                Writer.WriteTableHeader("Name", "Description");
                foreach (TypeInfo F in Fields) {
                    Writer.Write($"|{Extension.GetTypeName(F.Name)}|");
                    this.WriteSummary(Writer, F);
                    Writer.Write("|\n");
                }

                Writer.Write("\n\n");
                Writer.WriteSeperator();
            }


            //Properties
            if (Properties.Count > 0) {
                Writer.WriteHeader("Properties", 1);

                Writer.WriteTableHeader("Name", "Description");
                foreach (TypeInfo P in Properties) {
                    Writer.Write($"|{Extension.GetTypeName(P.Name)}|");
                    this.WriteSummary(Writer, P);
                    Writer.Write("|\n");
                }

                Writer.Write("\n\n");
                Writer.WriteSeperator();
            }


            //Methods
            if (Methods.Count > 0) {
                Methods.Sort((x, y) => x.Name.CompareTo(y.Name));
                Writer.WriteHeader("Methods", 1);

                foreach (TypeInfo M in Methods) {
                    this.WriteMethod(M, Writer);
                }
            }

            Writer.Close();
        }

        public void WriteSummary(MarkdownWriter Writer, List<TypeInfo> Items) {
            Items.ForEach(I => this.WriteSummary(Writer, I));
        }

        public void WriteSummary(MarkdownWriter Writer, TypeInfo Item) {
            //Write type
            Item.XmlInfo?.ForEach(x => {
                if (x.Name == "summary") {
                    Writer.Write(x.Value);
                }
            });
        }
    }
}
