using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationCore.Classes
{
    public class Browser {
        public bool IsUsed { get; private set; }

        public void Release() {
            IsUsed = false;
            driver.Quit();
            driver = null;
        }

        public void SetBusy() {
            IsUsed = true;
        }

        private IWebDriver driver = null;

        public IWebDriver Driver {
            get {
                if(driver == null) {
                    driver = new ChromeDriver();
                }
                return driver;
            }
        }

        public IWebElement FindElement(By locator)
        {
            return Driver.FindElement(locator);
            //return Waitings.WaitClickability(Driver, locator);
        }

        public List<IWebElement> FindElements(By locator){
            return Driver.FindElements(locator).ToList();
        }
   
        public Browser(){
            
        }

        public void CloseAll(){
            Driver.Quit();
        }

        public void CloseCurrentTab(){
            Driver.Close();
        }

        public string GetCurentUrl(){
            return Driver.Url;
        }

        public void GoToUrl(string url) {
            Driver.Navigate().GoToUrl(url);
        }
    }
}