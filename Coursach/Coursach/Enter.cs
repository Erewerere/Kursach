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
        List<string> fio = new List<string>();
        List<string> password = new List<string>();
        string password1;
        string fio1;
        DataTable ViewTable;

        MySql.Data.MySqlClient.MySqlConnection connection = Program.connection;

        private void Enter_Load(object sender, EventArgs e)
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
                
            }
            catch (Exception er) { MessageBox.Show($"Проблема завантаження даних: {er.Message}. Джерело: {er.Source}"); }
            

        }


        public Enter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();

        }

        private bool check()
        {
          

            foreach( DataRow d in TestDataTable.AsEnumerable())
            {              
                if (d.Field<string>("FIO") == fio1)
                {
                    User.fio = d.Field<string>("Fio");
                    User.id = d.Field<int>("Id");
                    return true;
                }
                
            }         
            return false;
      
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            password1 = textBox1.Text;
            fio1 = textBox2.Text;
           if(check()==true)
            {
                
                new Main().Show();
              
            }
        }
    }
}
