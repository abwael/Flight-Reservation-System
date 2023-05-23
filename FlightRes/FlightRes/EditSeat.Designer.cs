namespace FlightRes
{
    partial class EditSeat
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
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            button3 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            button4 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(800, 240);
            dataGridView1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(297, 351);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 52;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(134, 355);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 51;
            label3.Text = "Current Seat Number";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(297, 312);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 50;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(182, 315);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 49;
            label1.Text = "Flight Number";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(307, 260);
            label4.Name = "label4";
            label4.Size = new Size(191, 32);
            label4.TabIndex = 48;
            label4.Text = "Change Seat";
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(404, 401);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 47;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(568, 351);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 46;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(428, 355);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 45;
            label5.Text = "New Seat Number";
            label5.Click += label5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(304, 401);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 44;
            button4.Text = "Confirm";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(438, 312);
            button1.Name = "button1";
            button1.Size = new Size(203, 29);
            button1.TabIndex = 53;
            button1.Text = "View Available Seats";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditSeat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Name = "EditSeat";
            Text = "ChangeSeat";
            Load += EditSeat_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label1;
        private Label label4;
        private Button button3;
        private TextBox textBox4;
        private Label label5;
        private Button button4;
        private Button button1;
    }
}