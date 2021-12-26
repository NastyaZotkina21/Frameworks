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

namespace WD_labs_Frameworks.business_logic
{
    class ProductCreationLogic
    {
        public ProductCreationLogic(ProductPreparation product, page_objects.HomePage homePage)
        {

            page_objects.AllProductsPage AllProductsPage = homePage.GoToProductsPage();

            page_objects.ProductEditingPage ProductEditingPage = AllProductsPage.CreateNew();

            ProductEditingPage.CreateProduct(product.ProductName, product.CategoryId, product.SupplierId, product.UnitPrice, product.QuantityPerUnit, product.UnitsInStock, product.UnitsOnOrder, product.ReorderLevel, product.Discontinued);

            AllProductsPage.CreatedProducts(product.ProductName);

        }


    }
}
