using System;
using System.Windows.Forms;

namespace Курсач_по_методам
{
    public partial class Form6 : Form
    {
        internal Form1 form;

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fam = textBox1.Text;
            int count = 0;

            for (int i = 0; i < form.Grid.RowCount; i++)
            {
                string fam1 = (string)form.Grid[0, i].Value;
                if (fam1 == fam)
                {
                    long phone = Convert.ToInt64(form.Grid[1, i].Value);
                    MessageBox.Show("Номер абонента: " + phone);
                    count++;
                }
               
            }
            if (count == 0)
            {
                MessageBox.Show("Такого абонента в списке нет");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
