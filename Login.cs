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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data source =DESKTOP-CPVI968; Initial catalog=Restaurant_1; Integrated security = true;");
        SqlCommand cmd = new SqlCommand();
        public static string employeeName = "";
        public static string employeePosition = "";
        private void btn_login_Click(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(*) FROM MsEmployee " +
                "WHERE Email='" + box_email.Text + "' AND Password='" + box_password.Text + "'";
            int cnt = (int)cmd.ExecuteScalar();
            if(cnt > 0)
            {
                //MessageBox.Show("masuk");
                cmd.CommandText = "SELECT Position FROM MsEmployee WHERE Email='"+box_email.Text+"'";
                employeePosition = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "SELECT Name FROM MsEmployee WHERE Email='" + box_email.Text + "'";
                employeeName = cmd.ExecuteScalar().ToString();

                if (employeePosition == "Admin")
                {
                    AdminNavigation open = new AdminNavigation();
                    open.Show();
                    this.Hide();
                }else if (employeePosition == "Cashier")
                {
                    CashierNavigation open = new CashierNavigation();
                    open.Show();
                    this.Hide();
                }
            }
            else
            {
                //MessageBox.Show("tidak masuk");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
