using checkmate.BaseClass;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace checkmate.Pages
{
    public class AmazonHomePage :  Base
    {
      
        
        public void  AndClickButton()
        {
            IWebElement button = driver.FindElement(By.Id("sp-cc-accept"));
            button.Click();
        }

        public void confirm()
        {
            IWebElement confirm = driver.FindElement(By.Id("nav-logo"));
            Assert.True(confirm.Displayed,"Is not dispalyed");
        }

        public void allbutton()
        {
            IWebElement allbutton = driver.FindElement(By.Id("searchDropdownBox"));
            SelectElement selectallbutton = new SelectElement(allbutton);
            selectallbutton.SelectByValue("search-alias=alexa-skills");

            //WebDriverWait wait = new WebDriverWait(driver,)

            Thread.Sleep(200);
            

            
        }

        public void balls()
        {
            IWebElement balls = driver.FindElement(By.Id("searchDropdownBox"));
            SelectElement selectballs = new SelectElement(balls);
            selectballs.SelectByText("Amazon Global Store");
             
        }


        public void anotherone()
        {
            IWebElement anotherone = driver.FindElement(By.Id("searchDropdownBox"));
            SelectElement selectanotherone = new SelectElement(anotherone);
            selectanotherone.SelectByText("Apps & Games");

            Thread.Sleep(20);
        }
    }
}
