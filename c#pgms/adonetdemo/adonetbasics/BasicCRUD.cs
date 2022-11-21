using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetbasics
{
    public  class BasicCRUD
    {
        internal static SqlConnection GetConnection()
        {
            string cs= "Data Source=FWS-LP-5154\\SQLSERVER2019;Initial Catalog=demodb;Integrated Security=true; "; 
            SqlConnection conn = new SqlConnection(cs);
            
            try
            {
                conn.Open();
                if(conn.State==System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connection has been created successfully");
                }
                else
                {
                    Console.WriteLine("Failed to establish the connection");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //conn.Close();
            }
            return conn;
        }
        internal static void ReadData()
        {
            string query = "select * from product";
            SqlConnection con = GetConnection();    
            SqlCommand cmd=new SqlCommand(query, con);  
            SqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine("ProductId : " + dr[0]+"Product Name : " + dr[1] +"SupplierId : "+ dr[2] +"ShipperId : "+ dr[3] +"Price : " + dr[4]);
            }
            con.Close();
        }
        internal static void InsertData()
        {
            string query = "insert into product values(11,'Perfume',101,4,20)";
            SqlConnection conn = GetConnection();
            SqlCommand cmd=new SqlCommand(query,conn);
            int status = cmd.ExecuteNonQuery();
            if(status>0)
            {
                Console.WriteLine("Insertion Successfully");
            }
            else
            {
                Console.WriteLine("Insertion Failed");
            }
            //conn.Close();
        }
        internal static void UpdateData()
        {
            Console.WriteLine("Update Data");
            Console.WriteLine("Enter ProductId to update price");
            int ProductId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter updated price");
             decimal price=Convert.ToDecimal(Console.ReadLine());
            string query = "update product set price=@price where ProductId=@ProductId";
            SqlConnection conn=GetConnection();
            SqlCommand cmd=new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.Parameters.AddWithValue("@price", price);
            int status=cmd.ExecuteNonQuery();   
            if(status>0)
            {
                Console.WriteLine("Updates successfully");
                    
            }
            else
            {
                Console.WriteLine("Updation Failed");
            }
          //  conn.Close();
        }
        internal static void DeleteData()
        {
            Console.WriteLine("Delete Data");
            Console.WriteLine("Enter Quantity to delete the data");
            int val=Convert.ToInt32(Console.ReadLine());
            string query = "delete from OrderDetails where Quantity=@val";
            SqlConnection con=GetConnection();
            SqlCommand cmd=new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@val", val);
            int status=cmd.ExecuteNonQuery();
            if( status>0 )
            {
                Console.WriteLine("Deleted successfully");
            }
            else
            {
                Console.WriteLine("Deletiion failed");
            }
            con.Close();
        }
    }
}
