using AutomationCore.Classes;
using AutomationCore.Core.Attributes;
using AutomationCore.Core.Classes.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationCore.PageObjects {
    [PageUrl("https://music.yandex.ru/home")]
    class YandexMusic : BasePage {
        public YandexMusic(Browser browser) : base(browser) {
        }
    }
}
