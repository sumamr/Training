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
    public partial class WebForm1 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into users values(@name,@email,@mobile,@password)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", nametextbox.Text);
            cmd.Parameters.AddWithValue("@email", emailtextbox.Text);
            cmd.Parameters.AddWithValue("@mobile", mobiletextbox.Text);
            cmd.Parameters.AddWithValue("@password", passwordtextbox.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('Registration Successfull for  user: " + nametextbox.Text + " and Password is: " + passwordtextbox.Text + "');", true);
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
            nametextbox.Text = emailtextbox.Text = mobiletextbox.Text = passwordtextbox.Text = cpasswordtextbox.Text = "";
        }
    }
    }
