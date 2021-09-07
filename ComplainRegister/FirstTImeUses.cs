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
    public partial class FirstTImeUses : Form
    {
        bool adminExists, OperatorExists;
        Point lastClick;
        string path = Application.StartupPath;
        public FirstTImeUses()
        {
            InitializeComponent();
            for (int i = 0; i < Accounts.RowCount; i++)
            {
                Accounts.Rows[Accounts.RowCount - 1].Cells[2].Value = "";

            }
        }
        //error1
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }


        public void adminsAndOperatorsAdded()
        {
            int adminCount = 0, operatorCount = 0;
            int a = 0;
            try
            {
                if (Accounts.Rows[Accounts.RowCount - 1].Cells[2].Value.ToString() == "")
                {
                    a = 1;
                }
                for (int i = 0; i < Accounts.RowCount - a; i++)
                {

                    if (Accounts.Rows[i].Cells[2].Value.ToString() == "Administrator")
                    {
                        adminCount++;
                        if (adminCount >= 2)
                        {
                            adminExists = true;
                        }
                        else
                            adminExists = false;
                    }

                }
                for (int i = 0; i < Accounts.RowCount - a; i++)
                {

                    if (Accounts.Rows[i].Cells[2].Value.ToString() == "operator")
                    {
                        operatorCount++;
                        if (operatorCount >= 2)
                        {
                            OperatorExists = true;
                        }
                        else
                            OperatorExists = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < Accounts.RowCount - 1; i++)
            {
                if (Accounts.Rows[i].Cells[0].Value == null)
                {
                    Accounts.Rows[i].Cells[0].Value = "";
                }
            }
            userDuplication();
        }


        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < Accounts.RowCount - 1; i++)
            {
                Accounts.Rows[Accounts.RowCount - 1].Cells[2].Value = "";
                if (Accounts.Rows[i].Cells[0].Value == null)
                {
                    Accounts.Rows[i].Cells[0].Value = "";
                }
            }

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
            validation();
        }

        private void Accounts_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                for (int i = 0; i < Accounts.RowCount - 1; i++)
                {
                    if (Accounts.Rows[i].Cells[0].Value == null)
                    {
                        Accounts.Rows[i].Cells[0].Value = "";
                    }
                }
                for (int i = 0; i < Accounts.RowCount - 1; i++)
                {
                    if (Accounts.Rows[i].Cells[0].Value.ToString() == "")
                    {
                        emptyUserLabel.ForeColor = Color.Red;
                        emptyUserLabelIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
                    }
                    else
                    {
                        emptyUserLabel.ForeColor = Color.Green;
                        emptyUserLabelIcon.Image = ComplainRegister.Properties.Resources.CHECK_GREEN_RESIZED;
                    }
                }
            }
            catch { }
            userDuplication();
            validation();
        }

        private void Accounts_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                for (int i = 0; i < Accounts.RowCount - 1; i++)
                {
                    if (Accounts.Rows[i].Cells[0].Value == null)
                    {
                        Accounts.Rows[i].Cells[0].Value = "";
                    }
                }
                for (int i = 0; i < Accounts.RowCount - 1; i++)
                {
                    if (Accounts.Rows[i].Cells[0].Value.ToString() == "")
                    {
                        emptyUserLabel.ForeColor = Color.Red;
                        emptyUserLabelIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
                    }
                    else
                    {
                        emptyUserLabel.ForeColor = Color.Green;
                        emptyUserLabelIcon.Image = ComplainRegister.Properties.Resources.CHECK_GREEN_RESIZED;
                    }
                }
            }
            catch { }
            userDuplication();
            validation();
        }


        public void userDuplication()
        {
            bool userDuplicate = false;
            List<int> flag = new List<int>();
            string temp = "";

            for (int i = 0; i < Accounts.RowCount - 1; i++)
            {
                try
                {
                    temp = Accounts.Rows[i].Cells[0].Value.ToString();
                    for (int j = 0; j < Accounts.RowCount - 1; j++)
                    {
                        if (temp == Accounts.Rows[j].Cells[0].Value.ToString())
                        {
                            if (i != j)
                            {
                                userDuplicate = true;
                            }
                        }
                    }
                }
                catch
                {

                }


            }

            if (userDuplicate == true)
            {
                duplicateUser.ForeColor = Color.Red;
                duplicateUserIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            }
            else
            {
                duplicateUser.ForeColor = Color.Green;
                duplicateUserIcon.Image = ComplainRegister.Properties.Resources.CHECK_GREEN_RESIZED;
            }
        }

        private void Accounts_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            for (int i = 0; i < Accounts.RowCount - 1; i++)
            {
                if (Accounts.Rows[i].Cells[0].Value == null)
                {
                    Accounts.Rows[i].Cells[0].Value = "";
                }
            }
            for (int i = 0; i < Accounts.RowCount - 1; i++)
            {
                if (Accounts.Rows[i].Cells[0].Value.ToString() == "")
                {
                    emptyUserLabel.ForeColor = Color.Red;
                    emptyUserLabelIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
                }
                else
                {
                    emptyUserLabel.ForeColor = Color.Green;
                    emptyUserLabelIcon.Image = ComplainRegister.Properties.Resources.CHECK_GREEN_RESIZED;
                }
            }
        }

        private void UpdateButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Accounts.RowCount - 1; i++)
                {
                    if (Accounts.Rows[i].Cells[0].Value == null)
                    {
                        Accounts.Rows[i].Cells[0].Value = "";
                    }
                }
                for (int i = 0; i < Accounts.RowCount - 1; i++)
                {
                    if (Accounts.Rows[i].Cells[0].Value.ToString() == "")
                    {
                        emptyUserLabel.ForeColor = Color.Red;
                        emptyUserLabelIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
                    }
                    else
                    {
                        emptyUserLabel.ForeColor = Color.Green;
                        emptyUserLabelIcon.Image = ComplainRegister.Properties.Resources.CHECK_GREEN_RESIZED;
                    }
                }
                userDuplication();
                validation();


                if (duplicateUser.ForeColor == Color.Red || adminExistLabel.ForeColor == Color.Red || operatorExistLabel.ForeColor == Color.Red || duplicateUser.ForeColor == Color.Red || emptyUserLabel.ForeColor == Color.Red)
                {
                    LogOutMessageBox log = new LogOutMessageBox();
                    log.makeOkButton("One or more requirements not fulfilled.");
                    log.Size = new Size(log.Width + 10, log.Height);
                    log.SetCrossLocation(log.button1.Location.X + 12, log.button1.Location.Y);
                    log.Show();
                }
                else
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP - CT235QF; Initial Catalog = coomplain; Integrated Security = True");
                        con.Open();
                        for (int i = 0; i < Accounts.RowCount - 1; i++)
                        {
                            string sql = "INSERT INTO Users (username,password,designation) VALUES (@usr,@pss,@desig)";
                            SqlCommand cmd = new SqlCommand(sql, con);

                            cmd.Parameters.AddWithValue("@usr", Accounts.Rows[i].Cells[0].Value.ToString());
                            cmd.Parameters.AddWithValue("@pss", Accounts.Rows[i].Cells[1].Value.ToString());
                            cmd.Parameters.AddWithValue("@desig", Accounts.Rows[i].Cells[2].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                        this.Hide();
                        new AddTechandEngineers().Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch { }
        }

        private void adminExistLabel_Click(object sender, EventArgs e)
        {

        }

        public void validation()
        {
            adminsAndOperatorsAdded();
            if (adminExists == true)
            {
                adminExistLabel.ForeColor = Color.Green;
                adminExistIcon.Image = ComplainRegister.Properties.Resources.CHECK_GREEN_RESIZED;
            }
            else
            {
                adminExistLabel.ForeColor = Color.Red;
                adminExistIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            }

            if (OperatorExists == true)
            {
                operatorExistLabel.ForeColor = Color.Green;
                operatorExistIcon.Image = ComplainRegister.Properties.Resources.CHECK_GREEN_RESIZED;
            }
            else
            {
                operatorExistLabel.ForeColor = Color.Red;
                operatorExistIcon.Image = ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            }
        }

    }
}
