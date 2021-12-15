using System;
using System.Collections.Generic;

namespace DaanV2.Documentation.Data {
    public partial class XmlInfo : INameable {
        /// <summary>
        /// 
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<String, String> Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public String Value { get; set; }
    }
}
