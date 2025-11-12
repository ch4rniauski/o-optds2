namespace laba5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelMovie = new Label();
            comboBoxMovies = new ComboBox();
            labelLanguage = new Label();
            comboBoxLanguage = new ComboBox();
            ButtonOrder = new Button();
            textBoxInfo = new TextBox();
            SuspendLayout();
            // 
            // labelMovie
            // 
            labelMovie.AutoSize = true;
            labelMovie.Font = new Font("Arial", 10F, FontStyle.Bold);
            labelMovie.Location = new Point(20, 20);
            labelMovie.Name = "labelMovie";
            labelMovie.Size = new Size(138, 16);
            labelMovie.TabIndex = 0;
            labelMovie.Text = "Выберите фильм:";
            // 
            // comboBoxMovies
            // 
            comboBoxMovies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMovies.FormattingEnabled = true;
            comboBoxMovies.Location = new Point(20, 50);
            comboBoxMovies.Name = "comboBoxMovies";
            comboBoxMovies.Size = new Size(300, 23);
            comboBoxMovies.TabIndex = 1;
            // 
            // labelLanguage
            // 
            labelLanguage.AutoSize = true;
            labelLanguage.Font = new Font("Arial", 10F, FontStyle.Bold);
            labelLanguage.Location = new Point(20, 90);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(122, 16);
            labelLanguage.TabIndex = 2;
            labelLanguage.Text = "Выберите язык:";
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(20, 120);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(200, 23);
            comboBoxLanguage.TabIndex = 3;
            // 
            // ButtonOrder
            // 
            ButtonOrder.Font = new Font("Arial", 10F, FontStyle.Bold);
            ButtonOrder.Location = new Point(20, 160);
            ButtonOrder.Name = "ButtonOrder";
            ButtonOrder.Size = new Size(300, 40);
            ButtonOrder.TabIndex = 4;
            ButtonOrder.Text = "Заказать фильм";
            ButtonOrder.UseVisualStyleBackColor = true;
            ButtonOrder.Click += ButtonOrder_Click_1;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Font = new Font("Arial", 10F);
            textBoxInfo.Location = new Point(20, 220);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.ScrollBars = ScrollBars.Vertical;
            textBoxInfo.Size = new Size(440, 150);
            textBoxInfo.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 400);
            Controls.Add(textBoxInfo);
            Controls.Add(ButtonOrder);
            Controls.Add(comboBoxLanguage);
            Controls.Add(labelLanguage);
            Controls.Add(comboBoxMovies);
            Controls.Add(labelMovie);
            MaximumSize = new Size(516, 439);
            MinimumSize = new Size(516, 439);
            Name = "Form1";
            Text = "Кинопрокат";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelMovie;
        public ComboBox comboBoxMovies;
        public Label labelLanguage;
        public ComboBox comboBoxLanguage;
        public Button ButtonOrder;
        public TextBox textBoxInfo;
    }
}
