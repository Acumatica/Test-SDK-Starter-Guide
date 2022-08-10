using Controls.Alert;
using Controls.Button;
using Controls.DefaultControl;
using Controls.Input;
using Core.Core.Browser;
using Core.Log;
using Core.Wait;
using OpenQA.Selenium;
using System;
using System.Threading;


namespace GeneratedWrappers.ISVTestSDK
{
    public class HostedForm1
    {
        public Input Token, Token1, Token2, Token3, Token4, Token5;
        public Button SendTokenBack;


        public HostedForm1()
        {
            //create a "Wrapper" manually for a popup or page that is inaccessable to ClassGenerator.exe
            //eg. an external hosted html popup form for credit card payment
            Token2 = new Input("css=[aria-label='* Account Owner (name)']", "* Account Owner (name)", null, null);
            Token3 = new Input("css=[aria-label='* Routing Number']", "* Routing Number", null, null);
            Token4 = new Input("css=[aria-label='* Account Number']", "* Account Number", null, null);
            Token5 = new Input("css=[aria-label='* Verify Account Number']", "* Verify Account Number", null, null);
            SendTokenBack = new Button("css=button:textEqual('Create ACH Token')", "Create Card Token", null);
        }


        public void Add()
        {
            new DefaultControl("css=:textEqual(\"* Account Type\")", null, null, null).Click();
            new DefaultControl("css=.q-item__label:textEqual(\"Business\")", null, null, null).Click();
            new DefaultControl("css=:textEqual(\"* Account Type\")", null, null, null).Click();
            new DefaultControl("css=.q-item__label:textEqual(\"Savings\")", null, null, null).Click();

            Maximize();
            Token2.Type("User1");
            Token3.Type("12354375");
            Token4.Type("23454353");
            Token5.Type("23454353");

            SendTokenBack.Click();
        }

        public void Maximize()
        {
            const string scriptMaximizePanel = "var elem = window.document.activePanel && window.document.activePanel.element.querySelector('.control-Maximize'); elem && elem.click();";
            Browser.JavaScriptExecutor.ExecuteScript(scriptMaximizePanel);
            Wait.WaitForCallbackToComplete();
            Log.Screenshot();
        }

        public void Close()
        {
            const string scriptMaximizePanel = "var elem = window.document.activePanel && window.document.activePanel.element.querySelector('.control-Close'); elem && elem.click();";
            Browser.JavaScriptExecutor.ExecuteScript(scriptMaximizePanel);
            Wait.WaitForCallbackToComplete();
            Log.Screenshot();
        }

    }
}
