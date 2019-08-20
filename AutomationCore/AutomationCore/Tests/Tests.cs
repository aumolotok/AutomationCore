using AutomationCore.Classes;
using AutomationCore.Core.Classes.Pages;
using AutomationCore.Core.Managers;
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
            var page = PageFactory.OpenPage<YandexPage>(browser);
            page.SearchDiv.SearchField.InsertText("кошка");
        }

        [NUnit.Framework.Test]
        public void Test2() {
            var page = PageFactory.OpenPage<YandexPage>(browser);
            page.SearchDiv.SearchField.InsertText("кошка");
        }
    }
}
