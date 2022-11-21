using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettingStarted
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int res = 0;
            int n1=Convert.ToInt32(num1.Text);
            string ops = opr.Text;
            int n2=Convert.ToInt32(num2.Text);
            if (ops == "+")
            {
                res = n1 + n2;
            }
            else if (ops == "-")
            {
                res = n1 - n2;
            }
            else if (ops == "*")
            {
                res = n1 * n2;
            }
            else if (ops == "/")
            {
                res = n1 / n2;
            }
            else
                res = -1;
            result1.Text = res.ToString();
        }
        
    }
}
