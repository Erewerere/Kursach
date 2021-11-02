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
    public partial class Registration : Form
    {

        QuestionData Question = new QuestionData();
        protected System.Data.DataTable TestDataTable;
        protected System.Data.DataSet TestDataSet;

        MySql.Data.MySqlClient.MySqlConnection connection = Program.connection;
        List<string> fio = new List<string>();
        List<string> password = new List<string>();
        List<int> id = new List<int>();
        string password1;
        string fio1;
        int lastid= 0;
        private void TestForm_Load(object sender, EventArgs e)
        {
            System.String cmd = "SELECT * FROM users";
            try
            {
                connection.Open();
            }
            catch (Exception) { MessageBox.Show("Неможливо підключитись до бази даних!"); }
            try
            {
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd, connection);              
                TestDataTable = new System.Data.DataTable();              
                ad.Fill(TestDataTable);                            
                 fio = TestDataTable.AsEnumerable().Select(r => r.Field<string>("FIO")).ToList();
                 password = TestDataTable.AsEnumerable().Select(r => r.Field<string>("Password")).ToList();
                  id = TestDataTable.AsEnumerable().Select(r => r.Field<int>("Id")).ToList();
               

            }
            catch (Exception er) { MessageBox.Show($"Проблема завантаження даних: {er.Message}. Джерело: {er.Source}"); }
            lastid = id.Last();

        }
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            password1 = textBox1.Text;
            
        }
    }
}
