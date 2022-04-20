using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсач_по_методам
{
    public partial class Form8 : Form
    {
        internal Form1 form;

        public Form8()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Grid.Sort(form.Grid.Columns[comboBox1.SelectedIndex], (comboBox2.SelectedIndex == 0) ? ListSortDirection.Ascending : ListSortDirection.Descending);
            for (int i = 0; i < form.Grid.Columns.Count; i++)
                form.Grid.Columns[i].HeaderCell.SortGlyphDirection = SortOrder.None;
            form.Grid.Columns[comboBox1.SelectedIndex].HeaderCell.SortGlyphDirection = (comboBox2.SelectedIndex == 0) ? SortOrder.Ascending : SortOrder.Descending;
        }
    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
