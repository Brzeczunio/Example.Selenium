using OpenQA.Selenium;

namespace Example.Selenium
{
    public class Button
    {
        private IWebDriver _driver;
        private By _by;

        public void Click() => _driver.WaitForClickable(_by).Click();

        public Button(IWebDriver driver, By by)
        {
            _driver = driver;
            _by = by;
        }
    }
}
