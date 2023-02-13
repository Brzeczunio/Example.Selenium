using OpenQA.Selenium;

namespace Example.Selenium
{
    public class Button
    {
        private IWebElement _element { get; set; }

        public void Click() => _element.Click();
    }
}
