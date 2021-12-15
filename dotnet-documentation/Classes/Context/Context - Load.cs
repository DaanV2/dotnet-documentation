using System;

namespace DaanV2.Documentation {
    public partial class Context {
        /// <summary> Loads the context from the given arguments. </summary>
        /// <param name="args">The arguments.</param>
        /// <returns>The project context</returns>
        public static Context Load(String[] args) {
            var Out = new Context();

            if (args.Length == 2) {
                Out.SetOutputFolder(args[0]);
                Out.AddInputFile(args[1]);
                return Out;
            }


            for (Int32 I = 0; I < args.Length; I++) {
                String arg = args[I];

                switch (arg) {
                    case "-f":
                    case "--file":
                        Out.AddInputFile(args[I + 1]);
                        break;

                    case "-o":
                    case "--output":
                        Out.SetOutputFolder(args[I + 1]);
                        break;

                    default:
                        if (I == 0) {
                            Out.SetOutputFolder(arg);
                        }
                        else {
                            Out.AddInputFile(arg);
                        }
                        break;
                }


            }
            return Out;
        }
    }
}