using System;
using System.Xml;
using DaanV2.Documentation.Data;
using DaanV2.Documentation.Data.Converter;

namespace DaanV2.Documentation {
    public class Program {
        public static void Main(String[] args) {
            var context = Context.Load(args);

            foreach (String file in context.DocumentationFiles) {
                ReadFile(file);
            }
        }

        /// <summary></summary>
        private static AssemblyInfoConverter AIConverter = new AssemblyInfoConverter();

        /// <summary>Reads the give file into an AssemblyInfo object</summary>
        /// <param name="Filepath"></param>
        public static AssemblyInfo ReadFile(String Filepath) {
            var doc = new XmlDocument();
            doc.Load(Filepath);

            //Convert the XML to an AssemblyInfo
            return AIConverter.Convert(doc.DocumentElement);
        }
    }
}
