using AutomationCore.Classes;
using OpenQA.Selenium.Support.PageObjects;
using AutomationCore.Core.Classes.Elements;

namespace AutomationCore.Core.Classes.Pages {
    class YandexPage : BasePage {
        public YandexPage(Browser browser) : base(browser) {
            browser.GoToUrl("https://yandex.ru");
        }

        [FindsBy(How = How.CssSelector, Using = "div.home-arrow__search-wrapper")]
        public DivElement SearchDiv => FindElement<DivElement>();
    }
}
