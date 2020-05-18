using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tur
{
    public partial class Discont : Form
    {
        public Discont()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tickets f3 = new Tickets();
            this.Hide();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Trip.discount > 0.80)
            {
                Trip.discount = 0.8;
            }
            Finish f5 = new Finish();
            this.Hide();
            f5.ShowDialog();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value>Trip.dorosli)
            {
                numericUpDown1.Value = Trip.dorosli;
               
            }
            Trip.discount = + (0.15 * Convert.ToDouble(numericUpDown1.Value));
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > Trip.dorosli)
            {
                numericUpDown2.Value = Trip.dorosli;
              
            }
            Trip.discount = + (0.20 * Convert.ToDouble(numericUpDown2.Value));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value > Trip.dorosli)
            {
                numericUpDown3.Value = Trip.dorosli;
            }
            Trip.discount = + (0.30 * Convert.ToDouble(numericUpDown3.Value));
                
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value > Trip.dorosli)
            {
                numericUpDown4.Value = Trip.dorosli;
                
            }
            Trip.discount = + (0.10 * Convert.ToDouble(numericUpDown4.Value));
        }

        private void Discont_Load(object sender, EventArgs e)
        {

        }
    }
}
