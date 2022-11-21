using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpForm
{
    public partial class SignupForm : System.Windows.Forms.Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nam = name.Text;
            string ema=email.Text;
            long mob=Convert.ToInt64(mobile.Text);
            string se;
            if(sex1.Checked==true)
            {
                se=sex1.Text;
            }
            else
            {
                se=sex2.Text;
            }
            string d=dob.Text;
            string l = location.Text;
            r.Text = "Name : "+nam+" \nEmail : "+ema+" \nMobile : "+mob+" \nSex : "+se+" \nDOB : "+d+" \nLocation : "+l;
        }
    }
}
