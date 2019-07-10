using System;
using System.Data;
using System.Windows.Forms;

namespace Ordi.App.Test.Utils
{
    public partial class Form1 : Form
    {
        private IDBInstance Instance { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ds = GetDataSet("");

            var list2 = OrdiConvert.ConvertToModels<User>(ds);
            var list = ds.ToList<User>();
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
            table.Columns.Add("SexCode", typeof(decimal));
            table.Columns.Add("Age", typeof(byte));
            table.Columns.Add("RoleCode", typeof(int));
            for (int i = 0; i < 50000; i++)
            {
                table.Rows.Add(i, "blqw" + i, true, Guid.NewGuid(), DateTime.Now, "多余的", i % 4 == 0 ? 1 : 3, i % 3 == 0 ? 18 : 22, i % 5 == 0 ? 3 : 5);
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(table);
            return ds;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Instance == null)
                Instance = new OracleInstance("Mortal");

            //var list = Instance.Query<MortalLog>("SELECT T1.ID \"Id\", T1.CONTENT \"Content\", T1.CREATION_DATE \"CreationDate\" FROM MORTAL_LOG T1");
            //var list = Instance.Query<MortalLog>("SELECT * FROM MORTAL_LOG");
            var list = Instance.Query<PatientInfo>("SELECT * FROM CIS_PATIENT_INFO");
        }
    }
}
