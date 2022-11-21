using AjaxControlToolkit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LocalBusiness
{
    public partial class myservices : System.Web.UI.Page
    {
        static string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            showall();
        }
        void showall()
        {
            SqlConnection con=new SqlConnection(cs);
            string query = "select users.name as Name,services.Id,services.name as ServiceName,description,status from users cross join services where users.roleid=3";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable data=new DataTable();
            cmd.Fill(data);
            GridView1.DataSource=data;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Rating1_Click(object sender, AjaxControlToolkit.RatingEventArgs e)
        {
            Label1.Text = "You gave us  " + e.Value.ToString() + " Stars ";
            Label1.Visible = true;
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "click to select serviceprovider.";
            }
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("gray");
                    row.ToolTip = String.Empty;
                    String sid;
                    sid = row.Cells[2].Text;
                   
                    
                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to slect this row";



                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            foreach (GridViewRow row in GridView1.Rows)
            {
                bool select1 = Convert.ToBoolean(GridView1.SelectedIndex);
                if (select1)
                {
                    SqlConnection con = new SqlConnection(cs) ;

                    string query = "update serviceprovider set rating = @rating,comment =@comment where serviceid = @sid";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@sid", row.Cells[1].Text);
                    cmd.Parameters.AddWithValue("@rating", DropDownList1.SelectedValue);
                    cmd.Parameters.AddWithValue("@comment", TextBox1.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                }
                break;
            }
           // Message.show("Rating Successfully");
        }
    }
}