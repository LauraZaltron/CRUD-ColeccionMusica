using System;
using ColeccionMusica.Services.Handlers;
using System.Windows.Forms;

namespace ColeccionMusica
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string dbPath = Application.StartupPath;
            string database = dbPath + "/database/dbColeccionMusica.db";
            SqliteHandler.ConnStr = "Data Source = " + database;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ColeccionMusica());
        }
    }
}
