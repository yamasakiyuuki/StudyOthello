namespace osero
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
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            listBox1 = new System.Windows.Forms.ListBox();
            button4 = new System.Windows.Forms.Button();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(625, 569);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(134, 77);
            button1.TabIndex = 0;
            button1.Text = "スタート";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(625, 249);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 76);
            label1.TabIndex = 2;
            label1.Text = "黒:\r\n白:";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(625, 451);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(61, 69);
            button2.TabIndex = 3;
            button2.Text = "降参";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(692, 452);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(73, 68);
            button3.TabIndex = 4;
            button3.Text = "ヒント";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(616, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(194, 20);
            label2.TabIndex = 5;
            label2.Text = "打ち手(行,列) 色(左上から0,0)";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new System.Drawing.Point(616, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(194, 164);
            listBox1.TabIndex = 6;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new System.Drawing.Point(634, 364);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(131, 69);
            button4.TabIndex = 7;
            button4.Text = "待った";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(626, 539);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(60, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "先手";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(699, 539);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(60, 24);
            radioButton2.TabIndex = 9;
            radioButton2.Text = "後手";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(903, 684);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        //public static System.Windows.Forms.Label label1;
        //public static System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.PictureBox[] pictureBoxList;
    }
}

