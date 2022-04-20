using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Threading;
using System.Windows.Forms;
using Курсач_по_методам;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestProject1
{
    public class Tests
    {
        private Form1 form = new Form1();
        [TestMethod]
        private void run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(form);
        }
        
        public void AddEditRemove()
        {
            new Thread(run).Start();

            string field1;
            long field2;
            int field3;
            int field4;

            int length;
            DataGridViewCellCollection cells;

            ///Add

            field1 = "TestName1";
            field2 = 89887686876;
            field3 = 2018;
            field4 = 1;


            length = form.Grid.Rows.Count;

            form.Grid.Rows.Add(field1, field2, Form1.DEBT[field3], field4);

            Assert.AreEqual(length + 1, form.Grid.Rows.Count);

            cells = form.Grid.Rows[length].Cells;

            Assert.AreEqual(field1, Convert.ToString(cells[0].Value));
            Assert.AreEqual(field2, Convert.ToString(cells[1].Value));
            Assert.AreEqual(field3, Convert.ToUInt64(cells[2].Value));
            Assert.AreEqual(Form1.DEBT[field4], Convert.ToString(cells[3].Value));


            ///Edit

            field1 = "TestName2";
            field2 = 89887765457;
            field3 = 2019;
            field4 = 0;

            form.Grid.Rows[length].Cells[0].Value = field1;
            form.Grid.Rows[length].Cells[1].Value = field2;
            form.Grid.Rows[length].Cells[2].Value = field3;
            form.Grid.Rows[length].Cells[3].Value = Form1.DEBT[field4];


            cells = form.Grid.Rows[length].Cells;

            Assert.AreEqual(field1, Convert.ToString(cells[0].Value));
            Assert.AreEqual(field2, Convert.ToString(cells[1].Value));
            Assert.AreEqual(field3, Convert.ToUInt64(cells[3].Value));
            Assert.AreEqual(Form1.DEBT[field4], Convert.ToString(cells[3].Value));


            ///Remove

            form.Grid.Rows.RemoveAt(length);

            Assert.AreEqual(length, form.Grid.Rows.Count);
        }

    } 
}