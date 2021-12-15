using DaanV2.Documentation.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test {
    [TestClass]
    public partial class TypeInfoTest {
        [TestMethod]
        public void ObjectName() {
            var TI = new TypeInfo { Name = "T:DaanV2.Documentation.Example" };
            Assert.AreEqual(TI.ObjectName, "DaanV2.Documentation.Example");

            TI = new TypeInfo { Name = "M:DaanV2.Documentation.Example.#ctor" };
            Assert.AreEqual(TI.ObjectName, "DaanV2.Documentation.Example");
        }
    }
}
