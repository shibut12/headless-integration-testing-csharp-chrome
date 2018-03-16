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
            args.AddArgument("--no-sandbox");
            args.AddArgument("--ignore-ssl-errors=true");
            args.AddArgument("--ssl-protocol=any");
            args.AddArgument("--disable-gpu");
            args.AddArgument("window-size=1400,600");

            //var driver = new ChromeDriver(args);
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), args);
            driver.Url = "https://www.google.com";
            var pgTitle = driver.Title;
            driver.Quit();

            Assert.Equal("Google", pgTitle);
        }
    }
}
