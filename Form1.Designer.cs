namespace temperature
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            txtvalue = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            radioButton1.Location = new Point(373, 102);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(178, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Celcuis to Farenheit";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            radioButton2.Location = new Point(178, 102);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(177, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Farenheit to Celsius";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(326, 68);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 2;
            label1.Text = "CONVERT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(317, 144);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 3;
            label2.Text = "Enter any Value";
            // 
            // txtvalue
            // 
            txtvalue.Location = new Point(298, 185);
            txtvalue.Name = "txtvalue";
            txtvalue.Size = new Size(150, 23);
            txtvalue.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(298, 230);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 5;
            button1.Text = "Get Temperature";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 282);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(257, 25);
            label4.Name = "label4";
            label4.Size = new Size(220, 25);
            label4.TabIndex = 7;
            label4.Text = "Temperature Converter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(773, 319);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtvalue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private Label label2;
        private TextBox txtvalue;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}
