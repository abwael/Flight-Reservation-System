namespace FlightRes
{
    partial class DeleteAircraft
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
            button2.Location = new Point(415, 265);
            button2.Name = "button2";
            button2.Size = new Size(156, 53);
            button2.TabIndex = 51;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(242, 265);
            button1.Name = "button1";
            button1.Size = new Size(156, 53);
            button1.TabIndex = 50;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(175, 196);
            label2.Name = "label2";
            label2.Size = new Size(185, 29);
            label2.TabIndex = 49;
            label2.Text = "Enter Aircraft ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(366, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 27);
            textBox1.TabIndex = 48;
            // 
            // Welcome_text
            // 
            Welcome_text.AutoSize = true;
            Welcome_text.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Welcome_text.Location = new Point(287, 117);
            Welcome_text.Name = "Welcome_text";
            Welcome_text.Size = new Size(209, 32);
            Welcome_text.TabIndex = 47;
            Welcome_text.Text = "Delete Aircraft";
            // 
            // DeleteAircraft
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(Welcome_text);
            Name = "DeleteAircraft";
            Text = "DeleteAircraft";
            Load += DeleteAircraft_Load;
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