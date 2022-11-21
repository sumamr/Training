using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemanagement
{
    public partial class viewstate2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
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
    }
}