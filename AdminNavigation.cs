using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_11
{
    public partial class AdminNavigation : Form
    {
        public AdminNavigation()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data source =DESKTOP-CPVI968; Initial catalog=Restaurant_1; Integrated security = true;");
        SqlCommand cmd = new SqlCommand();
        string employeeName = Login.employeeName;
        string employeePosition = Login.employeePosition;

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            employeeName = "";
            employeePosition = "";
            Login open = new Login();
            open.Show();
        }

        private void AdminNavigation_Load(object sender, EventArgs e)
        {
            label_welcome.Text = "Welcome, " + employeePosition + " " + employeeName + " ";
            if(employeePosition == "Admin")
            {
                btn_logout.Enabled = true;
                btn_member.Enabled = true;
                btn_menu.Enabled = true;
                btn_order.Enabled = true;
            }
            else
            {
                btn_logout.Enabled = true;
                btn_member.Enabled = false;
                btn_menu.Enabled = false;
                btn_order.Enabled = false;
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            ManageMenu open = new ManageMenu();
            open.Show();
        }

        private void AdminNavigation_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            ManageMember open = new ManageMember();
            open.Show();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            Order open = new Order();
            open.Show();
        }
    }
}
