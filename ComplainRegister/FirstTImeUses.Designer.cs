
namespace ComplainRegister
{
    partial class FirstTImeUses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminExistLabel = new System.Windows.Forms.Label();
            this.operatorExistLabel = new System.Windows.Forms.Label();
            this.duplicateUser = new System.Windows.Forms.Label();
            this.Accounts = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.emptyUserLabel = new System.Windows.Forms.Label();
            this.duplicateUserIcon = new System.Windows.Forms.PictureBox();
            this.operatorExistIcon = new System.Windows.Forms.PictureBox();
            this.adminExistIcon = new System.Windows.Forms.PictureBox();
            this.engLabelIcon = new System.Windows.Forms.PictureBox();
            this.emptyUserLabelIcon = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CncelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplicateUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorExistIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminExistIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engLabelIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyUserLabelIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(156, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(2, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "We are preparing for first use. Please create user accounts for admins and operat" +
    "ors.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // adminExistLabel
            // 
            this.adminExistLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.adminExistLabel.ForeColor = System.Drawing.Color.Red;
            this.adminExistLabel.Location = new System.Drawing.Point(113, 394);
            this.adminExistLabel.Name = "adminExistLabel";
            this.adminExistLabel.Size = new System.Drawing.Size(196, 20);
            this.adminExistLabel.TabIndex = 38;
            this.adminExistLabel.Text = "At least two admin accounts";
            this.adminExistLabel.Click += new System.EventHandler(this.adminExistLabel_Click);
            // 
            // operatorExistLabel
            // 
            this.operatorExistLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.operatorExistLabel.ForeColor = System.Drawing.Color.Red;
            this.operatorExistLabel.Location = new System.Drawing.Point(113, 438);
            this.operatorExistLabel.Name = "operatorExistLabel";
            this.operatorExistLabel.Size = new System.Drawing.Size(212, 20);
            this.operatorExistLabel.TabIndex = 39;
            this.operatorExistLabel.Text = "At least two operator accounts";
            // 
            // duplicateUser
            // 
            this.duplicateUser.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.duplicateUser.ForeColor = System.Drawing.Color.Green;
            this.duplicateUser.Location = new System.Drawing.Point(113, 475);
            this.duplicateUser.Name = "duplicateUser";
            this.duplicateUser.Size = new System.Drawing.Size(169, 20);
            this.duplicateUser.TabIndex = 43;
            this.duplicateUser.Text = "No duplicate usernames";
            // 
            // Accounts
            // 
            this.Accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Accounts.BackgroundColor = System.Drawing.Color.White;
            this.Accounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Accounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Accounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password,
            this.Designation});
            this.Accounts.Location = new System.Drawing.Point(-1, 221);
            this.Accounts.Name = "Accounts";
            this.Accounts.RowHeadersVisible = false;
            this.Accounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Accounts.Size = new System.Drawing.Size(394, 163);
            this.Accounts.TabIndex = 6;
            this.Accounts.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Accounts_CellBeginEdit);
            this.Accounts.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.Accounts.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Accounts_MouseMove);
            this.Accounts.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.Accounts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Accounts_KeyPress);
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Designation
            // 
            this.Designation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Designation.HeaderText = "Designation";
            this.Designation.Items.AddRange(new object[] {
            "Administrator",
            "Operator"});
            this.Designation.Name = "Designation";
            this.Designation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // emptyUserLabel
            // 
            this.emptyUserLabel.AutoSize = true;
            this.emptyUserLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.emptyUserLabel.ForeColor = System.Drawing.Color.Red;
            this.emptyUserLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emptyUserLabel.Location = new System.Drawing.Point(113, 508);
            this.emptyUserLabel.Name = "emptyUserLabel";
            this.emptyUserLabel.Size = new System.Drawing.Size(149, 20);
            this.emptyUserLabel.TabIndex = 50;
            this.emptyUserLabel.Text = "No empty usernames";
            this.emptyUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // duplicateUserIcon
            // 
            this.duplicateUserIcon.Image = global::ComplainRegister.Properties.Resources.CHECK_GREEN_RESIZED;
            this.duplicateUserIcon.Location = new System.Drawing.Point(80, 468);
            this.duplicateUserIcon.Name = "duplicateUserIcon";
            this.duplicateUserIcon.Size = new System.Drawing.Size(27, 27);
            this.duplicateUserIcon.TabIndex = 53;
            this.duplicateUserIcon.TabStop = false;
            // 
            // operatorExistIcon
            // 
            this.operatorExistIcon.Image = global::ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            this.operatorExistIcon.InitialImage = global::ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            this.operatorExistIcon.Location = new System.Drawing.Point(80, 431);
            this.operatorExistIcon.Name = "operatorExistIcon";
            this.operatorExistIcon.Size = new System.Drawing.Size(27, 27);
            this.operatorExistIcon.TabIndex = 52;
            this.operatorExistIcon.TabStop = false;
            // 
            // adminExistIcon
            // 
            this.adminExistIcon.Image = global::ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            this.adminExistIcon.InitialImage = global::ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            this.adminExistIcon.Location = new System.Drawing.Point(80, 394);
            this.adminExistIcon.Name = "adminExistIcon";
            this.adminExistIcon.Size = new System.Drawing.Size(27, 27);
            this.adminExistIcon.TabIndex = 51;
            this.adminExistIcon.TabStop = false;
            // 
            // engLabelIcon
            // 
            this.engLabelIcon.Image = global::ComplainRegister.Properties.Resources.RESIZED_MORE;
            this.engLabelIcon.Location = new System.Drawing.Point(74, 38);
            this.engLabelIcon.Name = "engLabelIcon";
            this.engLabelIcon.Size = new System.Drawing.Size(83, 91);
            this.engLabelIcon.TabIndex = 1;
            this.engLabelIcon.TabStop = false;
            // 
            // emptyUserLabelIcon
            // 
            this.emptyUserLabelIcon.Image = global::ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            this.emptyUserLabelIcon.Location = new System.Drawing.Point(80, 501);
            this.emptyUserLabelIcon.Name = "emptyUserLabelIcon";
            this.emptyUserLabelIcon.Size = new System.Drawing.Size(27, 27);
            this.emptyUserLabelIcon.TabIndex = 54;
            this.emptyUserLabelIcon.TabStop = false;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Webdings", 10F);
            this.button4.Location = new System.Drawing.Point(360, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "r";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Webdings", 10F);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(319, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 29);
            this.button5.TabIndex = 55;
            this.button5.Text = "0";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UpdateButton.Location = new System.Drawing.Point(101, 577);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 56;
            this.UpdateButton.Text = "Continue";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click_1);
            // 
            // CncelButton
            // 
            this.CncelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CncelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CncelButton.Location = new System.Drawing.Point(207, 577);
            this.CncelButton.Name = "CncelButton";
            this.CncelButton.Size = new System.Drawing.Size(75, 23);
            this.CncelButton.TabIndex = 57;
            this.CncelButton.Text = "Exit";
            this.CncelButton.UseVisualStyleBackColor = true;
            this.CncelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // FirstTImeUses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 638);
            this.Controls.Add(this.CncelButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.emptyUserLabelIcon);
            this.Controls.Add(this.duplicateUserIcon);
            this.Controls.Add(this.operatorExistIcon);
            this.Controls.Add(this.adminExistIcon);
            this.Controls.Add(this.emptyUserLabel);
            this.Controls.Add(this.Accounts);
            this.Controls.Add(this.duplicateUser);
            this.Controls.Add(this.operatorExistLabel);
            this.Controls.Add(this.adminExistLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.engLabelIcon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstTImeUses";
            this.Text = "FirstTImeUses";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplicateUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorExistIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminExistIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engLabelIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyUserLabelIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox engLabelIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label adminExistLabel;
        private System.Windows.Forms.Label operatorExistLabel;
        private System.Windows.Forms.Label duplicateUser;
        private System.Windows.Forms.DataGridView Accounts;
        private System.Windows.Forms.Label emptyUserLabel;
        private System.Windows.Forms.PictureBox adminExistIcon;
        private System.Windows.Forms.PictureBox operatorExistIcon;
        private System.Windows.Forms.PictureBox duplicateUserIcon;
        private System.Windows.Forms.PictureBox emptyUserLabelIcon;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CncelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewComboBoxColumn Designation;
    }
}