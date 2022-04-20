using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсач_по_методам
{
    public partial class Form2 : Form
    {
        internal Form1 form;

        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim(' ');
            textBox2.Text = textBox2.Text.Trim(' ');
            textBox3.Text = textBox3.Text.Trim(' ');

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Поле \"Фамилия абонента\" пусто.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (!Form1.ALPHAVIT.Contains(textBox1.Text[i] + string.Empty))
                {
                    MessageBox.Show("Поле \"Фамилия абонентаф\" может содержать только символы латиницы, кирилицы и дефис.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Поле \"Номер телефона\" пусто.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long count;
            try
            {
                count = Convert.ToInt64(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Поле \"Номер телефона\" должен содержать только числа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Поле \"Год установки телефона\" пусто.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int date;
            try
            {
                date = Convert.ToInt32(textBox3.Text);
                if (date>2022)
                {
                    MessageBox.Show("Данный год еще не наступил");
                    textBox3.Text = "";
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Поле \"Год установки телефона\" должно быть в фортмате даты.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            form.Grid.Rows.Add(textBox1.Text, textBox2.Text, date, Form1.DEBT[comboBox1.SelectedIndex]) ;
            
            textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
            comboBox1.SelectedIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
