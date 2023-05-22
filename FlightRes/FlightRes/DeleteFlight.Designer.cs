namespace FlightRes
{
    partial class DeleteFlight
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
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            Welcome_text = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(404, 256);
            button2.Name = "button2";
            button2.Size = new Size(156, 53);
            button2.TabIndex = 46;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(231, 256);
            button1.Name = "button1";
            button1.Size = new Size(156, 53);
            button1.TabIndex = 45;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(178, 187);
            label2.Name = "label2";
            label2.Size = new Size(171, 29);
            label2.TabIndex = 43;
            label2.Text = "Enter Flight ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(355, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 27);
            textBox1.TabIndex = 41;
            // 
            // Welcome_text
            // 
            Welcome_text.AutoSize = true;
            Welcome_text.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Welcome_text.Location = new Point(294, 123);
            Welcome_text.Name = "Welcome_text";
            Welcome_text.Size = new Size(188, 32);
            Welcome_text.TabIndex = 37;
            Welcome_text.Text = "Delete Flight";
            // 
            // DeleteFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(Welcome_text);
            Name = "DeleteFlight";
            Text = "DeleteFlight";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label Welcome_text;
    }
}