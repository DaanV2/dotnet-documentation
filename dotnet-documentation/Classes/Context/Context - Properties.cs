using System;
using System.Collections.Generic;

namespace DaanV2.Documentation {
    public partial class Context {
        /// <summary>Gets the documentation files.</summary>
        public List<String> DocumentationFiles { get; private set; }

        /// <summary>Gets the output folder.</summary>
        public String OutputFolder { get; private set; }
    }
}
