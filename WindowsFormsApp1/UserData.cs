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
        string User = "", Name = "", LastName = "", Password = "", Role = "", Email = "", DateTime = "";
        public UserData()
        {
            InitializeComponent();
        }
        public UserData(string User, string Password, string Name, string LastName, string Email, string DateTime, string Role)
        {
            InitializeComponent();
            this.User = User;
            this.Name = Name;
            this.LastName = LastName;
            this.Password = Password;
            this.Email = Email;
            this.DateTime =DateTime;
            this.Role = Role;
        }

        private void ultraTabControl1_VisibleChanged(object sender, EventArgs e)
        {
            if (Role == "0" || Role =="1")
            {
                this.ultraTabControl1.Tabs[1].Visible = false;
                this.ultraTabControl1.Tabs[1].Enabled = false;
            }
        }

        private void ultraTabControl1_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
        {

        }

        private void ultraButton6_Click(object sender, EventArgs e)
        {
            if (isVaild())
            {
                if (validateUser())
                {
                    changedRole();
                    this.Close();
                    new Login().Show();
                }
                else
                {
                    MessageBox.Show("Username is invaild");
                }
            }
        }
        private bool isVaild()
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;//ok button
            MessageBoxIcon icon = MessageBoxIcon.Information;//the "!" icon
            if (string.IsNullOrEmpty(ultraTextEditor1.Text))
            {
                MessageBox.Show("Enter Username", "Caption", btn, icon);
                TextClear();
                return false;
            }
            else if (string.IsNullOrEmpty(ultraTextEditor2.Text))
            {
                MessageBox.Show("Pls Enter the Name of user", "Caption", btn, icon);
                TextClear();
                return false;
            }
            else if (string.IsNullOrEmpty(ultraTextEditor3.Text))
            {
                MessageBox.Show("Pls Enter the Current role", "Caption", btn, icon);
                TextClear();
                return false;
            }
            else if (string.IsNullOrEmpty(ultraTextEditor4.Text))
            {
                MessageBox.Show("Pls Enter the new role", "Caption", btn, icon);
                TextClear();
                return false;
            }

            if (ultraTextEditor3.Text == ultraTextEditor4.Text)
            {
                MessageBox.Show("The current role and new role cant not match", "Caption", btn, icon);
                TextClear();
                return false;
            }
            if (ultraTextEditor4.Text == "2")
            {
                MessageBox.Show("DENIE! ", "Caption", btn, icon);
                TextClear();
                return false;
            }
            return true;
        }

        private bool validateUser()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-11U2CDN\\SQLEXPRESS;Initial Catalog=MVVMLoginDb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select *from [User] where username=@username and name=@name and role=@role", conn);
            conn.Open();

            cmd.Parameters.AddWithValue("@username", ultraTextEditor1.Text);
            cmd.Parameters.AddWithValue("@name", ultraTextEditor2.Text);
            cmd.Parameters.AddWithValue("@role", ultraTextEditor3.Text);
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

        private void changedRole()
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;//ok button
            MessageBoxIcon icon = MessageBoxIcon.Information;//the "!" icon
            DialogResult result;
            MessageBoxButtons yn = MessageBoxButtons.YesNo;//yes no button
            MessageBoxIcon qt = MessageBoxIcon.Question;//"?" icon
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-11U2CDN\\SQLEXPRESS;Initial Catalog=MVVMLoginDb;Integrated Security=True");
            result = MessageBox.Show("Do you want to Change this account role", "Caption", yn, qt);
            // if chose Yes
            if (result == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE [User] SET role=@role WHERE username=@username", conn);
                cmd2.Parameters.AddWithValue("@username", ultraTextEditor1.Text);
                cmd2.Parameters.AddWithValue("@role", ultraTextEditor4.Text);
                cmd2.ExecuteNonQuery();//execute command and save the account to the Db
                MessageBox.Show("Role have been change", "Caption", btn, icon);
            }
        }
        private void TextClear()
        {
            ultraTextEditor1.Clear();
            ultraTextEditor2.Clear();
            ultraTextEditor3.Clear();
            ultraTextEditor4.Clear();
        }

        private void ultraButton3_Click(object sender, EventArgs e)
        {
            new Add().Show();
            this.Close();
        }

        private void ultraButton5_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;//ok button
            MessageBoxIcon icon = MessageBoxIcon.Information;//the "!" icon
            if (Role == "2" || Role == "1")
            {
                new Delete().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("YOU DONT HAVE ENOUGH AUTHENTICATION TO ACCES", "Caption", btn, icon);
            }
        }

        //private void ultraButton4_Click(object sender, EventArgs e)
        //{
        //    MessageBoxButtons btn = MessageBoxButtons.OK;//ok button
        //    MessageBoxIcon icon = MessageBoxIcon.Information;//the "!" icon
        //    if (Role == "2")
        //    {
        //        new Modify().Show();
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("YOU DONT HAVE ENOUGH AUTHENTICATION TO ACCES", "Caption", btn, icon);
        //    }
        //}

        //load data in sql
        private void UserData_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'mVVMLoginDbDataSet2.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.mVVMLoginDbDataSet2.User);
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
