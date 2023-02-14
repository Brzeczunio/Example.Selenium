using OpenQA.Selenium;

namespace Example.Selenium
{
    public class Input
    {
        private IWebDriver _driver;
        private By _by;

        public void SendKeys(string text) => _driver.WaitForVisible(_by).SendKeys(text);

        public Input(IWebDriver driver, By by)
        {
            _driver = driver;
            _by = by;
        }
    }
}
