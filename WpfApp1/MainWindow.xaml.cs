using Lib_5;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        int kol, sum; String ch = "";//Создание новых переменных.
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вычислить сумму целых случайных чисел, \nраспределенных в диапазоне от - 7 до 3,\nпока эта сумма не превышает некоторого " +
                "\nчисла K. Вывести на экран сгенерирован-\nные числа, значение суммы, и количество \nсгенерированных чисел", "О программе:");
        }
        private void btnRazr_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Студентка группы ИСП-31 \n       Лосева Анастасия", "О разработчике:");
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();//Кнопка закрытия программы.
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();//Кнопка закрытия программы в меню.
        }

        private void Rez_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Chislo.Text, out int w))//Проверка на данные, введённые пользователем.
            {
                Class1.Resh(w, out kol, out sum, out ch);//Присваиваем новым переменным значения, полученные в процессе решения функции.
                if (ch != "")
                {
                    Kolvo.Text = kol.ToString();//Выводим количество подобранных чисел.
                    Summ.Text = sum.ToString();//Выводим сумму подобранных чисел.
                    Sgen.Text = ch;//Выводим побобранные числа.
                }
                else
                {
                    Kolvo.Text = kol.ToString();//Выводим количество подобранных чисел(0).
                    Summ.Text = sum.ToString();//Выводим сумму подобранных чисел(0).
                    Sgen.Text = "Подобранные числа не соответствуют.";//Выводим надпись, если первое число, подобранное программой больше числа К.
                }
            }
            else MessageBox.Show("Введите правильное значение!");//Выводим, если пользователь ввёл не число.
        }
    }
}
