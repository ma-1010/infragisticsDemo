using Infragistics.Win.UltraWinEditors;
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

namespace WindowsFormsApp1
{
    public partial class ChangedPassword : Form
    {
        public ChangedPassword()
        {
            InitializeComponent();
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            if (isVaild())
            {
                if (validateUser())
                {
                    changedPassword();
                    this.Close();
                    new Login().Show();
                }
                else
                {
                    MessageBox.Show("Username or Password is invaild");
                }
            }
        }

        private bool isVaild()
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;//ok button
            MessageBoxIcon icon = MessageBoxIcon.Information;//the "!" icon
            if (string.IsNullOrEmpty(ultraTextEditor4.Text))
            {
                MessageBox.Show("Enter Username", "Caption", btn, icon);
                TextClear();
                return false;
            }
            else if(string.IsNullOrEmpty(ultraTextEditor3.Text))
            {
                MessageBox.Show("Pls Enter the curent password", "Caption", btn, icon);
                TextClear();
                return false;
            }
            else if(string.IsNullOrEmpty(ultraTextEditor2.Text))
            {
                MessageBox.Show("Pls Enter the new password", "Caption", btn, icon);
                TextClear();
                return false;
            }
            else if(string.IsNullOrEmpty(ultraTextEditor1.Text))
            {
                MessageBox.Show("Pls Enter the comfirm password", "Caption", btn, icon);
                TextClear();
                return false;
            }
            else if (string.IsNullOrEmpty(ultraTextEditor1.Text))
            {
                MessageBox.Show("Pls Enter the comfirm password", "Caption", btn, icon);
                TextClear();
                return false;
            }
            if (ultraTextEditor1.Text != ultraTextEditor2.Text)
            {
                MessageBox.Show("The Password and Comfirm Password do not match", "Caption", btn, icon);
                TextClear();
                return false;
            }
            if (ultraTextEditor3.Text == ultraTextEditor2.Text)
            {
                MessageBox.Show("The current password and new password can not identical ", "Caption", btn, icon);
                TextClear();
                return false;
            }
            return true;
        }

        private bool validateUser()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-11U2CDN\\SQLEXPRESS;Initial Catalog=MVVMLoginDb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select *from [User] where username=@username and password=@password", conn);
            conn.Open();

            cmd.Parameters.AddWithValue("@username", ultraTextEditor4.Text);
            cmd.Parameters.AddWithValue("@password", ultraTextEditor3.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void changedPassword()
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;//ok button
            MessageBoxIcon icon = MessageBoxIcon.Information;//the "!" icon
            DialogResult result;
            MessageBoxButtons yn = MessageBoxButtons.YesNo;//yes no button
            MessageBoxIcon qt = MessageBoxIcon.Question;//"?" icon
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-11U2CDN\\SQLEXPRESS;Initial Catalog=MVVMLoginDb;Integrated Security=True");
            result = MessageBox.Show("Do you want to Change this account password", "Caption", yn, qt);
            // if chose Yes
            if (result == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE [User] SET password=@password,datetime=CURRENT_TIMESTAMP WHERE username=@username", conn);
                cmd2.Parameters.AddWithValue("@username", ultraTextEditor4.Text);
                cmd2.Parameters.AddWithValue("@password", ultraTextEditor1.Text);
                cmd2.ExecuteNonQuery();//execute command and save the account to the Db
                MessageBox.Show("Pass word have been change", "Caption", btn, icon);
            }
        }
        private void TextClear()
        {
            ultraTextEditor1.Clear();
            ultraTextEditor2.Clear();
            ultraTextEditor3.Clear();
            ultraTextEditor4.Clear();
        }
    }
}
