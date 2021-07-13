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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data source =DESKTOP-CPVI968; Initial catalog=Restaurant_1; Integrated security = true;");
        SqlCommand cmd = new SqlCommand();
        string menuName = "";
        string menuQty = "";

        public void displayDataOrdered()
        {
            cmd.CommandText = "SELECT * FROM Temp_Order";
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            dataGridView_tempOrder.DataSource = dt;
        }
        public void calculate()
        {
            int total = 0;
            int carbo = 0;
            int protein = 0;
            for (int i = 0; i < dataGridView_tempOrder.Rows.Count; i++)
            {

                string carboData2 = (string)dataGridView_tempOrder.Rows[i].Cells["Carbo"].Value;
                string proteinData2 = (string)dataGridView_tempOrder.Rows[i].Cells["Protein"].Value;
                string totalData2 = (string)dataGridView_tempOrder.Rows[i].Cells["Total"].Value;

                int carboData = int.Parse(carboData2);
                int proteinData = int.Parse(proteinData2);
                int totalData = int.Parse(totalData2);


                carbo += (int)(carboData*box_menuQty.Value);
                protein += (int)(proteinData*box_menuQty.Value);
                total += totalData;
            }
            label_protein.Text = protein.ToString();
            label_total.Text = total.ToString();
            label_carbo.Text = carbo.ToString();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT Name,Price,Carbo,Protein FROM MsMenu";
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            dataGridView_order.DataSource = dt;
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void dataGridView_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                menuName = dataGridView_order.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                
                box_menuName.Text = menuName;
                cmd.CommandText = "SELECT Photo FROM MsMenu WHERE Name='" + menuName + "'";
                string photoName = cmd.ExecuteScalar().ToString();
                pictureBox1.Image = Image.FromFile(photoName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            cmd.CommandText = "SELECT COUNT(*) FROM Temp_Order WHERE Menu='"+box_menuName.Text+"'";
            int count = (int)cmd.ExecuteScalar();
            if(count > 0)
            {
                //update
                cmd.CommandText = "SELECT Carbo FROM MsMenu WHERE Name='" + box_menuName.Text + "'";
                string carbo = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "SELECT Protein FROM MsMenu WHERE Name='" + box_menuName.Text + "'";
                string protein = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "SELECT Price FROM MsMenu WHERE Name='" + box_menuName.Text + "'";
                string price = cmd.ExecuteScalar().ToString();
                int price2 = int.Parse(price);
                int qty = (int)box_menuQty.Value;
                cmd.CommandText = "UPDATE Temp_Order SET Qty='"+box_menuQty.Value+ "' ," +
                    " Total='" + (qty * price2) + "' WHERE Menu='"+box_menuName.Text+"'";
                cmd.ExecuteNonQuery();
                displayDataOrdered();
            }
            else
            {
                //tambah
                cmd.CommandText = "SELECT Carbo FROM MsMenu WHERE Name='"+box_menuName.Text+"'";
                string carbo = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "SELECT Protein FROM MsMenu WHERE Name='" + box_menuName.Text + "'";
                string protein = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "SELECT Price FROM MsMenu WHERE Name='" + box_menuName.Text + "'";
                string price = cmd.ExecuteScalar().ToString();
                int price2 = int.Parse(price);
                int qty = (int)box_menuQty.Value;
                cmd.CommandText = "INSERT INTO Temp_Order (Menu,Qty,Carbo,Protein,Price,Total)" +
                    " values('"+box_menuName.Text+"', '"+box_menuQty.Value+"', '"+carbo+"', " +
                    "'"+protein+"', '"+price+"', '"+(qty*price2)+"')";
                cmd.ExecuteNonQuery();
                displayDataOrdered();
            }
            calculate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM Temp_Order WHERE Menu='"+box_menuName.Text+"'";
            cmd.ExecuteNonQuery();
            displayDataOrdered();
            calculate();
        }

        private void dataGridView_tempOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            //insert into order detail
            //get next id of order id
            cmd.CommandText = "SELECT IDENT_CURRENT('OrderDetail')";
            string nextID = cmd.ExecuteScalar().ToString();
            //MessageBox.Show(nextID);

            for (int i = 0; i < dataGridView_tempOrder.Rows.Count; i++)
            {
                //get menu id
                string menuName = dataGridView_tempOrder.Rows[i].Cells["Menu"].Value.ToString();
                cmd.CommandText = "SELECT ID FROM MsMenu WHERE Name='" + menuName + "'";
                string menuID = cmd.ExecuteScalar().ToString();

                // get qty
                string qty = dataGridView_tempOrder.Rows[i].Cells["Qty"].Value.ToString();

                //make orderID
                string year = DateTime.Parse(DateTime.Now.ToString()).Year.ToString();
                string month = DateTime.Parse(DateTime.Now.ToString()).Month.ToString();
                string date = DateTime.Parse(DateTime.Now.ToString()).Day.ToString();
                //MessageBox.Show(year);
                //MessageBox.Show(month);
                //MessageBox.Show(date);
                string orderID = year + month + date + "000" + nextID;
                MessageBox.Show(orderID);
                cmd.CommandText = "INSERT INTO OrderDetail (OrderID,MenuID,Qty,Status) " +
                    "values('" + orderID + "', '" + menuID + "', '" + qty + "', 'blmdbyr')";
                cmd.ExecuteNonQuery();
            }
        }
    }
}
