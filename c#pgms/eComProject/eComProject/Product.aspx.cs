using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eComProject
{
    public partial class Product : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void productButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into products values(@code,@nam,@description,@manufacturer,@price)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@code", codetextbox.Text);
            cmd.Parameters.AddWithValue("@nam", nametextbox.Text);
            cmd.Parameters.AddWithValue("@description", desctextbox.Text);
            cmd.Parameters.AddWithValue("@manufacturer", mtextbox.Text);
            cmd.Parameters.AddWithValue("@price", pricetextbox.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('Registration Successfull for  \\nCode : " + codetextbox.Text + "\\nName: " + nametextbox.Text + "\\nDescription : " + desctextbox.Text + "\\nManufacturer : " + mtextbox.Text + "\\nPrice :" + pricetextbox.Text + "');", true);
                ClearControls();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Registration Failed !!')</script>");
            }
            con.Close();
        }
        void ClearControls()
        {
            nametextbox.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}