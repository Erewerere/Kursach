using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Coursach
{
    public class QuestionData
    {
        public int[] id = new int[Program.AmountOfQuestion];
        public string[] question = new string[Program.AmountOfQuestion];
        public List<string[]> variant = new List<string[]> { new string[Program.AmountOfQuestion],
         new string[Program.AmountOfQuestion],  new string[Program.AmountOfQuestion], new string[Program.AmountOfQuestion]};      
        public int[] correct = new int[Program.AmountOfQuestion];
    }
    public static class User
    {  public static int id { get; set; }
        public static string fio { get; set; }
      
        public static int group { get; set; }           
    }

    public class Group
    {
        int id;
        string name;
        public int Id { set { if (value > 0) id = value; } get { return id; } }
        public string Name { get; set; }
    }
    public static class Formi
    {
        public static TestForm Test;
        
        public static Main Main = new Main();
        public static Registration Reg = new Registration();
        public static Result Result = new Result();
        public static Theme Theme  = new Theme();
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Enter());
        }

      

        static public string DB_CONN_STR = "Server=127.0.0.1;Uid=root;Pwd=;Database=kursach";
        static public  MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(DB_CONN_STR);
        static public int AmountOfQuestion { get; private set ; } = 10;
        static int number = 5;
        static  int themenumber = 1;
        //возвращает количество тем в самой программе
        static public int AmountOfTheme { get => number;  /*set => number = value;*/ }
        //дает номер темы, которая выбрана в main
        static public int ThemeNumber
        {
            set
            {
                if (value < 1 || value > AmountOfTheme)
                {
                    Console.WriteLine("Wrong numbertheme was send");
                    return;
                }
                else
                    themenumber = value;
            }
            get
            {
                return themenumber;
            }
        }
    }
}

/// <summary>
/// MyData For using SqlReader, is not usable>
/// </summary>
//    class MyData
//    {
//        public int id { get; set; }
//        public string question { get; set; }
//        public string variant1 { get; set; }
//        public string variant2 { get; set; }
//        public string variant3 { get; set; }
//        public string variant4 { get; set; }
//        public int correct { get; set; }
//    }
////////////////////////////////
/// ///////////////////////////////////
////Using Mysqldatareader to get rows into MyData Class
//MySqlCommand command = connection.CreateCommand();
//command.CommandText = cmd;
//var Data = new List<MyData>();
//using (MySqlDataReader reader = command.ExecuteReader())
//{
//    while (reader.Read())
//    {
//        Data.Add(new MyData
//        {
//            id = reader.GetInt32(reader.GetOrdinal("Id")),
//            question = reader.GetString(reader.GetOrdinal("Question")),
//            variant1 = reader.GetString(reader.GetOrdinal("Variant1")),
//            variant2 = reader.GetString(reader.GetOrdinal("Variant2")),
//            variant3 = reader.GetString(reader.GetOrdinal("Variant3")),
//            variant4 = reader.GetString(reader.GetOrdinal("Variant4")),
//            correct = reader.GetInt32(reader.GetOrdinal("Correct")),
//        });
//    }
//}
//////////////////////////////////////////////////////
///////////Convert Table into string array(just function)
//string[] arrray = ViewTable.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
/////////////////////////////////////
