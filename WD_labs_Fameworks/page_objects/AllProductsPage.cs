using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace WD_labs_Frameworks.page_objects
{
    class AllProductsPage: AbstractPage
    {
        public AllProductsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Create new")]
        private IWebElement CreateNewBtn;
        public ProductEditingPage CreateNew()
        {
            IAction action = new Actions(driver)
                 .MoveToElement(CreateNewBtn)
                 .Click(CreateNewBtn)
                 .Build();

            action.Perform();

            return new ProductEditingPage(driver);
        }


        public ProductEditingPage CreatedProducts(string productName)
        {
            
            IWebElement CreatedProduct = driver.FindElement(By.LinkText(productName));

            IAction action = new Actions(driver)
                 .MoveToElement(CreatedProduct)
                 .Click(CreatedProduct)
                 .Build();

            action.Perform();

            return new ProductEditingPage(driver);
        }

    }
}
