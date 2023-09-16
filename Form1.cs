using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace IlvlCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            string sHead = textBox1.Text.ToString();
            int Head = Convert.ToInt32(sHead);

            string sNeck = textBox1.Text.ToString();
            int Neck = Convert.ToInt32(sNeck);
            int all = 2;
            int sumint = (Head) + (Neck);
            int sumdev = (sumint) / (all);
            string sum = sumint.ToString();

                label20.Text = sum;
                MessageBox.Show(sum);


        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }
            else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
                { }
                else { e.Handled = e.KeyChar != (char)Keys.Back; }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
                { }
                else { e.Handled = e.KeyChar != (char)Keys.Back; }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }
            else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }
            else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }
            else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }
            else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }
            else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }
            else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }
            else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }
            else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }
            else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }
            else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }
            else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }
            else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }
            else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }
    }
    
}
