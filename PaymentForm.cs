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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data source =DESKTOP-CPVI968; Initial catalog=Restaurant_1; Integrated security = true;");
        SqlCommand cmd = new SqlCommand();

        public void displayData()
        {
            cmd.CommandText = "SELECT Name, OrderDetail.Qty, Price, Price*OrderDetail.Qty as Total FROM MsMenu INNER JOIN OrderDetail ON MsMenu.ID = OrderDetail.MenuID";
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            dataGridView_details.DataSource = dt;
            /*SELECT nama_kolom_tampil FROM nama_tabel_pertama INNER JOIN 
              nama_tabel_kedua USING (nama_kolom_join)
            */
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            conn.Open();
            //fill combobox orderid
            cmd.CommandText = "SELECT OrderID FROM OrderDetail WHERE Status='blmdbyr'";
            var read = cmd.ExecuteReader();
            while (read.Read()) {
                box_orderID.Items.Add(read["OrderID"].ToString());
            }
            conn.Close();
            conn.Open();
            //fill combobox name
            cmd.CommandText = "SELECT Name FROM MsMember";
            var readName = cmd.ExecuteReader();
            while (readName.Read())
            {
                box_name.Items.Add(readName["Name"].ToString());
            }
            conn.Close();
            conn.Open();

        }

        private void box_orderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                displayData();
                //calculate and display total
                int totalPayment = 0;
                for(int i = 0; i < dataGridView_details.Rows.Count; i++)
                {
                    int total = int.Parse(dataGridView_details.Rows[i].Cells["Total"].Value.ToString());
                    totalPayment += total;
                }
                label_total.Text = totalPayment.ToString();
            }catch(Exception a)
            {
                
                //do nothing
            }
        }

        private void box_pt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (box_pt.Text)
            {
                case "Cash":
                    //set visibility to true
                    label_cn_cash.Visible = true;
                    box_cn_cash.Visible = true;
                    label_cashBack.Visible = true;
                    label_totalCashback.Visible = true;
                    label_cn_cash.Text = "Jumlah Uang ";
                    //set visibility to false
                    box_bankName.Visible = false;
                    break;
                case "Credit Card":
                    //set visibility to true
                    label_cn_cash.Visible = true;
                    box_cn_cash.Visible = true;
                    label_cashBack.Visible = false;
                    label_totalCashback.Visible = false;
                    label_cn_cash.Text = "Card Number ";
                    //set visibility to false
                    box_bankName.Visible = true;
                    break;
            }
        }
        //calculate cashback
        private void box_cn_cash_ValueChanged(object sender, EventArgs e)
        {
            if(box_cn_cash.Visible == true)
            {
                int total = int.Parse(label_total.Text);
                int bayar = (int)box_cn_cash.Value;
                label_totalCashback.Text = (bayar - total).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(box_pt.Text == "Cash")
            {
                if (String.IsNullOrEmpty(box_name.Text) == false &&
                   String.IsNullOrEmpty(box_pt.Text) == false &&
                   String.IsNullOrEmpty(box_cn_cash.Text) == false
                    )
                {
                    cmd.CommandText = "SELECT ID FROM MsMember WHERE Name='" + box_name.Text + "'";
                    string memberID = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "SELECT ID FROM MsEmployee WHERE Name='"+Login.employeeName+"'";
                    string employeeID = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "INSERT INTO OrderHeader (ID,EmployeeID,MemberID,Date)" +
                        " values('"+box_orderID.Text+ "', '" + employeeID + "', '" + memberID + "', '" + DateTime.Now.Date + "')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE OrderDetail SET Status='sdhtbyr' WHERE OrderID='"+box_orderID.Text+"'";
                    cmd.ExecuteNonQuery();
                }
            }
            else if(box_pt.Text == "Credit Card")
            {
                if (String.IsNullOrEmpty(box_name.Text) == false &&
                   String.IsNullOrEmpty(box_pt.Text) == false &&
                   String.IsNullOrEmpty(box_cn_cash.Text) == false &&
                   String.IsNullOrEmpty(box_bankName.Text) == false
                    )
                {

                    cmd.CommandText = "SELECT ID FROM MsMember WHERE Name='" + box_name.Text + "'";
                    string memberID = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "SELECT ID FROM MsEmployee WHERE Name='" + Login.employeeName + "'";
                    string employeeID = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "INSERT INTO OrderHeader (ID,EmployeeID,MemberID,Date,PaymentType,CardNumber,Bank)" +
                        " values('" + box_orderID.Text + "', '" + employeeID + "', '" + memberID + "', '" + DateTime.Now.Date + "', " +
                        "'" + box_pt.Text + "', '" + box_cn_cash.Value + "', '" + box_bankName.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE OrderDetail SET Status='sdhtbyr' WHERE OrderID='" + box_orderID.Text + "'";
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("pesanan telah dibayar");
        }
    }
}
