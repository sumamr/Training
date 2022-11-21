using adonetbasics;
using System.Data.SqlClient;
internal class Program
{




    private static void Main(string[] args)
    {
       // Console.WriteLine("Hello, World!");
        Console.WriteLine("ADO.NET");
        //Connection();
        //  BasicCRUD.ReadData();
        // BasicCRUD.InsertData();
        // BasicCRUD.UpdateData();
       // BasicCRUD.DeleteData();
      // Employee employee = new Employee();
      //  Employee.EmployeeCRUD();


    }
    static void Connection()
    {
        string cs = "Data Source=FWS-LP-5154\\SQLSERVER2019;Initial Catalog=demodb;Integrated Security=true; ";
        SqlConnection con = new SqlConnection(cs);
        try
        {
            con.Open();
            if (con.State == System.Data.ConnectionState.Open) 
            {
                Console.WriteLine("Connection has been established");
            }
            else
            {
                Console.WriteLine("failed to established the connection");
            }
        }
        catch(SqlException ex)
        {
            Console.WriteLine(ex.Message);  
        }
        finally
        {
            //con.Close();
        }

    }
    

}