using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemanagement
{
    public partial class State2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["user"] != null)
            {
                Response.Write("Welcome " + Application["user"].ToString());
            }
            else
            {
                Response.Redirect("State.aspx");
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("logout.aspx");
        }
    }
}