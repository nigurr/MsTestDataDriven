using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject5
{
    [TestClass]
    public class UnitTest1
    {
        [DataSource("System.Data.Odbc", "Dsn=ExcelFiles;Driver={Microsoft Excel Driver (*.xls)};dbq=|DataDirectory|\\Data.xls;defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true", "Sheet1$", DataAccessMethod.Sequential), DeploymentItem("Data.xls"), TestMethod]
        public void TestMethod1()
        {
            var num1 = int.Parse(TestContext.DataRow["Num1"].ToString());
            var num2 = int.Parse(TestContext.DataRow["Num2"].ToString());
            var sum = int.Parse(TestContext.DataRow["Sum"].ToString());
            Assert.AreEqual(num1 + num2, sum);
        }

        /// <summary>
        /// Gets or sets the microsoft test context.
        /// </summary>
        /// <value>
        /// The microsoft test context.
        /// </value>
        public TestContext TestContext { get; set; }
    }
}
