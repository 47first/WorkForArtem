using System.Diagnostics;

namespace WorkerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new();

            sw.Start();

            try
            {
                float workTime = float.Parse(workedTimeInput.Text);
                float salaryPerHour = float.Parse(salaryPerHourInput.Text);

                if (workTime < 1)
                    throw null;

                if (workTime > 8)
                {
                    float timeOverwork = workTime - 8;

                    hasOverworkLabel.Text = "Наличие переработки +";
                    timeOverworkLabel.Text = $"Время переработки - { (checkInComboBox.Text == "Минуты" ? $"{timeOverwork * 60} мин." : $"{timeOverwork} ч.") }";
                    amountOfOverworkLabel.Text = $"Сумма переработки - {timeOverwork * salaryPerHour}";
                    resultLabel.Text = "Итог -";
                }
                else
                {
                    hasOverworkLabel.Text = "Наличие переработки -";
                    timeOverworkLabel.Text = $"Время переработки - 0";
                    amountOfOverworkLabel.Text = $"Сумма переработки - 0";
                    resultLabel.Text = $"Итог {workTime * salaryPerHour}";
                }
            }
            catch
            {
                hasOverworkLabel.Text = "Наличие переработки -";
                timeOverworkLabel.Text = "Время переработки -";
                amountOfOverworkLabel.Text = "Сумма переработки -";
                resultLabel.Text = "Итог -";
            }

            sw.Stop();

            programTimeLabel.Text = $"Времы выполнения программы - {sw.ElapsedMilliseconds} мс";
        }
    }
}
