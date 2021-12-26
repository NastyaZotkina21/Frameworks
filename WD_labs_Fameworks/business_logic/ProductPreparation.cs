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
    class ProductPreparation
    {
        public string ProductName;
        public string CategoryId;
        public string SupplierId;
        public string UnitPrice;
        public string QuantityPerUnit;
        public string UnitsInStock;
        public string UnitsOnOrder;
        public string ReorderLevel;
        public bool Discontinued;

        public ProductPreparation (string name, string category, string supplier, string unitprice, string quantityperunit, string unitsinstock, string unitsonorder, string reorderlevel, bool discontinued)
        {
            ProductName = name;
            CategoryId = category;
            SupplierId = supplier;
            UnitPrice = unitprice;
            QuantityPerUnit = quantityperunit;
            UnitsInStock = unitsinstock;
            UnitsOnOrder = unitsonorder;
            ReorderLevel = reorderlevel;
            Discontinued = discontinued;
        }



    }
}
