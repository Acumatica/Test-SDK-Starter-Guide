using Api;
using GeneratedWrappers.Acumatica;
using System;

namespace Core
{
    public partial class FileUploadPreferences : SM202550_UploadAllowedFileTypesMaint
    {
        public c_prefs_form Summary => base.Prefs_form;

        public c_prefsdetail_grid Details => base.PrefsDetail_grid;

        public void Delete()
        {
            int random = new Random().Next(0, Details.Rows.Count - 1);

            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Delete file extension:" + Details.Rows[random].FileExt.Value))
            {
                OpenScreen();
                Summary.MaxUploadSize.Type();
                Details.SetPage(0);
                int pageCount = Details.PageCount();
                for (int i = 1; i <= pageCount;)
                {
                    try
                    {
                        Details.ClickCell(Details.Rows[random].FileExt.Value);
                        break;
                    }
                    catch
                    {
                        Details.SetPage(i++);
                    }
                }

                Details.Delete();
                Save();
                Details.SetPage(0);

                for (int i = 1; i <= pageCount;)
                {
                    try
                    {
                        Details.ClickCell(Details.Rows[random].FileExt.Value);
                        Log.Log.Error("Failed to delete file extension: " + Details.Rows[random].FileExt.Value);
                        break;
                    }
                    catch
                    {
                        Details.SetPage(i++);
                    }
                }

                Log.Log.Information("File extension was removed: " + Details.Rows[random].FileExt.Value);
            }
        }

        private void Process()
        {
            OpenScreen();
            int random = new Random().Next(0, Details.Rows.Count - 1);
            Summary.MaxUploadSize.Type();
            Details.Refresh();
            Details.SetPage(0);
            try
            {
                Details.ClickCell(Details.Rows[random].FileExt.Value);
            }
            catch
            {
                Details.Columns.FileExt.Equals(Details.Rows[random].FileExt.Value);
            }

            if (!Details.HasRows()) Details.New();

            Details.Rows[random].FileExt.Type();
            Details.Rows[random].IconUrl.Type();
            Details.Rows[random].Forbidden.Set();
            Details.Rows[random].IsImage.Set();
            Save();
        }
    }
}
