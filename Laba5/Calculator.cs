using lab_5_SH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string expression = textBox2.Text;
            try 
            {
                double result = Model_Calculator.Calculate(expression);
                Resultlabel.Text = "Результат: " + result.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Помилка в обчисленні: " + ex.Message);
            }
        }
    }
}
