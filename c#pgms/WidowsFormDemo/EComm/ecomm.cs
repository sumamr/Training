using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EComm
{
    public partial class ecomm : Form
    {
        public ecomm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dis;
            double disresult=0;
            double netAmount = 0; 
            int amt=Convert.ToInt32(pamt.Text);

            if (amt <= 10000)
            {
                if (yes.Checked == true)
                {
                    dis = 10+5;
                }
                else
                    dis = 10;
            }
            else if (amt > 10000 && amt <= 20000)
            {
                if (yes.Checked == true)
                {
                    dis = 20+5;
                }
                else
                    dis = 20;
            }
            else if (amt > 20000 && amt <= 30000)
            {
                if (yes.Checked == true)
                {
                    dis = 30+5;
                }
                dis = 30;
            }
            else
            {
                if (yes.Checked == true)
                {
                    dis = 35 + 5;
                }
                else
                    dis = 35;
            }
            disresult = (amt* dis)/100;
            netAmount = amt - disresult;
          
            purchase.Text = "Purchase Amount: "+amt.ToString();
            discount.Text = "Discount : "+disresult.ToString();
            netamount.Text = "Net Amount :"+netAmount.ToString();
        }

        private void discount_Click(object sender, EventArgs e)
        {

        }
    }
}
