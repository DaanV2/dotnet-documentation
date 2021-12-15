using System;
using System.Collections.Generic;

namespace DaanV2.Documentation.Data {
    public partial class AssemblyInfo : IEquatable<AssemblyInfo> {
        /// <inheritdoc/>
        public override String ToString() {
            return $"{this.Name} {this.TypeData.Count}";
        }

        /// <inheritdoc/>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as AssemblyInfo);
        }

        /// <inheritdoc/>
        public Boolean Equals(AssemblyInfo other) {
            return other != null &&
                   this.Name == other.Name &&
                   EqualityComparer<List<TypeInfo>>.Default.Equals(this.TypeData, other.TypeData);
        }

        /// <inheritdoc/>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.Name, this.TypeData);
        }

        /// <inheritdoc/>
        public static Boolean operator ==(AssemblyInfo left, AssemblyInfo right) {
            return EqualityComparer<AssemblyInfo>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static Boolean operator !=(AssemblyInfo left, AssemblyInfo right) {
            return !(left == right);
        }
    }
}
