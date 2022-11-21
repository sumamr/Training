using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleinterest
{
    public partial class SimpleInterest : Form
    {
        public SimpleInterest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(principle.Text);
            double r = Convert.ToDouble(roi.Text);
            int t = Convert.ToInt32(time.Text);
            double SI = (p * r * t) / 100;
            si.Text = Convert.ToString(SI);
        }
    }
    }

