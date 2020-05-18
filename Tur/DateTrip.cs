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
    public partial class DateTrip : Form
    {
        public DateTrip()
        {
            InitializeComponent();
        }

        private void DateOfTrip_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Trip.d1 = new DateTime();
            Trip.d2 = new DateTime();

            Trip.d1 = dateTimePicker1.Value;
            Trip.d2 = dateTimePicker2.Value;
            TimeSpan tDay = Trip.d2 - Trip.d1;

            string nCountDay = tDay.Days.ToString();
            double intDay = Convert.ToDouble(nCountDay);
            Trip.days = (int)intDay;
            label1.Text = "Кількість днів: " + nCountDay;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Country f1 = new Country();
            this.Hide();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            Tickets f3 = new Tickets();
            this.Hide();
            f3.Show();
        }
    }
}
