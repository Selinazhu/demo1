using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net");

            //inter the username
            IWebElement UserName = driver.FindElement(By.XPath("//*[@id='UserName']"));

            UserName.SendKeys("hari");

            //inter the password
            IWebElement PassWord = driver.FindElement(By.XPath("//*[@id='Password']"));

            PassWord.SendKeys("123123");

            //click the Login button
            IWebElement Login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));

            Login.Click();

            IWebElement AdminisButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            AdminisButton.Click();

            IWebElement EmployeesButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));

            EmployeesButton.Click();

        }
    }
}
