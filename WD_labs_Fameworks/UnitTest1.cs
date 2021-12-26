using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace WD_labs_Frameworks
{


    public class Tests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);


        }


        [Test]

        // new product created and added successfully
        public void Test1()
        {
            page_objects.LoginPage LoginPage = new page_objects.LoginPage(driver);
            page_objects.HomePage HomePage = LoginPage.Login("user", "user");

            business_logic.ProductPreparation newproduct = new business_logic.ProductPreparation("Чай индийский", "Condiments", "New Orleans Cajun Delights", "3", "21 000", "0", "0", "0", true);

            business_logic.ProductCreationLogic createdproduct = new business_logic.ProductCreationLogic(newproduct, HomePage);


            IWebElement label = driver.FindElement(By.XPath("//div[@class='container-fluid']/h2[text()='Product editing']"));
            Assert.IsTrue(label.Displayed);
        }



        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}