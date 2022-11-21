using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemanagement
{
    public partial class Viewstate : System.Web.UI.Page
    {
        string a, b;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ViewState["user"] != null)
            {
                utextbox.Text = ViewState["user"].ToString();
            }
            if (ViewState["pass"] != null)
            {
                ptextbox.Text = ViewState["pass"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["user"]=utextbox.Text;
            ViewState["pass"]=ptextbox.Text;

            utextbox.Text=string.Empty;
            ptextbox.Text = string.Empty;

            //Response.Redirect("viewstate2.aspx");
        }
    }
}