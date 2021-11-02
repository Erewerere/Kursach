using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursach
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }


        public Result(int a, double b)
        {
            label1.Text = $"Ви набрали {a} балів. Ваш відсоток складає {b} ";
            InitializeComponent();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
