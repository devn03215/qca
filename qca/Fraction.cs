using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace qca
{
    public class Fraction
    {

        public bool IsTrue()
        {
            return true;
        }

        public static string MathExpression(string input)
        {
            if (input.Length > 0)
            {
                List<string> list = new List<string>();
                // trim leading spaces, remove first char ?, create list after split on space 
                list = input.Trim().Substring(1).Trim().Split(" ").ToList();

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Contains("_"))
                    {
                        list[i] = "(" + list[i].Replace("_", "+") + ")";
                    }
                }

                // generate matematical expression string
                return string.Join("", list);
            }
            else
            return "";
        }

        public string TestAddOperation(string expression)
        {
            return Fraction.OutputInFraction(expression);
        }

        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
        public static string OutputInFraction(string expression)
        {
            double decOutputValue = 0.0;
            DataTable table = new DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            decOutputValue = double.Parse((string)row["expression"]);
            var sign = decOutputValue.ToString().StartsWith("-") ? "-" : "";
            decOutputValue = Math.Abs(decOutputValue);
            int decLength = decOutputValue.ToString().Substring(decOutputValue.ToString().IndexOf(".") + 1).Length;
            double d = Math.Pow(10, decLength);
            double n = decOutputValue * d;
            double divisor = GCD(n,d);
            n /= divisor;
            d /= divisor;
            var result = "= ";
            result += sign.Length > 0 ? sign : "";
            result += Math.Floor(n / d).Equals(0) ? "" : Math.Floor(n / d).ToString() ;
            result += (Math.Floor(n / d).Equals(0) || Math.Floor(n % d).Equals(0)) ? "" : "_";
            result += Math.Floor(n % d).Equals(0) ? "" : + Math.Floor(n % d) + "/" + Math.Floor(d);

            return result;
        }

        static double GCD(double a, double b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

    }
}
