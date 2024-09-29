using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Лаб_5_SH;

namespace Laba5
{
    public partial class Years : Form
    {
        public Years()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model_Years.Determine(textBox1.Text);
        }

        private void Years_Load(object sender, EventArgs e)
        {

        }
    }
}
