using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EContact.EcontactClasses
{
    class contactClass
    {

        public int ContactId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ContactNo { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        //Selection Data From DAtaBase
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

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


            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //Inserting Data Into DataBase

        public bool Insert(contactClass c)
        {

            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {

                string sql = "Insert into tbl_Contact (FirstName,LastName,ContactNo,Address,Gender) values(@FirstName,@LastName,@ContactNo,@Address,@Gender)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess=false;
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

            return isSuccess;
        }


        //Updating Data into DataBase

        public bool Update(contactClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "update tbl_Contact set FirstName = @FirstName, LastName = @LastName, ContactNo = @ContactNo, Address = @Address, Gender = @Gender where ContactId = @ContactId";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactId", c.ContactId);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close ();
            }
            return isSuccess;
        }


        //Delete Data From DataBase

        public bool delete(contactClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "delete from tbl_Contact where ContactId = @ContactId";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ContactId", c.ContactId);

                conn.Open ();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conn.Close (); 
            }

            return isSuccess;
        
        }


    }
}
