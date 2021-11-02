using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Coursach
{
    public partial class Enter : Form
    {
        QuestionData Question = new QuestionData();
        protected System.Data.DataTable TestDataTable;
        protected System.Data.DataSet TestDataSet;

        MySql.Data.MySqlClient.MySqlConnection connection = Program.connection;

        private void TestForm_Load(object sender, EventArgs e)
        {
            System.String cmd = "SELECT * FROM testdata";
            try
            {
                connection.Open();
            }
            catch (Exception) { MessageBox.Show("Неможливо підключитись до бази даних!"); }
            try
            {
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd, connection);

                int theme = Program.ThemeNumber;
                TestDataTable = new System.Data.DataTable();
                TestDataSet = new System.Data.DataSet();
                ad.Fill(TestDataTable);
                //TestDataTable = TestDataSet.Tables["testdata"];
                //Sorted DataTable
                IEnumerable<DataRow> query =
                from testdata in TestDataTable.AsEnumerable()
                where testdata.Field<int>("Theme") != 0
                select testdata;
                DataTable ViewTable = query.CopyToDataTable<DataRow>();
                Question.question = ViewTable.AsEnumerable().Select(r => r.Field<string>("Question")).ToArray();

                for (int i = 0; i < 4; i++)
                {
                    Question.variant[i] = ViewTable.AsEnumerable().Select(r => r.Field<string>($"Variant{i + 1}")).ToArray();
                }
                Question.correct = ViewTable.AsEnumerable().Select(r => r.Field<int>("Correct")).ToArray();
            }
            catch (Exception er) { MessageBox.Show($"Проблема завантаження даних: {er.Message}. Джерело: {er.Source}"); }
            

        }


        public Enter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
