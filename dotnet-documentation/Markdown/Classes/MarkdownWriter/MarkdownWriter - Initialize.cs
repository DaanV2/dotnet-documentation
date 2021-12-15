using System;

namespace DaanV2.Documentation.Markdown {
    ///<summary>Creates a markdown writer</summary>
    public partial class MarkdownWriter {
        /// <summary>Creates a new instance of <see cref="MarkdownWriter"/></summary>
        /// <param name="Filepath"> The filepath to the output file </param>
        /// <param name="append"> If true, the file will be appended </param>
        public MarkdownWriter(String Filepath, Boolean append = false) {
            this._Writer = new System.IO.StreamWriter(Filepath, append);
        }

        /// <summary> Closes the writer </summary>
        ~MarkdownWriter() {
            this.Close();
        }

        /// <summary> Closes the writer </summary>
        public void Close() {
            this._Writer.Flush();
            this._Writer.Close();
            this._Writer.Dispose();
        }
    }
}
