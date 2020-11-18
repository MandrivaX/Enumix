using Enumix.Implementations;
using Enumix.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using EnumDesc = System.ComponentModel;

namespace EnumixUnitTests
{
    [TestClass]
    public class EnumTest
    {
        enum TestEnumType
        {
            [Display(Name = "AA")]
            A,
            [Display(Name = "BB")]
            B,
            [Display(Name = "CC")]
            C
        }
        enum TestEnumTypeDecs
        {
            [EnumDesc.Description("This is red color")]
            Red,
            [EnumDesc.Description("This is Blue color")]
            Blue,
            [EnumDesc.Description("This is Whithe color")]
            Whithe
        }

        [TestMethod]
        public void TestMethod1()
        {
            IEnumix enu = new EnumixImpl();
            string s1 = enu.GetDisplayName(TestEnumType.B);
            string s2 = enu.GetEnumElementsDisplayName<TestEnumType>();
            string s3 = enu.GetEnumElementsDisplayName<TestEnumType>(",");
            string s4 = enu.GetEnumElementsDescription<TestEnumTypeDecs>();
            string s5 = enu.GetEnumElementsDescription<TestEnumTypeDecs>(";");
            string s6 = enu.GetDescription(TestEnumTypeDecs.Red);

            Assert.AreEqual("BB", s1);
        }
    }
}
