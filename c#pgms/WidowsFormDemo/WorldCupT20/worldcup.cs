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

namespace WorldCupT20
{
    public partial class worldcup : Form
    {
        public worldcup()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using(con= new SqlConnection(cs))
                {
                    string name = country.Text;
                    int matche=Convert.ToInt32(match.Text);
                    int wo = Convert.ToInt32(won.Text);
                    int los = Convert.ToInt32(lost.Text);
                    int point=Convert.ToInt32(points.Text);

                   string query = "insert into wct2022 values(@name,@matche,@wo,@los,@point)";
                 
                    SqlCommand cmd=new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@matche",matche);
                    cmd.Parameters.AddWithValue("@wo", wo);
                    cmd.Parameters.AddWithValue("@los",los);
                    cmd.Parameters.AddWithValue("@point", point);
                    con.Open();
                    int status = cmd.ExecuteNonQuery();
                    if(status > 0)
                    {
                        result.Text = "Insertion Successfully";
                        
                    }
                    else
                    {
                        result.Text="Insertion failed";
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

        private void reset_Click(object sender, EventArgs e)
        {
             country.Text=" ";
            
        }
    }
}
