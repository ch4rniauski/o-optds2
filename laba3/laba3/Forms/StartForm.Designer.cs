namespace laba3.Forms
{
    partial class StartForm
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
            AddUserButton = new Button();
            ViewUserButton = new Button();
            SetUpRoleRightsButton = new Button();
            SuspendLayout();
            // 
            // AddUserButton
            // 
            AddUserButton.Location = new Point(12, 223);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(110, 55);
            AddUserButton.TabIndex = 0;
            AddUserButton.Text = "Добавить пользователя";
            AddUserButton.UseVisualStyleBackColor = true;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // ViewUserButton
            // 
            ViewUserButton.Location = new Point(420, 223);
            ViewUserButton.Name = "ViewUserButton";
            ViewUserButton.Size = new Size(110, 55);
            ViewUserButton.TabIndex = 1;
            ViewUserButton.Text = "Просмотр пользователя";
            ViewUserButton.UseVisualStyleBackColor = true;
            ViewUserButton.Click += ViewUserButton_Click;
            // 
            // SetUpRoleRightsButton
            // 
            SetUpRoleRightsButton.Location = new Point(828, 223);
            SetUpRoleRightsButton.Name = "SetUpRoleRightsButton";
            SetUpRoleRightsButton.Size = new Size(110, 55);
            SetUpRoleRightsButton.TabIndex = 2;
            SetUpRoleRightsButton.Text = "Настройка прав для каждой роли";
            SetUpRoleRightsButton.UseVisualStyleBackColor = true;
            SetUpRoleRightsButton.Click += SetUpRoleRightsButton_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(950, 500);
            Controls.Add(SetUpRoleRightsButton);
            Controls.Add(ViewUserButton);
            Controls.Add(AddUserButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartForm";
            Text = "StartForm";
            ResumeLayout(false);
        }

        #endregion

        private Button AddUserButton;
        private Button ViewUserButton;
        private Button SetUpRoleRightsButton;
    }
}