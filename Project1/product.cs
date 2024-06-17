using Project1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }


        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        SqlConnection conn = new SqlConnection(myconnstrng);
        public string Email { get; set; }

        public void clear()
        {
            txtProductName.Text = "";
            txtPrice.Text = "";
            dtpMDate.Text = "";
            txtPId.Text = "";
        }
        private void pictureclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        productsmethod pm = new productsmethod();
       

        private void btnInsert_Click(object sender, EventArgs e)
        {
            pm.ProductName = txtProductName.Text;
            pm.Price = txtPrice.Text;
            pm.MDate = dtpMDate.Text;

            bool success = pm.insert(pm);
            if (success)
            {
                MessageBox.Show("Product Add Successfully");
                DataTable dt = pm.select();
                dgvProduct.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add product");
            }
        }

        private void product_Load(object sender, EventArgs e)
        {
            UserName.Text = Email;

            DataTable dt = pm.select();
            dgvProduct.DataSource = dt;

            try
            {

                string sql = "Select permission from register where Email = @Email";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Email", Email);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string Permission = reader.GetValue(0).ToString();
                    
                    

                    if(Permission == "2")
                    {
                        btnUpdate.Hide();
                        btnDelete.Hide();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { conn.Close(); }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pm.ProductName = txtProductName.Text;
            pm.Price = txtPrice.Text;
            pm.MDate = dtpMDate.Text;
            pm.ProductId = int.Parse(txtPId.Text);

            bool success = pm.update(pm);
            if (success)
            {
                MessageBox.Show("Product Update Successfully");
                DataTable dt = pm.select();
                dgvProduct.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to update product");
            }
        }

        private void dgvProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtPId.Text = dgvProduct.Rows[rowIndex].Cells[0].Value.ToString();
            txtProductName.Text = dgvProduct.Rows[rowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgvProduct.Rows[rowIndex].Cells[2].Value.ToString();
            dtpMDate.Text = dgvProduct.Rows[rowIndex].Cells[3].Value.ToString();
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pm.ProductId = int.Parse(txtPId.Text);

            bool success = pm.delete(pm);
            if (success)
            {
                MessageBox.Show("Product delete Successfully");
                DataTable dt = pm.select();
                dgvProduct.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to delete product");
            }
        }
    }
}
