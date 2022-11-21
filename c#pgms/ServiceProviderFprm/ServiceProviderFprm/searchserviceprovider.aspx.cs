using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.UI.HtmlControls;

namespace ServiceProviderFprm
{
    public partial class searchserviceprovider : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            AllData();
        }
        void searchByservicetype()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from serviceprovider where servicetype like '%"+TextBox2.Text.Trim()+"%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@servicet", TextBox2.Text);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
        void location()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from serviceprovider where location like '%"+TextBox2.Text.Trim()+"%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //sda.SelectCommand.Parameters.AddWithValue("@loc", TextBox2.Text);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
        void AllData()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from serviceprovider";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

       
        protected void Button1_Click(object sender, EventArgs e)
        {
           
            if(DropDownList1.SelectedIndex==0)
            {
                searchByservicetype();
            }
            
            else if(DropDownList1.SelectedIndex==1)
            {
                location();
            }
            else
            {
                AllData();
            }

            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("serviceprovider.aspx");
        }
    }
}