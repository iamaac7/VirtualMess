﻿namespace VirtualMessManager
{
    partial class EditMealChartnew
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
            this.cb_Date = new System.Windows.Forms.ComboBox();
            this.cb_UserName = new System.Windows.Forms.ComboBox();
            this.textBoxBreak = new System.Windows.Forms.TextBox();
            this.textBoxDinner = new System.Windows.Forms.TextBox();
            this.textBoxLunch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Date
            // 
            this.cb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_Date.FormattingEnabled = true;
            this.cb_Date.Location = new System.Drawing.Point(12, 104);
            this.cb_Date.Name = "cb_Date";
            this.cb_Date.Size = new System.Drawing.Size(121, 28);
            this.cb_Date.TabIndex = 0;
            this.cb_Date.SelectedIndexChanged += new System.EventHandler(this.cb_Date_SelectedIndexChanged);
            this.cb_Date.TextChanged += new System.EventHandler(this.cb_Date_TextChanged);
            // 
            // cb_UserName
            // 
            this.cb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_UserName.FormattingEnabled = true;
            this.cb_UserName.Location = new System.Drawing.Point(148, 104);
            this.cb_UserName.Name = "cb_UserName";
            this.cb_UserName.Size = new System.Drawing.Size(121, 28);
            this.cb_UserName.TabIndex = 1;
            this.cb_UserName.SelectedValueChanged += new System.EventHandler(this.cb_UserName_SelectedValueChanged);
            this.cb_UserName.TextChanged += new System.EventHandler(this.cb_UserName_TextChanged);
            // 
            // textBoxBreak
            // 
            this.textBoxBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBreak.Location = new System.Drawing.Point(310, 104);
            this.textBoxBreak.Name = "textBoxBreak";
            this.textBoxBreak.Size = new System.Drawing.Size(58, 26);
            this.textBoxBreak.TabIndex = 2;
            // 
            // textBoxDinner
            // 
            this.textBoxDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDinner.Location = new System.Drawing.Point(475, 104);
            this.textBoxDinner.Name = "textBoxDinner";
            this.textBoxDinner.Size = new System.Drawing.Size(58, 26);
            this.textBoxDinner.TabIndex = 3;
            // 
            // textBoxLunch
            // 
            this.textBoxLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLunch.Location = new System.Drawing.Point(395, 104);
            this.textBoxLunch.Name = "textBoxLunch";
            this.textBoxLunch.Size = new System.Drawing.Size(58, 26);
            this.textBoxLunch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(472, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dinner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(400, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lunch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(306, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Breakfast";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(153, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "User Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(370, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(455, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 39);
            this.button2.TabIndex = 11;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(233, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 39);
            this.button3.TabIndex = 12;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(455, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 39);
            this.button4.TabIndex = 13;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EditMealChartnew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 475);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLunch);
            this.Controls.Add(this.textBoxDinner);
            this.Controls.Add(this.textBoxBreak);
            this.Controls.Add(this.cb_UserName);
            this.Controls.Add(this.cb_Date);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMealChartnew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMealChartnew";
            this.Load += new System.EventHandler(this.EditMealChartnew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Date;
        private System.Windows.Forms.ComboBox cb_UserName;
        private System.Windows.Forms.TextBox textBoxBreak;
        private System.Windows.Forms.TextBox textBoxDinner;
        private System.Windows.Forms.TextBox textBoxLunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}