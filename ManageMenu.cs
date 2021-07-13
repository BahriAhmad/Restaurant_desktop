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
    public partial class ManageMenu : Form
    {
        public ManageMenu()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data source =DESKTOP-CPVI968; Initial catalog=Restaurant_1; Integrated security = true;");
        SqlCommand cmd = new SqlCommand();
        string state = "";

        public void displayData()
        {
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM MsMenu";
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            dataGridView_menu.DataSource = dt;
        }

        private void ManageMenu_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM MsMenu";
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            dataGridView_menu.DataSource = dt;
        }

        private void ManageMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if(state != "insert")
            {
                state = "insert";
                btn_cancel.Visible = true;
                btn_save.Visible = true;

                btn_delete.Visible = false;
                btn_insert.Visible = false;
                btn_delete.Visible = false;
                btn_update.Visible = false;

                box_id.Enabled = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (state != "update")
            {
                state = "update";
                btn_cancel.Visible = true;
                btn_save.Visible = true;

                btn_delete.Visible = false;
                btn_insert.Visible = false;
                btn_delete.Visible = false;
                btn_update.Visible = false;

                box_id.Enabled = true;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(box_id.Text) == false)
            {
                var result = MessageBox.Show("Apakah anda yakin ingin menghapus menu dengan id='" + box_id.Text + "'?", "perhatian", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM MsMenu WHERE ID='" + box_id.Text + "'";
                    cmd.ExecuteNonQuery();
                    displayData();
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            state = "";
            btn_cancel.Visible = false;
            btn_save.Visible = false;

            btn_delete.Visible = true;
            btn_insert.Visible = true;
            btn_delete.Visible = true;
            btn_update.Visible = true;
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Filter = "Image Files(*.jpeg;*.jpg)|*.jpeg; *.jpg";
            if(fdlg.ShowDialog() == DialogResult.OK)
            {
                picture.Image = new Bitmap(fdlg.FileName);
                box_photoName.Text = fdlg.FileName;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (state == "insert")
            {
                if(String.IsNullOrEmpty(box_name.Text) == false &&
                    String.IsNullOrEmpty(box_photoName.Text) == false &&
                    box_price.Value > 0 &&
                    box_carbo.Value > 0 &&
                    box_protein.Value > 0)
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO MsMenu (Name,Price,Photo,Carbo,Protein) " +
                        "values('"+box_name.Text+ "', '" + box_price.Value + "', '" + box_photoName.Text + "', " +
                        "'" + box_carbo.Value + "', '" + box_protein.Value + "')";
                    cmd.ExecuteNonQuery();
                    displayData();
                    MessageBox.Show("data telah diinsert!");

                }
            }else if (state == "update")
            {
                if (String.IsNullOrEmpty(box_name.Text) == false &&
                    String.IsNullOrEmpty(box_id.Text) == false &&
                    String.IsNullOrEmpty(box_photoName.Text) == false &&
                    box_price.Value > 0 &&
                    box_carbo.Value > 0 &&
                    box_protein.Value > 0)
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE MsMenu SET Name='"+box_name.Text+ "', Price='" + box_price.Value + "', " +
                        "Photo='" + box_photoName.Text + "', Carbo='" + box_carbo.Value + "', Protein='" + box_protein.Value + "' " +
                        "WHERE ID='"+box_id.Text+"'";
                    cmd.ExecuteNonQuery();
                    displayData();
                    MessageBox.Show("data telah diupdate!");

                }
            }
            state = "";
            btn_cancel.Visible = false;
            btn_save.Visible = false;

            btn_delete.Visible = true;
            btn_insert.Visible = true;
            btn_delete.Visible = true;
            btn_update.Visible = true;

        }

        private void box_price_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            //check apakah data nya ada atau tidak
            try
            {

                cmd.CommandText = "SELECT COUNT(*) FROM MsMenu WHERE ID='" + box_search.Text + "'";
                int idCount = (int)cmd.ExecuteScalar();
                if (idCount > 0)
                {
                    //MessageBox.Show("ada di id");
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM MsMenu WHERE ID='" + box_search.Text + "'";
                    SqlDataAdapter dta = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dta.Fill(dt);
                    dataGridView_menu.DataSource = dt;
                }
            }
            catch(Exception a)
            {
                //do nothing
            }

            try
            {

                cmd.CommandText = "SELECT COUNT(*) FROM MsMenu WHERE Name='" + box_search.Text + "'";
                int nameCount = (int)cmd.ExecuteScalar();
                if (nameCount > 0)
                {
                    //MessageBox.Show("ada di name");
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM MsMenu WHERE Name='" + box_search.Text + "'";
                    SqlDataAdapter dta = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dta.Fill(dt);
                    dataGridView_menu.DataSource = dt;
                }
            }
            catch(Exception a)
            {
                //do nothing
            }

            try
            {

                cmd.CommandText = "SELECT COUNT(*) FROM MsMenu WHERE Price='" + box_search.Text + "'";
                int priceCount = (int)cmd.ExecuteScalar();
                if (priceCount > 0)
                {
                    //MessageBox.Show("ada di price");

                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM MsMenu WHERE Price='" + box_search.Text + "'";
                    SqlDataAdapter dta = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dta.Fill(dt);
                    dataGridView_menu.DataSource = dt;
                }
            }
            catch (Exception a)
            {
                //do nothing
            }
            try
            {

                cmd.CommandText = "SELECT COUNT(*) FROM MsMenu WHERE Carbo='" + box_search.Text + "'";
                int carboCount = (int)cmd.ExecuteScalar();
                if (carboCount > 0)
                {
                    //MessageBox.Show("ada di carbo");
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM MsMenu WHERE Carbo='" + box_search.Text + "'";
                    SqlDataAdapter dta = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dta.Fill(dt);
                    dataGridView_menu.DataSource = dt;
                }
            }
            catch (Exception a)
            {
                //do nothing
            }
            try
            {

                cmd.CommandText = "SELECT COUNT(*) FROM MsMenu WHERE protein='" + box_search.Text + "'";
                int proteinCount = (int)cmd.ExecuteScalar();

                if (proteinCount > 0)
                {
                    //MessageBox.Show("ada di carbo");
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM MsMenu  WHERE protein='" + box_search.Text + "'";
                    SqlDataAdapter dta = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dta.Fill(dt);
                    dataGridView_menu.DataSource = dt;
                }
            }catch (Exception a)
            {
                //do nothing
            }

        }

        private void box_search_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(box_search.Text) == true)
            {
                displayData();
            }
        }
    }
}
