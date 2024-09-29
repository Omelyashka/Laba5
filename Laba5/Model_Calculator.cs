using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5_SH
{
    public class Model_Calculator
    {
        public static double Calculate(string expression)
        {
            double result = 0;
            StringBuilder stringBuilder = new StringBuilder(expression);
            List<double> nums = new List<double>();
            List<char> operations = new List<char>();
            double num = 0;
            StringBuilder numberBuilder = new StringBuilder();

            for (int i = 0; i < stringBuilder.Length; i++)
            {
                char currentChar = stringBuilder[i];

                if (char.IsDigit(currentChar) || currentChar == '.')
                {
                    numberBuilder.Append(currentChar);
                }
                else if (currentChar == '-' || currentChar == '+' ||
                         currentChar == '*' || currentChar == '/')
                {
                    if (numberBuilder.Length > 0)
                    {
                        num = Convert.ToDouble(numberBuilder.ToString());
                        nums.Add(num);
                        numberBuilder.Clear();
                    }

                    operations.Add(currentChar);
                }
            }

            if (numberBuilder.Length > 0)
            {
                num = Convert.ToDouble(numberBuilder.ToString());
                nums.Add(num);
            }

            for (int i = 0; i < operations.Count; i++)
            {
                if (operations[i] == '*')
                {
                    result = nums[i] * nums[i + 1];
                    operations.RemoveAt(i);
                    nums.RemoveAt(i + 1);
                    nums[i] = result;
                    i--;
                }
                else if (operations[i] == '/')
                {
                    result = nums[i] / nums[i + 1];
                    operations.RemoveAt(i);
                    nums.RemoveAt(i + 1);
                    nums[i] = result;
                    i--;
                }
            }

            for (int i = 0; i < operations.Count; i++)
            {
                if (operations[i] == '-')
                {
                    result = nums[i] - nums[i + 1];
                    operations.RemoveAt(i);
                    nums.RemoveAt(i + 1);
                    nums[i] = result;
                    i--;
                }
                else if (operations[i] == '+')
                {
                    result = nums[i] + nums[i + 1];
                    operations.RemoveAt(i);
                    nums.RemoveAt(i + 1);
                    nums[i] = result;
                    i--;
                }
            }

            return nums[0];
        }
    }
}