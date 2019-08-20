using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AutomationCore.Classes;

namespace AutomationCore.Core.Managers {
    class BrowserManager{

        private static BrowserManager instance = null;

        public static BrowserManager Instanse {
            get {
                if(instance == null) {
                    instance = new BrowserManager();
                }
                return instance;
            }
        }

        private Mutex mutex = new Mutex();

        static private int browserCount = 1;

        private SemaphoreSlim semaphore = new SemaphoreSlim(browserCount);

        private List<Browser> browserList = new List<Browser>();


        private BrowserManager() {
            for (int i = 0; i < browserCount; i++) {
                browserList.Add(new Browser());
            }
        }

        public Browser GetFreeBrowser() {
            Browser driver;

            semaphore.Wait();

            mutex.WaitOne();
            driver = browserList.FirstOrDefault(i => i.IsUsed == false);
            driver.SetBusy();
            mutex.ReleaseMutex();

            return driver;
        }

        public void ReleaseBrowser(Browser driver) {
            driver.Release();
            semaphore.Release();
        }   
    }
}