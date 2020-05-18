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
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTrip f2 = new DateTrip();
            this.Hide();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Trip.name = textBox1.Text;
            Trip.transport = comboBox1.Text;
            
            if (comboBox1.Text == "Літак")
            {
                Trip.pricetransport = 6000;
            }
            else if (comboBox1.Text == "Потяг")
            {
                Trip.pricetransport = 3000;
            }
            else if (comboBox1.Text == "Автобус")
            {
                Trip.pricetransport = 1500;
            }


            Trip.Hotel = comboBox2.Text;
            if (comboBox2.Text == "Radisson Blue")
            {
                Trip.pricetHotel2 = 6000;
            }
            else if (comboBox2.Text == "Hayat")
            {
                Trip.pricetHotel2 = 4000;
            }
            else if (comboBox2.Text == "Zubrovka Hotel")
            {
                Trip.pricetHotel2 = 1000;
            }

            Trip.children = (int)numericUpDown1.Value;
            Trip.dorosli = (int)numericUpDown2.Value;
            if (radioButton1.Checked == true)
            {
                Trip.clas = radioButton1.Text;
                Trip.clasprice = 750;


            }
            if (radioButton2.Checked == true)
            {
                Trip.clas = radioButton2.Text;
                Trip.clasprice = 1250;
            }
            if (radioButton3.Checked == true)
            {
                Trip.clas = radioButton3.Text;
                Trip.clasprice = 3400;
            }
            Trip.price = (((  Trip.days * Trip.clasprice) * Trip.dorosli) + (0.5 * ((  Trip.days * Trip.clasprice) * Trip.children)) + ((Trip.dorosli + (Trip.children * 0.5)) * (Trip.pricetransport+ Trip.pricetHotel2)));
            Trip.discount = 0;
            
            Discont f4 = new Discont();
            this.Hide();
            f4.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Tickets_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
