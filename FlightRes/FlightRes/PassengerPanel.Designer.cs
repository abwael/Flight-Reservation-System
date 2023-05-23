namespace FlightRes
{
    partial class PassengerPanel
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
            button6 = new Button();
            button5 = new Button();
            button1 = new Button();
            Welcome_text = new Label();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(395, 220);
            button6.Name = "button6";
            button6.Size = new Size(156, 53);
            button6.TabIndex = 57;
            button6.Text = "Log out";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(219, 220);
            button5.Name = "button5";
            button5.Size = new Size(156, 53);
            button5.TabIndex = 56;
            button5.Text = "View Profile";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(219, 161);
            button1.Name = "button1";
            button1.Size = new Size(156, 53);
            button1.TabIndex = 52;
            button1.Text = "View available flights";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Welcome_text
            // 
            Welcome_text.AutoSize = true;
            Welcome_text.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Welcome_text.Location = new Point(219, 51);
            Welcome_text.Name = "Welcome_text";
            Welcome_text.Size = new Size(156, 32);
            Welcome_text.TabIndex = 51;
            Welcome_text.Text = "Welcome, ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(369, 51);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 58;
            label1.Text = "First + Last";
            label1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(395, 161);
            button2.Name = "button2";
            button2.Size = new Size(156, 53);
            button2.TabIndex = 59;
            button2.Text = "View Booked Flights";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PassengerPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(Welcome_text);
            Name = "PassengerPanel";
            Text = "PassengerPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button1;
        private Label Welcome_text;
        private Label label1;
        private Button button2;
    }
}