
namespace Курсач_по_методам
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общееКолвоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номерАбонентаПоФамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поСтолбцуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.поСтолбуцToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьНомерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьНомерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(443, 256);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия абонента";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номер телефона";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Год установки телефона";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Наличие задолженности";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.сортировкаToolStripMenuItem1,
            this.сортировкаToolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(532, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общееКолвоToolStripMenuItem,
            this.номерАбонентаПоФамилииToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.сортировкаToolStripMenuItem.Text = "Найти";
            // 
            // общееКолвоToolStripMenuItem
            // 
            this.общееКолвоToolStripMenuItem.Name = "общееКолвоToolStripMenuItem";
            this.общееКолвоToolStripMenuItem.Size = new System.Drawing.Size(379, 22);
            this.общееКолвоToolStripMenuItem.Text = "Общее кол-во абонентов, установленных в диапозоне:";
            this.общееКолвоToolStripMenuItem.Click += new System.EventHandler(this.общееКолвоToolStripMenuItem_Click);
            // 
            // номерАбонентаПоФамилииToolStripMenuItem
            // 
            this.номерАбонентаПоФамилииToolStripMenuItem.Name = "номерАбонентаПоФамилииToolStripMenuItem";
            this.номерАбонентаПоФамилииToolStripMenuItem.Size = new System.Drawing.Size(379, 22);
            this.номерАбонентаПоФамилииToolStripMenuItem.Text = "Номер по фамилии абонента";
            this.номерАбонентаПоФамилииToolStripMenuItem.Click += new System.EventHandler(this.номерАбонентаПоФамилииToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem1
            // 
            this.сортировкаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поСтолбцуToolStripMenuItem});
            this.сортировкаToolStripMenuItem1.Name = "сортировкаToolStripMenuItem1";
            this.сортировкаToolStripMenuItem1.Size = new System.Drawing.Size(88, 20);
            this.сортировкаToolStripMenuItem1.Text = "Задолжники";
            this.сортировкаToolStripMenuItem1.Click += new System.EventHandler(this.сортировкаToolStripMenuItem1_Click);
            // 
            // поСтолбцуToolStripMenuItem
            // 
            this.поСтолбцуToolStripMenuItem.Name = "поСтолбцуToolStripMenuItem";
            this.поСтолбцуToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.поСтолбцуToolStripMenuItem.Text = "Таблица задолжников";
            this.поСтолбцуToolStripMenuItem.Click += new System.EventHandler(this.поСтолбцуToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem2
            // 
            this.сортировкаToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поСтолбуцToolStripMenuItem,
            this.изменитьНомерToolStripMenuItem,
            this.удалитьНомерToolStripMenuItem});
            this.сортировкаToolStripMenuItem2.Name = "сортировкаToolStripMenuItem2";
            this.сортировкаToolStripMenuItem2.Size = new System.Drawing.Size(65, 20);
            this.сортировкаToolStripMenuItem2.Text = "Таблица";
            // 
            // поСтолбуцToolStripMenuItem
            // 
            this.поСтолбуцToolStripMenuItem.Name = "поСтолбуцToolStripMenuItem";
            this.поСтолбуцToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.поСтолбуцToolStripMenuItem.Text = "Сортировать по столбцу";
            this.поСтолбуцToolStripMenuItem.Click += new System.EventHandler(this.поСтолбуцToolStripMenuItem_Click);
            // 
            // изменитьНомерToolStripMenuItem
            // 
            this.изменитьНомерToolStripMenuItem.Name = "изменитьНомерToolStripMenuItem";
            this.изменитьНомерToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.изменитьНомерToolStripMenuItem.Text = "Изменить номер";
            this.изменитьНомерToolStripMenuItem.Click += new System.EventHandler(this.изменитьНомерToolStripMenuItem_Click);
            // 
            // удалитьНомерToolStripMenuItem
            // 
            this.удалитьНомерToolStripMenuItem.Name = "удалитьНомерToolStripMenuItem";
            this.удалитьНомерToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.удалитьНомерToolStripMenuItem.Text = "Удалить номер";
            this.удалитьНомерToolStripMenuItem.Click += new System.EventHandler(this.удалитьНомерToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 341);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Органайзер менеджера по учету телефонных абонентов";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поСтолбцуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem поСтолбуцToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общееКолвоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьНомерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьНомерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номерАбонентаПоФамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

