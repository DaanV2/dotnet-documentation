using System;
using System.Collections.Generic;

namespace DaanV2.Documentation.Data {
    /// <summary>The class that stores assembly information read from xml files</summary>
    public partial class AssemblyInfo {
        /// <summary>Creates a new instance of <see cref="AssemblyInfo"/></summary>
        public AssemblyInfo() {
            this.TypeData = new Dictionary<String, List<TypeInfo>>(100000);
            this.Name = String.Empty;
        }
    }
}
