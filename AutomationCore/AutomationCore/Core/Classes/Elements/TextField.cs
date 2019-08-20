using AutomationCore.Core.Classes.Pages;
using Autotests.PageElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationCore.PageElements
{
    class TextField : BaseElement 
    {
        public TextField(IWebElement root, IPage page) : base(root, page) {
        }

        public void InsertText(string text)
        {
            RootElement.Click();
            RootElement.SendKeys(text);
        }
    }
}
