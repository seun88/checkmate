using checkmate.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace checkmate.Hooks
{
    [Binding]
    public sealed class Hooks1: Base
    {
        

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("Chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        { 
            CloseBrowser();
        }
    }
}
