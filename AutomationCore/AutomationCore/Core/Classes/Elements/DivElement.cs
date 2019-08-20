using AutomationCore.Core.Classes.Pages;
using AutomationCore.PageElements;
using Autotests.PageElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationCore.Core.Classes.Elements {
    class DivElement : BaseElement {
        public DivElement(IWebElement root, IPage page) : base(root, page) {
        }

        [FindsBy(How = How.CssSelector, Using = "input.input__control ")]
        public TextField SearchField => FindElement<TextField>();
    }
}
