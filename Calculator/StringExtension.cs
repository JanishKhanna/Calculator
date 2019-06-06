using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator
{
    public static class StringExtension
    {
        public static (int? i, decimal? d) Calculate(this string str)
        {
            DataTable dataTable = new DataTable();
            object result;

            try
            {
                result = dataTable.Compute(str, null);
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");

                return (null, null);
            }

            int? output1 = result as int?;
            decimal? output2 = result as decimal?;

            return (output1, output2);
        }        
    }
}
