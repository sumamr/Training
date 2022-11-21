using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxGettingStarted
{
    public partial class city : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        void showcity()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Test where city=@suma";
            SqlDataAdapter s = new SqlDataAdapter(query,con);
            s.SelectCommand.Parameters.AddWithValue("@suma", ctextbox.Text);
            DataTable data = new DataTable();
            s.Fill(data);
            GridView2.DataSource=data;
            GridView2.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"]!=null)
            {
                Response.Write("Enter  City from below grid view for updation");
            }
            else
            {
                Response.Redirect("autocomplete.aspx");
            }
        }


        protected void ctextbox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            showcity();
        }
    }
}