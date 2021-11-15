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
    public partial class Theme : Form
    {
       
        public Theme()
        {
            InitializeComponent();
        }
        MySql.Data.MySqlClient.MySqlConnection connection = Program.connection;

       
        protected System.Data.DataTable TestDataTable;
        protected System.Data.DataSet TestDataSet;

        private void Theme_Load(object sender, EventArgs e)
        {
            
         
            System.String cmd = "SELECT * FROM materials";
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
                ad.Fill(TestDataTable);
             
              
                IEnumerable<DataRow> query =
                from testdata in TestDataTable.AsEnumerable()
                where testdata.Field<int>("Theme") == 1
                select testdata;
                DataTable ViewTable = query.CopyToDataTable<DataRow>();
               
                foreach (string a in ViewTable.AsEnumerable().Select(r => r.Field<string>("Text")).ToArray())
                {
                    textBox1.Text += a;
                }

                //MySqlCommand command = connection.CreateCommand();
                //command.CommandText = cmd;
             
                //using (MySqlDataReader reader = command.ExecuteReader())
                //{
                //    while (reader.Read())
                //    {


                //        textBox1.AppendText(reader.GetString(reader.GetOrdinal("Question")));
                           
                       
                //    }
                //}

            }
            catch (Exception er) { MessageBox.Show($"Проблема завантаження даних: {er.Message}. Джерело: {er.Source}"); }



          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
    }
