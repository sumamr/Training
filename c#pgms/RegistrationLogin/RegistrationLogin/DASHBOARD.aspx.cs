using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationLogin
{
    public partial class DASHBOARD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"]!=null)
            {
                Response.Write("Welcome to My Site Mr/Mrs  Name : "+Session["name"]);
            }
            else
            {
                Response.Redirect("LoginForm.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Session["name"]!=null)
            {
                Session["name"] = null;
                Response.Redirect("LoginForm.aspx");
            }
        }
    }
}