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

        public IWebDriver WebDriver { get; }

        public void EnterUsername(String username) => UsernameInput.SendKeys(username);
        public void EnterPassword(String password) => PasswordInput.SendKeys(password);
        public void ClickLoginButton() => LoginButton.Click();
    }
}
