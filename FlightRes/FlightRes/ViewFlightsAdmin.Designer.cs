namespace FlightRes
{
    partial class ViewFlightsAdmin
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            dateTimePicker1 = new DateTimePicker();
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
            dataGridView1.Size = new Size(800, 283);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(50, 370);
            button1.Name = "button1";
            button1.Size = new Size(156, 53);
            button1.TabIndex = 10;
            button1.Text = "Add Flight";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(230, 370);
            button2.Name = "button2";
            button2.Size = new Size(156, 53);
            button2.TabIndex = 11;
            button2.Text = "Edit Flight";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(412, 370);
            button3.Name = "button3";
            button3.Size = new Size(156, 53);
            button3.TabIndex = 12;
            button3.Text = "Delete Flight";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Flight Num", "Aircraft Num", "Flight Date", "Arrival Time", "Launching Time", "Source Place", "Distination Place", "Seats Available " });
            comboBox1.Location = new Point(208, 316);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 13;
            comboBox1.Tag = "";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 321);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 14;
            label1.Text = "Search By:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(374, 317);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 15;
            // 
            // button4
            // 
            button4.Location = new Point(591, 315);
            button4.Name = "button4";
            button4.Size = new Size(67, 30);
            button4.TabIndex = 16;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(596, 370);
            button5.Name = "button5";
            button5.Size = new Size(156, 53);
            button5.TabIndex = 17;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(374, 317);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(189, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // ViewFlightsAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ViewFlightsAdmin";
            Text = "View All Flights";
            Load += ViewFlightsAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private DateTimePicker dateTimePicker1;
    }
}