using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocalBusiness
{
    public partial class Registration : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int userId = 0;
            string constr = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Insert_User"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", ntextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", etextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Mobile",mtextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@City",ctextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Location",ltextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", atextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@ZipCode",ztextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password",ptextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@roleid", DropDownList1.SelectedValue.Trim());
                        cmd.Connection = con;
                        con.Open();
                        userId = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                    }
                }
                string message = string.Empty;
                switch (userId)
                {
                    case -1:
                        message = "Username already exists.\\nPlease choose a different username.";
                        break;
                    case -2:
                        message = "Supplied email address has already been used.";
                        break;
                    default:
                        message = "Registration successful.\\nUser Id: " + userId.ToString();
                        break;
                }
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('" + message + "');", true);
            }
        }
        
    }
}