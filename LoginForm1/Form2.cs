using System.Data.SqlClient;
using IE322_Project;
using Microsoft.Data.SqlClient;

namespace LoginForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtPass.UseSystemPasswordChar = true;

        }

        public bool IsLoggedIn { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
   
    
                InventoryManagementStudio frm = new InventoryManagementStudio();
            frm.Show();

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {

            txtPass.UseSystemPasswordChar = !chkShow.Checked;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}