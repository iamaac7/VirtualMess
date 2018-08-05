﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vmmBAL;
using vmmBLL;

namespace VirtualMessManager
{
    public partial class AdminChange : Form
    {
        bool flag = true;
        public Informations info = new Informations();
        public Operation opr = new Operation();

        private AdminSession managerBack = null;

        string userNameChangeAdmin;
        string passwordChangeAdmin;
        public AdminChange()
        {
            InitializeComponent();
            this.ActiveControl = tb_NewAdminName;
        }

        public AdminChange(AdminSession adminBack): this()
        {
            this.managerBack = adminBack;
        }

        private void AdminChange_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tb_OldAdminUserName;
            tb_OldAdminUserName.Focus();
            //tb_OldAdminUserName.Focus();
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {

            if (tb_NewAdminName.Text.Trim() == "")
            {
                flag = false;
            }
            else if (tb_NewAdminUserName.Text.Trim() == "")
            {
                flag = false;
            }
            else if (tb_NewAdminId.Text.Trim() == "")
            {
                flag = false;
            }
            else if (tb_OldAdminUserName.Text.Trim() == "")
            {
                flag = false;
            }
            else if (tb_OldAdminPassword.Text.Trim() == "")
            {
                flag = false;
            }


            if (flag == true)
            {
                string tempOldUserName = tb_OldAdminUserName.Text;
                string tempOldPassword = tb_OldAdminPassword.Text;

                userNameChangeAdmin = Login.logInUserName1;
                passwordChangeAdmin = Login.logInPassword1;

                if (tempOldUserName.Equals(userNameChangeAdmin) && tempOldPassword.Equals(passwordChangeAdmin))
                {
                    info.newAdminName = tb_NewAdminName.Text;
                    info.newAdminUsername = tb_NewAdminName.Text;
                    info.newAdminId = Convert.ToInt32(tb_NewAdminId.Text);

                    info.logInUserName = Login.logInUserName1;
                    info.logInPassword = Login.logInPassword1;

                    info.name = Login.loginName;
                    info.refManagrtName = Login.refManagerName;

                    int confirmMemberToManager = opr.MemberToManager(info);

                    if (confirmMemberToManager > 0)
                    {
                        int confirmManagerToMember = opr.ManagerToMember(info);

                        if (confirmManagerToMember > 0)
                        {
                            int confirmRefManagerChange = opr.ChangeRerManagerName(info);

                            if (confirmRefManagerChange > 0)
                            {
                                MessageBox.Show("Admin Changed Successfully.","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Problem in Old Manager.","Wrong Old Admin Info",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        }

                    }
                    else
                    {
                        MessageBox.Show("New Admin Name or Id Doesn't Match with Database.\n Please Check it......!","Wrong Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        tb_NewAdminName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("InValid Old Admin...\nAdmin Change Operaton doesn't Applicable.","Wrong Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    flag = true;
                }
            }
            else
            {
                MessageBox.Show("OOoopsss....\nComplete Each text Box.","Incomplete",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                tb_NewAdminName.Focus();
                flag = true;
            }
        }

        private void tb_NewAdminId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch !=8)
            {
                e.Handled = true;
            }
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerBack.Show();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You want to exit?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            ////Application.Exit();
            //this.Hide();
            //Login log = new Login();
            //log.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}