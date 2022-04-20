using NUnit.Framework;
using System;
using System.Threading;
using System.Windows.Forms;
using Курсач_по_методам;

namespace TestProject2
{
    public class Tests
    {
        internal Form1 form = new Form1();
       

        [Test]
        public void Test1()
        {

            string field1;
            long field2;
            int field3;
            int field4;
           
            int length;
            DataGridViewCellCollection cells;

            ///Add

            field1 = "TestName1";
            field2 = 89887676445;
            field3 = 2021;
            field4 = 0;
            
            length = form.Grid.Rows.Count;

            form.Grid.Rows.Add(field1, field2,  field3, Form1.DEBT[field4]);

            Assert.AreEqual(length + 1, form.Grid.Rows.Count);

            cells = form.Grid.Rows[length].Cells;

            Assert.AreEqual(field1, Convert.ToString(cells[0].Value));
            Assert.AreEqual(field2, Convert.ToInt64(cells[1].Value));         
            Assert.AreEqual(field3, Convert.ToUInt32(cells[2].Value));
            Assert.AreEqual(Form1.DEBT[field4], Convert.ToString(cells[3].Value));


            ///Edit

            field1 = "TestName3";
            field2 = 89897678956;
            field3 = 2018;
            field4 = 1;         

            form.Grid.Rows[length].Cells[0].Value = field1;
            form.Grid.Rows[length].Cells[1].Value = field2;
            form.Grid.Rows[length].Cells[2].Value = field3;
            form.Grid.Rows[length].Cells[3].Value = Form1.DEBT[field4];

            cells = form.Grid.Rows[length].Cells;

            Assert.AreEqual(field1, Convert.ToString(cells[0].Value));
            Assert.AreEqual(field2, Convert.ToInt64(cells[1].Value));
            Assert.AreEqual(field3, Convert.ToUInt32(cells[2].Value));
            Assert.AreEqual(Form1.DEBT[field4], Convert.ToString(cells[3].Value));

            ///Remove

            form.Grid.Rows.RemoveAt(length);

            Assert.AreEqual(length, form.Grid.Rows.Count);
        }
    }
}