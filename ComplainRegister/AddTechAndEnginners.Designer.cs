
namespace ComplainRegister
{
    partial class AddTechandEngineers
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
            this.technicianBox = new System.Windows.Forms.TextBox();
            this.engineerBox = new System.Windows.Forms.TextBox();
            this.techList = new System.Windows.Forms.ListBox();
            this.engList = new System.Windows.Forms.ListBox();
            this.techLabel = new System.Windows.Forms.Label();
            this.engLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Continue = new System.Windows.Forms.Button();
            this.techLabelIcon = new System.Windows.Forms.PictureBox();
            this.engLabelIcon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.remo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techLabelIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engLabelIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(231, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 45);
            this.label1.TabIndex = 46;
            this.label1.Text = "Getting Started";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(16, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(602, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please add your company\'s technician and engineer names to be added to the databa" +
    "se.";
            // 
            // technicianBox
            // 
            this.technicianBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.technicianBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.technicianBox.Location = new System.Drawing.Point(109, 216);
            this.technicianBox.Name = "technicianBox";
            this.technicianBox.Size = new System.Drawing.Size(133, 27);
            this.technicianBox.TabIndex = 37;
            this.technicianBox.TextChanged += new System.EventHandler(this.technicianBox_TextChanged);
            this.technicianBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.technicanBox_keyPress);
            // 
            // engineerBox
            // 
            this.engineerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.engineerBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.engineerBox.Location = new System.Drawing.Point(404, 215);
            this.engineerBox.Name = "engineerBox";
            this.engineerBox.Size = new System.Drawing.Size(133, 27);
            this.engineerBox.TabIndex = 38;
            // 
            // techList
            // 
            this.techList.FormattingEnabled = true;
            this.techList.Location = new System.Drawing.Point(109, 264);
            this.techList.Name = "techList";
            this.techList.Size = new System.Drawing.Size(133, 160);
            this.techList.TabIndex = 49;
            // 
            // engList
            // 
            this.engList.FormattingEnabled = true;
            this.engList.Location = new System.Drawing.Point(404, 264);
            this.engList.Name = "engList";
            this.engList.Size = new System.Drawing.Size(133, 160);
            this.engList.TabIndex = 27;
            // 
            // techLabel
            // 
            this.techLabel.AutoSize = true;
            this.techLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.techLabel.ForeColor = System.Drawing.Color.Red;
            this.techLabel.Location = new System.Drawing.Point(112, 500);
            this.techLabel.Name = "techLabel";
            this.techLabel.Size = new System.Drawing.Size(165, 20);
            this.techLabel.TabIndex = 42;
            this.techLabel.Text = "At least two technicians";
            this.techLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // engLabel
            // 
            this.engLabel.AutoSize = true;
            this.engLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.engLabel.ForeColor = System.Drawing.Color.Red;
            this.engLabel.Location = new System.Drawing.Point(398, 500);
            this.engLabel.Name = "engLabel";
            this.engLabel.Size = new System.Drawing.Size(156, 20);
            this.engLabel.TabIndex = 43;
            this.engLabel.Text = "At least two engineers";
            this.engLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(322, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "Engineers:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(19, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Technicians:";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ComplainRegister.Properties.Resources.Plus_mark1;
            this.button3.Location = new System.Drawing.Point(543, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 27);
            this.button3.TabIndex = 40;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ComplainRegister.Properties.Resources.Plus_mark1;
            this.button2.Location = new System.Drawing.Point(248, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 27);
            this.button2.TabIndex = 39;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ComplainRegister.Properties.Resources.RESIZED_MORE;
            this.pictureBox1.InitialImage = global::ComplainRegister.Properties.Resources.RESIZED_MORE;
            this.pictureBox1.Location = new System.Drawing.Point(142, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 91);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // Continue
            // 
            this.Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Continue.Image = global::ComplainRegister.Properties.Resources.arrow_31_16;
            this.Continue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Continue.Location = new System.Drawing.Point(253, 561);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(134, 38);
            this.Continue.TabIndex = 36;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click_1);
            // 
            // techLabelIcon
            // 
            this.techLabelIcon.Image = global::ComplainRegister.Properties.Resources.CROSS_RED_RESIZED1;
            this.techLabelIcon.InitialImage = global::ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            this.techLabelIcon.Location = new System.Drawing.Point(83, 496);
            this.techLabelIcon.Name = "techLabelIcon";
            this.techLabelIcon.Size = new System.Drawing.Size(27, 27);
            this.techLabelIcon.TabIndex = 52;
            this.techLabelIcon.TabStop = false;
            // 
            // engLabelIcon
            // 
            this.engLabelIcon.Image = global::ComplainRegister.Properties.Resources.CROSS_RED_RESIZED1;
            this.engLabelIcon.InitialImage = global::ComplainRegister.Properties.Resources.CROSS_RED_RESIZED;
            this.engLabelIcon.Location = new System.Drawing.Point(368, 496);
            this.engLabelIcon.Name = "engLabelIcon";
            this.engLabelIcon.Size = new System.Drawing.Size(27, 27);
            this.engLabelIcon.TabIndex = 51;
            this.engLabelIcon.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::ComplainRegister.Properties.Resources.undo_4_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(404, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 50;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // remo
            // 
            this.remo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.remo.Image = global::ComplainRegister.Properties.Resources.undo_4_16;
            this.remo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remo.Location = new System.Drawing.Point(109, 440);
            this.remo.Name = "remo";
            this.remo.Size = new System.Drawing.Size(133, 33);
            this.remo.TabIndex = 33;
            this.remo.Text = "Remove";
            this.remo.UseVisualStyleBackColor = true;
            this.remo.Click += new System.EventHandler(this.remo_Click_1);
            // 
            // AddTechandEngineers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 621);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.techLabelIcon);
            this.Controls.Add(this.engLabelIcon);
            this.Controls.Add(this.engLabel);
            this.Controls.Add(this.techLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.remo);
            this.Controls.Add(this.engList);
            this.Controls.Add(this.techList);
            this.Controls.Add(this.engineerBox);
            this.Controls.Add(this.technicianBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTechandEngineers";
            this.Text = "AddTechAndEnginners";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techLabelIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engLabelIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox technicianBox;
        private System.Windows.Forms.TextBox engineerBox;
        private System.Windows.Forms.ListBox techList;
        private System.Windows.Forms.ListBox engList;
        private System.Windows.Forms.Button remo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label techLabel;
        private System.Windows.Forms.Label engLabel;
        private System.Windows.Forms.PictureBox engLabelIcon;
        private System.Windows.Forms.PictureBox techLabelIcon;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}