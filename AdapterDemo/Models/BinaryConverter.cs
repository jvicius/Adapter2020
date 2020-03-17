using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo.Models
{
    public static class BinaryConverter
    {
        public static string ToBinary(this int value)
        {
            return Convert.ToString(value, 2);
        }

        public static int ToInt(this string value)
        {
            return Convert.ToInt32(value, 2);
        }
    }
}
