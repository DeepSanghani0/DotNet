using EContact.EcontactClasses;
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

namespace EContact
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }
        contactClass c = new contactClass();
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;
            c.ContactNo = txtContactNo.Text;
            c.Address = txtAddress.Text;
            c.Gender = cmbGender.Text;

                bool success = c.Insert(c);

            if (success == true)
            {
                MessageBox.Show("Data Add Successfully");
                DataTable dt = c.Select();
                dgvcontact.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Fail to Add new Record");
            }
        }

        private void Econtact_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvcontact.DataSource = dt;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void clear()
        {
            txtContactId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContactNo.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.ContactId = int.Parse(txtContactId.Text);
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;
            c.ContactNo = txtContactNo.Text;
            c.Address = txtAddress.Text;
            c.Gender = cmbGender.Text;

            bool success = c.Update(c);
            if(success == true)
            {
                MessageBox.Show("Update Successfully");
            }
            else
            {
                MessageBox.Show("Failed to Upadte");
            }
            DataTable dt = c.Select();
            dgvcontact.DataSource = dt;

            clear();
        }

        private void dgvcontact_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtContactId.Text = dgvcontact.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvcontact.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvcontact.Rows[rowIndex].Cells[2].Value.ToString();
            txtContactNo.Text = dgvcontact.Rows[rowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgvcontact.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvcontact.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.ContactId = Convert.ToInt32(txtContactId.Text);
            bool Success = c.delete(c);
            if (Success == true)
            {
                MessageBox.Show("Deleted Successfully");
                DataTable dt = c.Select();
                dgvcontact.DataSource = dt;

                clear();
            }
            else
            {
                MessageBox.Show("Failed to delete data");
            }
        }


        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter(" Select * from tbl_Contact where FirstName Like '%" + keyword + "%' or LastName LIKE '%" + keyword + "%' or Address Like '%" + keyword+ "%'  or Id Like '%" + keyword + "%'  or  Mobile Like '%" + keyword + "%'  or  FirstName Like '%\" + keyword + \"%'  or  Email Like '%" + keyword + "%'  City Like '%" + keyword + "%'", conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgvcontact.DataSource= dt;
        }
    }
}
