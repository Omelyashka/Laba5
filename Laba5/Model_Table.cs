using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_5_SH
{
    internal class Model_Table
    {
        public static string GenerateMultiplicationTable(double value)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i <= 10; i++)
            {
                result.AppendLine($"{value} * {i} = {value * i}");
            }
            return result.ToString();
        }
    }
}
