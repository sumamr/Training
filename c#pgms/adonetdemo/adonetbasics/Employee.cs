using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetbasics
{
    internal class Employee
    {
        internal static void EmployeeCRUD()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs)) ;
                {
                    Console.WriteLine("Employee Name: ");
                    string name=Console.ReadLine();
                    Console.WriteLine("Employee Gender: ");
                    string gender=Console.ReadLine();
                    Console.WriteLine("Employee Age: ");
                    int age=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Employee Salary: ");
                    decimal salary=Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Employee City: ");
                    string city=Console.ReadLine();


                    string query = "insert into employee_tbl values(@name,@gender,@age,@salary,@city)";
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@salary",salary);
                    cmd.Parameters.AddWithValue("@city",city);
                    con.Open();
                    int status = cmd.ExecuteNonQuery();
                    if(status>0)
                    {
                        Console.WriteLine("Insertion successfully");
                    }
                    else
                    {
                        Console.WriteLine("Insertion Failed");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
