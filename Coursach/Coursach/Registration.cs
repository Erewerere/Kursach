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

     
      
        protected System.Data.DataTable UserDataTable;
        protected System.Data.DataTable GroupDataTable;

        MySql.Data.MySqlClient.MySqlConnection connection = Program.connection;
        List<string> fio = new List<string>();
        List<string> password = new List<string>();
        //List<Group> groups = new List<Group>() { "","" };
        List<Group> groups = new List<Group>();
        int AmountOfUser = 0;
        int lastid = 0;

        string password1;
        string fio1; 

        
        private void Registration_Load(object sender, EventArgs e)
        {
        
            System.String cmd = "SELECT * FROM users";
            System.String cmd2 = "SELECT * FROM groups";
           
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd, connection);
            MySqlDataAdapter ad2 = new MySqlDataAdapter(cmd2, connection);



            UserDataTable = new DataTable();
            GroupDataTable = new DataTable();
            ad.Fill(UserDataTable);
            ad2.Fill(GroupDataTable);
            fio = UserDataTable.AsEnumerable().Select(r => r.Field<string>("FIO")).ToList();
            password = UserDataTable.AsEnumerable().Select(r => r.Field<string>("Password")).ToList();
            AmountOfUser = fio.Count() +1;
            List<int> _enumerablegroupid = GroupDataTable.AsEnumerable().Select(r => r.Field<int>("Id")).ToList();
            List<string> _enumerablegroupname = GroupDataTable.AsEnumerable().Select(r => r.Field<string>("Name")).ToList();


          
            for ( int i =0; i < _enumerablegroupid.Count(); i++ )
            {
               
                
                
                groups.Add(new Group() { Id = _enumerablegroupid[i], Name = _enumerablegroupname[i] });
               
            }
        

            try
            {
               
            }
            catch(Exception er)
            {
                MessageBox.Show($"Помилка підключення до БД!");
            }

            try
            {
                

            }
            catch(Exception er2)
            {
                MessageBox.Show($"Помилка заповненя даниз з БД. Проблема: {er2.Message}. /n Source: {er2.Source}");
            }
           
            lastid = groups.Last().Id;
            
            foreach (Group g2 in groups) {
                
                comboBox1.Items.Add(g2.Name);
               

            }

                   }

        public bool CheckCollision()
        {
            foreach(string a in password)
            {
                if(password1 == a)
                {
                    return false;
                }

            }
            foreach(string b in fio)
            {
                if(fio1 == b)
                {
                    return false;
                }
            }
            return true;
        }

        public Registration()
        {
            InitializeComponent();
        }

        public void WriteToDB()
        {  
            int groupid = groups[comboBox1.SelectedIndex].Id;
            MySqlCommand com = new MySqlCommand(
               $"INSERT INTO Users (Id, Fio, Password, GroupId) VALUES({AmountOfUser},'{fio1}', '{password1}',{groupid})", connection);
            com.ExecuteNonQuery();

            AmountOfUser++;
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            password1 = textBox1.Text;
            fio1 = textBox2.Text;           
            if( CheckCollision() == true)
            {
                if(comboBox1.SelectedIndex>=0)
               WriteToDB();
            }


            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
