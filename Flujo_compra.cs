using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Prueba_Automatizada_Integrity
{
    class Flujo_compra
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;

        public Flujo_compra(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public void abrir_navegador()
        {
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }

        public void productos()
        {
            driver.FindElement(By.LinkText("Samsung galaxy s6")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Add to cart")).Click();
            Thread.Sleep(1000);
            //Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Product added"));
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);
            //driver.SwitchTo().Alert().Accept();
            //Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".active > .nav-link")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Nexus 6")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Add to cart")).Click();
            Thread.Sleep(1000);
            //Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Product added"));
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);
            //driver.SwitchTo().Alert().Accept();
        }

        public void facturar()
        {
            driver.FindElement(By.Id("cartur")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".btn-success")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("name")).Click();
            driver.FindElement(By.Id("name")).SendKeys("cristhian");
            driver.FindElement(By.Id("country")).Click();
            driver.FindElement(By.Id("country")).SendKeys("Guayaquil");
            driver.FindElement(By.Id("name")).Click();
            driver.FindElement(By.Id("name")).SendKeys("Cristhian");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("country")).Click();
            driver.FindElement(By.Id("country")).SendKeys("Ecuador");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Guayaquil");
            driver.FindElement(By.Id("card")).Click();
            driver.FindElement(By.Id("card")).SendKeys("123456789456789");
            driver.FindElement(By.Id("month")).Click();
            driver.FindElement(By.Id("month")).SendKeys("Diciembre");
            driver.FindElement(By.Id("year")).Click();
            driver.FindElement(By.Id("year")).SendKeys("2022");
            driver.FindElement(By.CssSelector("#orderModal .btn-primary")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".confirm")).Click();
            Thread.Sleep(2000);
        }
    }
}
