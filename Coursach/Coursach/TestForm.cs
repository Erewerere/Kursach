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
    { int _pageNum = 0;
          int _correct;
        static int _amount = Program.AmountOfQuestion;      
        int [] _points = new int[_amount];

        //показывает, какой вариант выбран. от 1 до 4
        static int [] _checked = new int [_amount];

        public int total = 0;
        public double percent = 0.0;
        QuestionData Question = new QuestionData();
        protected System.Data.DataTable TestDataTable;
        protected System.Data.DataSet TestDataSet;

        MySql.Data.MySqlClient.MySqlConnection connection = Program.connection;

       

        private void TestForm_Load(object sender, EventArgs e)
        {
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton4);
            System.String cmd = $"SELECT * FROM testdata where Theme ={Program.ThemeNumber}";
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

                int[] indexes = { 1, 2, 3 };
                TestDataTable.AsEnumerable().Where( x => Array.Exists(indexes, element => element == x.Field<int>("Id") ) );
                
                //Sorted DataTable              
            
                Question.question = TestDataTable.AsEnumerable().Select(r => r.Field<string>("Question")).ToArray();
                //Question.question = Question.question.OrderBy(n => Guid.NewGuid()).Take(5);
                for (int i = 0; i < 4; i++)
                {
                    Question.variant[i] = TestDataTable.AsEnumerable().Select(r => r.Field<string>($"Variant{i + 1}")).ToArray();
                }
                Question.correct = TestDataTable.AsEnumerable().Select(r => r.Field<int>("Correct")).ToArray();
            }
            catch (Exception er) { MessageBox.Show($"Проблема завантаження даних: {er.Message}. Джерело: {er.Source}"); }
            
           

            ShowPage(0);
        }


        public void UpdateResult() {

        }

        public void ResultToDB()
        {
           MySqlCommand com = new MySqlCommand(
               $"INSERT INTO Results (user, points, percent) VALUES({1},{total},{percent})", connection);
            com.ExecuteNonQuery();                      
        }

        public void CheckBox_Cliked(object sender, EventArgs e)
        {  
            var button = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            if (button != null)
            {
                char a = button.Text.ToCharArray()[0];
                _checked[_pageNum] = (int)Char.GetNumericValue(a);
                label1.Text = "a" + a + "checked:" + _checked[_pageNum];
            }

            if (_checked[_pageNum] == _correct)
            {
               
                _points[_pageNum] = 1;
            }
            else
                _points[_pageNum] = 0;



        }

        public void ShowPage(int pageNum)
        {
            if (pageNum > 8)
            {
                NextButton.Enabled = false;
                EndTestButton.Visible = true;
                PreviousButton.Enabled = true;
            }
            else if (pageNum < 1)
            {
                NextButton.Enabled = true;
                EndTestButton.Visible = false;
                PreviousButton.Enabled = false;
            }
            else
            {
                NextButton.Enabled = true;
                EndTestButton.Visible = false;
                PreviousButton.Enabled = true;
            }


            if (_checked[_pageNum] != 0)
            {
                groupBox1.Controls.OfType<RadioButton>().ElementAt(_checked[_pageNum]-1).Checked = true;
            }
            else {
                var button = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
                if (button != null)
                    groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Checked = false;
            }


          
            textBox1.Text = Question.question[pageNum];
            radioButton1.Text = "1." + Question.variant[0][pageNum];
            radioButton2.Text = "2." + Question.variant[1][pageNum];
            radioButton3.Text = "3." + Question.variant[2][pageNum];
            radioButton4.Text = "4." + Question.variant[3][pageNum];
            _correct = Question.correct[pageNum];
           
            

        }

        public void CalculateResult()
        {
            total = _points.Sum();
            percent = total *100.0/ _amount;
           
        }

        

        public TestForm()
        {
            InitializeComponent();
        }

             

        private void PreviousButton_Click(object sender, EventArgs e)
        {if (_pageNum < 1)
                return;
        else
            _pageNum--;
            ShowPage(_pageNum);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (_pageNum > 8)
                return;
            else
                _pageNum++;
                ShowPage(_pageNum);
        }


        private void EndTestButton_Click(object sender, EventArgs e)
        {
            CalculateResult();
            ResultToDB();
            connection.Close();

            Result result = new Result(total, percent);
            
            this.Close();
        }
    }

}