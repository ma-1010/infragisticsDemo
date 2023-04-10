using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinTabControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserData : Form
    {
        string User = "", Name = "", LastName = "", Password = "", Role = "";
        public UserData()
        {
            InitializeComponent();
        }


        private void ultraTabControl1_VisibleChanged(object sender, EventArgs e)
        {
            if (Role == "0")
            {
                this.ultraTabControl1.Tabs[1].Visible = false;
                this.ultraTabControl1.Tabs[1].Enabled = false;
            }
            else
            {
                this.ultraTabControl1.Tabs[1].Visible = true;
                this.ultraTabControl1.Tabs[1].Enabled = true;
            }
        }

        private void ultraButton3_Click(object sender, EventArgs e)
        {
            new Add().Show();
            this.Close();
        }

        private void ultraButton5_Click(object sender, EventArgs e)
        {
            new Delete().Show();
            this.Close();
            //MessageBoxButtons btn = MessageBoxButtons.OK;//ok button
            //MessageBoxIcon icon = MessageBoxIcon.Information;//the "!" icon
            //DialogResult result;
            //MessageBoxButtons yn = MessageBoxButtons.YesNo;//yes no button
            //MessageBoxIcon qt = MessageBoxIcon.Question;//"?" icon
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-11U2CDN\\SQLEXPRESS;Initial Catalog=MVVMLoginDb;Integrated Security=True");
            //result = MessageBox.Show("Do you want to Delete this account ", "Caption", yn, qt);
            //// if chose Yes
            //if (result == DialogResult.Yes)
            //{
            //    conn.Open();
            //    SqlCommand cmd2 = new SqlCommand("DELETE FROM [User] WHERE username = @username", conn);
            //    cmd2.Parameters.AddWithValue("@username", );
            //    cmd2.ExecuteNonQuery();
            //    this.ultraGrid1.DeleteSelectedRows(true);
            //    MessageBox.Show("Account have been deleted", "Caption", btn, icon);
            //}

        }

        private void ultraButton4_Click(object sender, EventArgs e)
        {
            new Modify().Show();
            this.Close();
        }



        //        if (Role == "0")
        //        {
        //            this.ultraTabControl1.Tabs[1].Visible = false;
        //        }
        //        else
        //        {
        //            this.ultraTabControl1.Tabs[1].Visible = true;
        //}

        public UserData(string User, string Password,string Name, string LastName , string Role)
        {
            InitializeComponent();
            this.User = User;
            this.Name = Name;   
            this.LastName = LastName;
            this.Password = Password;
            this.Role = Role;
        }
        //load data in sql
        private void UserData_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'mVVMLoginDbDataSet2.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.mVVMLoginDbDataSet2.User);
            // TODO: This line of code loads data into the 'mVVMLoginDbDataSet.User' table. You can move, or remove it, as needed.
            ultraButton1.Focus();
        }

        private void ultraButton2_Click(object sender, EventArgs e)
        {
            new ChangedPassword().Show();
            this.Close();
        }

        //Export data in sql to excel file
        private void ultraButton1_Click(object sender, EventArgs e)
        {
            this.ultraGridExcelExporter1.Export
            (
                this.ultraGrid1, "C:\\Users\\ADMIN\\Downloads\\GridData.xlsx"
            );
            Process.Start("C:\\Users\\ADMIN\\Downloads\\GridData.xlsx");
            this.Close();
            new UserData().Show();
        }





        //private void ultraGrid1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if(e.KeyCode == Keys.Up)
        //    {
        //        ultraButton1.Focus();
        //    }
        //}
    }
}
