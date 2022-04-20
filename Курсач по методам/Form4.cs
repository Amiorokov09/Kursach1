using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсач_по_методам
{
    public partial class Form4 : Form
    {
        internal Form1 form;
        public Form4()
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

             form.Grid.Rows.RemoveAt(comboBox1.SelectedIndex);
             int ind = comboBox1.SelectedIndex;
             comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
             comboBox1.SelectedIndex = Math.Min(ind, comboBox1.Items.Count - 1);
             if (comboBox1.Items.Count == 0)
         
           
           /* string fam = textBox1.Text;
            for (int i = 0; i < form.Grid.Rows.Count; i++)
            {
                string fam1 = Convert.ToString(form.Grid[0, i].Value);
                if (fam == fam1)
                {
                    form.Grid.Rows.RemoveAt(i);
                    textBox1.Text = "";
                }

            }
            if (textBox1.Text != "")
            {
                MessageBox.Show("Такой фамилии нет");
            }*/


            Close();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
