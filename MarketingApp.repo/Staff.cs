using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using MarketingApp.Model.Staff;


namespace MarketingApp.repo
{
    class Staff
    {
        public static int CreateStaff(SalesPerson salesperson)
        {
            int id;
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2C1HQML\SQLSERVER;Initial Catalog=parseh;Uid=;Pwd=;Connection Timeout=320500;"))
            {
                using (SqlCommand cmd = new SqlCommand("Staff_Create", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param;

                    try
                    {
                        con.Open();
                        param = new SqlParameter("name", salesperson.Name);
                        cmd.Parameters.Add(param);

                        param = new SqlParameter("lastname", salesperson.Lastname);
                        cmd.Parameters.Add(param);

                        param = new SqlParameter("code", salesperson.Code);
                        cmd.Parameters.Add(param);

                        param = new SqlParameter("comission", salesperson.Commission);
                        cmd.Parameters.Add(param);

                        param = new SqlParameter("phone", salesperson.Phone_number);
                        cmd.Parameters.Add(param);

                        param = new SqlParameter("mobile", salesperson.Mobile);
                        cmd.Parameters.Add(param);

                        param = new SqlParameter("address", salesperson.Address);
                        cmd.Parameters.Add(param);

                        id = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (Exception EX)
                    {

                        throw EX;
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open) con.Close();
                    }
                }
            }
            return id;
        }

        public static void UpdateStaff(SalesPerson salesPerson)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2C1HQML\SQLSERVER;Initial Catalog=parseh;Uid=;Pwd=;Connection Timeout=320500;"))
            {
                using (SqlCommand cmd = new SqlCommand("Staff_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param;

                    try
                    {
                        con.Open();
                        param = new SqlParameter("name", salesPerson.Name);
                        cmd.Parameters.Add(param);

                        param = new SqlParameter("lastname", salesPerson.Lastname);
                        cmd.Parameters.Add(param);

                        param = new SqlParameter("code", salesPerson.Code);
                        cmd.Parameters.Add(param);

                        param = new SqlParameter("comission", salesPerson.Commission);
                        cmd.Parameters.Add(param);

                        param = new SqlParameter("phone", salesPerson.Phone_number);
                        cmd.Parameters.Add(param);
                        param = new SqlParameter("mobile", salesPerson.Mobile);
                        cmd.Parameters.Add(param);
                        param = new SqlParameter("address", salesPerson.Address);
                        cmd.Parameters.Add(param);
                      

                        param = new SqlParameter("id", salesPerson.Id);
                        cmd.Parameters.Add(param);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception EX)
                    {

                        throw EX;
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open) con.Close();
                    }
                }
            }
        }

        public static bool DeleteStaff(int id)
        {
            bool completedata = true;
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2C1HQML\SQLSERVER;Initial Catalog=parseh;Uid=;Pwd=;Connection Timeout=320500;"))
            {
                using (SqlCommand cmd = new SqlCommand("Staff_Delete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param;

                    try
                    {
                        con.Open();

                        param = new SqlParameter("id", id);
                        cmd.Parameters.Add(param);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception EX)
                    {

                        completedata = false;
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open) con.Close();
                    }
                }
            }
            return completedata;
        }
    }
}
