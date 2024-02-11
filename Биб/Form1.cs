using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DDL;
namespace Биб
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;

            TimeSpan difference = DDL.Class1.GetDateDifference(date1, date2);

            MessageBox.Show("Разница между датами: " + difference.TotalDays + " дней", "Результат");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;

            // Проверяем, является ли год високосным
            bool isLeapYear = Class1.IsLeapYear(selectedDate.Year);

            // Выводим соответствующее сообщение
            if (isLeapYear)
            {
                MessageBox.Show(selectedDate.Year + " - високосный год", "Результат");
            }
            else
            {
                MessageBox.Show(selectedDate.Year + " - не високосный год", "Результат");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string timeString = maskedTextBox1.Text;

            // Парсим строку времени в объект DateTime
            DateTime time;
            if (!DateTime.TryParseExact(timeString, "HH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out time))
            {
                MessageBox.Show("Некорректный формат времени. Введите время в формате HH:mm.", "Ошибка");
                return;
            }

            // Определяем время суток
            string timeOfDay = Class1.GetTimeOfDay(time);

            // Выводим результат
            MessageBox.Show("Время суток: " + timeOfDay, "Результат");
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dateTimeString = maskedTextBox2.Text;

            // Парсим строку даты и времени в объект DateTime
            DateTime dateTime;
            if (!DateTime.TryParseExact(dateTimeString, "dd.MM.yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dateTime))
            {
                MessageBox.Show("Некорректный формат даты и времени. Введите дату и время в формате dd.MM.yyyy HH:mm.", "Ошибка");
                return;
            }

            // Форматируем дату и время
            string formattedDateTime = Class1.FormatDateTime(dateTime, "dd день MM месяц yyyy год  HH часов mm минут ");

            // Выводим отформатированную дату и время
            MessageBox.Show("Отформатированная дата и время: " + formattedDateTime, "Результат");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

           
        }
    }
    }
    

