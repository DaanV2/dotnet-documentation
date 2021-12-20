using System;

namespace DaanV2.Documentation.Markdown {
    ///DOLATER <summary>add description for class: NameCorrector</summary>
    public static partial class NameCorrector {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Method"></param>
        /// <returns></returns>
        public static String MethodName(String Method) {
            if (Method[0] == '#') {
                Method = Method.Replace("#ctor", "Constructor");
            }
            else if (Method.StartsWith("op_")) {
                Method = Method.Replace("op_", "Operation");
                Method = Method.Replace("Bitwise", "Bitwise ");
            }

            return Method;
        }
    }
}
