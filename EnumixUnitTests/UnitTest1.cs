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
            string s = enu.GetDisplayName(TestEnumType.B);
        }
    }
}
