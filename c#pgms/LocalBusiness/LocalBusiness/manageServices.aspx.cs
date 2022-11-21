using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows;

namespace LocalBusiness
{
    public partial class manageServices : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           add();
        }
        void add()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select name as ServiceName,description as Comment,status as Status from services";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            cmd.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into services values(@nam,@description,@status)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nam", DropDownList1.Text);
            cmd.Parameters.AddWithValue("@description", TextBox1.Text);
            cmd.Parameters.AddWithValue("@status", "I");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Service added Successfully");
        }
    }
}