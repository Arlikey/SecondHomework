using NCalc;

namespace SecondHomework
{
    public partial class MainTask : Form
    {
        private int correctAnswers = 0;

        private string[] difficulties = { "Легкий", "Средний", "Сложный" };

        private string[] selectedEquations;
        private int currentEquationIndex = 0;
        private string[] easyLevel = { "2+2", "3*3", "5-1", "10/2", "7+2", "9-6", "5*2", "20/5", "8+3", "15-9" };
        private string[] mediumLevel = { "8+6", "12-5", "4*7", "45/5", "18+9", "30-12", "6*8", "64/8", "15+20", "40-23" };
        private string[] hardLevel = { "24 + (7*5) - (42/6)", "(36/9) + (4*3) - 5", "(25/5) + (6*3) - Sqrt(49)",
            "(8*4) - (64/8) + 11", "(64/8) + (9*2) - Sqrt(64)", "Sqrt(16) + (4*23) - (33/11)", "12 -(36/6) + (4*8)",
            "(28/7) * (5+1) - Sqrt(81)", "(45/9) * (6+1) - 9", "9 + (4*5) - (30/6)" };
        public MainTask()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int userAnswer;
            if (!int.TryParse(answerTextBox.Text, out userAnswer))
            {
                MessageBox.Show("Введите числовое значение!");
                answerTextBox.Clear();
            }
            int result = Convert.ToInt32(new Expression(equationLabel.Text).Evaluate());

            if (userAnswer == result)
            {
                correctAnswers++;
            }
            ShowNextEquation();
        }

        private void MainTask_Load(object sender, EventArgs e)
        {
            difficultyComboBox.DataSource = difficulties;
            selectedEquations = easyLevel;
            equationLabel.Text = selectedEquations[currentEquationIndex];
        }

        private void ShowNextEquation()
        {
            currentEquationIndex++;
            if (currentEquationIndex >= selectedEquations.Length)
            {
                MessageBox.Show($"Вы завершили тест!\nКоличество правильных ответов: {correctAnswers}");
                return;
            }

            equationLabel.Text = selectedEquations[currentEquationIndex];
            answerTextBox.Clear();
        }

        private void difficultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (difficultyComboBox.SelectedIndex)
            {
                case 0: selectedEquations = easyLevel; break;
                case 1: selectedEquations = mediumLevel; break;
                case 2: selectedEquations = hardLevel; break;
            }

            currentEquationIndex = 0;
            equationLabel.Text = selectedEquations[currentEquationIndex];
        }
    }
}
