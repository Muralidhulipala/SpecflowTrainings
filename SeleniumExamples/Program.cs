using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //Text Field
            driver.FindElement(By.XPath("")).SendKeys("");
            driver.FindElement(By.XPath("")).SendKeys("");
            //Radio button
            driver.FindElement(By.XPath("")).Click();
            driver.FindElement(By.XPath("")).Click();
            //Checkbox
            driver.FindElement(By.XPath("")).Click();
            driver.FindElement(By.XPath("")).Click();

            //Dropdowns

            SelectElement select = new SelectElement(driver.FindElement(By.XPath("")));
           var list= select.AllSelectedOptions;
            select.SelectByValue("");
            select.SelectByText("");
            select.SelectByIndex(1);
            var selectedvalue=select.SelectedOption.Text;

            int totaloptions=select.Options.Count;


            //Alerts
            IAlert alert = driver.SwitchTo().Alert();
            var text=alert.Text;
            alert.Accept();
            alert.Dismiss();
            alert.SendKeys("");

            //Frames
            driver.SwitchTo().Frame(1);
            driver.FindElement(By.XPath("")).Click();
            driver.FindElement(By.XPath("")).Click();
            driver.SwitchTo().DefaultContent();

            //windows

            var wincount = driver.WindowHandles;
            foreach (var win in wincount)
            {
                driver.SwitchTo().Window(win);
               var title= driver.Title;

            }

            // Implict wait

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Webdriver wait explicit wait example
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("")));

            //Actions class
            Actions a = new Actions(driver);
            a.SendKeys("").Build().Perform();
            a.MoveToElement(driver.FindElement(By.Id(""))).ContextClick();
            a.MoveToElement(driver.FindElement(By.Id(""))).DoubleClick();

            //draganddrop
            var source = driver.FindElement(By.Id(""));
            var target = driver.FindElement(By.Id(""));
            a.ClickAndHold(source).MoveToElement(target).Release().Build().Perform();
            a.DragAndDrop(source, target).Build().Perform();





















        }
    }
}
