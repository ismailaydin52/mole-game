namespace kostebek
{
    partial class Form2
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
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(254, 92);
            label1.Name = "label1";
            label1.Size = new Size(458, 54);
            label1.TabIndex = 0;
            label1.Text = "Köstebek Vurmaca";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Font = new Font("Stencil", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.LightCoral;
            button1.Location = new Point(388, 218);
            button1.Name = "button1";
            button1.Size = new Size(203, 71);
            button1.TabIndex = 1;
            button1.Text = "Basla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_419184605_9wICyRFBh3eY7SaUaB8ayW2QpjgE4Fl3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 519);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}