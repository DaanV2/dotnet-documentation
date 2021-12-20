using System;
using System.Collections.Generic;
using DaanV2.Documentation.Data;

namespace DaanV2.Documentation.Markdown {
    public static partial class Extension {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="Name"></param>
        /// <param name="action"></param>
        public static void ForAll(this List<XmlInfo> info, String Name, Action<List<XmlInfo>> action) {
            List<XmlInfo> items = info.GetAll(Name);

            if (items.Count == 0) return;

            action.Invoke(items);
        }
    }
}
