namespace laba3.Forms
{
    partial class AddUserForm
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
            PhoneNumberTextBox = new TextBox();
            EmailTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            SubmitButton = new Button();
            GoBackButton = new Button();
            PhoneNumberLabel = new Label();
            FullNameLabel = new Label();
            EmailLabel = new Label();
            PhoneNumberErrorLabel = new Label();
            EmailErrorLabel = new Label();
            FullNameErrorLabel = new Label();
            SuspendLayout();
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(376, 85);
            PhoneNumberTextBox.MaxLength = 15;
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(198, 23);
            PhoneNumberTextBox.TabIndex = 0;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(376, 163);
            EmailTextBox.MaxLength = 50;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(198, 23);
            EmailTextBox.TabIndex = 1;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(376, 251);
            FullNameTextBox.MaxLength = 70;
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(198, 23);
            FullNameTextBox.TabIndex = 2;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(418, 326);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(114, 43);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "Подтвердить";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // GoBackButton
            // 
            GoBackButton.Location = new Point(12, 12);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(114, 43);
            GoBackButton.TabIndex = 4;
            GoBackButton.Text = "Назад";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(403, 67);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(145, 15);
            PhoneNumberLabel.TabIndex = 6;
            PhoneNumberLabel.Text = "Введите номер телефона";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(435, 233);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(80, 15);
            FullNameLabel.TabIndex = 7;
            FullNameLabel.Text = "Введите ФИО";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(434, 145);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(82, 15);
            EmailLabel.TabIndex = 8;
            EmailLabel.Text = "Введите Email";
            // 
            // PhoneNumberErrorLabel
            // 
            PhoneNumberErrorLabel.AutoSize = true;
            PhoneNumberErrorLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PhoneNumberErrorLabel.ForeColor = Color.Red;
            PhoneNumberErrorLabel.Location = new Point(351, 47);
            PhoneNumberErrorLabel.Name = "PhoneNumberErrorLabel";
            PhoneNumberErrorLabel.Size = new Size(274, 20);
            PhoneNumberErrorLabel.TabIndex = 9;
            PhoneNumberErrorLabel.Text = "Некорректно введен номер телефона";
            // 
            // EmailErrorLabel
            // 
            EmailErrorLabel.AutoSize = true;
            EmailErrorLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EmailErrorLabel.ForeColor = Color.Red;
            EmailErrorLabel.Location = new Point(376, 125);
            EmailErrorLabel.Name = "EmailErrorLabel";
            EmailErrorLabel.Size = new Size(195, 20);
            EmailErrorLabel.TabIndex = 10;
            EmailErrorLabel.Text = "Некорректно введен Email";
            // 
            // FullNameErrorLabel
            // 
            FullNameErrorLabel.AutoSize = true;
            FullNameErrorLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameErrorLabel.ForeColor = Color.Red;
            FullNameErrorLabel.Location = new Point(374, 213);
            FullNameErrorLabel.Name = "FullNameErrorLabel";
            FullNameErrorLabel.Size = new Size(200, 20);
            FullNameErrorLabel.TabIndex = 11;
            FullNameErrorLabel.Text = "Некорректно введено ФИО";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(950, 500);
            Controls.Add(FullNameErrorLabel);
            Controls.Add(EmailErrorLabel);
            Controls.Add(PhoneNumberErrorLabel);
            Controls.Add(EmailLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(GoBackButton);
            Controls.Add(SubmitButton);
            Controls.Add(FullNameTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(PhoneNumberTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUserForm";
            Text = "AddUserForm";
            Load += AddUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PhoneNumberTextBox;
        private TextBox EmailTextBox;
        private TextBox FullNameTextBox;
        private Button SubmitButton;
        private Button GoBackButton;
        private Label PhoneNumberLabel;
        private Label FullNameLabel;
        private Label EmailLabel;
        private Label PhoneNumberErrorLabel;
        private Label EmailErrorLabel;
        private Label FullNameErrorLabel;
    }
}