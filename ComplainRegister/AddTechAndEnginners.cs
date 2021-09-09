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
    public partial class AddTechandEngineers : Form
    {

        static string path = Application.StartupPath;
        string conString = "Data Source=DESKTOP-CT235QF;Initial Catalog=coomplain;Integrated Security=True";
        Point lastClick;
        public AddTechandEngineers()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (technicianBox.Text != "")
            {
                techList.Items.Add(technicianBox.Text);
                technicianBox.Clear();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (engineerBox.Text != "")
            {
                engList.Items.Add(engineerBox.Text);
                engineerBox.Clear();
            }
        }

        private void remo_Click_1(object sender, EventArgs e)
        {
            
            techList.Items.Remove(techList.SelectedItem);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            engList.Items.Remove(engList.SelectedItem);
        }

        private void Continue_Click_1(object sender, EventArgs e)
        {
            continueToLogin();
        }


        private void technicanBox_keyPress(object sender, KeyPressEventArgs e)
         {
             if (techList.Items.Count >= 2)
             {
                
                 techLabelIcon.Image = ComplainRegister.Properties.Resources.CHECK_GREEN_RESIZED;
                 techLabel.ForeColor = Color.Green;
             }
             else
             {
                 techLabelIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
                 techLabel.ForeColor = Color.Red;
             }
             if (e.KeyChar == (char)Keys.Enter)
             {
                 techList.Items.Add(technicianBox.Text);
                 technicianBox.Clear();
             }
         }
         private void engineerBox_keyPress(object sender, KeyPressEventArgs e)
         {
             if (engList.Items.Count >= 2)
             {
                 engLabelIcon.Image = ComplainRegister.Properties.Resources.CHECK_GREEN_RESIZED;
                 engLabel.ForeColor = Color.Green;
             }
             else
             {
                 engLabelIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
                 engLabel.ForeColor = Color.Red;
             }
             if (e.KeyChar == (char)Keys.Enter)
             {
                 engList.Items.Add(technicianBox.Text);
                 engineerBox.Clear(); 
             }

         }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (techList.Items.Count >= 2)
            {
                techLabelIcon.Image = ComplainRegister.Properties.Resources.CHECK_GREEN_RESIZED;
                techLabel.ForeColor = Color.Green;
            }
            else
            {
                techLabelIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
                techLabel.ForeColor = Color.Red;
            }

            if (engList.Items.Count >= 2)
            {
                engLabelIcon.Image = ComplainRegister.Properties.Resources.CHECK_GREEN_RESIZED;
                engLabel.ForeColor = Color.Green;
            }
            else
            {
                engLabelIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
                engLabel.ForeColor = Color.Red;
            }
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }


        public void continueToLogin()
        {
            if (techLabel.ForeColor == Color.Red || engLabel.ForeColor == Color.Red)
            {
                LogOutMessageBox log = new LogOutMessageBox();
                log.makeOkButton("One or more requirements not fulfilled.");
                log.Size = new Size(log.Width + 10, log.Height);
                log.SetCrossLocation(log.button1.Location.X + 12, log.button1.Location.Y);
                log.Show();
            }
            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                for (int i = 0; i < techList.Items.Count; i++)
                {
                    string sql = "INSERT INTO Technicians(Name) VALUES ('" + techList.Items[i].ToString() + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
                for (int i = 0; i < engList.Items.Count; i++)
                {
                    string sql = "INSERT INTO Engineers(Name) VALUES ('" + engList.Items[i].ToString() + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
                this.Hide();
                new FormLogin().Show();
            }
        }

       

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void technicianBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
