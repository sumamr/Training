using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace LocalBusiness
{
    public partial class ServiceafterLogin : System.Web.UI.Page
    {
        static string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            showall();
        }
        void showall()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select users.name as CustomerName,email as CustomerEmail,city as CustomerCity,mobile as CustomerContact,location as CustomerLocation,address as CustomerAddress,zipcode as CustomerZipcode,servicebooking.Id as bookid,servicebooking.description as Problem from users cross join servicebooking where roleid = 1";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            cmd.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("gray");
                    row.ToolTip = String.Empty;
                    String sid;
                    sid = row.Cells[7].Text;
                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to slect this row";
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        protected void SButton_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                bool select1 = Convert.ToBoolean(GridView1.SelectedIndex);
                if (select1)
                {
                    SqlConnection con = new SqlConnection(cs);
                    string query = "update servicebooking set status=@stat where id=@id";


                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", row.Cells[7].Text);
                    cmd.Parameters.AddWithValue("@stat", DropDownList1.SelectedValue);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                break;
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "click to select serviceprovider.";
            }
        }
    }
}