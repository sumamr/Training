using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxGettingStarted
{
    public partial class Ratingcontrol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Rating2_Click(object sender, AjaxControlToolkit.RatingEventArgs e)
        {
            Label1.Text="You gave us  "+e.Value.ToString()+" Stars ";
            Label1.Visible=true;
        }
    }
}