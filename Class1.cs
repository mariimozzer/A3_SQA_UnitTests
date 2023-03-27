/* Assignment 03 - Software Quality Assurance
 * Mariana Mozzer Arantes - 8665539
 * Date: 03/27/2023
 */

using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mariana_Mozzer_8665539_Assignment3
{
    public class Class1
    {

        [TestFixture]
        public class A3TestsTest
        {
            private IWebDriver driver;
            public IDictionary<string, object> vars { get; private set; }
            private IJavaScriptExecutor js;
            [SetUp]
            public void SetUp()
            {
                driver = new ChromeDriver();
                js = (IJavaScriptExecutor)driver;
                vars = new Dictionary<string, object>();
            }
            [TearDown]
            protected void TearDown()
            {
                driver.Quit();
            }
            [Test]
            public void test01_age25experience3accidents0_2500()
            {
                driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
                driver.FindElement(By.CssSelector(".btn")).Click();
                driver.FindElement(By.Id("firstName")).Click();
                driver.FindElement(By.Id("firstName")).SendKeys("Mariana");
                driver.FindElement(By.Id("lastName")).SendKeys("Mozzer Arantes");
                driver.FindElement(By.Id("address")).SendKeys("209 Deerpath Dr");
                driver.FindElement(By.Id("city")).SendKeys("Guelph");
                driver.FindElement(By.Id("postalCode")).SendKeys("N1K 1W6");
                driver.FindElement(By.Id("phone")).SendKeys("666-666-6666");
                driver.FindElement(By.Id("email")).SendKeys("mmozzerarantes5539@conestogac.on.ca");
                driver.FindElement(By.Id("age")).Click();
                driver.FindElement(By.Id("age")).SendKeys("25");
                driver.FindElement(By.Id("experience")).SendKeys("3");
                driver.FindElement(By.Id("accidents")).SendKeys("0");
                driver.FindElement(By.Id("btnSubmit")).Click();
                {
                    string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("$2500"));
                }
            }
            [Test]
            public void test02_age25experience3accidents4_noInsurance()
            {
                driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
                driver.Manage().Window.Size = new System.Drawing.Size(783, 816);
                driver.FindElement(By.CssSelector(".btn")).Click();
                driver.FindElement(By.Id("firstName")).Click();
                driver.FindElement(By.Id("firstName")).SendKeys("Mariana");
                driver.FindElement(By.Id("lastName")).SendKeys("Mozzer Arantes");
                driver.FindElement(By.Id("address")).SendKeys("209 Deerpath Dr");
                driver.FindElement(By.Id("city")).SendKeys("Guelph");
                driver.FindElement(By.Id("postalCode")).Click();
                driver.FindElement(By.Id("postalCode")).SendKeys("N1K 1W6");
                driver.FindElement(By.Id("phone")).Click();
                driver.FindElement(By.Id("phone")).SendKeys("666-666-6666");
                driver.FindElement(By.Id("email")).Click();
                driver.FindElement(By.Id("email")).SendKeys("mmozzerarantes5539@conestogac.on.ca");
                driver.FindElement(By.Id("age")).Click();
                driver.FindElement(By.Id("age")).SendKeys("25");
                driver.FindElement(By.Id("experience")).SendKeys("3");
                driver.FindElement(By.Id("accidents")).SendKeys("4");
                driver.FindElement(By.Id("btnSubmit")).Click();
                {
                    string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
                }
            }
            [Test]
            public void test03_age35experience10accidents2_1350()
            {
                driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
                driver.Manage().Window.Size = new System.Drawing.Size(784, 816);
                driver.FindElement(By.CssSelector(".btn")).Click();
                driver.FindElement(By.Id("firstName")).Click();
                driver.FindElement(By.Id("firstName")).SendKeys("Mariana");
                driver.FindElement(By.Id("lastName")).SendKeys("Mozzer Arantes");
                driver.FindElement(By.Id("address")).SendKeys("209 Deerpath Dr");
                driver.FindElement(By.Id("city")).SendKeys("Guelph");
                driver.FindElement(By.Id("postalCode")).SendKeys("N1K 1W6");
                driver.FindElement(By.Id("phone")).SendKeys("666-666-6666");
                driver.FindElement(By.Id("email")).SendKeys("mmozzerarantes5539@conestogac.on.ca");
                driver.FindElement(By.Id("age")).Click();
                driver.FindElement(By.Id("age")).SendKeys("35");
                driver.FindElement(By.Id("experience")).SendKeys("10");
                driver.FindElement(By.Id("accidents")).SendKeys("2");
                driver.FindElement(By.Id("btnSubmit")).Click();
                {
                    string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("$1350"));
                }
            }
            [Test]
            public void test04_invalidPhone_error()
            {
                driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
                driver.Manage().Window.Size = new System.Drawing.Size(784, 816);
                driver.FindElement(By.CssSelector(".btn")).Click();
                driver.FindElement(By.Id("firstName")).Click();
                driver.FindElement(By.Id("firstName")).SendKeys("Mariana");
                driver.FindElement(By.Id("lastName")).SendKeys("Mozzer Arantes");
                driver.FindElement(By.Id("address")).Click();
                driver.FindElement(By.Id("address")).SendKeys("209 Deerpath Dr");
                driver.FindElement(By.Id("city")).Click();
                driver.FindElement(By.Id("city")).SendKeys("Guelph");
                driver.FindElement(By.Id("postalCode")).Click();
                driver.FindElement(By.Id("postalCode")).SendKeys("N1K 1W6");
                driver.FindElement(By.Id("phone")).Click();
                driver.FindElement(By.Id("phone")).SendKeys("123-123-123");
                driver.FindElement(By.Id("email")).Click();
                driver.FindElement(By.Id("email")).SendKeys("mmozzerarantes5539@conestogac.on.ca");
                driver.FindElement(By.Id("age")).Click();
                driver.FindElement(By.Id("age")).SendKeys("25");
                driver.FindElement(By.Id("experience")).Click();
                driver.FindElement(By.Id("experience")).SendKeys("2");
                driver.FindElement(By.Id("accidents")).Click();
                driver.FindElement(By.Id("accidents")).SendKeys("0");
                driver.FindElement(By.Id("btnSubmit")).Click();
                {
                    var element = driver.FindElement(By.Id("btnSubmit"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element).Perform();
                }
                {
                    var element = driver.FindElement(By.TagName("body"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element, 0, 0).Perform();
                }
                Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
            }
            [Test]
            public void test06invalidPostalerror()
            {
                driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
                driver.Manage().Window.Size = new System.Drawing.Size(783, 816);
                driver.FindElement(By.CssSelector(".btn")).Click();
                driver.FindElement(By.Id("firstName")).Click();
                driver.FindElement(By.Id("firstName")).SendKeys("Mariana");
                driver.FindElement(By.Id("lastName")).SendKeys("Mozzer Arantes");
                driver.FindElement(By.Id("address")).SendKeys("209 Deerpath Dr");
                driver.FindElement(By.Id("city")).SendKeys("Guelph");
                driver.FindElement(By.Id("postalCode")).SendKeys("1N2 5G9");
                driver.FindElement(By.Id("phone")).Click();
                driver.FindElement(By.Id("phone")).SendKeys("123-456-7890");
                driver.FindElement(By.Id("email")).Click();
                driver.FindElement(By.Id("email")).SendKeys("mmozzerarantes5539@conestogac.on.ca");
                driver.FindElement(By.Id("age")).Click();
                driver.FindElement(By.Id("age")).SendKeys("25");
                driver.FindElement(By.Id("experience")).SendKeys("2");
                driver.FindElement(By.Id("accidents")).SendKeys("0");
                driver.FindElement(By.Id("btnSubmit")).Click();
                {
                    var element = driver.FindElement(By.Id("btnSubmit"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element).Perform();
                }
                {
                    var element = driver.FindElement(By.TagName("body"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element, 0, 0).Perform();
                }
                Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
            }


        }
    }
}
