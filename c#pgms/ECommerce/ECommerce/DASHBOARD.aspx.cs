using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class DASHBOARD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                Response.Write("Welcome to My Site Mr/Mrs : Email " + Session["email"].ToString());
            }
            else
            {
                Response.Redirect("Login.aspx");
            } 
        }

        protected void ProductButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Product.aspx");
        }

        protected void LogOutButton1_Click(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                Session["email"] = null;
                Response.Redirect("Login.aspx");
            }
        }

        protected void SearchButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("search.aspx");
        }
    }
}