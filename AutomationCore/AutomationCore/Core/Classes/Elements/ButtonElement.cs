using AutomationCore.Core.Classes.Pages;
using Autotests.PageElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationCore.Core.Classes.Elements {
    class ButtonElement : BaseElement {
        public ButtonElement(IWebElement root, IPage page) : base(root, page) {
        }

        public void Click() {
            RootElement.Click();
        }
    }
}
