using System;
using System.IO;

namespace DaanV2.Documentation {
    public partial class Context {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static Context Load(String[] args) {
            var Out = new Context();

            if (args.Length == 2) {
                Out.OutputFolder = args[0];
            }


            for (Int32 I = 0; I < args.Length; I++) {
                String arg = args[I];

                switch (arg) {
                    case "-f":
                    case "--file":
                        String Filepath = args[I + 1];

                        if (!Path.IsPathRooted(Filepath))
                            Filepath = Path.GetFullPath(Filepath);

                        Out.DocumentationFiles.Add(Filepath);
                        break;

                    case

                }
            }
            return Out;
        }
    }
