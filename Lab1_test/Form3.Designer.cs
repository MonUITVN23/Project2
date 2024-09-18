namespace Lab1_test
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 97);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Số thứ 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 97);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ 2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(635, 97);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Số thứ 3";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(332, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(603, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(65, 138);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(231, 224);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 6;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(497, 224);
            button2.Name = "button2";
            button2.Size = new Size(78, 34);
            button2.TabIndex = 7;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(694, 390);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 324);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 9;
            label4.Text = "Số lớn nhất";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(181, 324);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(457, 327);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 11;
            label5.Text = "Số nhỏ nhất";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(571, 324);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 12;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Info;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(288, 21);
            label6.Name = "label6";
            label6.Size = new Size(215, 46);
            label6.TabIndex = 13;
            label6.Text = "Tìm Min Max";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 431);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
    }
}