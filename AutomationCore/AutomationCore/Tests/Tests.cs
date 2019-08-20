using AutomationCore.Classes;
using AutomationCore.Core.Classes.Pages;
using AutomationCore.Core.Managers;
using AutomationCore.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationCore.Tests {
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class Tests : TestBase{

        [NUnit.Framework.Test]
        public void Test() {
            Assert.That(() => {
                var page = PageFactory.OpenPage<YandexPage>(browser);
                page.SearchDiv.SearchField.InsertText("кошка");
                page.SearchButton.Click();
            }, Throws.Nothing);
        }

        [NUnit.Framework.Test]
        public void Test2() {
           Assert.That(() =>
            PageFactory.OpenPage<YandexMusic>(browser), Throws.Nothing);
        }

        [NUnit.Framework.Test]
        public void Test3() {
            var page = PageFactory.OpenPage<YandexPage>(browser);
            Assert.That(() =>
             PageFactory.
             OpenByAction<YandexPage>(browser, 
                                      new Action(() => page.MusicButton.Click())), 
                                      Throws.Nothing);
        }
    }
}
