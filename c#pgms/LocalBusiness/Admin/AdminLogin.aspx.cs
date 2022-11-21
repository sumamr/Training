using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocalBusiness
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login2_Authenticate(object sender, AuthenticateEventArgs e)
        {
            
            
            Response.Redirect("~/manageServices.aspx");
        }
    }
}