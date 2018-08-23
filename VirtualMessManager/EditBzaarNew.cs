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
    public partial class EditBzaarNew : Form
    {
        public Informations info = new Informations();
        public Operation opr = new Operation();
        public DBConnection db = new DBConnection();
       // public BookMeal bm = new BookMeal();
        public Bazar ba = new Bazar();
       
        static int x;
        private SeeBazarHistory seeBazarHistory;

        public EditBzaarNew(AdminSession adminSession)
        {
            InitializeComponent();
        }

        public EditBzaarNew()
        {
        }

        public EditBzaarNew(SeeBazarHistory seeBazarHistory)
        {
            this.seeBazarHistory = seeBazarHistory;
            InitializeComponent();
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

        private void EditBzaarNew_Load(object sender, EventArgs e)
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
                string query1 = "select Date from vmmBazarChart";
                cmd.CommandText = query1;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    cb_Date.Items.Add(reader["Date"].ToString());

                }
                db.connection.Close();

                x = 0;
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
                    ba.id = info.ID;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void cb_UserName_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                info.dateFromMeal = Convert.ToDateTime(cb_Date.Text);
                ba.date = info.dateFromMeal;
                DataTable dt = new DataTable();
                dt = opr.GetItemQuantityPrice(info);
                textBoxItems.Text = dt.Rows[0][0].ToString();
                textBoxQuantity.Text = dt.Rows[0][1].ToString();
                textBoxPrice.Text = dt.Rows[0][2].ToString();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void cb_Date_TextChanged(object sender, EventArgs e)
        {
            if (cb_UserName.Text != "")
            {
                try
                {
                    info.dateFromMeal = Convert.ToDateTime(cb_Date.Text);
                    DataTable dt = new DataTable();
                    dt = opr.GetItemQuantityPrice(info);
                    textBoxItems.Text = dt.Rows[0][0].ToString();
                    textBoxQuantity.Text = dt.Rows[0][1].ToString();
                    textBoxPrice.Text = dt.Rows[0][2].ToString();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }


      
        private void cb_Date_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (cb_UserName.Text != "" && cb_Date.Text != "")
            {
                if (MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    info.userName = cb_UserName.Text;
                    info.dateFromMeal = Convert.ToDateTime(cb_Date.Text);

                    opr.DeleteInfoEB(ba);
                    MessageBox.Show("Row Deleted");

                }
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
                string query1 = "select Date from vmmBazarChart ";
                cmd.CommandText = query1;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    cb_Date.Items.Add(reader["Date"].ToString());

                }
                db.connection.Close();

                x = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_Date.Text != "" && cb_UserName.Text != "")
            {

                if (textBoxItems.Text != "" && textBoxQuantity.Text != "" && textBoxPrice.Text != "")
                {

                    try
                    {
                      

                        ba.items = Convert.ToString(textBoxItems.Text);
                        ba.quantity = Convert.ToString(textBoxQuantity.Text);
                        ba.amount = Convert.ToInt32(textBoxPrice.Text);

                     
                        int rowAffected = opr.UpdateBazar(ba);
                      

                        if (rowAffected > 0)
                        {
                            MessageBox.Show(cb_Date.Text + " " + "\nUserName: " + cb_UserName.Text + "\n" + "Items: " + textBoxItems.Text + " " + "Quantity: " + textBoxQuantity.Text + " " + "Price: " + textBoxPrice.Text + "\nData Update successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Items/Quantity/Price field must be Numbers(0-9) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else MessageBox.Show("Items/Quantity/Price field is empty.\nPlease Enter these Field correctly. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else MessageBox.Show("Empty User Name or Date field.\nPlease select these Field correctly. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
