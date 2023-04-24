namespace Lab7
{
    partial class Lab7
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
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(394, 36);
            button1.TabIndex = 0;
            button1.Text = "Обчислення значення виразу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(11, 75);
            button3.Name = "button3";
            button3.Size = new Size(394, 36);
            button3.TabIndex = 1;
            button3.Text = "Обчислення значення функції у точці";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(11, 130);
            button2.Name = "button2";
            button2.Size = new Size(394, 36);
            button2.TabIndex = 2;
            button2.Text = "Обчислення значення функції у декількох точках";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 402);
            button4.Name = "button4";
            button4.Size = new Size(394, 36);
            button4.TabIndex = 3;
            button4.Text = "Завершити роботу програми";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 169);
            label1.Name = "label1";
            label1.Size = new Size(406, 151);
            label1.TabIndex = 4;
            label1.Text = "Програма має можливість запам'ятовувати попереднє значення та автоматично його присвоювати при введенні порожнього рядка. Ця умова є передумовою для отримання додаткових +2 балів до оцінки.";
            label1.Click += label1_Click;
            // 
            // Lab7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 450);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Lab7";
            Text = "Lab 7";
            Load += Lab7_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Label label1;
    }
}