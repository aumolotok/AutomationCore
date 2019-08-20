using AutomationCore.Classes;
using AutomationCore.Core.Managers;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationCore.Tests {
    public class TestBase {
        protected Browser browser = null;

        [OneTimeSetUp]
        public void SetUp() {

            browser = BrowserManager.Instanse.GetFreeBrowser();

        }

        [OneTimeTearDown]
        public void TearDown() {
            BrowserManager.Instanse.ReleaseBrowser(browser);
        }
    }
}
