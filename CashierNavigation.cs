using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_11
{
    public partial class CashierNavigation : Form
    {
        public CashierNavigation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login open = new Login();
            open.Show();
        }

        private void CashierNavigation_Load(object sender, EventArgs e)
        {
            label2.Text = "Welcome, Cashier " + Login.employeeName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentForm open = new PaymentForm();
            open.Show();
        }
    }
}
