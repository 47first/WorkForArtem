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

                    hasOverworkLabel.Text = "������� ����������� +";
                    timeOverworkLabel.Text = $"����� ����������� - { (checkInComboBox.Text == "������" ? $"{timeOverwork * 60} ���." : $"{timeOverwork} �.") }";
                    amountOfOverworkLabel.Text = $"����� ����������� - {timeOverwork * salaryPerHour}";
                    resultLabel.Text = "���� -";
                }
                else
                {
                    hasOverworkLabel.Text = "������� ����������� -";
                    timeOverworkLabel.Text = $"����� ����������� - 0";
                    amountOfOverworkLabel.Text = $"����� ����������� - 0";
                    resultLabel.Text = $"���� {workTime * salaryPerHour}";
                }
            }
            catch
            {
                hasOverworkLabel.Text = "������� ����������� -";
                timeOverworkLabel.Text = "����� ����������� -";
                amountOfOverworkLabel.Text = "����� ����������� -";
                resultLabel.Text = "���� -";
            }

            sw.Stop();

            programTimeLabel.Text = $"����� ���������� ��������� - {sw.ElapsedMilliseconds} ��";
        }
    }
}
