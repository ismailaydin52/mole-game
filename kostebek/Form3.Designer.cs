namespace kostebek
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(471, 118);
            label1.Name = "label1";
            label1.Size = new Size(43, 47);
            label1.TabIndex = 0;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(425, 30);
            label2.Name = "label2";
            label2.Size = new Size(139, 54);
            label2.TabIndex = 1;
            label2.Text = "Skor";
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(416, 180);
            button1.Name = "button1";
            button1.Size = new Size(159, 82);
            button1.TabIndex = 2;
            button1.Text = "Tekrar Oyna";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Bisque;
            button2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkOrange;
            button2.Location = new Point(416, 290);
            button2.Name = "button2";
            button2.Size = new Size(159, 82);
            button2.TabIndex = 3;
            button2.Text = "Çıkıs";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_419184605_9wICyRFBh3eY7SaUaB8ayW2QpjgE4Fl3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(966, 500);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}