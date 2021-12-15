using System;
using System.Collections.Generic;

namespace DaanV2.Documentation.Data {
    public partial class AssemblyInfo : INameable {
        /// <summary> The name of the assembly </summary>
        public String Name { get; set; }

        /// <summary> Gets the types in the assembly </summary>
        public Dictionary<String, List<TypeInfo>> TypeData { get; set; }
    }
}
