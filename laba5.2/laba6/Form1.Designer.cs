namespace laba6
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
            ButtonGenerate = new Button();
            labelFigureName = new Label();
            PanelFigure = new Panel();
            labelFigureType = new Label();
            SuspendLayout();
            // 
            // ButtonGenerate
            // 
            ButtonGenerate.Font = new Font("Arial", 10F, FontStyle.Bold);
            ButtonGenerate.Location = new Point(20, 20);
            ButtonGenerate.Name = "ButtonGenerate";
            ButtonGenerate.Size = new Size(200, 40);
            ButtonGenerate.TabIndex = 0;
            ButtonGenerate.Text = "Генерировать фигуру";
            ButtonGenerate.UseVisualStyleBackColor = true;
            ButtonGenerate.Click += ButtonGenerate_Click_1;
            // 
            // labelFigureName
            // 
            labelFigureName.AutoSize = true;
            labelFigureName.Font = new Font("Arial", 12F, FontStyle.Bold);
            labelFigureName.Location = new Point(20, 70);
            labelFigureName.Name = "labelFigureName";
            labelFigureName.Size = new Size(83, 19);
            labelFigureName.TabIndex = 1;
            labelFigureName.Text = "Фигура: -";
            // 
            // PanelFigure
            // 
            PanelFigure.BackColor = Color.White;
            PanelFigure.BorderStyle = BorderStyle.FixedSingle;
            PanelFigure.Location = new Point(20, 110);
            PanelFigure.Name = "PanelFigure";
            PanelFigure.Size = new Size(400, 300);
            PanelFigure.TabIndex = 2;
            PanelFigure.Paint += PanelFigure_Paint_1;
            // 
            // labelFigureType
            // 
            labelFigureType.AutoSize = true;
            labelFigureType.Font = new Font("Arial", 11F);
            labelFigureType.Location = new Point(20, 420);
            labelFigureType.Name = "labelFigureType";
            labelFigureType.Size = new Size(104, 17);
            labelFigureType.TabIndex = 3;
            labelFigureType.Text = "Тип: Обычная";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 500);
            Controls.Add(labelFigureType);
            Controls.Add(PanelFigure);
            Controls.Add(labelFigureName);
            Controls.Add(ButtonGenerate);
            MaximumSize = new Size(516, 539);
            MinimumSize = new Size(516, 539);
            Name = "Form1";
            Text = "Тетрис - Factory Method";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button ButtonGenerate;
        public Label labelFigureName;
        public Panel PanelFigure;
        public Label labelFigureType;
    }
}
