using System.Drawing;

namespace VirtualMessManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_login = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.signUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.errorUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tb_login);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.loginPassword);
            this.panel1.Controls.Add(this.signUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(35, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 433);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(262, 360);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(63, 20);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Sign Up";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(96, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Don\'t have an account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(129, 380);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forget Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(78, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "E&xit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_login
            // 
            this.tb_login.BackColor = System.Drawing.Color.Blue;
            this.tb_login.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tb_login.FlatAppearance.BorderSize = 0;
            this.tb_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.tb_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tb_login.Location = new System.Drawing.Point(78, 271);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(266, 37);
            this.tb_login.TabIndex = 5;
            this.tb_login.Text = "&LOGIN";
            this.tb_login.UseVisualStyleBackColor = false;
            this.tb_login.Click += new System.EventHandler(this.tb_login_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(88, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 38);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 38);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // loginPassword
            // 
            this.loginPassword.BackColor = System.Drawing.Color.LightSteelBlue;
            this.loginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPassword.ForeColor = System.Drawing.Color.MistyRose;
            this.loginPassword.Location = new System.Drawing.Point(129, 212);
            this.loginPassword.Multiline = true;
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(199, 38);
            this.loginPassword.TabIndex = 2;
            this.loginPassword.Text = "PASSWORD";
            // 
            // signUsername
            // 
            this.signUsername.BackColor = System.Drawing.Color.LightSteelBlue;
            this.signUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signUsername.ForeColor = System.Drawing.Color.MistyRose;
            this.signUsername.Location = new System.Drawing.Point(129, 154);
            this.signUsername.Multiline = true;
            this.signUsername.Name = "signUsername";
            this.signUsername.Size = new System.Drawing.Size(199, 38);
            this.signUsername.TabIndex = 2;
            this.signUsername.Text = "USERNAME";
            this.signUsername.TextChanged += new System.EventHandler(this.signUsername_TextChanged);
            this.signUsername.Validating += new System.ComponentModel.CancelEventHandler(this.signUsername_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(114, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Login";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(435, 433);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.SlateGray;
            this.rectangleShape2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangleShape2.Location = new System.Drawing.Point(87, 202);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(240, 2);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangleShape1.Location = new System.Drawing.Point(78, 149);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(266, 105);
            // 
            // errorUsername
            // 
            this.errorUsername.ContainerControl = this;
            this.errorUsername.Icon = ((System.Drawing.Icon)(resources.GetObject("errorUsername.Icon")));
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            this.errorPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("errorPassword.Icon")));
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 504);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox signUsername;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button tb_login;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.ErrorProvider errorUsername;
        private System.Windows.Forms.ErrorProvider errorPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}