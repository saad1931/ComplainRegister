
namespace ComplainRegister
{
    partial class ChangeOwnPass
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
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.userPassMatched = new System.Windows.Forms.Label();
            this.passConfirmed = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.passConfirmIcon = new System.Windows.Forms.PictureBox();
            this.userPassMatchedIcon = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passConfirmIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPassMatchedIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label10.Location = new System.Drawing.Point(57, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "Old Password:";
            // 
            // label13
            // 
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label13.Location = new System.Drawing.Point(54, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 25);
            this.label13.TabIndex = 39;
            this.label13.Text = "New Password:";
            // 
            // label12
            // 
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label12.Location = new System.Drawing.Point(30, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 25);
            this.label12.TabIndex = 40;
            this.label12.Text = "Confirm Password:";
            // 
            // oldPass
            // 
            this.oldPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldPass.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.oldPass.Location = new System.Drawing.Point(236, 59);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(165, 31);
            this.oldPass.TabIndex = 41;
            this.oldPass.TextChanged += new System.EventHandler(this.oldPass_TextChanged_1);
            // 
            // newPass
            // 
            this.newPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPass.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.newPass.Location = new System.Drawing.Point(236, 108);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(165, 31);
            this.newPass.TabIndex = 42;
            // 
            // confirmPass
            // 
            this.confirmPass.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.confirmPass.Location = new System.Drawing.Point(236, 159);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(165, 31);
            this.confirmPass.TabIndex = 43;
            this.confirmPass.TextChanged += new System.EventHandler(this.confirmPass_TextChanged);
            // 
            // userPassMatched
            // 
            this.userPassMatched.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.userPassMatched.ForeColor = System.Drawing.Color.Red;
            this.userPassMatched.Location = new System.Drawing.Point(149, 269);
            this.userPassMatched.Name = "userPassMatched";
            this.userPassMatched.Size = new System.Drawing.Size(233, 20);
            this.userPassMatched.TabIndex = 44;
            this.userPassMatched.Text = "Username and password matched";
            // 
            // passConfirmed
            // 
            this.passConfirmed.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.passConfirmed.ForeColor = System.Drawing.Color.Red;
            this.passConfirmed.Location = new System.Drawing.Point(155, 321);
            this.passConfirmed.Name = "passConfirmed";
            this.passConfirmed.Size = new System.Drawing.Size(221, 20);
            this.passConfirmed.TabIndex = 45;
            this.passConfirmed.Text = "Password confirmation matched";
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button12.Image = global::ComplainRegister.Properties.Resources.upload_3_16;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(59, 389);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(170, 33);
            this.button12.TabIndex = 49;
            this.button12.Text = "Update Password";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::ComplainRegister.Properties.Resources.x_mark_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(253, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 33);
            this.button1.TabIndex = 48;
            this.button1.Text = "Cancel Update";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // passConfirmIcon
            // 
            this.passConfirmIcon.Image = global::ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            this.passConfirmIcon.InitialImage = global::ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            this.passConfirmIcon.Location = new System.Drawing.Point(119, 316);
            this.passConfirmIcon.Name = "passConfirmIcon";
            this.passConfirmIcon.Size = new System.Drawing.Size(27, 27);
            this.passConfirmIcon.TabIndex = 47;
            this.passConfirmIcon.TabStop = false;
            // 
            // userPassMatchedIcon
            // 
            this.userPassMatchedIcon.Image = global::ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            this.userPassMatchedIcon.InitialImage = global::ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            this.userPassMatchedIcon.Location = new System.Drawing.Point(118, 265);
            this.userPassMatchedIcon.Name = "userPassMatchedIcon";
            this.userPassMatchedIcon.Size = new System.Drawing.Size(27, 27);
            this.userPassMatchedIcon.TabIndex = 46;
            this.userPassMatchedIcon.TabStop = false;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Webdings", 10F);
            this.button4.Location = new System.Drawing.Point(422, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 28);
            this.button4.TabIndex = 50;
            this.button4.Text = "r";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // ChangeOwnPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(460, 462);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passConfirmIcon);
            this.Controls.Add(this.userPassMatchedIcon);
            this.Controls.Add(this.passConfirmed);
            this.Controls.Add(this.userPassMatched);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.oldPass);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeOwnPass";
            this.Text = "ChangeOwnPass";
            ((System.ComponentModel.ISupportInitialize)(this.passConfirmIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPassMatchedIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.Label userPassMatched;
        private System.Windows.Forms.Label passConfirmed;
        private System.Windows.Forms.PictureBox userPassMatchedIcon;
        private System.Windows.Forms.PictureBox passConfirmIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button4;
    }
}