using System;

namespace DaanV2.Documentation.Data {
    /// <summary>The class that stores xml information read from additional xml nodes in xml files</summary>
    public partial class XmlInfo {
        /// <summary>Creates a new instance of <see cref="XmlInfo"/></summary>
        public XmlInfo() {
            this.Attributes = null;
            this.Name = String.Empty;
            this.Value = String.Empty;
        }
    }
}
