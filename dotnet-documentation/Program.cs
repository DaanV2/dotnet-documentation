using System;
using System.Collections.Generic;
using System.Xml;
using DaanV2.Documentation.Data;
using DaanV2.Documentation.Data.Converter;

namespace DaanV2.Documentation {
    public class Program {
        public static void Main(String[] args) {
#if DEBUG
            var context = new Context();

            Console.WriteLine("output?");
            context.SetOutputFolder(Console.ReadLine());

            Console.WriteLine("file?");
            context.AddInputFile(Console.ReadLine());
#else
            var context = Context.Load(args);
#endif

            var Assemblies = new List<AssemblyInfo>(context.DocumentationFiles.Count);

            foreach (String file in context.DocumentationFiles) {
                Assemblies.Add(ReadFile(file));
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
