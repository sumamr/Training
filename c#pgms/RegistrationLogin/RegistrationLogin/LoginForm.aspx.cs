using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationLogin
{
    public partial class LoginForm : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from users where name = @nam and password = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nam",nametextbox.Text);
            cmd.Parameters.AddWithValue("@pass",passwordtextbox.Text);
            con.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            if(dr.HasRows)
            {
                Session["name"]=nametextbox.Text;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Login Successfully !!')</script>");

                Response.Redirect("DASHBOARD.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Login Failed ,,New User Please Register !!')</script>");
            }
        }
    }
}