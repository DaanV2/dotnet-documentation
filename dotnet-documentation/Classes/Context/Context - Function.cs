using System;
using System.IO;

namespace DaanV2.Documentation {
    public partial class Context {
        /// <summary> Add the given input file into the context. </summary>
        /// <param name="Filepath">The filepath to add</param>
        public void AddInputFile(String Filepath) {
            if (!Path.IsPathRooted(Filepath))
                Filepath = Path.GetFullPath(Filepath);

            this.DocumentationFiles.Add(Filepath);
        }

        /// <summary> Sets the output folder. </summary>
        /// <param name="Filepath">The filepath to output the api to</param>
        public void SetOutputFolder(String Filepath) {
            if (!Path.IsPathRooted(Filepath))
                Filepath = Path.GetFullPath(Filepath);

            this.OutputFolder = Filepath;
        }
    }
}
