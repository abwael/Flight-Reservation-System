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
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(314, 282);
            button6.Name = "button6";
            button6.Size = new Size(156, 53);
            button6.TabIndex = 57;
            button6.Text = "Log out";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(314, 223);
            button5.Name = "button5";
            button5.Size = new Size(156, 53);
            button5.TabIndex = 56;
            button5.Text = "View Profile";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(314, 164);
            button1.Name = "button1";
            button1.Size = new Size(156, 53);
            button1.TabIndex = 52;
            button1.Text = "View available flights";
            button1.UseVisualStyleBackColor = true;
            // 
            // Welcome_text
            // 
            Welcome_text.AutoSize = true;
            Welcome_text.Font = new Font("Ubuntu", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            Welcome_text.Location = new Point(219, 51);
            Welcome_text.Name = "Welcome_text";
            Welcome_text.Size = new Size(147, 34);
            Welcome_text.TabIndex = 51;
            Welcome_text.Text = "Welcome, ";
            // 
            // PassengerPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}