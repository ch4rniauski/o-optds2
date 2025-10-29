namespace laba3.Forms
{
    partial class ViewUserForm
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
            UsersListBox = new ListBox();
            GoBackButton = new Button();
            DeleteUserButton = new Button();
            ChangeUserDataButton = new Button();
            ViewUserDataButton = new Button();
            SelectedUserNameLabel = new Label();
            SelectedUserPhoneNumberLabel = new Label();
            SelectedUserEmailLabel = new Label();
            ChangeSelectedUserRoleButton = new Button();
            ChangeUserRoleComboBox = new ComboBox();
            CurrentUserRoleLabel = new Label();
            SuspendLayout();
            // 
            // UsersListBox
            // 
            UsersListBox.FormattingEnabled = true;
            UsersListBox.Location = new Point(12, 61);
            UsersListBox.Name = "UsersListBox";
            UsersListBox.Size = new Size(256, 424);
            UsersListBox.TabIndex = 0;
            UsersListBox.SelectedIndexChanged += UsersListBox_SelectedIndexChanged;
            // 
            // GoBackButton
            // 
            GoBackButton.Location = new Point(12, 12);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(114, 43);
            GoBackButton.TabIndex = 5;
            GoBackButton.Text = "Назад";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Enabled = false;
            DeleteUserButton.Location = new Point(824, 442);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(114, 43);
            DeleteUserButton.TabIndex = 6;
            DeleteUserButton.Text = "Удалить пользователя";
            DeleteUserButton.UseVisualStyleBackColor = true;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // ChangeUserDataButton
            // 
            ChangeUserDataButton.Enabled = false;
            ChangeUserDataButton.Location = new Point(704, 442);
            ChangeUserDataButton.Name = "ChangeUserDataButton";
            ChangeUserDataButton.Size = new Size(114, 43);
            ChangeUserDataButton.TabIndex = 7;
            ChangeUserDataButton.Text = "Изменить данные";
            ChangeUserDataButton.UseVisualStyleBackColor = true;
            ChangeUserDataButton.Click += ChangeUserDataButton_Click;
            // 
            // ViewUserDataButton
            // 
            ViewUserDataButton.Enabled = false;
            ViewUserDataButton.Location = new Point(464, 442);
            ViewUserDataButton.Name = "ViewUserDataButton";
            ViewUserDataButton.Size = new Size(114, 43);
            ViewUserDataButton.TabIndex = 8;
            ViewUserDataButton.Text = "Просмотреть информацию";
            ViewUserDataButton.UseVisualStyleBackColor = true;
            ViewUserDataButton.Click += ViewUserDataButton_Click;
            // 
            // SelectedUserNameLabel
            // 
            SelectedUserNameLabel.AutoSize = true;
            SelectedUserNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SelectedUserNameLabel.Location = new Point(274, 61);
            SelectedUserNameLabel.Name = "SelectedUserNameLabel";
            SelectedUserNameLabel.Size = new Size(53, 25);
            SelectedUserNameLabel.TabIndex = 9;
            SelectedUserNameLabel.Text = "Имя:";
            // 
            // SelectedUserPhoneNumberLabel
            // 
            SelectedUserPhoneNumberLabel.AutoSize = true;
            SelectedUserPhoneNumberLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SelectedUserPhoneNumberLabel.Location = new Point(274, 86);
            SelectedUserPhoneNumberLabel.Name = "SelectedUserPhoneNumberLabel";
            SelectedUserPhoneNumberLabel.Size = new Size(91, 25);
            SelectedUserPhoneNumberLabel.TabIndex = 10;
            SelectedUserPhoneNumberLabel.Text = "Телефон:";
            // 
            // SelectedUserEmailLabel
            // 
            SelectedUserEmailLabel.AutoSize = true;
            SelectedUserEmailLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SelectedUserEmailLabel.Location = new Point(274, 111);
            SelectedUserEmailLabel.Name = "SelectedUserEmailLabel";
            SelectedUserEmailLabel.Size = new Size(62, 25);
            SelectedUserEmailLabel.TabIndex = 11;
            SelectedUserEmailLabel.Text = "Email:";
            // 
            // ChangeSelectedUserRoleButton
            // 
            ChangeSelectedUserRoleButton.Enabled = false;
            ChangeSelectedUserRoleButton.Location = new Point(584, 442);
            ChangeSelectedUserRoleButton.Name = "ChangeSelectedUserRoleButton";
            ChangeSelectedUserRoleButton.Size = new Size(114, 43);
            ChangeSelectedUserRoleButton.TabIndex = 12;
            ChangeSelectedUserRoleButton.Text = "Изменить роль";
            ChangeSelectedUserRoleButton.UseVisualStyleBackColor = true;
            ChangeSelectedUserRoleButton.Click += ChangeSelectedUserRoleButton_Click;
            // 
            // ChangeUserRoleComboBox
            // 
            ChangeUserRoleComboBox.FormattingEnabled = true;
            ChangeUserRoleComboBox.Location = new Point(274, 167);
            ChangeUserRoleComboBox.Name = "ChangeUserRoleComboBox";
            ChangeUserRoleComboBox.Size = new Size(121, 23);
            ChangeUserRoleComboBox.TabIndex = 13;
            ChangeUserRoleComboBox.SelectedIndexChanged += ComboBoxRoles_SelectedIndexChanged;
            // 
            // CurrentUserRoleLabel
            // 
            CurrentUserRoleLabel.AutoSize = true;
            CurrentUserRoleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CurrentUserRoleLabel.Location = new Point(274, 139);
            CurrentUserRoleLabel.Name = "CurrentUserRoleLabel";
            CurrentUserRoleLabel.Size = new Size(137, 25);
            CurrentUserRoleLabel.TabIndex = 14;
            CurrentUserRoleLabel.Text = "Текущая роль:";
            // 
            // ViewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(950, 500);
            Controls.Add(CurrentUserRoleLabel);
            Controls.Add(ChangeUserRoleComboBox);
            Controls.Add(ChangeSelectedUserRoleButton);
            Controls.Add(SelectedUserEmailLabel);
            Controls.Add(SelectedUserPhoneNumberLabel);
            Controls.Add(SelectedUserNameLabel);
            Controls.Add(ViewUserDataButton);
            Controls.Add(ChangeUserDataButton);
            Controls.Add(DeleteUserButton);
            Controls.Add(GoBackButton);
            Controls.Add(UsersListBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewUserForm";
            Text = "ViewUserForm";
            Load += ViewUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox UsersListBox;
        private Button GoBackButton;
        private Button DeleteUserButton;
        private Button ChangeUserDataButton;
        private Button ViewUserDataButton;
        private Label SelectedUserNameLabel;
        private Label SelectedUserPhoneNumberLabel;
        private Label SelectedUserEmailLabel;
        private Button ChangeSelectedUserRoleButton;
        private ComboBox ChangeUserRoleComboBox;
        private Label CurrentUserRoleLabel;
    }
}