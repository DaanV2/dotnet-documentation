using System;
using System.Collections.Generic;

namespace DaanV2.Documentation.Data {
    public partial class XmlInfo : INameable {
        /// <summary> Gets or sets the name of the xml node </summary>
        public String Name { get; set; }

        /// <summary> Gets or sets the xml node attributes information, is null if it has none </summary>
        public Dictionary<String, String> Attributes { get; set; }

        /// <summary> Gets or sets the xml node value </summary>
        public String Value { get; set; }
    }
}
