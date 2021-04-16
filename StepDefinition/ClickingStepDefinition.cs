using checkmate.BaseClass;
using checkmate.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace checkmate.StepDefinition
{
    [Binding]
    public sealed class ClickingStepDefinition
    {
        private AmazonHomePage hp;


        [Given(@"i navigate to amazon")]
        public void GivenINavigateToAmazon()
        {
            hp = Base.GivenINavigateAmazonPage();
        }

        [Given(@"i click the button")]
        public void GivenIClickTheButton()
        {
            hp.AndClickButton();
            hp.confirm();
            hp.allbutton();
            hp.balls();
            hp.anotherone();

            
        }

    }
}
