using AutomationCore.Classes;
using OpenQA.Selenium.Support.PageObjects;
using AutomationCore.Core.Classes.Elements;
using AutomationCore.Core.Attributes;

namespace AutomationCore.Core.Classes.Pages {
    [PageUrl("https://yandex.ru")]
    class YandexPage : BasePage {
        public YandexPage(Browser browser) : base(browser) {
        }

        [FindsBy(How = How.CssSelector, Using = "div.home-arrow__search-wrapper")]
        public DivElement SearchDiv => FindElement<DivElement>();
    }
}
