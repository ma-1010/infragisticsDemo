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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;//ok button
            MessageBoxIcon icon = MessageBoxIcon.Information;//the "!" icon
            DialogResult result;
            MessageBoxButtons yn = MessageBoxButtons.YesNo;//yes no button
            MessageBoxIcon qt = MessageBoxIcon.Question;//"?" icon
            result = MessageBox.Show("Do you want to Delete this account ", "Caption", yn, qt);
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-11U2CDN\\SQLEXPRESS;Initial Catalog=MVVMLoginDb;Integrated Security=True");

            if (result == DialogResult.Yes)
            {       
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [User] WHERE username = @username", conn);
                //set @ to the texteditor
                cmd.Parameters.AddWithValue("@username", ultraTextEditor1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account have been deleted", "Caption", btn, icon);
            }
    
        }
    }
}
