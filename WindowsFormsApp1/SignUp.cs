using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win.UltraWinEditors;
using System.Text;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class SignUp : Form
    {
        string[] salt = File.ReadAllLines(@"C:\Users\ADMIN\Downloads\test.txt");
        public SignUp()
        {
            InitializeComponent();

        }

        public static string sha256(string pw, string[] salt)
        {
            System.Security.Cryptography.SHA256Managed sha256 = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(pw + salt));
            return Convert.ToBase64String(hash);
        }
        //move to login page
        private void ultraButton3_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        //create new account
        private void ultraButton1_Click(object sender, EventArgs e)
        {
            //set messagebox button and icon
            MessageBoxButtons btn = MessageBoxButtons.OK;//ok button
            MessageBoxIcon icon = MessageBoxIcon.Information;//the "!" icon
            //check if any text field is empty or not
            if (string.IsNullOrEmpty(ultraTextEditor3.Text))
            {
                MessageBox.Show("Enter Username", "Caption", btn, icon);
                ultraTextEditor3.Select();
                return;
            }
            if (string.IsNullOrEmpty(ultraTextEditor1.Text))
            {
                MessageBox.Show("Pls Enter the Password", "Caption", btn, icon);
                ultraTextEditor1.Select();
                return;
            }
            if (string.IsNullOrEmpty(ultraTextEditor2.Text))
            {
                MessageBox.Show("Pls Enter the Comfirm Password", "Caption", btn, icon);
                ultraTextEditor2.Select();
                return;
            }
            if (string.IsNullOrEmpty(ultraTextEditor4.Text))
            {
                MessageBox.Show("Pls Enter the Last name", "Caption", btn, icon);
                ultraTextEditor4.Select();
                return;
            }
            if (string.IsNullOrEmpty(ultraTextEditor5.Text))
            {
                MessageBox.Show("Pls Enter the Name", "Caption", btn, icon);
                ultraTextEditor5.Select();
                return;
            }
            if (string.IsNullOrEmpty(ultraTextEditor6.Text))
            {
                MessageBox.Show("Pls Enter the Email", "Caption", btn, icon);
                ultraTextEditor6.Select();
                return;
            }
            // check the password and comPassword it match
            if (ultraTextEditor2.Text != ultraTextEditor1.Text)
            {
                MessageBox.Show("The Password and Comfirm Password do not match", "Caption", btn, icon);
                ultraTextEditor2.Select();
                return;
            }
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-11U2CDN\\SQLEXPRESS;Initial Catalog=MVVMLoginDb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select *from [User] where username=@username", conn);
            cmd.Parameters.AddWithValue("@username", ultraTextEditor3.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            //check if the account have already exists or not
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Username already exists, Pls try other name", "Caption", btn, icon);
                ultraTextEditor3.Select();
                return;
            }

            DialogResult result;
            MessageBoxButtons yn = MessageBoxButtons.YesNo;//yes no button
            MessageBoxIcon qt = MessageBoxIcon.Question;//"?" icon
            result = MessageBox.Show("Do you want to create this account", "Caption", yn, qt);
            // if chose Yes
            if( result == DialogResult.Yes)
            {
                string sql = string.Empty;
                //sql command
                sql += "INSERT INTO [User] ([UserName],[Password],[Name],[LastName],[Email],[Datetime])";
                sql += "VALUES(@username, @password,@name,@lastname,@email,CURRENT_TIMESTAMP)";
                conn.Open();
                SqlCommand cmd2 =new SqlCommand(sql, conn);
                cmd2.Parameters.AddWithValue("@username", ultraTextEditor3.Text);
                cmd2.Parameters.AddWithValue("@password", sha256(ultraTextEditor1.Text, salt));
                cmd2.Parameters.AddWithValue("@name", ultraTextEditor5.Text);
                cmd2.Parameters.AddWithValue("@lastname", ultraTextEditor4.Text);
                cmd2.Parameters.AddWithValue("@email", ultraTextEditor6.Text);
                cmd2.ExecuteNonQuery();//execute command and save the account to the Db
                MessageBox.Show("Username have create", "Caption", btn, icon);
                conn.Close();
            }
        }

        private void ultraButton2_Click(object sender, EventArgs e)
        {
            ultraTextEditor1.Clear();
            ultraTextEditor2.Clear();
            ultraTextEditor3.Clear();
            ultraTextEditor4.Clear();
            ultraTextEditor5.Clear();
            ultraTextEditor6.Clear();

        }

        private void ultraTextEditor3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ultraTextEditor4.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                ultraTextEditor4.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ultraTextEditor1.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                ultraButton3.Focus();
            }
        }

        private void ultraTextEditor1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ultraTextEditor5.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                ultraTextEditor5.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ultraTextEditor2.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                ultraTextEditor3.Focus();
            }
        }
        private void ultraTextEditor2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ultraTextEditor6.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                ultraTextEditor6.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                ultraTextEditor1.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ultraButton1.Focus();
            }
        }
        private void ultraTextEditor4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ultraTextEditor3.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                ultraTextEditor3.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ultraTextEditor5.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                ultraButton3.Focus();
            }
        }

        private void ultraTextEditor5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ultraTextEditor1.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                ultraTextEditor1.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ultraTextEditor6.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                ultraTextEditor4.Focus();
            }
        }

        private void ultraTextEditor6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ultraTextEditor2.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                ultraTextEditor2.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                ultraTextEditor5.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ultraButton1.Focus();
            }
        }


        private void ultraButton3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                ultraTextEditor3.Focus();
            }
        }

        private void ultraButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ultraTextEditor6.Focus();
            }
        }
    }
}
