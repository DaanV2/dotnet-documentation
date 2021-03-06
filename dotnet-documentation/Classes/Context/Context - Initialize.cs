using System;
using System.Collections.Generic;
using System.IO;

namespace DaanV2.Documentation {
    /// <summary> The class that stores the context of project </summary>
    public partial class Context {
        /// <summary>Creates a new instance of <see cref="Context"/></summary>
        public Context() {
            this.DocumentationFiles = new List<String>();
            this.OutputFolder = Path.Combine(Environment.CurrentDirectory, "documentation");
        }
    }
}
