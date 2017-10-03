using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugaringAutomation
{
    public class Driver
    {
        public static IWebDriver SetPropertys { get; set; }
       
        public static void Init()
        {
            SetPropertys = new FirefoxDriver();
        }
    }

    public class LoginPage
    {
      
        public static void GoTo(string url)
        {
            Driver.SetPropertys.Navigate().GoToUrl(url);

        }

        public static void Close()
        {
            Driver.SetPropertys.Close();
        }

        public static LoginPropertise EnterUsername(string email)
        {
            return new LoginPropertise(email);
        }
        public static Boolean CheckForLoginUser()
        {
            bool userLink = Driver.SetPropertys.FindElement(By.XPath("//*[@class='toprow']/*[@class='links']/*[@class='login_h']/a[text()='Nas']")).Displayed;

            if (userLink == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class LoginPropertise
    {
        public string email;
        public string password;

        public LoginPropertise(string email)
        {
            this.email = email;
        }
        public LoginPropertise EnterPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var emailTextField = Driver.SetPropertys.FindElement(By.Name("email"));
            emailTextField.SendKeys(email);
            var passwordField = Driver.SetPropertys.FindElement(By.Name("password"));
            passwordField.SendKeys(password);
            var submitButton = Driver.SetPropertys.FindElement(By.XPath("//*[@class='login-buttons']/*[text()='Login']"));
            submitButton.Click();
        }

    }
}
