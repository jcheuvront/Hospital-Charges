﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Charges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CalcStayCharges(double days)
        {
            return days * 350;
           
        }

        private double CalcMiscCharges(double med, double surg, double lab, double rehab)
        {
            return med + surg + lab + rehab;

        }


        private void label1_Click(object sender, EventArgs e)
        {

           

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result;
            result = CalcStayCharges(Convert.ToDouble(textBox2.Text));
            label3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double result, med, surg, lab, rehab;
            result = CalcMiscCharges(Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox8.Text));
            label10.Text = result.ToString();
        }
    }
}
