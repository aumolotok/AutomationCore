using AutomationCore.Core.Classes.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationCore.Tests {
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class Tests3 : TestBase {


        [NUnit.Framework.Test]
        public void Test() {
            var page = new YandexPage(browser);
            page.SearchDiv.SearchField.InsertText("кошка");
        }

        [NUnit.Framework.Test]
        public void Test2() {
            var page = new YandexPage(browser);
            page.SearchDiv.SearchField.InsertText("кошка");
        }
    }
}
