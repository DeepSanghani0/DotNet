using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1.Data
{
    internal class register
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string CPassword { get; set; }

        public int Permission { get; set; }


        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        SqlConnection conn = new SqlConnection(myconnstrng);

        public bool insert(register r)
        {
            bool issuccess = false;

            try
            {
                SqlCommand cmd = new SqlCommand("adduser1", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", r.Name);
                cmd.Parameters.AddWithValue("@Email", r.Email);
                cmd.Parameters.AddWithValue("@Password", r.Password);
                cmd.Parameters.AddWithValue("@Permission", r.Permission);

                conn.Open();

                int success = cmd.ExecuteNonQuery();
                if (success > 0)
                {
                    issuccess = true;
                }
                else
                {
                    issuccess = false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return issuccess;
        }

       
    }
}
