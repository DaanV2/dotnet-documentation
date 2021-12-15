using System;
using DaanV2.Documentation.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test {
    [TestClass]
    public partial class TypeInfoTest {
        [TestMethod]
        [DataRow("T:DaanV2.Documentation.Example", "DaanV2.Documentation.Example")]
        [DataRow("M:DaanV2.Documentation.Example.#ctor", "DaanV2.Documentation.Example")]
        [DataRow("M:DaanV2.Documentation.Factories.Example.Foo(System.Char,DaanV2.Documentation.Temple)", "DaanV2.Documentation.Factories.Example")]
        public void ObjectName(String Name, String Result) {
            var TI = new TypeInfo { Name = Name };
            Assert.AreEqual(TI.ObjectName, Result);
        }
    }
}
