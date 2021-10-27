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

namespace Coursach{       
    public partial class TestForm : Form
    {   int _pageNum = 0;
          int _correct;
        QuestionData Question = new QuestionData();
        protected System.Data.DataTable TestDataTable;
        protected System.String cmd = "SELECT * FROM testdata";
        const string DB_CONN_STR = "Server=127.0.0.1;Uid=root;Pwd=;Database=kursach";
      
        public void ShowPage(int pageNum)
        {
            textBox1.Text = Question.question[pageNum];
            radioButton1.Text = Question.variant[0][pageNum];
            radioButton2.Text = Question.variant[1][pageNum];
            radioButton3.Text = Question.variant[2][pageNum];
            radioButton4.Text = Question.variant[3][pageNum];
            _correct = Question.correct[pageNum];
            //for (int i = 0; i < 2; i++)
            //{
            //    textBox1.Text += question[i];
            //}

        }
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(DB_CONN_STR);
            connection.Open();
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd, connection);


            TestDataTable = new System.Data.DataTable();
            ad.Fill(TestDataTable);

            //Sorted DataTable
            IEnumerable<DataRow> query =
            from testdata in TestDataTable.AsEnumerable()
            where testdata.Field<int>("Id") > 1
            select testdata;
            DataTable ViewTable = query.CopyToDataTable<DataRow>();



            Question.question = ViewTable.AsEnumerable().Select(r => r.Field<string>("Question")).ToArray();

            for (int i = 0; i < 4; i++) {
                Question.variant[i] = ViewTable.AsEnumerable().Select(r => r.Field<string>($"Variant{i+1}")).ToArray();
            }
            Question.correct = ViewTable.AsEnumerable().Select(r => r.Field<int>("Correct")).ToArray();

            ShowPage(0);
           


        }       

        private void PreviousButton_Click(object sender, EventArgs e)
        {if (_pageNum < 1)
                return;
        else
            _pageNum--;
            ShowPage(_pageNum);
        }

        private void NextButton_Click(object sender, EventArgs e)
        { if (_pageNum > 8)
                return;
        else
            _pageNum++;
            ShowPage(_pageNum);
        }
    }

}