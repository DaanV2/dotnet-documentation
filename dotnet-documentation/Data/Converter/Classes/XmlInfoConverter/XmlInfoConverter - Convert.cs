using System.Xml;

namespace DaanV2.Documentation.Data.Converter {
    public partial class XmlInfoConverter {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public XmlInfo Convert(XmlNode element) {
            var Result = new XmlInfo {
                Name = element.Name,
                Value = element.InnerText
            };

            //Converts the attributes
            XmlAttributeCollection Attrs = element.Attributes;
            for (System.Int32 I = 0; I < Attrs.Count; I++) {
                XmlAttribute Attr = Attrs[I];

                Result.Attributes[Attr.Name] = Attr.Value;
            }

            return Result;
        }
    }
}
