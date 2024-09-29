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
    public partial class Multiplication_Table : Form
    {
        public Multiplication_Table()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = Model_Table.GenerateMultiplicationTable(Convert.ToDouble(textBox1.Text));
            label1.Text = result;
        }

        private void Multiplication_Table_Load(object sender, EventArgs e)
        {

        }
    }
}
