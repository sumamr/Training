using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocalBusiness
{
    public partial class ServiceProviderDetails : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            Details();
        }
        void Details()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select serviceid as ServiceId,userid as UserId,status as Status,date as Date,rating as Rating,comment as Comment from serviceprovider";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            cmd.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
    }
}