﻿namespace FlightRes
{
    partial class Start
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
            Welcome_text = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Welcome_text
            // 
            Welcome_text.AutoSize = true;
            Welcome_text.Font = new Font("Ubuntu", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            Welcome_text.Location = new Point(106, 93);
            Welcome_text.Name = "Welcome_text";
            Welcome_text.Size = new Size(580, 34);
            Welcome_text.TabIndex = 0;
            Welcome_text.Text = "Welcome to FCAI Flight Reservation System";
            Welcome_text.Click += label1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(303, 254);
            button2.Name = "button2";
            button2.Size = new Size(175, 56);
            button2.TabIndex = 3;
            button2.Text = "Signup";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(303, 179);
            button1.Name = "button1";
            button1.Size = new Size(175, 56);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Welcome_text);
            Name = "Start";
            Text = "Flight Reservation";
            Load += Start_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Welcome_text;
        private Button button2;
        private Button button1;
    }
}