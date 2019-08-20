using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AutomationCore.Classes;
using AutomationCore.Core.Classes.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationCore.Core.Classes.Pages {
    abstract public class BasePage: IPage
    {
        public string Url { get; }
        public Browser Browser { get; }

        public BasePage(Browser browser)
        {
           Browser = browser;
           Url = Browser.GetCurentUrl();
        }

        public T FindElement<T>([CallerMemberName] string caller = null) {
            var elementType = typeof(T);
            var constructorInfo = elementType.GetConstructor(new[] { typeof(IWebElement), typeof(IPage) });

            var property = GetType().GetProperty(caller);
            var attribute = (FindsByAttribute)property.GetCustomAttributes(typeof(FindsByAttribute), false).FirstOrDefault();

            var newElementRoot = Browser.FindElement(ElementsExtentions.GetBy(attribute));
            return (T)constructorInfo.Invoke(new object[] { newElementRoot, this });
        }
    }
}
