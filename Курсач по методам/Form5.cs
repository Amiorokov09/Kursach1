using System;
using System.Windows.Forms;

namespace Курсач_по_методам
{
    public partial class Form5 : Form
    {
        internal Form1 form;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Поле \"Год установки телефона\" пусто.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int date;
            try
            {
                date = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Поле \"Год установки телефона\" должно быть в фортмате даты.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int count = 0;
            int god = 2022;
            for (int i = 0; i < form.Grid.RowCount; i++)
            {

                int tab = Convert.ToInt32(form.Grid[2, i].Value);

                if (god >= date && tab >= date)
                {
                    count++;
                }
                if (god < date)
                {
                    MessageBox.Show("Установленный год не может быть больше нынешнего");
                }

            }
            
            MessageBox.Show("Общее количество телефонов равно: " + count);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
