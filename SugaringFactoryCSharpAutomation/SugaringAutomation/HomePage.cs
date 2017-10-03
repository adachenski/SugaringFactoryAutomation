using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugaringAutomation
{

    public class HomePage
    {
        public static string FirstItemName(string path)
        {
            return Driver.SetPropertys.FindElement(By.XPath(path)).GetAttribute("innerHTML");
        }

        public static void SelectFirstItem()
        {
            var firstItem = Driver.SetPropertys.FindElement(By.XPath("//*[@class='span3 first-in-line'][1]/*[@class='cart-button-holder']"));
            firstItem.Click();
        }

        public static void GoToShoppingCart()
        {
            Driver.SetPropertys.FindElement(By.XPath("//*[@class='span12']//*[text()='Shopping Cart']")).Click();
        }
        public static void CompareItems(string xpath_one, string xpath_two)
        {
            if (xpath_one == xpath_two)
            {
                System.Console.WriteLine("Great Job");
                System.Console.WriteLine(xpath_one);
            }
        }
        public static void RemoveItemFromCart()
        {
            Driver.SetPropertys.FindElement(By.XPath("//*[@class='icon-trash']")).Click();
        }
    }

    public class ByXPath
    {
        public string path { get; set; }

        public ByXPath(string path)
        {

            Driver.SetPropertys.FindElement(By.XPath(path)).GetAttribute("innerHTML");
        }
    }
}
