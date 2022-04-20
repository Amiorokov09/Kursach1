using System;
using System.Windows.Forms;

namespace Курсач_по_методам
{
    public partial class Form10 : Form
    {
        internal Form1 form;
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Поле \"Номер телефона\" пусто.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long count;
            try
            {
                count = Convert.ToInt64(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Поле \"Номер телефона\" должен содержать только числа.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            for (int i = 0; i < form.Grid.RowCount; i++)
            {
                long pt = Convert.ToInt64(form.Grid[1, i].Value);
                if (count == pt)
                {
                    form.Grid.Rows.RemoveAt(i);
                    textBox1.Text = "";

                }

            }
            if (textBox1.Text != "")
            {
                MessageBox.Show("Такого номера нет");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
