using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxGettingStarted
{
    public partial class ajaxexample2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(FirstNumberTextBox.Text);
            int num2 = int.Parse(SecondNumberTextBox.Text);
            int result = num1 + num2;
            Label3.Text = result.ToString();
            Label3.Visible = true;
        }
    }
}