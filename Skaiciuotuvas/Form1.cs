using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skaiciuotuvas
{
    

    public partial class Form1 : Form
    {

        double a = 0;       
        double ats = 0;
        String operacija = " ";

        public Form1()
        {
            InitializeComponent();
        }
               
        private void button10_Click(object sender, EventArgs e)
        {
            if (ekranas.Text == "0")
            {
                ekranas.Clear();
            }
            ekranas.Text = ekranas.Text + "0";
        }
       
        private void ekranas_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekranas.Text == "0")
            {
                ekranas.Clear();
            }
            ekranas.Text = ekranas.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ekranas.Text == "0")
            {
                ekranas.Clear();
            }
            ekranas.Text = ekranas.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ekranas.Text == "0")
            {
                ekranas.Clear();
            }
            ekranas.Text = ekranas.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ekranas.Text == "0")
            {
                ekranas.Clear();
            }
            ekranas.Text = ekranas.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ekranas.Text == "0")
            {
                ekranas.Clear();
            }
            ekranas.Text = ekranas.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ekranas.Text == "0")
            {
                ekranas.Clear();
            }
            ekranas.Text = ekranas.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ekranas.Text == "0")
            {
                ekranas.Clear();
            }
            ekranas.Text = ekranas.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ekranas.Text == "0")
            {
                ekranas.Clear();
            }
            ekranas.Text = ekranas.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ekranas.Text == "0")
            {
                ekranas.Clear();
            }
            ekranas.Text = ekranas.Text + "9";
        }

        private void kablelis_Click(object sender, EventArgs e)
        {
            ekranas.Text = ekranas.Text + ".";
           
        }
       
        private void clear_Click_1(object sender, EventArgs e)
        {
            ekranas.Clear();
            label1.Text=" ";
            ekranas.Text = ekranas.Text + "0";
        }

        private void sudetis1(object sender, EventArgs e) //sudetis
        {
            a = Convert.ToDouble(ekranas.Text);         
            ekranas.Clear();
            operacija = "+";
            label1.Text = Convert.ToString(a+" "+"+");
 
        }
       
        private void atimtis1(object sender, EventArgs e)
        {
           
            a = Convert.ToDouble(ekranas.Text);
            ekranas.Clear();
            operacija = "-";
            label1.Text = Convert.ToString(a +" "+"-");

        }

        private void daugyba1(object sender, EventArgs e)
        {
            a = Convert.ToDouble(ekranas.Text);
            ekranas.Clear();
            operacija = "*";
            label1.Text = Convert.ToString(a +" "+ "*");
        }

        private void dalyba1(object sender, EventArgs e)
        {
            a = Convert.ToDouble(ekranas.Text);
            ekranas.Clear();
            operacija = "/";
            label1.Text = Convert.ToString(a + " "+"/");
        }
        private void lygybe_Click(object sender, EventArgs e)
        {
            if (operacija == "+")
            {
                ats = a + Convert.ToDouble(ekranas.Text);
                ekranas.Text = Convert.ToString(ats);
                label1.Text = " ";
            }
            else if (operacija == "-")
            {
                ats = a - Convert.ToDouble(ekranas.Text);
                ekranas.Text = Convert.ToString(ats);
                label1.Text = " ";
            }
            else if (operacija == "*")
            {
                ats = a * Convert.ToDouble(ekranas.Text);
                ekranas.Text = Convert.ToString(ats);
                label1.Text = " ";
            }
            else
            {
                ats = a / Convert.ToDouble(ekranas.Text);
                ekranas.Text = Convert.ToString(ats);
                label1.Text = " ";
            }

        }

        
    }
}