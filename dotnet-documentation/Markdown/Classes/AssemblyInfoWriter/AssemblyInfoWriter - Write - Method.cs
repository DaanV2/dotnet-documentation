using System;
using System.Collections.Generic;
using DaanV2.Documentation.Data;

namespace DaanV2.Documentation.Markdown {
    public partial class AssemblyInfoWriter {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Method"></param>
        public void WriteMethod(TypeInfo Method, MarkdownWriter Writer) {
            String Name = Extension.GetMethodName(Method.Name);
            String WriteName = NameCorrector.MethodName(Name);
            String Type = Extension.GetTypeName(Method.Name);

            //Write header
            Writer.WriteHeader(WriteName, 2);

            this.WriteSummary(Writer, Method);
            Writer.Write("  \n\n");

            Method.XmlInfo.ForAll("returns", (returns) => {
                Writer.WriteLine("**Returns**");
                returns.ForEach(r => Writer.Write(r.Value + " "));
                Writer.Write(" \n\n");
            });


            //Write parameters
            Method.XmlInfo.ForAll("param", (parameters) => {
                Writer.WriteHeader("parameters", 3);
                Writer.WriteTableHeader("Parameter", "Description");

                foreach (XmlInfo P in parameters) {
                    Writer.WriteTableRow(P.Attributes["name"], P.Value);
                }

                Writer.Write("\n");

                if (!Name.StartsWith("op_")) {
                    Writer.WriteLine("**examples**");
                    Writer.WriteStartCodeBlock("csharp");

                    List<String> names = parameters.ConvertAll(x => x.Attributes["name"]);

                    if (Name.StartsWith("#ctor")) {
                        Writer.WriteLine($"{Type}({String.Join(", ", names)})");
                    }
                    else {
                        Writer.WriteLine($"{Name}({String.Join(", ", names)})");
                    }
                }

                Writer.WriteEndCodeBlock();
                Writer.Write("\n");
            });
        }
    }
}
