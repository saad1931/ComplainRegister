using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //error2
        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
