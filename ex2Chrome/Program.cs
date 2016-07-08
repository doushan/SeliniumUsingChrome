using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace ex2Chrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //adding the path of Google Chrome Web Driver
            IWebDriver driver = new ChromeDriver(@"C:\Users\dgoolab\Desktop\chromedriver");
            driver.Navigate().GoToUrl("http://www.pampers.com/registration");
            driver.FindElement(By.Id("phdesktopbody_0_imgmale")).Click();
            driver.FindElement(By.Id("phdesktopbody_0_imgmale")).Click();
            driver.FindElement(By.XPath(".//*[@name='phdesktopbody_0$grs_consumer[firstname]']")).SendKeys("Tom");
            driver.FindElement(By.Name("phdesktopbody_0$grs_consumer[lastname]")).SendKeys("Jerry");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[addresses][0][line1]")).SendKeys("Royal Road");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[addresses][0][line2]")).SendKeys("Vacoas");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[addresses][0][postalarea]")).SendKeys("123456");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[addresses][0][city]")).SendKeys("Vacoas");
            driver.FindElement(By.Name("phdesktopbody_0$grs_consumer[screenname]")).SendKeys("Doushan");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[emails][0][address]")).SendKeys("tom12@live.com");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[password][password]")).SendKeys("lol12345");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[password][confirm]")).SendKeys("lol12345");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[phones][0][fulltelephonenumber]")).SendKeys("5710152700");
            driver.FindElement(By.Name("phdesktopbody_0$grs_consumer[birthdate][month]")).SendKeys("03");
            driver.FindElement(By.Name("phdesktopbody_0$grs_consumer[birthdate][year]")).SendKeys("1993");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[addresses][0][territory]")).SendKeys("Hawaii");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[dependents][77][0][birth_date][month]")).SendKeys("9");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[dependents][77][0][birth_date][day]")).SendKeys("3");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[dependents][77][0][birth_date][year]")).SendKeys("2015");
            driver.FindElement(By.Name("phdesktopbody_0$grs_account[dependents][77][0][gender]")).SendKeys("Boy");


            //driver.FindElement(By.Id("phdesktopbody_0_submit")).Submit();
            IWebElement element = driver.FindElement(By.Name("phdesktopbody_0$submit"));
            element.Click();
            
            driver.FindElement(By.Id("phmainbodytop_0_ctl08_loginOrUsernameText")).Click();
            driver.FindElement(By.Name("phdesktopbody_0$username")).SendKeys("tom12@live.com");
            driver.FindElement(By.Name("phdesktopbody_0$password")).SendKeys("lol12345");

            IWebElement element2 = driver.FindElement(By.Name("phdesktopbody_0$submit"));
            element2.Click();

           

            Thread.Sleep(500000);
            driver.Quit();
        }
    }
}