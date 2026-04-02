using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TK
{
    public static class Calculator
    {
        /// <summary>
        /// Возвращает максимальное из трех вещественных чисел
        /// </summary>
        public static double GetMax(double a, double b, double c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        /// <summary>
        /// Возвращает минимальное из трех вещественных чисел
        /// </summary>
        public static double GetMin(double a, double b, double c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
    }
}
