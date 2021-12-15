using System;
using System.Collections.Generic;

namespace DaanV2.Documentation.Data {
    /// <summary>The class that stores type information read from xml files</summary>
    public partial class TypeInfo {
        /// <summary>Creates a new instance of <see cref="TypeInfo"/></summary>
        public TypeInfo() {
            this.Name = String.Empty;
            this.XmlInfo = new List<XmlInfo>();
        }
    }
}
