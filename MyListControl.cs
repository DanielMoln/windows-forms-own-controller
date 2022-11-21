using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class MyListControl : UserControl
    {
        int counterValue = 0;

        public int CounterValue => int.Parse(this.lblCounter.Text);

        public MyListControl(MyData data)
        {
            InitializeComponent();
            this.lblCounter.Text = $"{counterValue}";
            this.lblTitle.Text = data.Title;
            this.lblSubTitle.Text = data.SubTitle;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            counterValue++;
            this.lblCounter.Text = $"{counterValue}";
            this.btnMinus.Enabled = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            counterValue--;
            this.lblCounter.Text = $"{counterValue}";
            if (counterValue == 0)
            {
                this.btnMinus.Enabled = false;
            }
        }
    }
}
