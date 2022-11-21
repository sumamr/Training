using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_GettingStarted1
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
            string query = "insert into sign values(@name,@email,@pass,@mobile,@dob,@sex,@edu,@loc)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@email", emailtext.Text);
            cmd.Parameters.AddWithValue("@pass", passwordtext.Text);
            cmd.Parameters.AddWithValue("@mobile",mobiletext.Text);
            cmd.Parameters.AddWithValue("@dob",Cal.SelectedDate);
            cmd.Parameters.AddWithValue("@sex",gen.Text);
            String ed;
            if(ug.Checked)
            {
                ed = ug.Text;
            }
            else if(pg.Checked)
            {
                ed=pg.Text;
            }
            else
            {
                ed=others.Text;
            }
            cmd.Parameters.AddWithValue("@edu", ed);
            cmd.Parameters.AddWithValue("@loc",location.Text);
            con.Open();
            int s=cmd.ExecuteNonQuery();
            if(s>0)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('Registration Successfull for  \\nName: " + name.Text + "\\nEmail Id: "+emailtext.Text+"\\nPassword is: " + passwordtext.Text +"\\nMobile: "+mobiletext.Text+"\\nDOB: "+Cal.SelectedDate+"\\nSex: "+gen.Text+"\\nEducation: "+ed+" \\nLocation: "+location.Text+ "');", true);
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
            name.Text=emailtext.Text=passwordtext.Text=mobiletext.Text=gen.Text=" ";
        }

        protected void name_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}