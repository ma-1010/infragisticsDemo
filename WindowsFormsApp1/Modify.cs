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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
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
                this.Hide();
                Form ud = new UserData(dataTable.Rows[0][0].ToString(), dataTable.Rows[0][1].ToString(), dataTable.Rows[0][2].ToString(), dataTable.Rows[0][3].ToString(), dataTable.Rows[0][6].ToString());
                ud.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is invaild");
            }
        }
    }
}
