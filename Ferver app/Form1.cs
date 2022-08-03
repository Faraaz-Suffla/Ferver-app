using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferver_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            int temp = Convert.ToInt32(txtboxUserTemp.Text);
            
            if (temp >= 38)
            {
                lblTempDisplay.Text = ("Your temperature is " + temp).ToString();
                MessageBox.Show("Fever Alert!");
            }
            else if (temp < 38)
            {
                lblTempDisplay.Text = ("Your temperature is " + temp).ToString();
                MessageBox.Show("You are fine well.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
