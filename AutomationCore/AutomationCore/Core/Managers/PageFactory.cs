using AutomationCore.Classes;
using AutomationCore.Core.Attributes;
using AutomationCore.Core.Classes.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationCore.Core.Managers {
    public static class PageFactory {

        public static T OpenPage<T>(Browser browser) where T : IPage{
            var pageType = typeof(T);

            var constructor = pageType.GetConstructor(new[] { typeof(Browser) });
            var urlAttribute = (PageUrlAttribute)pageType.GetCustomAttributes(typeof(PageUrlAttribute), false).FirstOrDefault();

            browser.GoToUrl(urlAttribute.Url);
            return (T)constructor.Invoke(new object[] { browser });      
        }

        public static T OpenByAction<T>(Browser browser, Action action) {
            action.Invoke();
            var pageType = typeof(T);

            var constructor = pageType.GetConstructor(new[] { typeof(Browser) });
            var urlAttribute = (PageUrlAttribute)pageType.GetCustomAttributes(typeof(PageUrlAttribute), false).FirstOrDefault();

            return (T)constructor.Invoke(new object[] { browser });
        }
    }
}
