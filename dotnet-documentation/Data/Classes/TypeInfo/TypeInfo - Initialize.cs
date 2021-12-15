using System;
using System.Collections.Generic;

namespace DaanV2.Documentation.Data {
    ///DOLATER <summary>add description for class: TypeInfo</summary>
    public partial class TypeInfo {
        /// <summary>Creates a new instance of <see cref="TypeInfo"/></summary>
        public TypeInfo() {
            this.Name = String.Empty;
            this.XmlInfo = new List<XmlInfo>();
        }
    }
}
