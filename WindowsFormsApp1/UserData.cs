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

        public UserData()
        {
            InitializeComponent();
        }
        //load data in sql
        private void UserData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mVVMLoginDbDataSet2.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.mVVMLoginDbDataSet2.User);
            // TODO: This line of code loads data into the 'mVVMLoginDbDataSet.User' table. You can move, or remove it, as needed.

        }

        //Export data in sql to excel file
        private void ultraButton1_Click_1(object sender, EventArgs e)
        {
            this.ultraGridExcelExporter1.Export
            (
                this.ultraGrid1, "C:\\Users\\ADMIN\\Downloads\\GridData.xlsx"

            );
            Process.Start("C:\\Users\\ADMIN\\Downloads\\GridData.xlsx");
            this.Close();
            new UserData().Show();
        }

        private void ultraButton2_Click(object sender, EventArgs e)
        {
            new ChangedPassword().Show();
            this.Close();
        }
    }
}
