using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Net.Configuration;
using System.Drawing;
using System.Web.Services.Description;
using System.Windows;
using System.Windows.Documents;

namespace LocalBusiness
{
    public partial class CustomerAfterLogin : System.Web.UI.Page
    {
        static string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                showall();
            }
            else
            {
                BySearch();
            }
            
            
        }
        void BySearch()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select users.name,users.Id as UserId,email,mobile,city,location,address,zipcode,serviceprovider.Id as SPID, services.name as ServiceName,services.Id as ServiceId,description from users cross join services,serviceprovider where users.roleid=3 and services.name=@nam", con);
            cmd.Parameters.AddWithValue("@nam", stextbox.Text);
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            //GridView1.AutoGenerateColumns=false;
            
        }
        void showall()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select users.name,users.Id as UserId,email,mobile,city,location,address,zipcode,serviceprovider.Id as SPID, services.name as ServiceName,services.Id as ServiceId,description from users cross join services,serviceprovider where users.roleid=3";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            cmd.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/myservices.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*foreach (GridViewRow row in GridView1.Rows)
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
            }*/
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BySearch();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach(GridViewRow row in GridView1.Rows)
            {
                bool select1 = Convert.ToBoolean(GridView1.SelectedIndex);
                if(select1)
                {
                    DateTime d = DateTime.UtcNow;
                    SqlConnection con = new SqlConnection(cs);
                    /*string kkpp = $"select Id from serviceprovider where userid=(select Id from users where email={row.Cells[3].Text}) and serviceid=@sid";


                    SqlCommand md = new SqlCommand(kkpp, con);
                    md.Parameters.AddWithValue("@sid", row.Cells[10].Text);
                    con.Open();
                    int kk=md.ExecuteNonQuery();
                    con.Close();*/


                    SqlCommand cmd = new SqlCommand("Insert into servicebooking(date,serviceid,serviceproviderid,userid,description,status,providerdescription)Values(@date,@sid,@spid,@userid,@des,@stat,@prodes)", con);
                    cmd.Parameters.AddWithValue("@date", d);
                    cmd.Parameters.AddWithValue("@sid",row.Cells[11].Text);
                    cmd.Parameters.AddWithValue("@spid", row.Cells[9].Text);
                    cmd.Parameters.AddWithValue("@userid", row.Cells[2].Text);
                    cmd.Parameters.AddWithValue("@des", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@stat", 'A');

                    cmd.Parameters.AddWithValue("@prodes", row.Cells[12].Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                break;

            }
            MessageBox.Show("Booked");
            
          
                }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void suma_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkstatus=(CheckBox)sender;
            GridViewRow row = (GridViewRow)chkstatus.NamingContainer;

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkheader=(CheckBox)GridView1.HeaderRow.FindControl("CheckBox1");
            foreach(GridViewRow row in GridView1.Rows)
            {
                CheckBox chkrow = (CheckBox)row.FindControl("suma");
                if(chkheader.Checked==true)
                {
                    chkrow.Checked = true;

                }
                else
                {
                    chkrow.Checked = false;
                }
            }
        }
    }
    }
