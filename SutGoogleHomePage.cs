using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using Xunit;

namespace HeadLessTest
{
    public class SutGoogleHomePage
    {
        [Fact]
        public void GoogleHomePageVerifyPageIsLoading()
        {
            var args = new ChromeOptions();
            args.AddArgument("--headless");
            //var driver = new ChromeDriver(args);
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), args);
            driver.Url = "https://www.google.com";
            var pgTitle = driver.Title;
            driver.Quit();

            Assert.Equal("Google", pgTitle);
        }
    }
}
