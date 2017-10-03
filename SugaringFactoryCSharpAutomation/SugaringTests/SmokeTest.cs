using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SugaringAutomation;

namespace SugaringTests
{
    [TestClass]
    public class SmokeTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Init();
        }
        [TestMethod]
        public void Login()
        {
            LoginPage.GoTo("https://test.sugaringfactory.com/index.php?route=account/login");
            LoginPage.EnterUsername("nas@nas.nas").EnterPassword("atanas").Login();
            Assert.IsTrue(LoginPage.CheckForLoginUser());
            //LoginPage.Close();
        }
    }

   [TestClass]
   public class FunctionalTest 
   {

        [TestMethod]
        public void PutItemInToShoppingCard()
        {
            LoginPage.GoTo("https://test.sugaringfactory.com");
            HomePage.SelectFirstItem();
            var selectedItemName = HomePage.FirstItemName("//*[@class='span3 first-in-line'][1]/*[@class='name']/a");
            HomePage.GoToShoppingCart();
            var itemShoppingCard = HomePage.FirstItemName("//*[@id='form-cart']/div/div/table/tbody//*[@class='name']/a");
            HomePage.CompareItems(selectedItemName, itemShoppingCard);
            HomePage.RemoveItemFromCart();
            LoginPage.Close();
        }
   }
}
