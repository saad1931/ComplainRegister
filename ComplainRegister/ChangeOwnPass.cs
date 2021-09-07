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

namespace ComplainRegister
{
    public partial class ChangeOwnPass : Form
    {
        static string path = Application.StartupPath;
        public string conString = "Data Source=" + path + "\\ComplaintsDatabase.sdf";
        Point lastClick;
        string currentUser;
        public ChangeOwnPass()
        {
            InitializeComponent();
        }
        public ChangeOwnPass(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }
        /*private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Left += e.X - lastClick.X;
            this.Top += e.Y - lastClick.Y;
        }*/
       
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void oldPass_TextChanged_1(object sender, EventArgs e)
        {
            string pass = "", user = "";
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                string sql = "SELECT FORM USERS WHERE Username ='" + currentUser + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    user = dr["Username"].ToString();
                    pass = dr["Password"].ToString();
                }
                if (currentUser == user && oldPass.Text == pass)
                {
                    userPassMatched.ForeColor = Color.Green;
                    userPassMatchedIcon.Image = ComplainRegister.Properties.Resources.CHECK_GREEN_RESIZED;
                }
                else
                {
                    userPassMatched.ForeColor = Color.Red;
                    userPassMatchedIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
                }


            }
            catch { }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void confirmPass_TextChanged(object sender, EventArgs e)
        {
            if (newPass.Text == confirmPass.Text)
            {
                userPassMatched.ForeColor = Color.Green;
                userPassMatchedIcon.Image = ComplainRegister.Properties.Resources.CHECK_GREEN_RESIZED;
            }
            else
            {
                userPassMatched.ForeColor = Color.Red;
                userPassMatchedIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (confirmPass.ForeColor == Color.Green && userPassMatched.ForeColor == Color.Green)
                try
                {
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    string sql = "UPDATE USER SET PASSWORD ='" + confirmPass.Text + "' WHERE USERNAME ='" + currentUser + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    LogOutMessageBox log = new LogOutMessageBox();
                    log.makeOkButton("PASSWORD UPDATED SUCCESSFULLY!!");
                    oldPass.Clear();
                    newPass.Clear();
                    confirmPass.Clear();
                    userPassMatched.ForeColor = Color.Red;
                    userPassMatchedIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
                    passConfirmed.ForeColor = Color.Red;
                    passConfirmIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
                    log.Show();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

        }
    }
}
