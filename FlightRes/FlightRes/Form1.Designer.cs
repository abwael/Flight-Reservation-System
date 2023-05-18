namespace FlightRes
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminKey = new System.Windows.Forms.Label();
            this.PassengerKey = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.PassengerKey);
            this.panel1.Controls.Add(this.AdminKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 112);
            this.panel1.TabIndex = 0;
            // 
            // AdminKey
            // 
            this.AdminKey.AutoSize = true;
            this.AdminKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdminKey.Location = new System.Drawing.Point(560, 31);
            this.AdminKey.Name = "AdminKey";
            this.AdminKey.Size = new System.Drawing.Size(70, 28);
            this.AdminKey.TabIndex = 0;
            this.AdminKey.Text = "Admin";
            this.AdminKey.Click += new System.EventHandler(this.label1_Click);
            // 
            // PassengerKey
            // 
            this.PassengerKey.AutoSize = true;
            this.PassengerKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassengerKey.Location = new System.Drawing.Point(663, 31);
            this.PassengerKey.Name = "PassengerKey";
            this.PassengerKey.Size = new System.Drawing.Size(98, 28);
            this.PassengerKey.TabIndex = 1;
            this.PassengerKey.Text = "Passenger";
            this.PassengerKey.Click += new System.EventHandler(this.PassengerKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label AdminKey;
        private Label PassengerKey;
    }
}