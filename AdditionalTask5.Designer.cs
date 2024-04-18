namespace SecondHomework
{
    partial class AdditionalTask5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            wordsListBox = new ListBox();
            wordTextBox = new TextBox();
            translateTextBox = new TextBox();
            addButton = new Button();
            startTestButton = new Button();
            wordLabel = new Label();
            translateLabel = new Label();
            correctAnswersLabel = new Label();
            questionsLabel = new Label();
            countCorrectAnswersLabel = new Label();
            countQuestionsLabel = new Label();
            checkButton = new Button();
            SuspendLayout();
            // 
            // wordsListBox
            // 
            wordsListBox.FormattingEnabled = true;
            wordsListBox.ItemHeight = 15;
            wordsListBox.Location = new Point(471, 40);
            wordsListBox.Name = "wordsListBox";
            wordsListBox.Size = new Size(269, 244);
            wordsListBox.TabIndex = 0;
            // 
            // wordTextBox
            // 
            wordTextBox.Location = new Point(115, 58);
            wordTextBox.Name = "wordTextBox";
            wordTextBox.Size = new Size(100, 23);
            wordTextBox.TabIndex = 1;
            // 
            // translateTextBox
            // 
            translateTextBox.Location = new Point(115, 103);
            translateTextBox.Name = "translateTextBox";
            translateTextBox.Size = new Size(100, 23);
            translateTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.Location = new Point(128, 149);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // startTestButton
            // 
            startTestButton.Location = new Point(555, 307);
            startTestButton.Name = "startTestButton";
            startTestButton.Size = new Size(110, 23);
            startTestButton.TabIndex = 3;
            startTestButton.Text = "Начать тест";
            startTestButton.UseVisualStyleBackColor = true;
            startTestButton.Click += startTestButton_Click;
            // 
            // wordLabel
            // 
            wordLabel.AutoSize = true;
            wordLabel.Location = new Point(61, 61);
            wordLabel.Name = "wordLabel";
            wordLabel.Size = new Size(48, 15);
            wordLabel.TabIndex = 4;
            wordLabel.Text = "Слово :";
            // 
            // translateLabel
            // 
            translateLabel.AutoSize = true;
            translateLabel.Location = new Point(49, 106);
            translateLabel.Name = "translateLabel";
            translateLabel.Size = new Size(60, 15);
            translateLabel.TabIndex = 4;
            translateLabel.Text = "Перевод :";
            // 
            // correctAnswersLabel
            // 
            correctAnswersLabel.AutoSize = true;
            correctAnswersLabel.Location = new Point(238, 66);
            correctAnswersLabel.Name = "correctAnswersLabel";
            correctAnswersLabel.Size = new Size(124, 15);
            correctAnswersLabel.TabIndex = 5;
            correctAnswersLabel.Text = "Правильные ответы :";
            correctAnswersLabel.Visible = false;
            // 
            // questionsLabel
            // 
            questionsLabel.AutoSize = true;
            questionsLabel.Location = new Point(238, 106);
            questionsLabel.Name = "questionsLabel";
            questionsLabel.Size = new Size(134, 15);
            questionsLabel.TabIndex = 6;
            questionsLabel.Text = "Количество вопросов :";
            questionsLabel.Visible = false;
            // 
            // countCorrectAnswersLabel
            // 
            countCorrectAnswersLabel.AutoSize = true;
            countCorrectAnswersLabel.Location = new Point(365, 67);
            countCorrectAnswersLabel.Name = "countCorrectAnswersLabel";
            countCorrectAnswersLabel.Size = new Size(0, 15);
            countCorrectAnswersLabel.TabIndex = 7;
            // 
            // countQuestionsLabel
            // 
            countQuestionsLabel.AutoSize = true;
            countQuestionsLabel.Location = new Point(375, 107);
            countQuestionsLabel.Name = "countQuestionsLabel";
            countQuestionsLabel.Size = new Size(0, 15);
            countQuestionsLabel.TabIndex = 8;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(128, 149);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(75, 23);
            checkButton.TabIndex = 9;
            checkButton.Text = "Проверить";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Visible = false;
            checkButton.Click += checkButton_Click;
            // 
            // AdditionalTask5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkButton);
            Controls.Add(countQuestionsLabel);
            Controls.Add(countCorrectAnswersLabel);
            Controls.Add(questionsLabel);
            Controls.Add(correctAnswersLabel);
            Controls.Add(translateLabel);
            Controls.Add(wordLabel);
            Controls.Add(startTestButton);
            Controls.Add(addButton);
            Controls.Add(translateTextBox);
            Controls.Add(wordTextBox);
            Controls.Add(wordsListBox);
            Name = "AdditionalTask5";
            Text = "AdditionalTask5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox wordsListBox;
        private TextBox wordTextBox;
        private TextBox translateTextBox;
        private Button addButton;
        private Button startTestButton;
        private Label wordLabel;
        private Label translateLabel;
        private Label correctAnswersLabel;
        private Label questionsLabel;
        private Label countCorrectAnswersLabel;
        private Label countQuestionsLabel;
        private Button checkButton;
    }
}