using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServiceProviderFprm
{
    public partial class servicprovider : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into serviceprovider values(@nam,@emai,@mobil,@service,@add,@loc,@cit,@zipcod)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nam", nametextbox.Text.Trim());
            cmd.Parameters.AddWithValue("@emai", emailtextbox.Text.Trim());
            cmd.Parameters.AddWithValue("@mobil",mobiletextbox.Text.Trim());
            cmd.Parameters.AddWithValue("@service",DropDownList1.Text.Trim());
            cmd.Parameters.AddWithValue("@add", addresstextbox.Text.Trim());
            cmd.Parameters.AddWithValue("@loc",DropDownList2.Text.Trim());
            cmd.Parameters.AddWithValue("@cit",citytextbox.Text.Trim());
            cmd.Parameters.AddWithValue("@zipcod",zipcodetextbox.Text.Trim());
           
            con.Open();
            int s = cmd.ExecuteNonQuery();
            if (s > 0)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('Saved Successfull for  \\nName : " + nametextbox.Text + "\\nEmail: " + emailtextbox.Text + "\\nMobile : " + mobiletextbox.Text + "\\nService Type : " + DropDownList1.SelectedValue + "\\nAddress :" + addresstextbox.Text + "\\nLocation : "+DropDownList2.SelectedValue +"\\nCity : "+citytextbox.Text+"\\nZipCode :"+zipcodetextbox.Text+"');", true);
                ClearControls();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert(' Failed !!')</script>");
            }
            con.Close();
        }
        void ClearControls()
        {
            nametextbox.Text= emailtextbox.Text= " ";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into serviceprovider values(@nam,@emai,@mobil,@service,@add,@loc,@cit,@zipcod)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nam", nametextbox.Text);
            cmd.Parameters.AddWithValue("@emai", emailtextbox.Text);
            cmd.Parameters.AddWithValue("@mobil", mobiletextbox.Text);
            cmd.Parameters.AddWithValue("@service", DropDownList1.Text);
            cmd.Parameters.AddWithValue("@add", addresstextbox.Text);
            cmd.Parameters.AddWithValue("@loc", DropDownList2.Text);
            cmd.Parameters.AddWithValue("@cit", citytextbox.Text);
            cmd.Parameters.AddWithValue("@zipcod", zipcodetextbox.Text);

            con.Open();
            int s = cmd.ExecuteNonQuery();
            if (s > 0)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('Saved Successfull for  \\nName : " + nametextbox.Text + "\\nEmail: " + emailtextbox.Text + "\\nMobile : " + mobiletextbox.Text + "\\nService Type : " + DropDownList1.SelectedValue + "\\nAddress :" + addresstextbox.Text + "\\nLocation : " + DropDownList2.SelectedValue + "\\nCity : " + citytextbox.Text + "\\nZipCode :" + zipcodetextbox.Text + "');", true);
                ClearControls();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert(' Failed !!')</script>");
            }
            con.Close();
        }
        void clearControls()
        {
            nametextbox.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("searchserviceprovider.aspx");
        }
    }
}