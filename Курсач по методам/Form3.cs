using System;
using System.Windows.Forms;

namespace Курсач_по_методам
{
    public partial class Form3 : Form
    {
        internal Form1 form;

        public Form3()
        {
            InitializeComponent();
        }

        internal void SetList()
        {
            object[] rows = new object[form.Grid.Rows.Count];
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = form.Grid.Rows[i].Cells[0].Value;
            }
            comboBox1.Items.AddRange(rows);
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Поле \"Фамилия абонента\" пусто.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (!Form1.ALPHAVIT.Contains(textBox1.Text[i] + string.Empty))
                {
                    MessageBox.Show("Поле \"Фамилия абонента\" может содержать только символы латиницы, кирилицы и дефис.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            catch
            {
                MessageBox.Show("Поле \"Год установки телефона\" должно быть в фортмате даты.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            form.Grid.Rows[comboBox1.SelectedIndex].Cells[0].Value = textBox1.Text;
            form.Grid.Rows[comboBox1.SelectedIndex].Cells[1].Value = textBox2.Text;
            form.Grid.Rows[comboBox1.SelectedIndex].Cells[2].Value = date;
            form.Grid.Rows[comboBox1.SelectedIndex].Cells[3].Value = Form1.DEBT[comboBox2.SelectedIndex];

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = form.Grid.Rows[comboBox1.SelectedIndex];
            textBox1.Text = Convert.ToString(row.Cells[0].Value);
            textBox2.Text = Convert.ToString(row.Cells[1].Value);
            textBox3.Text = Convert.ToString(row.Cells[2].Value);
            comboBox2.SelectedIndex = Array.IndexOf(Form1.DEBT, Convert.ToString(row.Cells[3].Value));

        }
    }
}
