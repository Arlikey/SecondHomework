namespace SecondHomework
{
    partial class MainTask
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
            difficultyComboBox = new ComboBox();
            chooseDifficultyLabel = new Label();
            equationLabel = new Label();
            answerTextBox = new TextBox();
            nextButton = new Button();
            equalsLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // difficultyComboBox
            // 
            difficultyComboBox.FormattingEnabled = true;
            difficultyComboBox.Location = new Point(420, 111);
            difficultyComboBox.Name = "difficultyComboBox";
            difficultyComboBox.Size = new Size(121, 23);
            difficultyComboBox.TabIndex = 0;
            difficultyComboBox.SelectedIndexChanged += difficultyComboBox_SelectedIndexChanged;
            // 
            // chooseDifficultyLabel
            // 
            chooseDifficultyLabel.AutoSize = true;
            chooseDifficultyLabel.Location = new Point(232, 114);
            chooseDifficultyLabel.Name = "chooseDifficultyLabel";
            chooseDifficultyLabel.Size = new Size(182, 15);
            chooseDifficultyLabel.TabIndex = 1;
            chooseDifficultyLabel.Text = "Выберите уровень сложности : ";
            // 
            // equationLabel
            // 
            equationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            equationLabel.AutoSize = true;
            equationLabel.Location = new Point(179, 0);
            equationLabel.Name = "equationLabel";
            equationLabel.Size = new Size(0, 44);
            equationLabel.TabIndex = 2;
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(420, 222);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(68, 23);
            answerTextBox.TabIndex = 3;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(505, 222);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(93, 23);
            nextButton.TabIndex = 4;
            nextButton.Text = "Следующий";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // equalsLabel
            // 
            equalsLabel.AutoSize = true;
            equalsLabel.Location = new Point(185, 0);
            equalsLabel.Name = "equalsLabel";
            equalsLabel.Size = new Size(12, 15);
            equalsLabel.TabIndex = 5;
            equalsLabel.Text = "=";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.Controls.Add(equalsLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(equationLabel, 0, 0);
            tableLayoutPanel1.Location = new Point(219, 223);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(200, 44);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // MainTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(nextButton);
            Controls.Add(answerTextBox);
            Controls.Add(chooseDifficultyLabel);
            Controls.Add(difficultyComboBox);
            Name = "MainTask";
            Text = "Form1";
            Load += MainTask_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox difficultyComboBox;
        private Label chooseDifficultyLabel;
        private Label equationLabel;
        private TextBox answerTextBox;
        private Button nextButton;
        private Label equalsLabel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
