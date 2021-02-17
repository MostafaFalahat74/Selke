using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace Selke
{
    using Conditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var driver = new ChromeDriver();
            //jhj
            var options = driver.Manage();
         //   options.Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            var window = options.Window;
            window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
            var wait = new WebDriverWait(driver , timeout:TimeSpan.FromSeconds(3));
         //   Thread.Sleep(3000);
           

            var inputXpath = By.XPath("/html/body/div[1]/div[3]/form/div[2]/div[1]/div[1]/div/div[2]/input");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(inputXpath));
            var inputElement = driver.FindElement(inputXpath);
          


            var searchXpath = By.XPath("/html/body/div[1]/div[3]/form/div[2]/div[1]/div[3]/center/input[1]");
            var searchElement = driver.FindElement(searchXpath);

            inputElement.SendKeys("mosi");
            searchElement.Click();

        */
            //var driver = new ChromeDriver();
            //var options = driver.Manage();

            //var window = options.Window;
            //window.Maximize();
            //driver.Navigate().GoToUrl("https://github.com/");
            //driver.Manage().Cookies.DeleteAllCookies();
            //driver.ExecuteScript("window.localStorage.clear()");
            //driver.ExecuteScript("window.sessionStorage.clear()");

            //var wait = new WebDriverWait(driver, timeout: TimeSpan.FromSeconds(3));


            //var loginXpath = By.XPath("/html/body/div[1]/header/div/div[2]/div[2]/a[1]");
            //var loginElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(loginXpath));
            //var loginElement = driver.FindElement(loginXpath);
            //Thread.Sleep(3000);
            //loginElement.Click();


            //var userNameXpath = By.XPath("/html/body/div[3]/main/div/div[4]/form/input[2]");
            //var userNameElement = driver.FindElement(userNameXpath);
            //userNameElement.SendKeys("mostafa.falahat@gmail.com");


            //var passwordXpath = By.XPath("/html/body/div[3]/main/div/div[4]/form/input[3]");
            //var passwordElement = driver.FindElement(passwordXpath);
            //passwordElement.SendKeys("m4801F!@#$");

            //var signInXpath = By.XPath("/html/body/div[3]/main/div/div[4]/form/input[14]");
            //var signInElement = driver.FindElement(signInXpath);
            //signInElement.Click();

            //Thread.Sleep(3000);
            //driver.Dispose();

            //   wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(inputXpath));


            //var option = new ChromeOptions();
            //option.AddArgument("headless");

            var driver = new ChromeDriver();
            var options = driver.Manage();
            var window = options.Window;          
            window.Maximize();
            driver.Navigate().GoToUrl("https://www.w3schools.com/js/tryit.asp?filename=tryjs_alert");
            var wait = new WebDriverWait(driver, timeout: TimeSpan.FromSeconds(3));
            driver.SwitchTo().Frame("iframeResult");
            var alertButtonXpath = By.XPath("/html/body/button");
            //var alertButtonElement = driver.FindElement(alertButtonXpath);
            var alertButtonElement = wait.Until(Conditions.ElementExists(alertButtonXpath));
            alertButtonElement.Click();
          
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);
            driver.Dispose();
        }
    }
}
