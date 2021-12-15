using System;
using System.Collections.Generic;
using System.Xml;

namespace DaanV2.Documentation.Data.Converter {
    public partial class AssemblyInfoConverter {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public AssemblyInfo Convert(XmlElement doc) {
            var Result = new AssemblyInfo();

            XmlElement assembly = doc["assembly"];
            XmlElement members = doc["members"];

            //Get the assembly name
            Result.Name = assembly["name"].InnerText;

            //Loop over members
            XmlNode member = members.FirstChild;

            while (member is not null) {
                TypeInfo T = this.TIConverter.Convert(member);

                if (T is not null) {
                    String K = T.ObjectName;

                    if (!Result.TypeData.TryGetValue(K, out List<TypeInfo> Container)) {
                        Container = new List<TypeInfo>();
                        Result.TypeData.Add(K, Container);
                    }

                    Container.Add(T);
                }

                member = member.NextSibling;
            }

            foreach (KeyValuePair<String, List<TypeInfo>> item in Result.TypeData) {
                item.Value.Sort(CompareTo);
            }

            return Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Int32 CompareTo(TypeInfo a, TypeInfo b) {
            if (a.Name.Length < b.Name.Length) {
                return 1;
            }
            else if (a.Name.Length > b.Name.Length) {
                return -1;
            }

            return a.Name.CompareTo(b.Name);
        }
    }
}
