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
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        register r = new register();

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        SqlConnection conn = new SqlConnection(myconnstrng);

        private void pictureclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" || txtEmail.Text != "" || txtPassword.Text != "" || txtCPassword.Text != "")
            {
                if (txtPassword.Text == txtCPassword.Text)
                {
                    string sql = "select * from register where Email = '" + txtEmail.Text + "' ";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        r.Name = txtName.Text;
                        r.Email = txtEmail.Text;
                        r.Password = txtPassword.Text;
                        r.Permission = int.Parse(cmbpermission.Text);

                        bool success = r.insert(r);

                        if (success)
                        {
                            MessageBox.Show("Regisration SuccessFully");
                            Login l = new Login();
                            l.Show();
                        }
                        else
                        {
                            MessageBox.Show("Regisration Failed");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password are not same");
                }
            }
            else
            {
                MessageBox.Show("Please Enter all credential properly");
            }
        }
        private void btnforloginpage_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }
    }
}
