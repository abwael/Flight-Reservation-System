namespace FlightRes
{
    partial class AdminPanel
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
            this.Welcome_text = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Welcome_text
            // 
            this.Welcome_text.AutoSize = true;
            this.Welcome_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Welcome_text.Location = new System.Drawing.Point(233, 33);
            this.Welcome_text.Name = "Welcome_text";
            this.Welcome_text.Size = new System.Drawing.Size(156, 32);
            this.Welcome_text.TabIndex = 28;
            this.Welcome_text.Text = "Welcome, ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 53);
            this.button2.TabIndex = 46;
            this.button2.Text = "View all aircrafts";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 53);
            this.button1.TabIndex = 45;
            this.button1.Text = "View all flights";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 53);
            this.button3.TabIndex = 47;
            this.button3.Text = "Edit Flights";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(412, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 53);
            this.button4.TabIndex = 48;
            this.button4.Text = "Edit Aircrafts";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(321, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 53);
            this.button5.TabIndex = 49;
            this.button5.Text = "View Profile";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(321, 314);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 53);
            this.button6.TabIndex = 50;
            this.button6.Text = "Log out";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(385, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 59;
            this.label1.Text = "First + Last";
            this.label1.Visible = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Welcome_text);
            this.Name = "AdminPanel";
            this.Text = "Admin Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Welcome_text;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
    }
}