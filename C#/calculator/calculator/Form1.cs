using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kadai01
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.result.Text = "";
            this.calResult.Text = "";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            String result = (Convert.ToInt32(this.inputBox1.Text) + Convert.ToInt32(this.inputBox2.Text)).ToString();
            String cal = "+";
            calPrint(cal,result);
        }
        private void minus_Click(object sender, EventArgs e)
        {
            String result = (Convert.ToInt32(this.inputBox1.Text) - Convert.ToInt32(this.inputBox2.Text)).ToString();
            String cal = "-";
            calPrint(cal,result);
        }

        private void times_Click(object sender, EventArgs e)
        {
            String result = (Convert.ToInt32(this.inputBox1.Text) * Convert.ToInt32(this.inputBox2.Text)).ToString();
            String cal = "*";
            calPrint(cal,result);
        }

        private void divided_Click(object sender, EventArgs e)
        {
            String cal ="";
            String result = "";
            if (((this.inputBox1.Text).Equals("0")) || ((this.inputBox2.Text).Equals("0")))
            {
                cal = "0";
                result = "0で割ることができません。";
            }
            else
            {
                cal = "/";
                result = (Convert.ToInt32(this.inputBox1.Text) / Convert.ToInt32(this.inputBox2.Text)).ToString();
            }
            calPrint(cal,result);
        }

        //表示メソッド
        private void calPrint(String cal,String result)
        {
            this.result.Text = result;
            if (cal.Equals("+"))
            {
                this.calResult.Text = this.inputBox1.Text + "+" + this.inputBox2.Text;
            }
            else if(cal.Equals("-"))
            {
                this.calResult.Text = this.inputBox1.Text + "-" + this.inputBox2.Text;
            }
            else if (cal.Equals("*"))
            {
                this.calResult.Text = this.inputBox1.Text + "×" + this.inputBox2.Text;
            }
            else if (cal.Equals("/"))
            {
                this.calResult.Text = this.inputBox1.Text + "÷" + this.inputBox2.Text;
            }
            else if (cal.Equals("0"))
            {
                this.calResult.Text = "";
            }
        }
    }
}
