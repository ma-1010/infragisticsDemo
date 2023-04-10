using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string[] salt = File.ReadAllLines(@"C:\Users\ADMIN\Downloads\test.txt");// edit the path of the salt file in the database file to where you put it

        //private static bool MatchSHA1(byte[] p1, byte[] p2)
        //{
        //    bool result = false;
        //    if (p1 != null && p2 != null)
        //    {s
        //        if (p1.Length == p2.Length)
        //        {
        //            result = true;
        //            for (int i = 0; i < p1.Length; i++)
        //            {
        //                if (p1[i] != p2[i])
        //                {
        //                    result = false;
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //    return result;
        //}
        
        //sha256 password hashcode
        public static string sha256(string pw, string[] salt)
        {
            System.Security.Cryptography.SHA256Managed sha256 = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(pw + salt));
            return Convert.ToBase64String(hash);
        }
        private void ultraButton1_Click(object sender, EventArgs e)
        {
            //check user or password it empty or not
            if (ultraTextEditor1.Text == "")
            {
                MessageBox.Show("Enter Username");
            }
            else if (ultraTextEditor2.Text == "")
            {
                MessageBox.Show(" Enter the Password");
            }
            else
            {
                try
                {
                    //connect to sql Db
                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-11U2CDN\\SQLEXPRESS;Initial Catalog=MVVMLoginDb;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("select *from [User] where username=@username and password=@password", conn);
                    //set @ to the texteditor
                    cmd.Parameters.AddWithValue("@username", ultraTextEditor1.Text);
                    cmd.Parameters.AddWithValue("@password", sha256(ultraTextEditor2.Text,salt));
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    //check the data in sql if the username or password it correct or not
                    if (dataTable.Rows.Count > 0)
                    {
                        this.Hide();
                        Form ud = new UserData(dataTable.Rows[0][1].ToString(), dataTable.Rows[0][2].ToString(), dataTable.Rows[0][3].ToString(), dataTable.Rows[0][4].ToString(), dataTable.Rows[0][5].ToString(), dataTable.Rows[0][6].ToString(), dataTable.Rows[0][7].ToString());
                        ud.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is invaild");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + ex);
                }
            }
        }
        //go to sign up page
        private void ultraButton3_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void ultraTextEditor1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ultraButton3.Focus();
            }
            if (e.KeyCode==Keys.Down)
            {
                ultraTextEditor2.Focus();
            }    
        }

        private void ultraTextEditor2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ultraTextEditor1.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ultraButton1.Focus();
            }
        }
    }
}
;
