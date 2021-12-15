using DaanV2.Documentation.Data;

namespace DaanV2.Documentation.Markdown {
    ///DOLATER <summary>add description for class: AssemblyInfoWriter</summary>
    public partial class AssemblyInfoWriter {
        /// <summary>Creates a new instance of <see cref="AssemblyInfoWriter"/></summary>
        public AssemblyInfoWriter(AssemblyInfo AInfo, Context context) {
            this.Context = context;
            this.Data = AInfo;

            this.ParentFolder = AInfo.GetFolderPath(context);
        }
    }
}
