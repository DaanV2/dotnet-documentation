using System;
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

                if (T is not null) Result.TypeData.Add(T);

                member = member.NextSibling;
            }


            Result.TypeData.Sort(CompareTo);

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
