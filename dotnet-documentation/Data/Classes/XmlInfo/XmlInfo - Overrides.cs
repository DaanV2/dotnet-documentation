using System;
using System.Collections.Generic;

namespace DaanV2.Documentation.Data {
    public partial class XmlInfo : IEquatable<XmlInfo> {
        /// <inheritdoc/>
        public override String ToString() {
            return $"{this.Name}[{this.Attributes?.Count}]: {this.Value}";
        }

        /// <inheritdoc/>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as XmlInfo);
        }

        /// <inheritdoc/>
        public Boolean Equals(XmlInfo other) {
            return other != null &&
                   this.Name == other.Name &&
                   EqualityComparer<Dictionary<String, String>>.Default.Equals(this.Attributes, other.Attributes) &&
                   this.Value == other.Value;
        }

        /// <inheritdoc/>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.Name, this.Attributes, this.Value);
        }

        /// <inheritdoc/>
        public static Boolean operator ==(XmlInfo left, XmlInfo right) {
            return EqualityComparer<XmlInfo>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static Boolean operator !=(XmlInfo left, XmlInfo right) {
            return !(left == right);
        }
    }
}
