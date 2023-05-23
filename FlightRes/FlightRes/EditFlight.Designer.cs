namespace FlightRes
{
    partial class EditFlight
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
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            Welcome_text = new Label();
            goodNews = new Label();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(225, 236);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(180, 27);
            dateTimePicker3.TabIndex = 93;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(565, 236);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(180, 27);
            dateTimePicker2.TabIndex = 92;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(554, 191);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(191, 27);
            dateTimePicker1.TabIndex = 91;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(381, 276);
            label1.Name = "label1";
            label1.Size = new Size(206, 29);
            label1.TabIndex = 88;
            label1.Text = "Destination Place:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(31, 274);
            label8.Name = "label8";
            label8.Size = new Size(163, 29);
            label8.TabIndex = 87;
            label8.Text = "Source Place:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(597, 278);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(148, 27);
            textBox7.TabIndex = 86;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(200, 276);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(167, 27);
            textBox8.TabIndex = 85;
            // 
            // Welcome_text
            // 
            Welcome_text.AutoSize = true;
            Welcome_text.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Welcome_text.Location = new Point(312, 47);
            Welcome_text.Name = "Welcome_text";
            Welcome_text.Size = new Size(153, 32);
            Welcome_text.TabIndex = 84;
            Welcome_text.Text = "Edit Flight";
            // 
            // goodNews
            // 
            goodNews.AutoSize = true;
            goodNews.Location = new Point(344, 329);
            goodNews.Name = "goodNews";
            goodNews.Size = new Size(0, 20);
            goodNews.TabIndex = 83;
            goodNews.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(412, 359);
            button2.Name = "button2";
            button2.Size = new Size(156, 50);
            button2.TabIndex = 82;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(35, 234);
            label6.Name = "label6";
            label6.Size = new Size(191, 29);
            label6.TabIndex = 81;
            label6.Text = "Luanching Time:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(422, 234);
            label7.Name = "label7";
            label7.Size = new Size(148, 29);
            label7.TabIndex = 80;
            label7.Text = "Arrival Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(422, 191);
            label4.Name = "label4";
            label4.Size = new Size(135, 29);
            label4.TabIndex = 79;
            label4.Text = "Flight Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(35, 187);
            label5.Name = "label5";
            label5.Size = new Size(154, 29);
            label5.TabIndex = 78;
            label5.Text = "Admin Email:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(187, 191);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(218, 27);
            textBox4.TabIndex = 77;
            // 
            // button1
            // 
            button1.Location = new Point(239, 359);
            button1.Name = "button1";
            button1.Size = new Size(156, 50);
            button1.TabIndex = 76;
            button1.Text = "Edit Flight";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(435, 148);
            label3.Name = "label3";
            label3.Size = new Size(122, 29);
            label3.TabIndex = 75;
            label3.Text = "Aircraft ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 144);
            label2.Name = "label2";
            label2.Size = new Size(172, 29);
            label2.TabIndex = 74;
            label2.Text = "Flight Number:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(553, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 27);
            textBox2.TabIndex = 73;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 72;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(158, 94);
            label9.Name = "label9";
            label9.Size = new Size(199, 29);
            label9.TabIndex = 94;
            label9.Text = "Enter Flight Num:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(363, 98);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 27);
            textBox3.TabIndex = 95;
            // 
            // button3
            // 
            button3.Location = new Point(496, 94);
            button3.Name = "button3";
            button3.Size = new Size(91, 38);
            button3.TabIndex = 96;
            button3.Text = "Load Data";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // EditFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(Welcome_text);
            Controls.Add(goodNews);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "EditFlight";
            Text = "EditFlight";
            Load += EditFlight_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label8;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label Welcome_text;
        private Label goodNews;
        private Button button2;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox3;
        private Button button3;
    }
}