using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace Prueba_Automatizada_Integrity
{
    public class Tests
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\Chrome Driver\chromedriver.exe");
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Compras()
        {
            Flujo_compra fc = new Flujo_compra(driver);
            try
            {
                fc.abrir_navegador();
                fc.productos();
                fc.facturar();
                Assert.Pass("La prueba se realizo con exito");
            }
            catch (SystemException error)
            {
                Assert.Fail("El test tuvo un resultado fallido ",error);
            }
             
        }


    }
}