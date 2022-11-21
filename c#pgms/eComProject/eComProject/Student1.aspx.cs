using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace eComProject
{
    public partial class Student1 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                using (SqlConnection con = new SqlConnection(cs))
                {
                    using (SqlCommand cmd = new SqlCommand("GetStudent"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            GridView2.DataSource = dt;
                           // GridView2.DataBind();

                        }
                    }
                }
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["name"].DefaultValue = ((TextBox)GridView2.FooterRow.FindControl("FooterName")).Text;
            SqlDataSource1.InsertParameters["gender"].DefaultValue = ((DropDownList)GridView2.FooterRow.FindControl("footerddlgender")).Text;
            SqlDataSource1.InsertParameters["class"].DefaultValue = ((TextBox)GridView2.FooterRow.FindControl("FooterClass")).Text;

            int a = SqlDataSource1.Insert();
            if (a > 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Insertion Successfully')</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Insertion failed')</script>");

            }
        }
    }
}