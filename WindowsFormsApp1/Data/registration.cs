using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Data
{
    internal class registration
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public string DateOfBirth { get; set; }

        public string Address { get; set; }

        public string City { get; set; }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        SqlConnection conn = new SqlConnection(myconnstring);



        //Insert Data
        public bool insert(registration r)
        {
             bool issuccess = false;

            try
            {
                string sql = "insert into Registration(FirstName,LastName,Mobile,Email,Gender,DateOfBirth,Address,City) values(@FirstName,@LastName,@Mobile,@Email,@Gender,@DateOfBirth,@Address,@City)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FirstName", r.FirstName);
                cmd.Parameters.AddWithValue("@LastName", r.LastName);
                cmd.Parameters.AddWithValue("@Mobile", r.Mobile);
                cmd.Parameters.AddWithValue("@Email", r.Email);
                cmd.Parameters.AddWithValue("@Gender", r.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", r.DateOfBirth);
                cmd.Parameters.AddWithValue("@Address", r.Address);
                cmd.Parameters.AddWithValue("@City", r.City);

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


        //Select data
        public DataTable select()
        {
            DataTable dt = new DataTable();

            try

            {
                string sql = "select * from Registration";

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



        // Update Data
        public bool update(registration r)
        {
            bool issuccess = false;

            try
            {
                string sql = "update Registration set FirstName = @FirstName,LastName =@LastName,Mobile= @Mobile,Email = @Email,Gender = @Gender,DateOfBirth = @DateOfBirth,Address = @Address,City = @City where Id = @Id ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FIrstName", r.FirstName);
                cmd.Parameters.AddWithValue("@LastName", r.LastName);
                cmd.Parameters.AddWithValue("@Mobile", r.Mobile);
                cmd.Parameters.AddWithValue("@Email", r.Email);
                cmd.Parameters.AddWithValue("@Gender", r.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", r.DateOfBirth);
                cmd.Parameters.AddWithValue("@Address", r.Address);
                cmd.Parameters.AddWithValue("@City", r.City);
                cmd.Parameters.AddWithValue("@Id", r.Id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
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
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            return issuccess;
        }

        //Delete Data
        public bool delete(registration r)
        {
            bool issuccess = false;

            try
            {
                string sql = "delete from Registration where Id = @Id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Id", r.Id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
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
    