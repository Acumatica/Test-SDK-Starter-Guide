using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class Branch : CS102000_BranchMaint
    {
        public c_baccount_pxformview1 Summary => base.BAccount_PXFormView1;
        public c_currentbaccount_tab GeneralSettings => base.CurrentBAccount_tab;
        public c_defaddress_defaddress DefaultAddress => base.DefAddress_DefAddress;
        public c_defcontact_defcontact DefaultContact => base.DefContact_DefContact;
        public c_deflocation_frmdeflocation DefaultLocation => base.DefLocation_frmDefLocation;
        public c_deflocationcontact_deflocationcontact DeliveryContact => base.DefLocationContact_DefLocationContact;
        public c_deflocationaddress_deflocationaddress DeliveryAddress => base.DefLocationAddress_DefLocationAddress;
        public c_deflocation_frmdeflocation DeliverySettings => base.DefLocation_frmDefLocation;
        public c_deflocation_frmdeflocationgl Accounts => base.DefLocation_frmDefLocationGL;
        public c_employees_grdemployees Employees => base.Employees_grdEmployees;
        public c_currentbaccount_frmlogo Logo => base.CurrentBAccount_frmLogo;
        public c_changeiddialog_formchangeid SpecifyNewID => base.ChangeIDDialog_formChangeID;
        public c_ledgersview_grdledgers LedgerDetails => base.LedgersView_grdLedgers;
        public c_changeiddialog_formchangeid SpecifyNewIDForm => base.ChangeIDDialog_formChangeID;
        public c_currentbaccount_formcarrierfacility CarrierFacility => CurrentBAccount_formCarrierFacility;
        public c_taxes_grdtaxes Taxes => base.Taxes_grdTaxes;

        public Branch()
        {
            FileName = "Branches";

            Employees.ToolBar.NewContact.WaitAction = Wait.Wait.WaitForNewWindowToOpen;

            LedgerDetails.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            Employees.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
        }
    }
}
