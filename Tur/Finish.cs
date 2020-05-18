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
    public partial class Finish : Form
    {
        public Finish()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Country f1 = new Country();
            this.Hide();
            f1.Show();
        }

        private void Finish_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Ім'я замовника: " + Trip.name +
                "\nВи обрали: " + Trip.country +
                "\nПочаток подорожі: " + Trip.d1.ToShortDateString() + " кінець подорожі: " + Trip.d2.ToShortDateString() +
                "\nВибраний вами вид транспорту: " + Trip.transport +
                "\nВибраний вами Готел: " + Trip.Hotel +
                "\nВаша подорож триватеме " + Trip.days + " днів." +
                "\nКількість дорослих: " + Trip.dorosli +
                "\nКількість дітей: " + Trip.children +
                "\nЗагальна кількість осіб: " + (Trip.dorosli + Trip.children) +
                "\nКлас подорожі: " + Trip.clas +
                "\nЗагальна вартість (Без урахування знижки): " + Trip.price + " грн." +
                "\nЗнижка: " + (Math.Round(Trip.discount, 2) * 100) + "%" +
                "\nКінечна вартість подорожі: " + (Trip.price - Trip.price * Trip.discount) + " грн.";
               

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
