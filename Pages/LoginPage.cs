using OpenQA.Selenium;

namespace SpecFlowTraining.Pages
{
    public class LoginPage
    {
        public IWebDriver webDriver { get; }
        public LoginPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement UsernameInput => webDriver.FindElement(By.Id("user-name"));
        public IWebElement PasswordInput => webDriver.FindElement(By.CssSelector("#password"));
        public IWebElement LoginButton => webDriver.FindElement(By.Id("login-button"));
        public IWebElement ErrorText => webDriver.FindElement(By.XPath("//body/div[@id='root']/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[3]/h3[1]"));

        public IWebDriver WebDriver { get; }

        public void EnterUsername(String username) => UsernameInput.SendKeys(username);
        public void EnterPassword(String password) => PasswordInput.SendKeys(password);
        public void ClickLoginButton() => LoginButton.Click();

        public String errorMessage()
        {
            return ErrorText.Text;
        }
    }
}
