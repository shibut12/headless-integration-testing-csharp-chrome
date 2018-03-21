using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using Xunit;

namespace HeadLessTest
{
    public class SutGoogleHomePage
    {
        private ChromeOptions desiredCapabilities;
        private string googleUrl;
        private ChromeDriver chromeDriver;

        public SutGoogleHomePage()
        {
            desiredCapabilities = new ChromeOptions();
            desiredCapabilities.AddArgument("--headless");
            desiredCapabilities.AddArgument("--no-sandbox");
            desiredCapabilities.AddArgument("--ignore-ssl-errors=true");
            desiredCapabilities.AddArgument("--ssl-protocol=any");
            desiredCapabilities.AddArgument("--disable-gpu");
            desiredCapabilities.AddArgument("window-size=1400,600");

            googleUrl = "https://www.google.com";

            chromeDriver = new ChromeDriver(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), 
                desiredCapabilities
            );
        }
        
        [Fact]
        public void GoogleHomePageVerifyPageIsLoading()
        {
            chromeDriver.Navigate().GoToUrl(googleUrl);
            var pgTitle = chromeDriver.Title;
            chromeDriver.Quit();

            Assert.Equal("Google", pgTitle);
        }
    }
}
