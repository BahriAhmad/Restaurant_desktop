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
    public partial class ManageMember : Form
    {
        public ManageMember()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data source =DESKTOP-CPVI968; Initial catalog=Restaurant_1; Integrated security = true;");
        SqlCommand cmd = new SqlCommand();
        string state = "";

        private void ManageMember_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM MsMember";
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            dataGridView_member.DataSource = dt;
        }

        private void ManageMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(state != "update")
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            state = "";
            btn_cancel.Visible = false;
            btn_save.Visible = false;

            btn_delete.Visible = true;
            btn_insert.Visible = true;
            btn_delete.Visible = true;
            btn_update.Visible = true;

            box_id.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (state == "insert")
            {
                if (String.IsNullOrEmpty(box_name.Text) == false &&
                    String.IsNullOrEmpty(box_email.Text) == false &&
                    String.IsNullOrEmpty(box_handphone.Text) == false )
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO MsMember (Name,email,Handphone,JoinDate) " +
                        "values('"+box_name.Text+ "', '" + box_email.Text + "', '" + box_handphone.Text + "', '" + DateTime.Now + "')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT * FROM MsMember";
                    SqlDataAdapter dta = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dta.Fill(dt);
                    dataGridView_member.DataSource = dt;
                    MessageBox.Show("data telah diinsert!");

                }
            }else if (state == "update")
            {
                if (String.IsNullOrEmpty(box_name.Text) == false &&
                   String.IsNullOrEmpty(box_email.Text) == false &&
                   String.IsNullOrEmpty(box_id.Text) == false &&
                   String.IsNullOrEmpty(box_handphone.Text) == false)
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE MsMember SET Name='"+box_name.Text+ "', Email='" + box_email.Text + "'" +
                        " , HandPhone='" + box_handphone.Text + "' WHERE ID='"+box_id.Text+"'";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT * FROM MsMember";
                    SqlDataAdapter dta = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dta.Fill(dt);
                    dataGridView_member.DataSource = dt;
                    MessageBox.Show("data telah diupdate!");

                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            box_id.Enabled = true;
            if (String.IsNullOrEmpty(box_id.Text) == false)
            {
                var result = MessageBox.Show("Apakah anda yakin ingin menghapus menu dengan id='" + box_id.Text + "'?", "perhatian", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM MsMember WHERE ID='" + box_id.Text + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT * FROM MsMember";
                    SqlDataAdapter dta = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dta.Fill(dt);
                    dataGridView_member.DataSource = dt;
                }
            }
        }

        private void box_search_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(box_search.Text) == true)
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM MsMember";
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dta.Fill(dt);
                dataGridView_member.DataSource = dt;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT COUNT(*) FROM MsMember WHERE Name='"+box_search.Text+"'";
                int count = (int)cmd.ExecuteScalar();
                if(count > 0)
                {
                    cmd.CommandText = "SELECT * FROM MsMember WHERE Name='" + box_search.Text + "'";
                    SqlDataAdapter dta = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dta.Fill(dt);
                    dataGridView_member.DataSource = dt;
                }
            }catch (Exception a)
            {
                //do nothing
            }
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT COUNT(*) FROM MsMember WHERE Email='" + box_search.Text + "'";
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    cmd.CommandText = "SELECT * FROM MsMember WHERE Email='" + box_search.Text + "'";
                    SqlDataAdapter dta = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dta.Fill(dt);
                    dataGridView_member.DataSource = dt;
                }
            }
            catch (Exception a)
            {
                //do nothing
            }
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT COUNT(*) FROM MsMember WHERE HandPhone='" + box_search.Text + "'";
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    cmd.CommandText = "SELECT * FROM MsMember WHERE HandPhone='" + box_search.Text + "'";
                    SqlDataAdapter dta = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dta.Fill(dt);
                    dataGridView_member.DataSource = dt;
                }
            }
            catch (Exception a)
            {
                //do nothing
            }
        }
    }
}
