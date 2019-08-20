using OpenQA.Selenium;
using AutomationCore.PageElements;
using AutomationCore.Classes;
using AutomationCore.Core.Classes.Pages;
using AutomationCore.Core.Classes.Elements;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Autotests.PageElements
{
    class BaseElement: ICustomElement
    {
        public IWebElement RootElement { get; }
        public IPage Page { get; }


        public BaseElement(IWebElement root, IPage page) {
            RootElement = root;
            Page = page;
        }

        public T FindElement<T>([CallerMemberName] string caller = null) {
            var elementType = typeof(T);
            var constructorInfo = elementType.GetConstructor(new[] { typeof(IWebElement), typeof(IPage) });

            var property = GetType().GetProperty(caller);
            var attribute = (FindsByAttribute)property.GetCustomAttributes(typeof(FindsByAttribute), false).FirstOrDefault();

            var newElementRoot = RootElement.FindElement(attribute.GetBy());
            return (T)constructorInfo.Invoke(new object[] { newElementRoot, Page });
        }
    }
}
