using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EContact2.Data
{
    internal class registration
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ContactNo { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string DateOfBirth { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        SqlConnection conn = new SqlConnection(myconnstrng);


        public bool insert(registration r)
        {
            bool issuccess = false;


            try
            {
                string sql = "insert into tbl_Contact (FirstName,LastName,ContactNo,Address,Gender,Email,DateOfBirth) values(@FirstName,@LastName,@ContactNo,@Address,@Gender,@Email,@DateOfBirth)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FirstName", r.FirstName);
                cmd.Parameters.AddWithValue("@LastName", r.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", r.ContactNo);
                cmd.Parameters.AddWithValue("@Address", r.Address);
                cmd.Parameters.AddWithValue("@Gender", r.Gender);
                cmd.Parameters.AddWithValue("@Email", r.Email);
                cmd.Parameters.AddWithValue("@DateOfBirth", r.DateOfBirth);

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

        public DataTable select()
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "select * from tbl_Contact";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public bool delete(registration r)
        {
            bool success = false;

            try
            {
                string sql = "delete from tbl_Contact where Id = @Id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Id", r.Id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
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
            return success;
        }


        public bool update(registration r)
        {
            bool success = false;

            try
            {
                string sql = "update tbl_Contact set Firstname = @FirstName ,LastName = @LastName,ContactNo = @ContactNo,Address = @Address,Gender = @Gender,Email = @Email,DateOfBirth = @DateOfBirth where Id = @Id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("FirstName", r.FirstName);
                cmd.Parameters.AddWithValue("@LastName", r.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", r.ContactNo);
                cmd.Parameters.AddWithValue("@Address", r.Address);
                cmd.Parameters.AddWithValue("@Gender", r.Gender);
                cmd.Parameters.AddWithValue("@Email", r.Email);
                cmd.Parameters.AddWithValue("@DateOfBirth", r.DateOfBirth);
                cmd.Parameters.AddWithValue("@Id", r.Id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
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

            return success;
        }
    }
}
