using OpenQA.Selenium;

namespace Example.Selenium
{
    public class GooglePage : BasePage
    {
        public Input SearchInput => new Input(Driver.WaitForVisible(By.Name("q")));

        public GooglePage(IWebDriver driver) : base(driver)
        {
        }
    }
}
