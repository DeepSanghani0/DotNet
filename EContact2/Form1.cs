using EContact2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EContact2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtId.Text = "";
            txtFirstName.Text = "";
            txtlastName.Text = "";
            txtContactno.Text = "";
            txtAddress.Text = "";
            cmbGender.SelectedIndex = 0;
            txtEmail.Text = "";
            dtpDOB.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        registration r = new registration();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            r.FirstName = txtFirstName.Text;
            r.LastName = txtlastName.Text;
            r.ContactNo = txtContactno.Text;
            r.Address = txtAddress.Text;
            r.Gender = cmbGender.Text;
            r.Email = txtEmail.Text;
            r.DateOfBirth = dtpDOB.Text;

            bool success = r.insert(r);
            if (success == true)
            {
                MessageBox.Show("Data Insert Successfully");
                DataTable dt = r.select();
                dgvregis.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add Data");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = r.select();
            dgvregis.DataSource = dt;
        }

        private void btnDelele_Click(object sender, EventArgs e)
        {
            r.Id =Convert.ToInt32(txtId.Text);

            bool issuccess = r.delete(r);
            if (issuccess == true)
            {
                MessageBox.Show("Delete Success");
                DataTable dt = r.select();
                dgvregis.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvregis_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvregis.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvregis.Rows[rowIndex].Cells[1].Value.ToString();
            txtlastName.Text = dgvregis.Rows[rowIndex].Cells[2].Value.ToString();
            txtContactno.Text = dgvregis.Rows[rowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgvregis.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvregis.Rows[rowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dgvregis.Rows[rowIndex].Cells[6].Value.ToString();
            dtpDOB.Text = dgvregis.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            r.Id = int.Parse(txtId.Text);
            r.FirstName = txtFirstName.Text;
            r.LastName = txtlastName.Text;
            r.ContactNo = txtContactno.Text;
            r.Address = txtAddress.Text;
            r.Gender = cmbGender.Text;
            r.Email = txtEmail.Text;
            r.DateOfBirth = dtpDOB.Text;

            bool issuccess = r.update(r);

            if (issuccess == true)
            {
                MessageBox.Show("Update Successfully");
                DataTable dt = r.select();
                dgvregis.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to Update Data");
            }
        }
    }
}
