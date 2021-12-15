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

        /// <summary>
        /// 
        /// </summary>
        public String ObjectName {
            get {
                if (this.Name[0] == 'T') {
                    return this.Name.Substring(2);
                }

                Int32 Index = this.Name.LastIndexOf('.');
                if (Index < 0) Index = this.Name.Length;

                return this.Name.Substring(2, Index - 2);
            }
        }
    }
}
