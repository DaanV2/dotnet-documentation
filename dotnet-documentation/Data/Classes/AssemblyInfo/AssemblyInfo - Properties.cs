using System;
using System.Collections.Generic;

namespace DaanV2.Documentation.Data {
    public partial class AssemblyInfo : INameable {
        /// <summary>
        /// 
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<String, List<TypeInfo>> TypeData { get; set; }
    }
}
