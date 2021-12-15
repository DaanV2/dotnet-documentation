using System;
using System.Collections.Generic;

namespace DaanV2.Documentation.Data {
    public partial class TypeInfo : IEquatable<TypeInfo> {
        /// <inheritdoc/>
        public override String ToString() {
            return $"{this.Name} {this.XmlInfo.Count}";
        }

        /// <inheritdoc/>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as TypeInfo);
        }

        /// <inheritdoc/>
        public Boolean Equals(TypeInfo other) {
            return other != null &&
                   this.Name == other.Name &&
                   EqualityComparer<List<XmlInfo>>.Default.Equals(this.XmlInfo, other.XmlInfo);
        }

        /// <inheritdoc/>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.Name, this.XmlInfo);
        }

        /// <inheritdoc/>
        public static Boolean operator ==(TypeInfo left, TypeInfo right) {
            return EqualityComparer<TypeInfo>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static Boolean operator !=(TypeInfo left, TypeInfo right) {
            return !(left == right);
        }
    }
}
