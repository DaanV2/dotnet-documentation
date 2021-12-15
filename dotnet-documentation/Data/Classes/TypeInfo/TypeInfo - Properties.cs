using System;
using System.Collections.Generic;

namespace DaanV2.Documentation.Data {
    public partial class TypeInfo : INameable {
        /// <summary>
        /// 
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<XmlInfo> XmlInfo { get; set; }
    }
}
