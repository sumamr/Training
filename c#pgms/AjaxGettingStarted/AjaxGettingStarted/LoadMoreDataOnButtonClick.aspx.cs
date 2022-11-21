using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AjaxGettingStarted
{
   
    public partial class LoadMoreDataOnButtonClick : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        int num = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                num = 5;
                ViewState["num"] = num;
                BindRepeaterWithDB(num);
            }
        }

        void BindRepeaterWithDB(int NOOfRows)
        {
            int rowCount=GetTotalRowsOfEmpTable();

            if(NOOfRows>rowCount)
            {
                Button1.Visible=false;
            }
            SqlConnection con=new SqlConnection(cs);
            string query = "select top(@val) * from emp1";
            SqlDataAdapter sda=new SqlDataAdapter(query,con);
            sda.SelectCommand.Parameters.AddWithValue("@val",NOOfRows);
            DataTable data = new DataTable();
            sda.Fill(data);
            if(data.Rows.Count > 0)
            {
                Repeater1.DataSource=data;
                Repeater1.DataBind();
            }
            else
            {
                Repeater1.DataSource = null;
                          }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int numValue = Convert.ToInt32(ViewState["num"]) + 5;
            BindRepeaterWithDB(numValue);
            ViewState["num"] = numValue;
       }
        int GetTotalRowsOfEmpTable()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select count(*) from emp1";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            int rowCount=Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            return rowCount;
        }
    }
}