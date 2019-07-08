using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ordi;

namespace Ordi.App.Test.Utils
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ds = GetDataSet("");

            var list = OrdiConvert.ConvertToModels<User>(ds);
        }

        public DataSet GetDataSet(string sql)
        {
            DataTable table = new DataTable("User");
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Sex", typeof(bool));
            table.Columns.Add("Uid", typeof(Guid));
            table.Columns.Add("Time", typeof(DateTime));
            table.Columns.Add("多出来的属性", typeof(string));
            //table.Columns.Add("SexCode", typeof(int));
            for (int i = 0; i < 50000; i++)
            {
                table.Rows.Add(i, "blqw" + i, true, Guid.NewGuid(), DateTime.Now, "多余的"/*, i % 4 == 0 ? 1 : 2*/);
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(table);
            return ds;
        }
    }
}
