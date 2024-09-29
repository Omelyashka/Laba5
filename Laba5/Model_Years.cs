using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб_5_SH
{
    internal class Model_Years
    {
        public static void Determine(string year)
        {
            int _year = Convert.ToInt32(year);
            if (_year < 12) { MessageBox.Show("Ви дитина"); }
            else if (_year < 19) { MessageBox.Show("Ви підліток"); }
            else if (_year < 25) { MessageBox.Show("Ви юнак"); }
            else if (_year < 44) { MessageBox.Show("Ви людина молодого віку"); }
            else if (_year < 60) { MessageBox.Show("Ви людина середнього віку"); }
            else if (_year >= 60) { MessageBox.Show("Ви людина похилого віку"); }

        }
    }
}
