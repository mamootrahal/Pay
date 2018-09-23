using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay
{
    public partial class Form2 : Form
    {

        private int fives = 0, fivesi = 0, fours = 0, foursi = 0, threes = 0, threesi = 0, twoes = 0, twoesi = 0, payment;

        private int Input(int toInc, Label label)
        {
            toInc++;
            label.Text = toInc.ToString();
            return toInc;
        }

        private int DeInput(int toDec, Label label)
        {
            toDec--;
            label.Text = toDec.ToString();
            return toDec;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            twoesi = Input(twoesi, label14);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fives = DeInput(fives, label2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fivesi = DeInput(fivesi, label3);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            fours = DeInput(fours, label6);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            foursi = DeInput(foursi, label5);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            threes = DeInput(threes, label11);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            threesi = DeInput(threesi, label9);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            twoes = DeInput(twoes, label15);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            twoesi = DeInput(twoesi, label14);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            payment = fives * 100 + fivesi * 200 + fours * 20 + foursi * 50 + threes * -100 + threesi * -200 +
                      twoes * -200 + twoesi * -400;
            MessageBox.Show("З/П: " + payment);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            fives = 0;
            fivesi = 0;
            fours = 0;
            foursi = 0;
            threes = 0;
            threesi = 0;
            twoes = 0;
            twoesi = 0;
            payment = 0;
            label2.Text = "0";
            label3.Text = "0";
            label6.Text = "0";
            label5.Text = "0";
            label11.Text = "0";
            label9.Text = "0";
            label15.Text = "0";
            label14.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            twoes = Input(twoes, label15);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            threesi = Input(threesi, label9);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            threes = Input(threes, label11);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foursi = Input(foursi, label5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fours = Input(fours, label6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fivesi = Input(fivesi, label3);
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fives = Input(fives, label2);
        }
    }
}
