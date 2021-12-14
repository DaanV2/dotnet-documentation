using System.Xml;

namespace DaanV2.Documentation.Data.Converter {
    public partial class AssemblyInfoConverter {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public AssemblyInfo Convert(XmlElement filecontents) {
            var Result = new AssemblyInfo();

            XmlElement doc = filecontents["doc"];
            XmlElement assembly = doc["assembly"];
            XmlElement members = doc["members"];

            //Get the assembly name
            Result.Name = assembly["name"].InnerText;

            //Loop over members
            XmlNode member = members.FirstChild;

            while (member is not null) {
                this.TIConverter.Convert(members);

                member = member.NextSibling;
            }


            return Result;
        }
    }
}
