using System;

namespace AutomationCore.Core.Attributes {
    class PageUrlAttribute : Attribute {
        public string Url { get; }

        public PageUrlAttribute(string url) {
            Url = url;
        }
    }
}
