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


namespace GeneratedWrappers.VYAPAY
{
    public class HostedFormHandlerACH
    {
        public Input Token, Token1, Token2, Token3, Token4, Token5;
        public Button SendTokenBack;

        
        public HostedFormHandlerACH()
        {
            //Token = new Input("title", null, null, null);//Account Kind
            //Token1 = new Input("account_holder_name", null, null, null);//Account Type
            Token2 = new Input("css=[aria-label='* Account Owner (name)']", "* Account Owner (name)", null, null);
            Token3 = new Input("css=[aria-label='* Routing Number']", "* Routing Number", null, null);
            Token4 = new Input("css=[aria-label='* Account Number']", "* Account Number", null, null);
            Token5 = new Input("css=[aria-label='* Verify Account Number']", "* Verify Account Number", null, null);
            //Token2 = new Input("account_type_checking", null, null, null);//Account owner name
            //Token3 = new Input("is_company_personal", null, null, null);//Routing number
            //Token4 = new Input("routing", null, null, null);//Account number
            //Token5 = new Input("account_number", null, null, null);//Verify Account number
            SendTokenBack = new Button("css=button:textEqual('Create ACH Token')", "Create Card Token", null);
        }

        
        public void Add()
        {
            new DefaultControl("css=:textEqual(\"* Account Kind\")", null, null, null).Click();
            new DefaultControl("css=.q-item__label:textEqual(\"Business\")", null, null, null).Click();
            new DefaultControl("css=:textEqual(\"* Account Type\")", null, null, null).Click();
            new DefaultControl("css=.q-item__label:textEqual(\"Savings\")", null, null, null).Click();
            //new DefaultControl("css=:textEqual(\"* Account Owner (name)\")", null, null, null).

            //new DefaultControl("css=:textEqual(\"* Routing Number\")", null, null, null).Click();

            //new DefaultControl("css=.q-item__label:textEqual(\"113122655\")", null, null, null).Click();
            //new DefaultControl("css=:textEqual(\"* Account Number\")", null, null, null).Click();      

            //new DefaultControl("css=.q-item__label:textEqual(\"215744301\")", null, null, null).Click();
            //new DefaultControl("css=:textEqual(\"* Verify Account Number\")", null, null, null).Click();
            //new DefaultControl("css=.q-item__label:textEqual(\"215744301\")", null, null, null).Click();
            //Token.Type("Business");
            //Token1.Type("Savings");
            Maximize();
            Token2.Type("Ikonic");
            Token3.Type("113122655");
            Token4.Type("215744301");
            Token5.Type("215744301");
            //Thread.Sleep(9000);

            SendTokenBack.Click();
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
