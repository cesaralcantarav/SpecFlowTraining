using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTraining.Pages
{
    public class InventoryPage
    {
        public IWebDriver webDriver { get; }
        public InventoryPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement ProductsTitle => webDriver.FindElement(By.XPath("//span[contains(text(),'Products')]"));

        public bool isProductsTitleExist() => ProductsTitle.Displayed;
    }
}
