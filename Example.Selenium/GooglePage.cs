using OpenQA.Selenium;

namespace Example.Selenium
{
    public class GooglePage : BasePage
    {
        public Input SearchInput;
        public Button AcceptAll;

        public GooglePage(IWebDriver driver) : base(driver)
        {
            SearchInput = new Input(Driver, By.Name("q"));
            AcceptAll = new Button(Driver, By.Id("L2AGLb"));
        }
    }
}
