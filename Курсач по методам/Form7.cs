using System;
using System.Windows.Forms;

namespace Курсач_по_методам
{
    public partial class Form7 : Form
    {
        internal Form1 form;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < form.Grid.RowCount; i++)
            {
                string fam = Convert.ToString(form.Grid[0, i].Value);
                long nom = Convert.ToInt64(form.Grid[1, i].Value);
                string otv = Convert.ToString(form.Grid[3, i].Value);

                if (otv == "Да")
                {
                    dataGridView1.Rows.Add(fam, nom);
                }
            }
        }
    }
}