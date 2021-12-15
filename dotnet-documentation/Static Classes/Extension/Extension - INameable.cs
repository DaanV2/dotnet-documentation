using System;
using System.Collections.Generic;

namespace DaanV2.Documentation {
    ///DOLATER <summary>add description for class: Extension</summary>
    public static partial class Extension {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Items"></param>
        /// <param name=""></param>
        public static T GetSingle<T>(this List<T> Items, String Name)
            where T : INameable {
            Int32 Max = Items.Count;

            for (Int32 I = 0; I < Max; I++) {
                T Item = Items[I];

                if (Item.Name == Name) return Item;
            }

            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Items"></param>
        /// <param name=""></param>
        public static List<T> GetAll<T>(this List<T> Items, String Name)
            where T : INameable {
            var Out = new List<T>();
            Int32 Max = Items.Count;

            for (Int32 I = 0; I < Max; I++) {
                T Item = Items[I];

                if (Item.Name == Name) Out.Add(Item);
            }

            return Out;
        }
    }
}
