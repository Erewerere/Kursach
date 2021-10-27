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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          


        }

        private void аккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void довідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void тестуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestForm Test = new TestForm();
            Test.Show();
            Program.ThemeNumber = 1;
          
        }
    }
}
