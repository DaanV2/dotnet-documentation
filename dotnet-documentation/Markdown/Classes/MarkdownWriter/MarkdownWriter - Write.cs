using System;

namespace DaanV2.Documentation.Markdown {
    public partial class MarkdownWriter {
        /// <summary> Writer a title to the output </summary>
        /// <param name="Header">The title to write</param>
        /// <param name="Level">The level of the title</param>
        public void WriteHeader(String Header, Int32 level = 0) {
            this.Write(new String('#', level + 1) + " " + Header + "\n\n");
        }

        /// <summary> Writer a table title to the output </summary>
        /// <param name="Colomns"> The colomns of the table </param>
        public void WriteTableHeader(params String[] Colomns) {
            this._Writer.WriteLine('|' + String.Join('|', Colomns) + '|');
            this._Writer.Write('|');

            for (Int32 I = 0; I < Colomns.Length; I++) {
                this._Writer.Write("---|");
            }

            this._Writer.Write("\n");
        }

        /// <summary> Writes a table row to the output </summary>
        /// <param name="Colomns"> The colomns of the row </param>
        public void WriteTableRow(params String[] Colomns) {
            this._Writer.WriteLine('|' + String.Join('|', Colomns) + '|');
        }

        /// <summary> Writes a seperator to the output </summary>
        public void WriteSeperator() {
            this.WriteLine("---");
        }

        /// <summary> Writes a seperator to the output </summary>
        /// <param name="Text">The text to write</param>
        public void WriteHighLighted(String Text) {
            this._Writer.Write('`' + Text + '`');
        }

        /// <summary> Writes a seperator to the output </summary>
        /// <param name="Text">The text to write</param>
        public void WriteLink(String LinkText, String Link) {
            this._Writer.Write('[' + LinkText + "](" + Link + ')');
        }

        /// <summary> Writes a start code block to the output </summary>
        public void WriteStartCodeBlock() {
            this.WriteLine("```");
        }

        /// <summary> Writes a end code block to the output </summary>
        /// <param name="Code">The language of the code block</param>
        public void WriteStartCodeBlock(String Code) {
            this.WriteLine("```" + Code);
        }

        /// <summary> Writes a end code block to the output </summary>
        public void WriteEndCodeBlock() {
            this.WriteLine("```");
        }

        /// <summary> Writes the text to the output </summary>
        /// <param name="Text">The text to write</param>
        public void Write(String Text) {
            this._Writer.Write(Text);
        }

        /// <summary> Writes the text to the output </summary>
        /// <param name="Text">The text to write</param>
        public void WriteEndLine() {
            this._Writer.Write("  \n");
        }

        /// <summary> Writes the text to the output and adds a markdown ending</summary>
        /// <param name="Text">The text to write</param>
        public void WriteLine(String text) {
            this._Writer.WriteLine(text + "  ");
        }
    }
}
