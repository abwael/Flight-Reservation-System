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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Welcome_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(314, 282);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 53);
            this.button6.TabIndex = 57;
            this.button6.Text = "Log out";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(314, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 53);
            this.button5.TabIndex = 56;
            this.button5.Text = "View Profile";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 53);
            this.button1.TabIndex = 52;
            this.button1.Text = "View available flights";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Welcome_text
            // 
            this.Welcome_text.AutoSize = true;
            this.Welcome_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Welcome_text.Location = new System.Drawing.Point(219, 51);
            this.Welcome_text.Name = "Welcome_text";
            this.Welcome_text.Size = new System.Drawing.Size(156, 32);
            this.Welcome_text.TabIndex = 51;
            this.Welcome_text.Text = "Welcome, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(369, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 58;
            this.label1.Text = "First + Last";
            this.label1.Visible = false;
            // 
            // PassengerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Welcome_text);
            this.Name = "PassengerPanel";
            this.Text = "PassengerPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button1;
        private Label Welcome_text;
        private Label label1;
    }
}