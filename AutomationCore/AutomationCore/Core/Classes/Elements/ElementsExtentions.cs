using Autotests.PageElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using AutomationCore.Core.Classes.Pages;

namespace AutomationCore.Core.Classes.Elements {
    static class ElementsExtentions {

        public static By GetBy(this FindsByAttribute attributr)
            {
            var how = attributr.How;
            var sourseString = attributr.Using;

            switch (how) {
                case How.ClassName: {
                        return By.ClassName(sourseString);
                }
                case How.CssSelector: {
                        return By.CssSelector(sourseString);
                }
                case How.Id: {
                        return By.Id(sourseString);
                }
                case How.LinkText: {
                        return By.LinkText(sourseString);
                }
                case How.Name : {
                        return By.Name(sourseString);
                }
                case How.PartialLinkText: {
                        return By.PartialLinkText(sourseString);
                }
                case How.TagName: {
                        return By.TagName(sourseString);
                }
                case How.XPath: {
                        return By.XPath(sourseString);
                }
                default: {
                        return By.XPath(sourseString);
                }
            }
        }
    }
}
