using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
                    cmd.Parameters.AddWithValue("@password", ultraTextEditor2.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    //check the data in sql if the username or password it correct or not
                    if (dataTable.Rows.Count > 0)
                    {
                        new UserData().Show();
                        this.Hide();
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
            new Form1().Show();
            this.Hide();
        }

    }
}
;