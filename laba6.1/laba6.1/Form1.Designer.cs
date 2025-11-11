namespace laba6._1
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
            txtDV = new TextBox();
            txtT0 = new TextBox();
            txtT1 = new TextBox();
            btnCalculate = new Button();
            lblPressureChange = new Label();
            lblPassport = new Label();
            lblDV = new Label();
            lblT0 = new Label();
            lblT1 = new Label();
            SuspendLayout();
            // 
            // txtDV
            // 
            txtDV.Location = new Point(200, 30);
            txtDV.Name = "txtDV";
            txtDV.Size = new Size(100, 23);
            txtDV.TabIndex = 0;
            // 
            // txtT0
            // 
            txtT0.Location = new Point(200, 70);
            txtT0.Name = "txtT0";
            txtT0.Size = new Size(100, 23);
            txtT0.TabIndex = 1;
            // 
            // txtT1
            // 
            txtT1.Location = new Point(200, 110);
            txtT1.Name = "txtT1";
            txtT1.Size = new Size(100, 23);
            txtT1.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(30, 150);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(270, 30);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Выполнить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblPressureChange
            // 
            lblPressureChange.Location = new Point(30, 195);
            lblPressureChange.Name = "lblPressureChange";
            lblPressureChange.Size = new Size(400, 40);
            lblPressureChange.TabIndex = 4;
            lblPressureChange.Text = "Изменение давления:";
            // 
            // lblPassport
            // 
            lblPassport.Location = new Point(30, 240);
            lblPassport.Name = "lblPassport";
            lblPassport.Size = new Size(400, 40);
            lblPassport.TabIndex = 5;
            lblPassport.Text = "Данные объекта:";
            // 
            // lblDV
            // 
            lblDV.Location = new Point(30, 30);
            lblDV.Name = "lblDV";
            lblDV.Size = new Size(150, 20);
            lblDV.TabIndex = 0;
            lblDV.Text = "Изменение объема dV:";
            lblDV.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblT0
            // 
            lblT0.Location = new Point(30, 70);
            lblT0.Name = "lblT0";
            lblT0.Size = new Size(150, 20);
            lblT0.TabIndex = 1;
            lblT0.Text = "Температура T0 (°C):";
            lblT0.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblT1
            // 
            lblT1.Location = new Point(30, 110);
            lblT1.Name = "lblT1";
            lblT1.Size = new Size(150, 20);
            lblT1.TabIndex = 2;
            lblT1.Text = "Температура T1 (°C):";
            lblT1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 320);
            Controls.Add(lblDV);
            Controls.Add(txtDV);
            Controls.Add(lblT0);
            Controls.Add(txtT0);
            Controls.Add(lblT1);
            Controls.Add(txtT1);
            Controls.Add(btnCalculate);
            Controls.Add(lblPressureChange);
            Controls.Add(lblPassport);
            MaximumSize = new Size(476, 359);
            MinimumSize = new Size(476, 359);
            Name = "Form1";
            Text = "Задание 3. Вариант 2. Адаптер класса";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox txtDV;
        private TextBox txtT1;
        private TextBox txtT0;
        private Button btnCalculate;
        private Label lblPressureChange;
        private Label lblPassport;
        private Label lblDV;
        private Label lblT0;
        private Label lblT1;
    }
}
