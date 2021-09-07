﻿using System;
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
    public partial class LogOutMessageBox : Form
    {
        public LogOutMessageBox()
        {
            InitializeComponent();
        }
        public void labelText(string s)
        {
            label1.Text = s;
        }
        public void SetCrossLocation(int x, int y)
        {
            button1.Location = new Point(x, y);
        }
        private void button1_click(object sender,EventArgs e)
        {
            this.Hide();
        }
        private void button5_click(object sender,EventArgs e)
        {
            
        }
        private void button4_click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            //ComplainRegister.Form1.ActiveForm.Hide();
            new FormLogin().Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void makeOkButton(string labelText)
        {
            Point okButton = new Point(245, 119);
            Point xButton = new Point(462, 2);
            button4.Location = okButton;
            button5.Hide();
            button4.Text = "Ok";
            button1.Location = xButton;
            Size sz = new Size(500, 179);
            this.Size = sz;
            label1.Text = labelText;
        }

    }
}
