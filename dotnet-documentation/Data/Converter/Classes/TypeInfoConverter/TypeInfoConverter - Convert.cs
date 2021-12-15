
using System.Xml;

namespace DaanV2.Documentation.Data.Converter {
    public partial class TypeInfoConverter {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public TypeInfo Convert(XmlNode element) {
            var Result = new TypeInfo {
                Name = element.Attributes["name"].Value
            };

            //Loop over members
            XmlNode child = element.FirstChild;

            while (child is not null) {
                Result.XmlInfo.Add(this.XIConverter.Convert(child));

                child = child.NextSibling;
            }

            return Result;
        }
    }
}
