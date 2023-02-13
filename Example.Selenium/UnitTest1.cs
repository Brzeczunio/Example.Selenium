using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Example.Selenium
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate()
                .GoToUrl("http:///www.google.pl");
        }

        [Test]
        public void SendKeysToInput()
        {
            new GooglePage(driver)
                .SearchInput
                .SendKeys("aaa");
        }
    }
}