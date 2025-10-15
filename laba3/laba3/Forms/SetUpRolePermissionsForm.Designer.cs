namespace laba3.Forms
{
    partial class SetUpRolePermissionsForm
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
            PermissionsListBox = new ListBox();
            ChangeDataPermissionCheckBox = new CheckBox();
            RolePermissionsLabel = new Label();
            ViewingDataPermissionCheckBox = new CheckBox();
            DeketeUserPermissionCheckBox = new CheckBox();
            GoBackButton = new Button();
            SuspendLayout();
            // 
            // PermissionsListBox
            // 
            PermissionsListBox.FormattingEnabled = true;
            PermissionsListBox.Location = new Point(12, 57);
            PermissionsListBox.Name = "PermissionsListBox";
            PermissionsListBox.Size = new Size(197, 424);
            PermissionsListBox.TabIndex = 0;
            PermissionsListBox.SelectedIndexChanged += PermissionsListBox_SelectedIndexChanged;
            // 
            // ChangeDataPermissionCheckBox
            // 
            ChangeDataPermissionCheckBox.AutoSize = true;
            ChangeDataPermissionCheckBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChangeDataPermissionCheckBox.Location = new Point(215, 51);
            ChangeDataPermissionCheckBox.Name = "ChangeDataPermissionCheckBox";
            ChangeDataPermissionCheckBox.Size = new Size(323, 24);
            ChangeDataPermissionCheckBox.TabIndex = 1;
            ChangeDataPermissionCheckBox.Text = "Изменение данных других пользователей";
            ChangeDataPermissionCheckBox.UseVisualStyleBackColor = true;
            ChangeDataPermissionCheckBox.CheckedChanged += ChangeDataPermissionCheckBox_CheckedChanged;
            // 
            // RolePermissionsLabel
            // 
            RolePermissionsLabel.AutoSize = true;
            RolePermissionsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RolePermissionsLabel.Location = new Point(215, 12);
            RolePermissionsLabel.Name = "RolePermissionsLabel";
            RolePermissionsLabel.Size = new Size(123, 25);
            RolePermissionsLabel.TabIndex = 2;
            RolePermissionsLabel.Text = "Разрешения:";
            // 
            // ViewingDataPermissionCheckBox
            // 
            ViewingDataPermissionCheckBox.AutoSize = true;
            ViewingDataPermissionCheckBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ViewingDataPermissionCheckBox.Location = new Point(215, 81);
            ViewingDataPermissionCheckBox.Name = "ViewingDataPermissionCheckBox";
            ViewingDataPermissionCheckBox.Size = new Size(314, 24);
            ViewingDataPermissionCheckBox.TabIndex = 3;
            ViewingDataPermissionCheckBox.Text = "Просмотр данных других пользователей";
            ViewingDataPermissionCheckBox.UseVisualStyleBackColor = true;
            ViewingDataPermissionCheckBox.CheckedChanged += ViewingDataPermissionCheckBox_CheckedChanged;
            // 
            // DeketeUserPermissionCheckBox
            // 
            DeketeUserPermissionCheckBox.AutoSize = true;
            DeketeUserPermissionCheckBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeketeUserPermissionCheckBox.Location = new Point(215, 111);
            DeketeUserPermissionCheckBox.Name = "DeketeUserPermissionCheckBox";
            DeketeUserPermissionCheckBox.Size = new Size(254, 24);
            DeketeUserPermissionCheckBox.TabIndex = 4;
            DeketeUserPermissionCheckBox.Text = "Удаление других пользователей";
            DeketeUserPermissionCheckBox.UseVisualStyleBackColor = true;
            DeketeUserPermissionCheckBox.CheckedChanged += DeketeUserPermissionCheckBox_CheckedChanged;
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
            // SetUpRolePermissionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(950, 500);
            Controls.Add(GoBackButton);
            Controls.Add(DeketeUserPermissionCheckBox);
            Controls.Add(ViewingDataPermissionCheckBox);
            Controls.Add(RolePermissionsLabel);
            Controls.Add(ChangeDataPermissionCheckBox);
            Controls.Add(PermissionsListBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SetUpRolePermissionsForm";
            Text = "SetUpRoleRightsForm";
            Load += SetUpRolePermissionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox PermissionsListBox;
        private CheckBox ChangeDataPermissionCheckBox;
        private Label RolePermissionsLabel;
        private CheckBox ViewingDataPermissionCheckBox;
        private CheckBox DeketeUserPermissionCheckBox;
        private Button GoBackButton;
    }
}