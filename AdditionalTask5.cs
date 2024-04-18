using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondHomework
{
    public partial class AdditionalTask5 : Form
    {
        private Dictionary<string, string> dictionary;

        private int correctAnswers = 0;
        private int currentQuestionIndex = 0;
        Random random = new Random();
        public AdditionalTask5()
        {
            InitializeComponent();
            dictionary = new Dictionary<string, string>();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(wordTextBox.Text))
            {
                MessageBox.Show("Вы ввели пустую строку! Попробуйте снова.");
                return;
            }
            if (string.IsNullOrEmpty(translateTextBox.Text))
            {
                MessageBox.Show("Вы ввели пустую строку! Попробуйте снова.");
                return;
            }
            if (dictionary.ContainsKey(wordTextBox.Text))
            {
                return;
            }
            dictionary.Add(wordTextBox.Text, translateTextBox.Text);
            wordsListBox.Items.Add($"{wordTextBox.Text} - {translateTextBox.Text}");
        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            PrepareForm();
            wordTextBox.Text = dictionary.ElementAt(random.Next(0, dictionary.Count)).Key;
        }

        private void PrepareForm()
        {
            countCorrectAnswersLabel.Text = Convert.ToString(correctAnswers);
            checkButton.Visible = true;
            translateTextBox.Clear();
            correctAnswersLabel.Visible = true;
            addButton.Visible = false;
            questionsLabel.Visible = true;
            wordsListBox.Visible = false;
            startTestButton.Visible = false;
            wordTextBox.Enabled = false;
            countQuestionsLabel.Text = Convert.ToString(dictionary.Count);
        }
        private void ShowNextWord()
        {
            currentQuestionIndex++;
            if(currentQuestionIndex >= dictionary.Count)
            {
                MessageBox.Show($"Вы завершили тест!\nКоличество правильных ответов - {correctAnswers}");
                return;
            }
            wordTextBox.Text = dictionary.ElementAt(random.Next(0, dictionary.Count)).Key;
            translateTextBox.Clear();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(translateTextBox.Text))
            {
                MessageBox.Show("Вы ввели пустую строку! Попробуйте снова.");
                return;
            }
            if (dictionary[wordTextBox.Text].Equals(translateTextBox.Text, StringComparison.OrdinalIgnoreCase))
            {
                correctAnswers++;
            }
            countCorrectAnswersLabel.Text = Convert.ToString(correctAnswers);
            ShowNextWord();
        }
    }
}
