using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ComplainRegister
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string path = Application.StartupPath;
            bool error = false;
            int rows = 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool databaseExists = new ConnectionClass().dbExists();
            if (!databaseExists)
            {

                if (rows == 0)
                {
                    Application.Run(new FirstTImeUses());
                }
                else
                {
                    Application.Run(new FormLogin());
                }
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-CT235QF;Initial Catalog=coomplain;Integrated Security=True");
                    con.Open();
                    string sql = "SELECT * FROM Users";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<string> L = new List<string>();
                    while (dr.Read())
                    {
                        L.Add(dr["Username"].ToString());
                    }
                    con.Close();
                    rows = L.Count;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    error = true;
                }
                if (error == false)
                {
                    if (rows == 0)
                    {
                        Application.Run(new FirstTImeUses());
                    }
                    else
                    {
                        Application.Run(new FormLogin());
                    }
                }
                else
                {
                    LogOutMessageBox log = new LogOutMessageBox();
                    log.makeOkButton("Error connecting to database");
                }
            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AddTechandEngineers());
        }
    }
}
