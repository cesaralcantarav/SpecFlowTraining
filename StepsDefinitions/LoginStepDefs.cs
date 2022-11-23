using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SpecFlowTraining.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepsDefinitions
{
    [Binding]
    public sealed class LoginStepDefs
    {
        LoginPage LoginPage;
        InventoryPage InventoryPage;
        IWebDriver webDriver = new ChromeDriver();

        [Given(@"que el Cliente se encuentra en la página SauceDemo")]
        public void ClientOpenSauceDemoPage()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
            LoginPage = new LoginPage(webDriver);
        }

        [When(@"inicia sesión con las credenciales: (.*), (.*)")]
        public void LoginWithCredentials(String username, String password)
        {
            LoginPage.EnterUsername(username);
            LoginPage.EnterPassword(password);
            LoginPage.ClickLoginButton();
        }

        [Then(@"el login es satisfactorio")]
        public void ThenElLoginEsSatisfactorio()
        {
            //Assert.That(InventoryPage.isProductsTitleExist(), Is.True);
            InventoryPage = new InventoryPage(webDriver);
            Assert.IsTrue(InventoryPage.isProductsTitleExist());
            webDriver.Quit();

        }

        [Then(@"se muestra el mensaje de error ""([^""]*)""")]
        public void ThenSeMuestraElMensajeDeError(string message)
        {
            Assert.AreEqual(LoginPage.errorMessage(), message);
            webDriver.Quit();
        }


    }
}
