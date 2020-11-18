using Enumix.Implementations;
using Enumix.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;

namespace EnumixUnitTests
{
    [TestClass]
    public class UnitTest1
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
        
        [TestMethod]
        public void TestMethod1()
        {
            IEnumix enu = new EnumixImpl();
            string s1 = enu.GetDisplayName(TestEnumType.B);
            string s2 = enu.GetEnumElements<TestEnumType>();
            string s3 = enu.GetEnumElementsWithSeparator<TestEnumType>(",");
        }
    }
}
