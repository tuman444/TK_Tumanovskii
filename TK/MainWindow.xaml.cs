using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TK
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик нажатия кнопки "Вычислить"
        /// </summary>
        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Парсинг введенных значений
                // Используем double.Parse или TryParse для вещественных чисел
                double n1 = double.Parse(TxtNum1.Text.Replace('.', ','));
                double n2 = double.Parse(TxtNum2.Text.Replace('.', ','));
                double n3 = double.Parse(TxtNum3.Text.Replace('.', ','));

                double result;

                // Проверка, какая радиокнопка выбрана
                if (RbMax.IsChecked == true)
                {
                    result = Calculator.GetMax(n1, n2, n3);
                    TxtResult.Text = $"Результат (max) = {result}";
                }
                else
                {
                    result = Calculator.GetMin(n1, n2, n3);
                    TxtResult.Text = $"Результат (min) = {result}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные вещественные числа.", "Ошибка ввода");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
