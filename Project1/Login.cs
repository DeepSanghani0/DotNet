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
    public partial class Login : Form
    {
        public Login()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("login", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Email",txtEmail.Text);
            cmd.Parameters.AddWithValue("@Password",txtPassword.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Successfully");
                product p = new product();
               
                p.Email = txtEmail.Text;

                p.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");

            }

            conn.Close();

        }
    }
}
