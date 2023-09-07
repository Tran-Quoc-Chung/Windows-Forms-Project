using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HospitalManager.Views
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Login_Form = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textbox_Password = new System.Windows.Forms.TextBox();
            this.textbox_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_Login_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel_Login_Form);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 757);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_Login_Form
            // 
            this.panel_Login_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_Login_Form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_Login_Form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Login_Form.Controls.Add(this.label4);
            this.panel_Login_Form.Controls.Add(this.label3);
            this.panel_Login_Form.Controls.Add(this.button1);
            this.panel_Login_Form.Controls.Add(this.panel4);
            this.panel_Login_Form.Controls.Add(this.panel3);
            this.panel_Login_Form.Controls.Add(this.textbox_Password);
            this.panel_Login_Form.Controls.Add(this.textbox_Username);
            this.panel_Login_Form.Controls.Add(this.label2);
            this.panel_Login_Form.Controls.Add(this.panel2);
            this.panel_Login_Form.Controls.Add(this.label1);
            this.panel_Login_Form.Controls.Add(this.label_title);
            this.panel_Login_Form.Location = new System.Drawing.Point(934, 12);
            this.panel_Login_Form.Name = "panel_Login_Form";
            this.panel_Login_Form.Size = new System.Drawing.Size(466, 733);
            this.panel_Login_Form.TabIndex = 0;
            this.panel_Login_Form.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(344, 631);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "CLICK HERE!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(184, 629);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Forgot password ?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aqua;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(55, 449);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 42);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aqua;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(54, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(53, 44);
            this.panel3.TabIndex = 6;
            // 
            // textbox_Password
            // 
            this.textbox_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_Password.BackColor = System.Drawing.Color.Aqua;
            this.textbox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_Password.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textbox_Password.Location = new System.Drawing.Point(105, 448);
            this.textbox_Password.Margin = new System.Windows.Forms.Padding(5);
            this.textbox_Password.MaxLength = 10;
            this.textbox_Password.Name = "textbox_Password";
            this.textbox_Password.Size = new System.Drawing.Size(304, 44);
            this.textbox_Password.TabIndex = 5;
            this.textbox_Password.UseSystemPasswordChar = true;
            // 
            // textbox_Username
            // 
            this.textbox_Username.BackColor = System.Drawing.Color.Aqua;
            this.textbox_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_Username.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textbox_Username.Location = new System.Drawing.Point(105, 354);
            this.textbox_Username.Margin = new System.Windows.Forms.Padding(5);
            this.textbox_Username.MaxLength = 40;
            this.textbox_Username.Multiline = true;
            this.textbox_Username.Name = "textbox_Username";
            this.textbox_Username.Size = new System.Drawing.Size(309, 46);
            this.textbox_Username.TabIndex = 4;
            this.textbox_Username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(101, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Get Started From Login Below";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(142, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 150);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(179, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("MS PGothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.SystemColors.Control;
            this.label_title.Location = new System.Drawing.Point(95, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(235, 60);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Hospital";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 757);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel_Login_Form.ResumeLayout(false);
            this.panel_Login_Form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Login_Form;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_Username;
        private System.Windows.Forms.TextBox textbox_Password;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Button button1;
        private Label label4;
        private Label label3;
    }
}