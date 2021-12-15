using System;
using System.Collections.Generic;

namespace DaanV2.Documentation {
    public static partial class Extension {
        /// <summary> Retrieves the object with the matching name. </summary>
        /// <typeparam name="T"> The type of object to retrieve. </typeparam>
        /// <param name="Items"> The list of items to search through. </param>
        /// <param name="Name"> The name of the object to retrieve. </param>
        /// <returns> The object with the matching name. or default / null</returns>
        public static T GetSingle<T>(this List<T> Items, String Name)
            where T : INameable {
            Int32 Max = Items.Count;

            for (Int32 I = 0; I < Max; I++) {
                T Item = Items[I];

                if (Name.Equals(Item.Name)) return Item;
            }

            return default;
        }

        /// <summary> Retrieves the objects with the matching name. </summary>
        /// <typeparam name="T"> The type of object to retrieve. </typeparam>
        /// <param name="Items"> The list of items to search through. </param>
        /// <param name="Name"> The name of the object to retrieve. </param>
        /// <returns> The objects with the matching name. or default / null</returns>
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
