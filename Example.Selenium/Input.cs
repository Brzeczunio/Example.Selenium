using OpenQA.Selenium;

namespace Example.Selenium
{
    public class Input
    {
        private IWebElement _element { get; set; }

        public void SendKeys(string text) => _element.SendKeys(text);

        public Input(IWebElement element)
        {
            _element = element;
        }
    }
}
