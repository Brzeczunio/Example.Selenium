using OpenQA.Selenium.Chrome;

namespace Example.Selenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http:///www.google.pl");

            var googlePage = new GooglePage(driver);
            googlePage.SearchInput.SendKeys("aaa");
            Assert.Pass();
        }
    }
}