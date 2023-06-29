namespace Lab_1
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            WeightTxt = new Label();
            HeightTxt = new Label();
            Agetxt = new Label();
            GoalTxt = new Label();
            Sextxt = new Label();
            GoalWeidth = new Label();
            Weight = new TextBox();
            Height = new TextBox();
            Age = new TextBox();
            GoalWeight = new TextBox();
            SexCheck = new GroupBox();
            femaleButton = new RadioButton();
            maleButton = new RadioButton();
            checkedGoals = new GroupBox();
            WeightGain = new RadioButton();
            WeightLoss = new RadioButton();
            mainingWeight = new RadioButton();
            ResultTxt = new Label();
            dailyСaloriestxt = new Label();
            dailyСaloriesResult = new TextBox();
            ResultFolder = new RichTextBox();
            PrintResultButton = new Button();
            SexCheck.SuspendLayout();
            checkedGoals.SuspendLayout();
            SuspendLayout();
            // 
            // WeightTxt
            // 
            WeightTxt.AutoSize = true;
            WeightTxt.Font = new Font("Calibri", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            WeightTxt.Location = new Point(86, 98);
            WeightTxt.Name = "WeightTxt";
            WeightTxt.Size = new Size(60, 21);
            WeightTxt.TabIndex = 12;
            WeightTxt.Text = "Вес(кг)";
            // 
            // HeightTxt
            // 
            HeightTxt.AutoSize = true;
            HeightTxt.Font = new Font("Calibri", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            HeightTxt.Location = new Point(79, 137);
            HeightTxt.Name = "HeightTxt";
            HeightTxt.Size = new Size(64, 21);
            HeightTxt.TabIndex = 13;
            HeightTxt.Text = "Рост(м)";
            // 
            // Agetxt
            // 
            Agetxt.AutoSize = true;
            Agetxt.Font = new Font("Calibri", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Agetxt.Location = new Point(78, 190);
            Agetxt.Name = "Agetxt";
            Agetxt.Size = new Size(67, 21);
            Agetxt.TabIndex = 14;
            Agetxt.Text = "Возраст";
            // 
            // GoalTxt
            // 
            GoalTxt.AutoSize = true;
            GoalTxt.Font = new Font("Calibri", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            GoalTxt.Location = new Point(86, 235);
            GoalTxt.Name = "GoalTxt";
            GoalTxt.Size = new Size(47, 21);
            GoalTxt.TabIndex = 15;
            GoalTxt.Text = "Цель";
            // 
            // Sextxt
            // 
            Sextxt.AutoSize = true;
            Sextxt.Font = new Font("Calibri", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Sextxt.Location = new Point(99, 33);
            Sextxt.Name = "Sextxt";
            Sextxt.Size = new Size(39, 21);
            Sextxt.TabIndex = 17;
            Sextxt.Text = "Пол";
            // 
            // GoalWeidth
            // 
            GoalWeidth.AutoSize = true;
            GoalWeidth.Font = new Font("Calibri", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            GoalWeidth.Location = new Point(13, 357);
            GoalWeidth.Name = "GoalWeidth";
            GoalWeidth.Size = new Size(144, 21);
            GoalWeidth.TabIndex = 18;
            GoalWeidth.Text = "Желаемый вес(кг)";
            // 
            // Weight
            // 
            Weight.Location = new Point(155, 98);
            Weight.Name = "Weight";
            Weight.Size = new Size(97, 27);
            Weight.TabIndex = 20;
            // 
            // Height
            // 
            Height.Location = new Point(156, 137);
            Height.Name = "Height";
            Height.Size = new Size(107, 27);
            Height.TabIndex = 21;
            Height.TextChanged += Height_TextChanged;
            // 
            // Age
            // 
            Age.Location = new Point(155, 190);
            Age.Name = "Age";
            Age.Size = new Size(96, 27);
            Age.TabIndex = 22;
            // 
            // GoalWeight
            // 
            GoalWeight.Location = new Point(156, 354);
            GoalWeight.Name = "GoalWeight";
            GoalWeight.Size = new Size(130, 27);
            GoalWeight.TabIndex = 23;
            // 
            // SexCheck
            // 
            SexCheck.Controls.Add(femaleButton);
            SexCheck.Controls.Add(maleButton);
            SexCheck.FlatStyle = FlatStyle.Flat;
            SexCheck.Location = new Point(154, 18);
            SexCheck.Name = "SexCheck";
            SexCheck.Size = new Size(83, 73);
            SexCheck.TabIndex = 26;
            SexCheck.TabStop = false;
            // 
            // femaleButton
            // 
            femaleButton.AutoSize = true;
            femaleButton.Location = new Point(6, 46);
            femaleButton.Name = "femaleButton";
            femaleButton.Size = new Size(76, 24);
            femaleButton.TabIndex = 1;
            femaleButton.TabStop = true;
            femaleButton.Text = "female";
            femaleButton.UseVisualStyleBackColor = true;
            // 
            // maleButton
            // 
            maleButton.AutoSize = true;
            maleButton.Location = new Point(6, 15);
            maleButton.Name = "maleButton";
            maleButton.Size = new Size(63, 24);
            maleButton.TabIndex = 0;
            maleButton.TabStop = true;
            maleButton.Text = "male";
            maleButton.UseVisualStyleBackColor = true;
            // 
            // checkedGoals
            // 
            checkedGoals.Controls.Add(WeightGain);
            checkedGoals.Controls.Add(WeightLoss);
            checkedGoals.Controls.Add(mainingWeight);
            checkedGoals.Location = new Point(154, 223);
            checkedGoals.Name = "checkedGoals";
            checkedGoals.Size = new Size(169, 116);
            checkedGoals.TabIndex = 27;
            checkedGoals.TabStop = false;
            // 
            // WeightGain
            // 
            WeightGain.AutoSize = true;
            WeightGain.Location = new Point(6, 85);
            WeightGain.Name = "WeightGain";
            WeightGain.Size = new Size(146, 24);
            WeightGain.TabIndex = 2;
            WeightGain.TabStop = true;
            WeightGain.Text = "увелечение веса";
            WeightGain.UseVisualStyleBackColor = true;
            // 
            // WeightLoss
            // 
            WeightLoss.AutoSize = true;
            WeightLoss.Location = new Point(6, 55);
            WeightLoss.Name = "WeightLoss";
            WeightLoss.Size = new Size(135, 24);
            WeightLoss.TabIndex = 1;
            WeightLoss.TabStop = true;
            WeightLoss.Text = "снижение веса";
            WeightLoss.UseVisualStyleBackColor = true;
            // 
            // mainingWeight
            // 
            mainingWeight.AutoSize = true;
            mainingWeight.Location = new Point(6, 25);
            mainingWeight.Name = "mainingWeight";
            mainingWeight.Size = new Size(161, 24);
            mainingWeight.TabIndex = 0;
            mainingWeight.TabStop = true;
            mainingWeight.Text = "поддержание веса";
            mainingWeight.UseVisualStyleBackColor = true;
            // 
            // ResultTxt
            // 
            ResultTxt.AutoSize = true;
            ResultTxt.Font = new Font("Calibri", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            ResultTxt.Location = new Point(498, 108);
            ResultTxt.Name = "ResultTxt";
            ResultTxt.Size = new Size(112, 29);
            ResultTxt.TabIndex = 28;
            ResultTxt.Text = "Результат";
            // 
            // dailyСaloriestxt
            // 
            dailyСaloriestxt.AutoSize = true;
            dailyСaloriestxt.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dailyСaloriestxt.Location = new Point(462, 261);
            dailyСaloriestxt.Name = "dailyСaloriestxt";
            dailyСaloriestxt.Size = new Size(192, 21);
            dailyСaloriestxt.TabIndex = 29;
            dailyСaloriestxt.Text = "Суточная норма калорий";
            // 
            // dailyСaloriesResult
            // 
            dailyСaloriesResult.Location = new Point(475, 285);
            dailyСaloriesResult.Name = "dailyСaloriesResult";
            dailyСaloriesResult.Size = new Size(153, 27);
            dailyСaloriesResult.TabIndex = 31;
            dailyСaloriesResult.TextChanged += dailyСaloriesResult_TextChanged;
            // 
            // ResultFolder
            // 
            ResultFolder.Location = new Point(439, 156);
            ResultFolder.Name = "ResultFolder";
            ResultFolder.Size = new Size(231, 86);
            ResultFolder.TabIndex = 33;
            ResultFolder.Text = "";
            ResultFolder.Click += ResultFolder_Click;
            // 
            // PrintResultButton
            // 
            PrintResultButton.BackColor = Color.White;
            PrintResultButton.Location = new Point(260, 457);
            PrintResultButton.Name = "PrintResultButton";
            PrintResultButton.Size = new Size(264, 51);
            PrintResultButton.TabIndex = 34;
            PrintResultButton.Text = "Получить результат";
            PrintResultButton.UseVisualStyleBackColor = false;
            PrintResultButton.Click += PrintResultButton_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(767, 619);
            Controls.Add(PrintResultButton);
            Controls.Add(ResultFolder);
            Controls.Add(dailyСaloriesResult);
            Controls.Add(dailyСaloriestxt);
            Controls.Add(ResultTxt);
            Controls.Add(checkedGoals);
            Controls.Add(SexCheck);
            Controls.Add(GoalWeight);
            Controls.Add(Age);
            Controls.Add(Height);
            Controls.Add(Weight);
            Controls.Add(GoalWeidth);
            Controls.Add(Sextxt);
            Controls.Add(GoalTxt);
            Controls.Add(Agetxt);
            Controls.Add(HeightTxt);
            Controls.Add(WeightTxt);
            Name = "Calculator";
            Text = "Calculator";
            SexCheck.ResumeLayout(false);
            SexCheck.PerformLayout();
            checkedGoals.ResumeLayout(false);
            checkedGoals.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label WeightTxt;
        private Label HeightTxt;
        private Label Agetxt;
        private Label GoalTxt;
        private Label Sextxt;
        private Label GoalWeidth;
        private TextBox Weight;
        private TextBox Height;
        private TextBox Age;
        private TextBox GoalWeight;
        private GroupBox SexCheck;
        private RadioButton femaleButton;
        private RadioButton maleButton;
        private GroupBox checkedGoals;
        private RadioButton WeightGain;
        private RadioButton WeightLoss;
        private RadioButton mainingWeight;
        private Label ResultTxt;
        private Label dailyСaloriestxt;
        private TextBox dailyСaloriesResult;
        private RichTextBox ResultFolder;
        private Button PrintResultButton;
    }
}