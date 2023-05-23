namespace FlightRes
{
    partial class AddAircraft
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
            label10 = new Label();
            textBox10 = new TextBox();
            Welcome_text = new Label();
            goodNews = new Label();
            button2 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(417, 184);
            label10.Name = "label10";
            label10.Size = new Size(141, 29);
            label10.TabIndex = 90;
            label10.Text = "Total Seats:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(564, 184);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(181, 27);
            textBox10.TabIndex = 89;
            // 
            // Welcome_text
            // 
            Welcome_text.AutoSize = true;
            Welcome_text.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Welcome_text.Location = new Point(316, 64);
            Welcome_text.Name = "Welcome_text";
            Welcome_text.Size = new Size(174, 32);
            Welcome_text.TabIndex = 84;
            Welcome_text.Text = "Add Aircraft";
            // 
            // goodNews
            // 
            goodNews.AutoSize = true;
            goodNews.Location = new Point(349, 295);
            goodNews.Name = "goodNews";
            goodNews.Size = new Size(0, 20);
            goodNews.TabIndex = 83;
            goodNews.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(417, 327);
            button2.Name = "button2";
            button2.Size = new Size(156, 53);
            button2.TabIndex = 82;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(77, 133);
            label5.Name = "label5";
            label5.Size = new Size(154, 29);
            label5.TabIndex = 78;
            label5.Text = "Admin Email:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(229, 137);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(516, 27);
            textBox4.TabIndex = 77;
            // 
            // button1
            // 
            button1.Location = new Point(244, 327);
            button1.Name = "button1";
            button1.Size = new Size(156, 53);
            button1.TabIndex = 76;
            button1.Text = "Add Aircraft";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(76, 184);
            label3.Name = "label3";
            label3.Size = new Size(122, 29);
            label3.TabIndex = 75;
            label3.Text = "Aircraft ID:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 27);
            textBox2.TabIndex = 73;
            // 
            // AddAircraft
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(textBox10);
            Controls.Add(Welcome_text);
            Controls.Add(goodNews);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Name = "AddAircraft";
            Text = "AddAircraft";
            Load += AddAircraft_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private TextBox textBox10;
        private Label Welcome_text;
        private Label goodNews;
        private Button button2;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
        private Label label3;
        private TextBox textBox2;
    }
}