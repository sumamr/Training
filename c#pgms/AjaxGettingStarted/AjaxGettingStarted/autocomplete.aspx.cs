using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace AjaxGettingStarted
{
    public partial class autocomplete : System.Web.UI.Page
    {
       static string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod()]

        public static List<string> GetCompletionList(string prefixText,int count)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from cities where city like @name+'%'";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@name", prefixText);
            List<string> cityNames = new List<string>();
            con.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                cityNames.Add(dr["city"].ToString());
            }
            con.Close();
            return cityNames;
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["user"] = TextBox1.Text;
            Response.Redirect("city.aspx");
        }
    }
}