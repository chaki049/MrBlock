﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace normlab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //берем значение из текстбокса и конвертируем его в число:
            int year = Convert.ToInt32(textBox1.Text);
            //вызываем функцию для проверки:
            bool result = DateFunctions.IsLeapYear(year);
            //показываем сообщение пользователю:
            MessageBox.Show(result ? "Високосный" : "Не високосный");

        }
    }
}
