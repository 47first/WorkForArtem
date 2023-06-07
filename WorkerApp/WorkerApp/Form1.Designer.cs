namespace WorkerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            hasOverworkLabel = new Label();
            timeOverworkLabel = new Label();
            amountOfOverworkLabel = new Label();
            resultLabel = new Label();
            button1 = new Button();
            programTimeLabel = new Label();
            checkInComboBox = new ComboBox();
            workedTimeInput = new TextBox();
            salaryPerHourInput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Отработанное время";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "З/п в час";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Счет в";
            // 
            // hasOverworkLabel
            // 
            hasOverworkLabel.AutoSize = true;
            hasOverworkLabel.Location = new Point(12, 96);
            hasOverworkLabel.Name = "hasOverworkLabel";
            hasOverworkLabel.Size = new Size(138, 15);
            hasOverworkLabel.TabIndex = 3;
            hasOverworkLabel.Text = "Наличие переработки -";
            // 
            // timeOverworkLabel
            // 
            timeOverworkLabel.AutoSize = true;
            timeOverworkLabel.Location = new Point(12, 123);
            timeOverworkLabel.Name = "timeOverworkLabel";
            timeOverworkLabel.Size = new Size(124, 15);
            timeOverworkLabel.TabIndex = 4;
            timeOverworkLabel.Text = "Время переработки -";
            // 
            // amountOfOverworkLabel
            // 
            amountOfOverworkLabel.AutoSize = true;
            amountOfOverworkLabel.Location = new Point(12, 151);
            amountOfOverworkLabel.Name = "amountOfOverworkLabel";
            amountOfOverworkLabel.Size = new Size(127, 15);
            amountOfOverworkLabel.TabIndex = 5;
            amountOfOverworkLabel.Text = "Сумма переработки -";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(12, 180);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(41, 15);
            resultLabel.TabIndex = 6;
            resultLabel.Text = "Итог -";
            // 
            // button1
            // 
            button1.Location = new Point(12, 210);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Расчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // programTimeLabel
            // 
            programTimeLabel.AutoSize = true;
            programTimeLabel.Location = new Point(12, 245);
            programTimeLabel.Name = "programTimeLabel";
            programTimeLabel.Size = new Size(221, 15);
            programTimeLabel.TabIndex = 8;
            programTimeLabel.Text = "Времы выполнения программы - 0 мс";
            // 
            // checkInComboBox
            // 
            checkInComboBox.FormattingEnabled = true;
            checkInComboBox.Items.AddRange(new object[] { "Часы", "Минуты" });
            checkInComboBox.Location = new Point(60, 64);
            checkInComboBox.Name = "checkInComboBox";
            checkInComboBox.Size = new Size(229, 23);
            checkInComboBox.TabIndex = 9;
            // 
            // workedTimeInput
            // 
            workedTimeInput.Location = new Point(141, 6);
            workedTimeInput.Name = "workedTimeInput";
            workedTimeInput.Size = new Size(148, 23);
            workedTimeInput.TabIndex = 10;
            // 
            // salaryPerHourInput
            // 
            salaryPerHourInput.Location = new Point(75, 35);
            salaryPerHourInput.Name = "salaryPerHourInput";
            salaryPerHourInput.Size = new Size(214, 23);
            salaryPerHourInput.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 272);
            Controls.Add(salaryPerHourInput);
            Controls.Add(workedTimeInput);
            Controls.Add(checkInComboBox);
            Controls.Add(programTimeLabel);
            Controls.Add(button1);
            Controls.Add(resultLabel);
            Controls.Add(amountOfOverworkLabel);
            Controls.Add(timeOverworkLabel);
            Controls.Add(hasOverworkLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label hasOverworkLabel;
        private Label timeOverworkLabel;
        private Label amountOfOverworkLabel;
        private Label resultLabel;
        private Button button1;
        private Label programTimeLabel;
        private ComboBox checkInComboBox;
        private TextBox workedTimeInput;
        private TextBox salaryPerHourInput;
    }
}