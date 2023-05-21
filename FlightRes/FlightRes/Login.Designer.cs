namespace FlightRes
{
    partial class Login
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
            Welcome_text = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Welcome_text
            // 
            Welcome_text.AutoSize = true;
            Welcome_text.Font = new Font("Ubuntu", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            Welcome_text.Location = new Point(365, 83);
            Welcome_text.Name = "Welcome_text";
            Welcome_text.Size = new Size(86, 34);
            Welcome_text.TabIndex = 1;
            Welcome_text.Text = "Login";
            Welcome_text.Click += Welcome_text_Click_1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(377, 146);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(74, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Admin";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(457, 145);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Passenger";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ubuntu", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 140);
            label1.Name = "label1";
            label1.Size = new Size(104, 29);
            label1.TabIndex = 4;
            label1.Text = "Login as:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(329, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(329, 228);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(246, 27);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ubuntu", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(246, 181);
            label2.Name = "label2";
            label2.Size = new Size(77, 29);
            label2.TabIndex = 7;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ubuntu", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(204, 223);
            label3.Name = "label3";
            label3.Size = new Size(119, 29);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            // 
            // button1
            // 
            button1.Location = new Point(230, 300);
            button1.Name = "button1";
            button1.Size = new Size(156, 53);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(403, 300);
            button2.Name = "button2";
            button2.Size = new Size(156, 53);
            button2.TabIndex = 36;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(Welcome_text);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Welcome_text;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}