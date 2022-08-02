using Controls.Alert;
using Controls.Button;
using Controls.Input;
using Core.Core.Browser;
using Core.Log;
using Core.Wait;
using OpenQA.Selenium;
using System;
using Core;
using Controls.DefaultControl;

namespace GeneratedWrappers.ISVTestSDK
{
    public class HostedFormHandler : Wrapper
    {
        public Input Token, Token1, Token2, Token3, Token4, Token5, Token6, Token7, Token8;
        public Button SendTokenBack1, SendTokenBack;

        public HostedFormHandler()
        {

            Token = new Input("css=[aria-label='* Cardholder (name)']", "* Cardholder (name)", null, null);
            Token2 = new Input("css=[aria-label='* Card Number']", "* Card Number", null, null);
            Token5 = new Input("css=[aria-label='* CVV/CSC']", "* CVV/CSV", null, null);
            Token6 = new Input("css=[aria-label='* Billing Zip']", "* Billing Zip", null, null);
            Token7 = new Input("css=[aria-label='* Billing Street Address']", "* Billing Street Address", null, null);
            Token8 = new Input("css=[aria-label='* Billing City']", "* Billing City", null, null);
            SendTokenBack1 = new Button("css=button:textEqual('Create Card Token')", "Create Card Token", null);

        }


        public void Add()
        {
            Token.Type("ABC");
            Token2.Type("5555 5555 5555 4444");
            //Token3.Click();
            new DefaultControl("css=:textEqual(\"* Expire Month\")", null, null, null).Click();
            new DefaultControl("css=.q-item__label:textEqual(\"December\")", null, null, null).Click();
            new DefaultControl("css=:textEqual(\"* Expire Year\")", null, null, null).Click();
            new DefaultControl("css=.q-item__label:textEqual(\"2042\")", null, null, null).Click();
            new DefaultControl("css=:textEqual(\"* Billing State\")", null, null, null).Click();
            new DefaultControl("css=.q-item__label:textEqual(\"New York\")", null, null, null).Click();
            Token5.Type("123");
            Token6.Type("10011");
            Token7.Type("156 10th Ave");
            Token8.Type("New York");
            Maximize();
            SendTokenBack1.Click();
        }

        protected void SaveWaitAction()
        {
            Wait.WaitForCondition(() =>
            {
                try
                {
                    Wait.WaitForPageToLoad();
                    return !SendTokenBack.IsVisible();
                }
                catch (UnhandledAlertException)
                {
                    throw;
                }
                catch (Exception e)
                {
                    Log.Information(e.ToString());
                    return false;
                }
                finally
                {
                    Alert.AlertToException();
                    Wait.WaitForPageToLoad();
                }
            }, Wait.LongTimeOut);
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
