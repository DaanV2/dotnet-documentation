using System;
using System.IO;

namespace DaanV2.Documentation {
    public partial class Context {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Filepath"></param>
        public void AddInputFile(String Filepath) {
            if (!Path.IsPathRooted(Filepath))
                Filepath = Path.GetFullPath(Filepath);

            this.DocumentationFiles.Add(Filepath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Filepath"></param>
        public void SetOutputFolder(String Filepath) {
            if (!Path.IsPathRooted(Filepath))
                Filepath = Path.GetFullPath(Filepath);

            this.OutputFolder = Filepath;
        }
    }
}
