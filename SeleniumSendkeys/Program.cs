using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumSendkeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mail.rediff.com/cgi-bin/login.cgi");
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);

            //1st approach

            IJavaScriptExecutor ij1 = (IJavaScriptExecutor)driver;
            //ij1.ExecuteScript("document.getElementById('login1').value ='test'");
            //Thread.Sleep(2000);

            //2nd approach
            IWebElement ele1 = driver.FindElement(By.Id("login1"));
            ij1.ExecuteScript("arguments[0].value='test data';",ele1);
            Thread.Sleep(2000);

            //Click operation new apparoach
            IWebElement clck = driver.FindElement(By.XPath("//input[@type='submit']"));
            ij1.ExecuteScript("arguments[0].click();", clck);
            //driver.Close();

        }
    }
}
