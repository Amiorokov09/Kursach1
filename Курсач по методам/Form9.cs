using System;
using System.Windows.Forms;

namespace Курсач_по_методам
{
    public partial class Form9 : Form
    {
        internal Form1 form;
        public Form9()
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


            form.Grid.Rows[comboBox1.SelectedIndex].Cells[1].Value = textBox1.Text;
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            long phone = 0;
            string fam = comboBox1.Text;
            for (int i = 0; i < form.Grid.RowCount; i++)
            {
                string fam1 = (string)form.Grid[0, i].Value;
                if (fam1 == fam)
                {
                    phone = Convert.ToInt64(form.Grid[1, i].Value);

                }

            }
            textBox1.Text = Convert.ToString(phone);
        }
    }
}
