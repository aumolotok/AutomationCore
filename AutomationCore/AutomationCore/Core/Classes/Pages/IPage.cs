using AutomationCore.Classes;

namespace AutomationCore.Core.Classes.Pages {
    public interface IPage {
        string Url { get; }
        Browser Browser { get; }
    }
}
