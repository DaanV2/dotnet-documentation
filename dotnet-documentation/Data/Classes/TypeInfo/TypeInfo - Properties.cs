using System;
using System.Collections.Generic;

namespace DaanV2.Documentation.Data {
    public partial class TypeInfo : INameable {
        /// <summary> Gets or sets the name of the type </summary>
        public String Name { get; set; }

        /// <summary> Gets or sets the xml information </summary>
        public List<XmlInfo> XmlInfo { get; set; }

        /// <summary> Gets or base object name </summary>
        public String ObjectName {
            get {
                Char c = this.Name[0];
                if (c == 'T') {
                    return this.Name[2..];
                }

                Int32 Index = this.Name.IndexOf('(');

                if (Index < 0) Index = this.Name.Length;
                ReadOnlySpan<Char> Temp = this.Name.AsSpan(2, Index - 2);

                Index = Temp.LastIndexOf('.');
                if (Index < 0) Index = Temp.Length;

                return Temp.Slice(0, Index).ToString();
            }
        }
    }
}
