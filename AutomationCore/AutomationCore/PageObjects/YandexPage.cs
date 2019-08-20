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

        [FindsBy(How = How.XPath, Using = ".//a[text()='Музыка']")]
        public ButtonElement MusicButton => FindElement<ButtonElement>();

        [FindsBy(How = How.XPath, Using = ".//button[./span[text()='Найти']]")]
        public ButtonElement SearchButton => FindElement<ButtonElement>();
    }
}
