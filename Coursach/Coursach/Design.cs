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
    public partial class Design : Form
    {
        public Design()
        {
            InitializeComponent();
        }

        private void Design_Load(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#16024F");
            this.BackColor = ColorTranslator.FromHtml("#DAC6C6");
        }
    }
}
