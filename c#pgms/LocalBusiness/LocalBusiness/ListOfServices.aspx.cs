using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace LocalBusiness
{
    public partial class ListOfServices : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                show();
            }
            
        }
        void show()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select name as ServiceName,description as Comment,status as Status from services";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            cmd.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "Insert into services(name,description,status)Values(@nam,@desc,'I')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nam", namtext.Text);
            cmd.Parameters.AddWithValue("@desc", destext.Text);
            cmd.Parameters.AddWithValue("@st", "I");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Service added Successfully");
        }
    }
}