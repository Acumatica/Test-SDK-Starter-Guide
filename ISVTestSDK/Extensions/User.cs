using System;
using System.Collections.Generic;
using System.Linq;
using Api;
using Core.Core.Browser;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public class User : SM201010_AccessUsers
    {
        public static readonly HashSet<string> DefaultUsers = new HashSet<string> { "admin", "Anonymous", "AcumaticaSupport" };

        public c_userlist_form Summary => base.UserList_form;

        public c_allowedroles_gridroles Roles => base.AllowedRoles_gridRoles;

        public c_userlistcurrent_tab Options => base.UserListCurrent_tab;

        public c_userfilters_gridfilterip Filters => base.UserFilters_gridFilterIP;

        public c_aduser_frmaduser ActiveDirectoryUser => base.ADUser_frmADUser;

        public c_userprefs_prefsform PersonalSettings => base.UserPrefs_PrefsForm;

        public c_userlistcurrent_tab Statistics => base.UserListCurrent_tab;

        public c_identities_grididentities ExternalIdentities => base.Identities_gridIdentities;

        public c_userprefs_formlt UserPreferences => base.UserPrefs_formLT;

        public c_userdevices_griddevices Devices => base.UserDevices_gridDevices;

        public c_locationtracking_gridlt LocationTracking => base.LocationTracking_gridLT;

        public User()
        {
            FileName = "Users";
            ToolBar.AddADUser.WaitAction = Wait.Wait.WaitForCallbackToComplete;
            ActiveDirectoryUser.Buttons.Ok.WaitAction = Wait.Wait.WaitForPageToLoad;
            Summary.Buttons.Ok.WaitAction = () =>
            {
                Wait.Wait.WaitForCondition(() => !Summary.Buttons.Ok.IsVisible(), Wait.Wait.LongTimeOut);
            };
        }

        public override void LoginAsUser()
        {
            try
            {
                base.LoginAsUser();
            }
            catch (Exception e)
            {
                Log.Log.Information(e.Message);
                Browser.WebDriver.SwitchTo().Window(Browser.WebDriver.WindowHandles.FirstOrDefault());
            }
        }
        public void Select()
        {
            OpenScreen();
            RefreshScreen();
            Summary.Username.Select();
        }

        public void ResetPassword(String password)
        {
            ResetPassword();
            Summary.NewPassword.Reset();
            Summary.NewPassword.Type(password);
            Summary.ConfirmPassword.Reset();
            Summary.ConfirmPassword.Type(password);
            // Summary.Buttons.Ok.WaitAction = Wait.Wait.WaitForPageToLoad;
            Summary.Ok();
        }

        public override void Delete()
        {
            const string alert = "participate in the Assignment and Approval Map";

            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Delete user: " + Summary.Username.Value))
            {
                Select();

                if (Browser.LAST_USER == Summary.Username.Value && ToolBar.Delete.IsEnabled().Equals(false))
                {
                    Log.Log.Information("You cannot delete current active user:" + Browser.LAST_USER);
                }
                else
                {
                    try
                    {
                        base.Delete();
                    }
                    catch (Exception e)
                    {
                        if (e.Message.Contains(alert))
                        {
                            Log.Log.Information(Summary.Username.Value + " " + alert + ". Delete user from maps first");
                            return;
                        }
                    }

                    RefreshScreen();

                    try
                    {
                        Summary.Username.Select();
                        Log.Log.Error("Failed to delete user");
                    }
                    catch
                    {
                        Log.Log.Information("User was deleted successfully");
                    }
                }
            }
        }

        public override void ConfigureImportScenario()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Configure import scenario: " + ImportScenarioName))
            {
                var importScenario = new ImportScenario();
                importScenario.OpenScreen();
                importScenario.Summary.Name.Select(ImportScenarioName);
                importScenario.Mapping.WhatToShow.Select(importScenario.Mapping.WhatToShow.Items["1"]);
                importScenario.Save();
                importScenario.Mapping.Adjust();
                bool updateUserContact;

                try
                {
                    updateUserContact =
                        new ExtendedBiObject<Employee>(ApiConnection.ApiConnection.Destination).ExportKeys().Any();
                }
                catch (Exception)
                {
                    updateUserContact = false;
                }

                importScenario.Mapping.ClickCell("Contact");
                importScenario.Mapping.Row.IsActive.Set(updateUserContact);
                importScenario.Save();
            }
        }
    }
}
