namespace laba6._2
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
            cbBodyType = new ComboBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            txtAge = new TextBox();
            cbGender = new ComboBox();
            cbActivity = new ComboBox();
            btnCalculate = new Button();
            lblResult = new Label();
            labelBodyType = new Label();
            labelGender = new Label();
            labelActivity = new Label();
            labelHeight = new Label();
            labelWeight = new Label();
            labelAge = new Label();
            SuspendLayout();
            // 
            // cbBodyType
            // 
            cbBodyType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBodyType.Items.AddRange(new object[] { "Астеник", "Нормостеник", "Гиперстеник" });
            cbBodyType.Location = new Point(180, 20);
            cbBodyType.Name = "cbBodyType";
            cbBodyType.Size = new Size(150, 23);
            cbBodyType.TabIndex = 0;
            cbBodyType.Tag = "";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(180, 60);
            txtHeight.Name = "txtHeight";
            txtHeight.PlaceholderText = "Рост (см)";
            txtHeight.Size = new Size(150, 23);
            txtHeight.TabIndex = 1;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(180, 100);
            txtWeight.Name = "txtWeight";
            txtWeight.PlaceholderText = "Вес (кг)";
            txtWeight.Size = new Size(150, 23);
            txtWeight.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(180, 140);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Возраст (лет)";
            txtAge.Size = new Size(150, 23);
            txtAge.TabIndex = 3;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Items.AddRange(new object[] { "Мужской", "Женский" });
            cbGender.Location = new Point(180, 180);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(150, 23);
            cbGender.TabIndex = 4;
            // 
            // cbActivity
            // 
            cbActivity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbActivity.Items.AddRange(new object[] { "Низкая", "Средняя", "Высокая" });
            cbActivity.Location = new Point(180, 220);
            cbActivity.Name = "cbActivity";
            cbActivity.Size = new Size(150, 23);
            cbActivity.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(180, 260);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 30);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Рассчитать";
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(30, 300);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(420, 100);
            lblResult.TabIndex = 7;
            lblResult.Text = "Результат:";
            // 
            // labelBodyType
            // 
            labelBodyType.AutoSize = true;
            labelBodyType.Location = new Point(60, 23);
            labelBodyType.Name = "labelBodyType";
            labelBodyType.Size = new Size(114, 15);
            labelBodyType.TabIndex = 8;
            labelBodyType.Text = "Тип телосложения:";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(141, 183);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(33, 15);
            labelGender.TabIndex = 9;
            labelGender.Text = "Пол:";
            // 
            // labelActivity
            // 
            labelActivity.AutoSize = true;
            labelActivity.Location = new Point(35, 223);
            labelActivity.Name = "labelActivity";
            labelActivity.Size = new Size(139, 15);
            labelActivity.TabIndex = 10;
            labelActivity.Text = "Физическая активность:";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(113, 63);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(61, 15);
            labelHeight.TabIndex = 11;
            labelHeight.Text = "Рост (см):";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(113, 103);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(51, 15);
            labelWeight.TabIndex = 12;
            labelWeight.Text = "Вес (кг):";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(92, 143);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(82, 15);
            labelAge.TabIndex = 13;
            labelAge.Text = "Возраст (лет):";
            // 
            // Form1
            // 
            ClientSize = new Size(480, 420);
            Controls.Add(labelAge);
            Controls.Add(labelWeight);
            Controls.Add(labelHeight);
            Controls.Add(labelActivity);
            Controls.Add(labelGender);
            Controls.Add(labelBodyType);
            Controls.Add(cbBodyType);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(txtAge);
            Controls.Add(cbGender);
            Controls.Add(cbActivity);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            MaximumSize = new Size(496, 459);
            MinimumSize = new Size(496, 459);
            Name = "Form1";
            Text = "Фасад";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbBodyType;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private TextBox txtAge;
        private ComboBox cbGender;
        private ComboBox cbActivity;
        private Button btnCalculate;
        private Label lblResult;
        private Label labelBodyType;
        private Label labelGender;
        private Label labelActivity;
        private Label labelHeight;
        private Label labelWeight;
        private Label labelAge;
    }
}
