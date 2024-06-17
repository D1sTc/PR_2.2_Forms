using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink; // Отключение мигания
        }
        private void Generation_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            HashSet<int> randomKeys = new HashSet<int>(); // HashSet для автоматической проверки на дубликаты

            while (randomKeys.Count < 5) // Генерируем пока не будет 5 уникальных ключей
            {
                randomKeys.Add(rand.Next(1, 11));
            }

            textBoxNumbersKeys.Text = string.Join(" ", randomKeys); // Выводим ключи в текстовое поле
        }

        private void Cubing_Click(object sender, EventArgs e)
        {  
            try
            {
                string keysExit = textBoxNumbersKeys.Text; // Получаем строку с ключами из текстового поля textBoxNumbersKeys
                string[] keysArray = keysExit.Split(' '); // Разбиваем строку на подстроки, значения через ' '
                Dictionary<int, int> randomKeys = new Dictionary<int, int>(); // Создаем новый словарь (2-ой) для хранения ключей и их кубов

                foreach (string keyString in keysArray)
                {
                    int key = Convert.ToInt32(keyString); // создаём переменную ключ и после в нём преобразуем строки/уже созданные ранее ключи в целочисленное значение
                    int valueKeyX3 = key * key * key; // Значение (value) получаем возводя ключ в куб
                    randomKeys.Add(key, valueKeyX3); // Добавляем ключ и его куб в словарь
                }

                string result = String.Join(" ", randomKeys.Values); // Преобразуем значения (кубы ключей) в строку через пробел
                textBoxNumbersValues.Text = result; // Выводим строку с кубами в текстовое поле textBoxNumbersValues
            }
            catch
            {
                MessageBox.Show("Нет данных. Введите или сгенерируйте валидные ключи для возведения в куб", "Ошибка"); // Выводим результат в сообщении, довольно интересная тема на будущие работы >:З
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            string input = textBoxNumbersValues.Text;
            string[] numbersArray = input.Split(' '); // Разбиваем строку на отдельные числа

            int result = 1; // Инициализируем результат умножения

            foreach (string numStr in numbersArray)
            {
                int number;
                if (int.TryParse(numStr, out number)) // Пытаемся преобразовать строку в число
                {
                    result *= number; // Умножаем значение на результат
                }
            }
            if (result == 1) MessageBox.Show("Нет значений", "Ошибка"); // Выводим результат умножения в текстовое поле
            else MessageBox.Show(result.ToString(), "результат");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxNumbersKeys.Clear();
            textBoxNumbersValues.Clear();
            errorProvider.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplicationGeneration_Click(object sender, EventArgs e)
        {
            Generation_Click(sender, e);
        }

        private void ApplicationMultiply_Click(object sender, EventArgs e)
        {
            Multiply_Click(sender, e);
        }

        private void ApplicationCubing_Click(object sender, EventArgs e)
        {
            Cubing_Click(sender, e);
        }

        private void ClearMenu_Click(object sender, EventArgs e)
        {
            Clear_Click(sender, e);
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutProgram_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }
        private void textBoxNumbersKeys_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumbersKeys.Text)) // Проверка на пустое поле
            {
                errorProvider.SetError(textBoxNumbersKeys, "Оставлять данное поле пустым нельзя");
                return; // Прерываем выполнение, если всё норм
            }

            string[] numbers = textBoxNumbersKeys.Text.Split(' '); // Разделяем строку по пробелам

            bool isValid = true; // Проверка: все ли элементы массива numbers являются числами // isValid - переменная, которая будет хранить информацию о корректности введенных данных.
            foreach (string number in numbers) // цикл, который перебирает каждый элемент массива numbers
            {
                if (!int.TryParse(number, out int result)) // метод, который пытается преобразовать строку number в целочисленное число.
                {
                    isValid = false;
                    break;
                }

                if (result < -1000 || result > 1000) // на макс. и мин. значение в размер 1000.
                {
                    isValid = false;
                    break;
                }
            }

            if (!isValid)
            {
                errorProvider.SetError(textBoxNumbersKeys, "Некорректное значение");
                return; // Прерываем выполнение, если всё норм
            }

            errorProvider.Clear(); // Если ошибок нет, очищаем сообщение об ошибке
        }
    }
}
