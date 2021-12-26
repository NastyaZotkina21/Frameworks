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
    class ProductEditingPage: AbstractPage
    {
        public ProductEditingPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ProductName")]
        private IWebElement ProductName;

        [FindsBy(How = How.Id, Using = "CategoryId")]
        private IWebElement CategoryId;

        [FindsBy(How = How.Id, Using = "SupplierId")]
        private IWebElement SupplierId;

        [FindsBy(How = How.Id, Using = "UnitPrice")]
        private IWebElement UnitPrice;

        [FindsBy(How = How.Id, Using = "QuantityPerUnit")]
        private IWebElement QuantityPerUnit;

        [FindsBy(How = How.Id, Using = "UnitsInStock")]
        private IWebElement UnitsInStock;

        [FindsBy(How = How.Id, Using = "UnitsOnOrder")]
        private IWebElement UnitsOnOrder;

        [FindsBy(How = How.Id, Using = "ReorderLevel")]
        private IWebElement ReorderLevel;

        [FindsBy(How = How.Id, Using = "Discontinued")]
        private IWebElement Discontinued;

        [FindsBy(How = How.CssSelector, Using = ".btn")]
        private IWebElement SubmitBtn;

        public AllProductsPage CreateProduct(string name, string category, string supplier, string unitprice, string quantityperunit, string unitsinstock, string unitsonorder, string reorderlevel, bool discontinued)
        {
            if (discontinued)

            {
                IAction action = new Actions(driver)
                   .Click(ProductName)
                   .SendKeys(name)
                   .Click(CategoryId)
                   .SendKeys(category)
                   .Click(SupplierId)
                   .SendKeys(supplier)
                   .Click(UnitPrice)
                   .SendKeys(unitprice)
                   .Click(QuantityPerUnit)
                   .SendKeys(quantityperunit)
                   .Click(UnitsInStock)
                   .SendKeys(unitsinstock)
                   .Click(UnitsOnOrder)
                   .SendKeys(unitsonorder)
                   .Click(ReorderLevel)
                   .SendKeys(reorderlevel)
                   .Click(Discontinued)
                   .Click(SubmitBtn)
                   .Build();


                    action.Perform();
            }
            else
            {
                IAction action = new Actions(driver)
                        .Click(ProductName)
                        .SendKeys(name)
                        .Click(CategoryId)
                        .SendKeys(category)
                        .Click(SupplierId)
                        .SendKeys(supplier)
                        .Click(UnitPrice)
                        .SendKeys(unitprice)
                        .Click(QuantityPerUnit)
                        .SendKeys(quantityperunit)
                        .Click(UnitsInStock)
                        .SendKeys(unitsinstock)
                        .Click(UnitsOnOrder)
                        .SendKeys(unitsonorder)
                        .Click(ReorderLevel)
                        .SendKeys(reorderlevel)
                        .Click(SubmitBtn)
                        .Build();

                        action.Perform();

            }



            return new AllProductsPage(driver);
        }

    }
}
