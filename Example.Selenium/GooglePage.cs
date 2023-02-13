using OpenQA.Selenium;

namespace Example.Selenium
{
    public class GooglePage : BasePage
    {
        public Input SearchInput { get; set; }

        public GooglePage(IWebDriver driver) : base(driver)
        {
            SearchInput = new Input(Driver.WaitForVisible(By.Name("q")));
        }
    }
}
