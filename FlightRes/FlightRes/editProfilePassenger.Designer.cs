namespace FlightRes
{
    partial class editProfilePassenger
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
            button3 = new Button();
            goodNews = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Welcome_text = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(303, 298);
            button3.Name = "button3";
            button3.Size = new Size(156, 53);
            button3.TabIndex = 90;
            button3.Text = "Edit Password";
            button3.UseVisualStyleBackColor = true;
            // 
            // goodNews
            // 
            goodNews.AutoSize = true;
            goodNews.Location = new Point(386, 209);
            goodNews.Name = "goodNews";
            goodNews.Size = new Size(0, 20);
            goodNews.TabIndex = 89;
            goodNews.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(303, 357);
            button2.Name = "button2";
            button2.Size = new Size(156, 53);
            button2.TabIndex = 88;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(377, 149);
            label4.Name = "label4";
            label4.Size = new Size(182, 29);
            label4.TabIndex = 87;
            label4.Text = "Phone Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(377, 109);
            label5.Name = "label5";
            label5.Size = new Size(80, 29);
            label5.TabIndex = 86;
            label5.Text = "Email:";
            // 
            // textBox3
            // 
            textBox3.HideSelection = false;
            textBox3.Location = new Point(560, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 27);
            textBox3.TabIndex = 85;
            // 
            // textBox4
            // 
            textBox4.HideSelection = false;
            textBox4.Location = new Point(460, 104);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(292, 27);
            textBox4.TabIndex = 84;
            // 
            // button1
            // 
            button1.Location = new Point(303, 239);
            button1.Name = "button1";
            button1.Size = new Size(156, 53);
            button1.TabIndex = 83;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 146);
            label3.Name = "label3";
            label3.Size = new Size(134, 29);
            label3.TabIndex = 82;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 104);
            label2.Name = "label2";
            label2.Size = new Size(137, 29);
            label2.TabIndex = 81;
            label2.Text = "First Name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 27);
            textBox2.TabIndex = 80;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 79;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Welcome_text
            // 
            Welcome_text.AutoSize = true;
            Welcome_text.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Welcome_text.Location = new Point(334, 40);
            Welcome_text.Name = "Welcome_text";
            Welcome_text.Size = new Size(103, 32);
            Welcome_text.TabIndex = 78;
            Welcome_text.Text = "Profile";
            Welcome_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editProfilePassenger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(goodNews);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Welcome_text);
            Name = "editProfilePassenger";
            Text = "Edit Profile";
            Load += editProfilePassenger_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label goodNews;
        private Button button2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label Welcome_text;
    }
}