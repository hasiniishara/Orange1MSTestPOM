using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange1
{
    [TestClass]
    public class SanityTest
    {
        private static LoginPage loginPage;
        private static DashboardPage dashboardPage;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            SystemUtil.OpenSystem();

            loginPage = new LoginPage(SystemUtil.GetDriver());
            dashboardPage = new DashboardPage(SystemUtil.GetDriver());
        }

        [TestMethod]
        public void LoginTest()
        {
            string UName = "Admin";
            string UPassword = "z@52zrUKFA";

            dashboardPage = loginPage.Login(UName, UPassword);
            Assert.IsTrue(SystemUtil.GetDriver().Url.Contains("https://devmini-trials711.orangehrmlive.com/client/#/dashboard"));
            Console.WriteLine("Successfully login to the system");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            SystemUtil.CloseDriver();
        }

    }
}
