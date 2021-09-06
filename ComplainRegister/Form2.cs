using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace ComplainRegister
{
    public partial class FormLogin : Form
    {
        Point lastClick;
        string path = Application.StartupPath;
        string connectionString = "Server=51.89.37.225;Database=SampleDB;User=sa;Password=blue@1122;";

        public FormLogin()
        {
            InitializeComponent();
            this.ActiveControl = userTextBox;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.SteelBlue, 1, ButtonBorderStyle.Solid, Color.SteelBlue, 1, ButtonBorderStyle.Solid, Color.SteelBlue, 1, ButtonBorderStyle.Solid, Color.SteelBlue, 1, ButtonBorderStyle.Solid);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con =new SqlConnection (@"Data Source=51.89.37.225;Initial Catalog=SampleDB;User ID=sa;Password=blue@1122");
            string query = "select * from ADMINISTRATOR where UserName '" + userTextBox.Text.Trim() + "' and password = '" + passwordTextBox.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows[0][0].ToString() == "1")
            {
                Form1 objform1 = new Form1();
                this.Hide();
                objform1.Show();
            }
            else
            {
                MessageBox.Show("Please Check your username or Password");
            }
           
       
        }

        /*public void login()
        {
            string check = "";
            try
            {
                SqlConnection con = new SqlConnection("Server=51.89.37.225;Database=SampleDB;User=sa;Password=blue@1122;");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sql = "SELECT * FROM ADMINISTRATOR ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr["UserName"].ToString() == userTextBox.Text && dr["password"].ToString() == passwordTextBox.Text && dr["Designation"].ToString() == "ADMINISTRATOR")
                        {
                            check = "ADMINISTRATOR";
                        }
                      //  else if (dr["Username"].ToString() == userTextBox.Text && dr["Password"].ToString() == passwordTextBox.Text && dr["Designation"].ToString() == "Admin")
                        //{
                          //  check = "Admin";
                        //}
                    }
                    con.Close();
                }
                if (check == "ADMINISTRATOR")
                {
                    this.Hide();
                    Form1 f = new Form1();
                    //f.operatorLogin();
                    f.Show();

                }
               
                else if (check == "")
                {
                    LogOutMessageBox log = new LogOutMessageBox();
                    //log.makeOkButton("Incorrect username or Password. Please try again.");
                    log.Size = new Size(600, 179);
                    log.button1.Location = new Point(562, 2);
                    log.Show();
                }
            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }*/


    }


    
}
