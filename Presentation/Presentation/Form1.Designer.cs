namespace Presentation
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.SizeSwitch = new System.Windows.Forms.Button();
            this.ToTray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.settext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(65, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(572, 460);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(634, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(66, 35);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "x";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SizeSwitch
            // 
            this.SizeSwitch.BackColor = System.Drawing.Color.Yellow;
            this.SizeSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SizeSwitch.Location = new System.Drawing.Point(562, 9);
            this.SizeSwitch.Name = "SizeSwitch";
            this.SizeSwitch.Size = new System.Drawing.Size(66, 35);
            this.SizeSwitch.TabIndex = 2;
            this.SizeSwitch.Text = "|";
            this.SizeSwitch.UseVisualStyleBackColor = false;
            this.SizeSwitch.Click += new System.EventHandler(this.SizeSwitch_Click);
            // 
            // ToTray
            // 
            this.ToTray.BackColor = System.Drawing.Color.Lime;
            this.ToTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToTray.Location = new System.Drawing.Point(490, 9);
            this.ToTray.Name = "ToTray";
            this.ToTray.Size = new System.Drawing.Size(66, 35);
            this.ToTray.TabIndex = 4;
            this.ToTray.Text = "_";
            this.ToTray.UseVisualStyleBackColor = false;
            this.ToTray.Click += new System.EventHandler(this.ToTray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Presentation Viewer";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(2, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 460);
            this.button1.TabIndex = 6;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(643, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 460);
            this.button2.TabIndex = 7;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(537, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Timofey Chicherin";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(65, 48);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(292, 28);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // settext
            // 
            this.settext.Location = new System.Drawing.Point(363, 48);
            this.settext.Name = "settext";
            this.settext.Size = new System.Drawing.Size(135, 28);
            this.settext.TabIndex = 10;
            this.settext.Text = "Другой текст";
            this.settext.UseVisualStyleBackColor = true;
            this.settext.Click += new System.EventHandler(this.settext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 587);
            this.Controls.Add(this.settext);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToTray);
            this.Controls.Add(this.SizeSwitch);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SizeSwitch;
        private System.Windows.Forms.Button ToTray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button settext;
    }
}

