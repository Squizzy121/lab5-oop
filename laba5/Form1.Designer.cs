﻿
namespace OOP_Lab5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.x_textBox = new System.Windows.Forms.TextBox();
            this.y_textBox = new System.Windows.Forms.TextBox();
            this.rad_textBox = new System.Windows.Forms.TextBox();
            this.verLen_textBox = new System.Windows.Forms.TextBox();
            this.horLen_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sideLen_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(2, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 333);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // x_textBox
            // 
            this.x_textBox.Location = new System.Drawing.Point(30, 27);
            this.x_textBox.Name = "x_textBox";
            this.x_textBox.Size = new System.Drawing.Size(49, 20);
            this.x_textBox.TabIndex = 1;
            // 
            // y_textBox
            // 
            this.y_textBox.Location = new System.Drawing.Point(30, 53);
            this.y_textBox.Name = "y_textBox";
            this.y_textBox.Size = new System.Drawing.Size(49, 20);
            this.y_textBox.TabIndex = 2;
            // 
            // rad_textBox
            // 
            this.rad_textBox.Location = new System.Drawing.Point(135, 24);
            this.rad_textBox.Name = "rad_textBox";
            this.rad_textBox.Size = new System.Drawing.Size(49, 20);
            this.rad_textBox.TabIndex = 3;
            this.rad_textBox.TextChanged += new System.EventHandler(this.rad_textBox_TextChanged);
            // 
            // verLen_textBox
            // 
            this.verLen_textBox.Location = new System.Drawing.Point(417, 24);
            this.verLen_textBox.Name = "verLen_textBox";
            this.verLen_textBox.Size = new System.Drawing.Size(49, 20);
            this.verLen_textBox.TabIndex = 4;
            // 
            // horLen_textBox
            // 
            this.horLen_textBox.Location = new System.Drawing.Point(417, 60);
            this.horLen_textBox.Name = "horLen_textBox";
            this.horLen_textBox.Size = new System.Drawing.Size(49, 20);
            this.horLen_textBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "x";
            // 
            // sideLen_textBox
            // 
            this.sideLen_textBox.Location = new System.Drawing.Point(258, 27);
            this.sideLen_textBox.Name = "sideLen_textBox";
            this.sideLen_textBox.Size = new System.Drawing.Size(49, 20);
            this.sideLen_textBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "radius";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "side length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "vertical diagonal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "horizontal diagonal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sideLen_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.horLen_textBox);
            this.Controls.Add(this.verLen_textBox);
            this.Controls.Add(this.rad_textBox);
            this.Controls.Add(this.y_textBox);
            this.Controls.Add(this.x_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox x_textBox;
        private System.Windows.Forms.TextBox y_textBox;
        private System.Windows.Forms.TextBox rad_textBox;
        private System.Windows.Forms.TextBox verLen_textBox;
        private System.Windows.Forms.TextBox horLen_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sideLen_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

