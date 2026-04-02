using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TK;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTests
    {
        // тесты для вычисления минимума
        [DataTestMethod]
        // Все положительные
        [DataRow(1.0, 2.0, 3.0, 1.0, DisplayName = "Min_Positive_FirstIsMin")]
        [DataRow(10.5, 2.1, 5.5, 2.1, DisplayName = "Min_Positive_MiddleIsMin")]
        [DataRow(10.1, 9.9, 3.3, 3.3, DisplayName = "Min_Positive_LastIsMin")]
        // Отрицательные
        [DataRow(-5.0, -2.0, -10.0, -10.0, DisplayName = "Min_AllNegative")]
        // Смешанные
        [DataRow(-5.0, 5.0, 0.0, -5.0, DisplayName = "Min_MixedValues")]
        [DataRow(10.5, 0.0, 2.2, 0.0, DisplayName = "Min_WithZeroAndPositives")]
        // Нули
        [DataRow(0.0, 0.0, 0.0, 0.0, DisplayName = "Min_AllZeroes")]
        // Одинаковые числа
        [DataRow(-7.5, -7.5, 2.1, -7.5, DisplayName = "Min_TwoEqualMin")]
        [DataRow(-3.3, -3.3, -3.3, -3.3, DisplayName = "Min_AllEqual")]
        // Экстремальные значения   
        [DataRow(double.MinValue, 0, double.MaxValue, double.MinValue, DisplayName = "Min_ExtremeValues")]
        public void GetMin_TestCases(double a, double b, double c, double expected)
        {
            double actual = Calculator.GetMin(a, b, c);
            Assert.AreEqual(expected, actual, "Расчет минимума неверен.");
        }

        // тесты для вычисления максимума
        [DataTestMethod]
        // Все положительные
        [DataRow(1.0, 2.0, 3.0, 3.0, DisplayName = "Max_Positive_LastIsMax")]
        [DataRow(10.5, 2.1, 5.5, 10.5, DisplayName = "Max_Positive_FirstIsMax")]
        [DataRow(1.1, 9.9, 3.3, 9.9, DisplayName = "Max_Positive_MiddleIsMax")] 
        // Отрицательные
        [DataRow(-5.0, -2.0, -10.0, -2.0, DisplayName = "Max_AllNegative")]
        // Смешанные
        [DataRow(-5.0, 5.0, 0.0, 5.0, DisplayName = "Max_MixedValues")]
        [DataRow(-10.5, 0.0, -2.2, 0.0, DisplayName = "Max_WithZeroAndNegatives")]
        // Нули
        [DataRow(0.0, 0.0, 0.0, 0.0, DisplayName = "Max_AllZeroes")]
        // Одинаковые числа
        [DataRow(7.5, 7.5, 2.1, 7.5, DisplayName = "Max_TwoEqualMax")]
        [DataRow(3.3, 3.3, 3.3, 3.3, DisplayName = "Max_AllEqual")]
        // Экстремальные значения (границы типа double)
        [DataRow(double.MaxValue, 0, double.MinValue, double.MaxValue, DisplayName = "Max_ExtremeValues")]
        public void GetMax_TestCases(double a, double b, double c, double expected)
        {
            double actual = Calculator.GetMin(a, b, c);
            Assert.AreEqual(expected, actual, "Расчет максимума неверен.");
        }
    }
}
