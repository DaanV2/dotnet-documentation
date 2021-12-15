using System;
using System.Collections.Generic;
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

            if (Attrs is not null && Attrs.Count > 0) {
                Result.Attributes = new Dictionary<String, String>();

                for (Int32 I = 0; I < Attrs.Count; I++) {
                    XmlAttribute Attr = Attrs[I];

                    Result.Attributes[Attr.Name] = Attr.Value;
                }
            }

            return Result;
        }
    }
}
