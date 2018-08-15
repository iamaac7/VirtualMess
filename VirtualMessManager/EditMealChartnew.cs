using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vmmBAL;
using vmmBLL;
using vmmDAL;

namespace VirtualMessManager
{
    public partial class EditMealChartnew : Form
    {
        public Informations info = new Informations();
        public Operation opr = new Operation();
        public DBConnection db = new DBConnection();
        static int x;
        static int ID;


        public EditMealChartnew(AdminSession adminSession)
        {
            InitializeComponent();
        }

        private void EditMealChartnew_Load(object sender, EventArgs e)
        {
            db.connection.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = db.connection;
            string query = "select UserName from vmmUser1 ";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                cb_UserName.Items.Add(reader["UserName"]);

            }
            x++;
            db.connection.Close();
            if (x == 1)
            {

                db.connection.Open();

                cmd.Connection = db.connection;
                string query1 = "select Date from vmmMealChart ";
                cmd.CommandText = query1;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    cb_Date.Items.Add(reader["Date"].ToString());

                }
                db.connection.Close();


            }
        }

        private void cb_Date_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You want to exit?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSession AS = new AdminSession();
            AS.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cb_UserName.Text != "" && cb_Date.Text != "")
            {
                info.userName = cb_UserName.Text;
                info.dateFromMeal = Convert.ToDateTime(cb_Date.Text);
                
                opr.DeleteInfo(info);
                MessageBox.Show("Row Deleted");


            }
            else { MessageBox.Show("No row selected."); }

            db.connection.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = db.connection;
            string query = "select UserName from vmmUser1 ";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                cb_UserName.Items.Add(reader["UserName"]);

            }
            x++;
            db.connection.Close();
            if (x == 1)
            {

                db.connection.Open();

                cmd.Connection = db.connection;
                string query1 = "select Date from vmmMealChart ";
                cmd.CommandText = query1;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    cb_Date.Items.Add(reader["Date"].ToString());

                }
                db.connection.Close();


            }

        }

        private void cb_UserName_TextChanged(object sender, EventArgs e)
        {
            if (cb_UserName.Text != "")
            {
                try
                {
                    info.userName = cb_UserName.Text;

                    DataTable dt = opr.GetId(info);
                    info.ID = Convert.ToInt32(dt.Rows[0][0]);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            //try
            //{
            //    info.dateFromMeal = Convert.ToDateTime(cb_Date.Text);
            //    DataTable dt = new DataTable();
            //    dt = opr.GetBreakLunDin(info);
            //    textBoxBreak.Text = dt.Rows[0][4].ToString();
            //    textBoxLunch.Text = dt.Rows[0][5].ToString();
            //    textBoxDinner.Text = dt.Rows[0][6].ToString();
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void cb_UserName_SelectedValueChanged(object sender, EventArgs e)
        {
            
            try
            {
                info.dateFromMeal = Convert.ToDateTime(cb_Date.Text);
                DataTable dt = new DataTable();
                dt = opr.GetBreakLunDin(info);
                textBoxBreak.Text = dt.Rows[0][0].ToString();
                textBoxLunch.Text = dt.Rows[0][1].ToString();
                textBoxDinner.Text = dt.Rows[0][2].ToString();
     
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void cb_Date_TextChanged(object sender, EventArgs e)
        {
            if (cb_UserName.Text != "") {
                try
                {
                    info.dateFromMeal = Convert.ToDateTime(cb_Date.Text);
                    DataTable dt = new DataTable();
                    dt = opr.GetBreakLunDin(info);
                    textBoxBreak.Text = dt.Rows[0][0].ToString();
                    textBoxLunch.Text = dt.Rows[0][1].ToString();
                    textBoxDinner.Text = dt.Rows[0][2].ToString();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }
    }
}