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
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Gender;

        
        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        public void clear()
        {
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            cmbCity.SelectedIndex = 0;
            radioMale.Checked = false;
            radioFemale.Checked = false;

        }

        registration r = new registration();
        private void btnInsert_Click(object sender, EventArgs e) 
        {
            r.FirstName = txtFirstName.Text;
            r.LastName = txtLastName.Text;
            r.Mobile = txtMobile.Text;
            r.Email = txtEmail.Text;
            r.Gender = Gender;
            r.DateOfBirth = dtpDOB.Text;
            r.Address = txtAddress.Text;
            r.City = cmbCity.Text;

            bool success = r.insert(r);

            if (success == true)
            {
                MessageBox.Show("Data Add Successfully");

                DataTable dt = r.select();

                dgvRegistration.DataSource = dt;

                clear();
            }
            else
            {
                MessageBox.Show("Failed Data Add");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = r.select();

            dgvRegistration.DataSource = dt;
        }

        private void dgvRegistration_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvRegistration.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvRegistration.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvRegistration.Rows[rowIndex].Cells[2].Value.ToString();
            txtMobile.Text = dgvRegistration.Rows[rowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dgvRegistration.Rows[rowIndex].Cells[4].Value.ToString();
            dtpDOB.Text = dgvRegistration.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dgvRegistration.Rows[rowIndex].Cells[7].Value.ToString();
            cmbCity.Text = dgvRegistration.Rows[rowIndex].Cells[8].Value.ToString();

            if (dgvRegistration.Rows[rowIndex].Cells[5].Value.ToString() == "Male")
            {
                radioMale.Checked = true;
            }
            else
            {
                radioFemale.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            r.Id = int.Parse(txtId.Text);
            r.FirstName = txtFirstName.Text;
            r.LastName = txtLastName.Text;
            r.Mobile = txtMobile.Text;
            r.Email = txtEmail.Text;
            r.DateOfBirth = dtpDOB.Text;
            r.Address = txtAddress.Text;
            r.City = cmbCity.Text;
            r.Gender = Gender;

            bool success = r.update(r);

            if (success == true)
            {
                MessageBox.Show("Update SuccessFully");

            }
            else
            {
                MessageBox.Show("Failed To Update Data");
            }
            DataTable dt = r.select();
            dgvRegistration.DataSource = dt;

            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            r.Id = Convert.ToInt32(txtId.Text);
            bool success = r.delete(r);
            if (success == true)
            {
                MessageBox.Show("Deleted Successfully");
                DataTable dt = r.select();
                dgvRegistration.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to delete data");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }


        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            SqlConnection conn = new SqlConnection(myconnstr);

            SqlDataAdapter sda = new SqlDataAdapter(" Select * from Registration where FirstName Like '%" + keyword + "%' or LastName LIKE '%" + keyword + "%' or Address Like '%" + keyword + "%'  or Id Like '%" + keyword + "%'  or  Mobile Like '%" + keyword + "%'  or  FirstName Like '%\" + keyword + \"%'  or  Email Like '%" + keyword + "%'  ", conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgvRegistration.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
