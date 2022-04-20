
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Курсач_по_методам
{
    public partial class Form1 : Form
    {

        internal const string ALPHAVIT = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ-";
        public static readonly string[] DEBT = new string[] { "Да", "Нет" };
        public DataGridView Grid
        {
            get
            {
                return dataGridView1;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            dataGridView1.Rows.Add("Лопачев", 89769435676, 2021, DEBT[0]);
            dataGridView1.Rows.Add("Мнацаканов", 89899997676, 2021, DEBT[1]);
            dataGridView1.Rows.Add("Ярошенко", 89887542467, 2021, DEBT[0]);
            dataGridView1.Rows.Add("Каранов", 89856782345, 2022, DEBT[0]);
            dataGridView1.Rows.Add("Амироков", 89769435676, 2022, DEBT[1]);
            dataGridView1.Rows.Add("Борануков", 89776543457, 2022, DEBT[1]);
            dataGridView1.Rows.Add("Туровец", 89786785643, 2022, DEBT[1]);
            dataGridView1.Rows.Add("Иванов", 89899675429, 2022, DEBT[0]);


        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.form = this;
            form.ShowDialog();
        }
        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("В таблице нет записей, доступных для редактирования.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form3 form = new Form3();
            form.form = this;
            form.SetList();
            form.ShowDialog();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("В таблице нет записей, доступных для удаления.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form4 form = new Form4();
            form.form = this;
            form.SetList();
            form.ShowDialog();
        }
        private void общееКолвоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("В таблице нет записей, доступных для расчёта.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form5 form = new Form5();
            form.form = this;
            form.ShowDialog();


        }
        private void номерАбонентаПоФамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("В таблице нет записей, доступных для поиска.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form6 form = new Form6();
            form.form = this;
            form.ShowDialog();


        }

        private void сортировкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void поСтолбуцToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("В таблице нет записей, доступных для сортировки по столбцу.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form8 form = new Form8();
            form.form = this;
            form.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void изменитьНомерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("В таблице нет записей, доступных для сортировки по столбцу.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form9 form = new Form9();
            form.form = this;
            form.SetList();
            form.ShowDialog();
        }

        private void удалитьНомерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("В таблице нет записей, доступных для сортировки по столбцу.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form10 form = new Form10();
            form.form = this;

            form.ShowDialog();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream st=null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((st = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter wr = new StreamWriter(st);
                    try
                    {
                        for (int i = 0; i < Grid.RowCount; i++)
                        {
                            for (int j = 0; j < Grid.ColumnCount; j++)
                            {
                                string data = Grid.Rows[i].Cells[j].Value.ToString().Replace("^", "[sim]");
                                wr.Write(data + '^');

                            }
                            wr.WriteLine();
                        }
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        wr.Close();
                    }
                    st.Close();
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream st=null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((st = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader rd = new StreamReader(st);
                    string[] pt;
                    int num = 0;
                    try
                    {
                        string[] st1 = rd.ReadToEnd().Split('\n');
                        num = st1.Count();
                        Grid.RowCount = num;
                        for (int i = 0; i < num; i++)
                        {
                            pt = st1[i].Split('^');
                            for (int j = 0; j < Grid.ColumnCount; j++)
                            {
                                try
                                {
                                    string data = pt[j].Replace("[sim]", "^");

                                    Grid.Rows[i].Cells[j].Value = data;
                                }
                                catch
                                {                                   
                                }
                            }                          
                        }
                        Grid.Rows.RemoveAt(Grid.RowCount-1);

                    }
                    
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        rd.Close();
                    }
                }
            }
        }
        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var filepath in fileList)
                {
                    FileStream st = File.OpenRead(filepath);

                    StreamReader rd = new StreamReader(st);
                    string[] pt;
                    int num = 0;
                    try
                    {
                        string[] st1 = rd.ReadToEnd().Split('\n');

                        num = st1.Count();
                        Grid.RowCount = num;
                        for (int i = 0; i < num; i++)
                        {
                            pt = st1[i].Split('^');
                            for (int j = 0; j < Grid.ColumnCount; j++)
                            {
                                try
                                {
                                    string data = pt[j].Replace("[sim]", "^");

                                    Grid.Rows[i].Cells[j].Value = data;
                                }
                                catch 
                                {
                                }
                            }
                        }
                        Grid.Rows.RemoveAt(Grid.RowCount - 1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        rd.Close();
                    }
                }
            }
        }
        private void поСтолбцуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("В таблице нет записей, доступных для поиска.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form7 form = new Form7();
            form.form = this;
            form.ShowDialog();
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


    }
}




