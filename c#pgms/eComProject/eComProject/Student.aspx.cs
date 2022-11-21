using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eComProject
{
    public partial class Student : System.Web.UI.Page
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
                                GridView3.DataSource = dt;
                                GridView3.DataBind();

                            }
                        }
                    }
                }
            
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["name"].DefaultValue=((TextBox)GridView3.FooterRow.FindControl("FooterName")).Text;
            SqlDataSource1.InsertParameters["gender"].DefaultValue = ((DropDownList)GridView3.FooterRow.FindControl("footerddlgender")).Text;
            SqlDataSource1.InsertParameters["class"].DefaultValue=((TextBox)GridView3.FooterRow.FindControl("FooterClass")).Text;

            int a = SqlDataSource1.Insert();
            if(a>0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(),"Scripts","<script>alert('Insertion Successfully')</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Insertion failed')</script>");

            }
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}