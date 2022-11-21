using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class search : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            bindGridView();
        }
        void bindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from products";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
        void searchByName()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from products where name =@nam";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@nam", searchtextbox.Text);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
        void searchByMan()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from products where manufacturer =@man";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@man", searchtextbox.Text);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection(cs);
           // string query = "select * from products";
           // SqlDataAdapter sda = new SqlDataAdapter(query, con);
           // DataTable data = new DataTable();
          //  sda.Fill(data);
           // GridView1.DataSource = data;
           // GridView1.DataBind();
           if(DropDownList1.SelectedIndex==0)
            {
                searchByName();
            }
            else if(DropDownList1.SelectedIndex==1)
            {
                searchByMan();
            }
            else
            {
                bindGridView();
            }
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedIndex==0)
            {
                searchByName();
            }
            else if(DropDownList1.SelectedIndex == 1)
            {
                searchByMan();
            }
            else
            {
                bindGridView();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}