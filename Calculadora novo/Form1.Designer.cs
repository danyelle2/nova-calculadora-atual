﻿namespace Calculadora_novo
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
            textBox1 = new TextBox();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button3 = new Button();
            button6 = new Button();
            button9 = new Button();
            button16 = new Button();
            button2 = new Button();
            button5 = new Button();
            button8 = new Button();
            button17 = new Button();
            button1 = new Button();
            button4 = new Button();
            button7 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 57);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ControlLightLight;
            button10.Location = new Point(255, 249);
            button10.Name = "button10";
            button10.Size = new Size(75, 52);
            button10.TabIndex = 18;
            button10.Text = "/";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ControlLightLight;
            button11.Location = new Point(255, 194);
            button11.Name = "button11";
            button11.Size = new Size(75, 52);
            button11.TabIndex = 19;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.Info;
            button12.Location = new Point(255, 81);
            button12.Name = "button12";
            button12.Size = new Size(75, 52);
            button12.TabIndex = 21;
            button12.Text = "C";
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.ControlLightLight;
            button13.Location = new Point(255, 136);
            button13.Name = "button13";
            button13.Size = new Size(75, 52);
            button13.TabIndex = 23;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.Location = new Point(255, 307);
            button14.Name = "button14";
            button14.Size = new Size(75, 52);
            button14.TabIndex = 24;
            button14.Text = "*";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(174, 139);
            button15.Name = "button15";
            button15.Size = new Size(75, 52);
            button15.TabIndex = 25;
            button15.Text = "3";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(174, 194);
            button3.Name = "button3";
            button3.Size = new Size(75, 52);
            button3.TabIndex = 26;
            button3.Text = "6";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button6
            // 
            button6.Location = new Point(174, 249);
            button6.Name = "button6";
            button6.Size = new Size(75, 52);
            button6.TabIndex = 27;
            button6.Text = "9";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.Info;
            button9.Location = new Point(174, 304);
            button9.Name = "button9";
            button9.Size = new Size(75, 52);
            button9.TabIndex = 28;
            button9.Text = "=";
            button9.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.Location = new Point(93, 139);
            button16.Name = "button16";
            button16.Size = new Size(75, 52);
            button16.TabIndex = 29;
            button16.Text = "2";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 194);
            button2.Name = "button2";
            button2.Size = new Size(75, 52);
            button2.TabIndex = 30;
            button2.Text = "5";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(93, 249);
            button5.Name = "button5";
            button5.Size = new Size(75, 52);
            button5.TabIndex = 31;
            button5.Text = "8";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button8
            // 
            button8.Location = new Point(93, 307);
            button8.Name = "button8";
            button8.Size = new Size(75, 52);
            button8.TabIndex = 32;
            button8.Text = "0";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // button17
            // 
            button17.Location = new Point(12, 139);
            button17.Name = "button17";
            button17.Size = new Size(75, 52);
            button17.TabIndex = 33;
            button17.Text = "1";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 194);
            button1.Name = "button1";
            button1.Size = new Size(75, 52);
            button1.TabIndex = 34;
            button1.Text = "4";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(12, 249);
            button4.Name = "button4";
            button4.Size = new Size(75, 52);
            button4.TabIndex = 35;
            button4.Text = "7";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button7
            // 
            button7.Location = new Point(12, 307);
            button7.Name = "button7";
            button7.Size = new Size(75, 52);
            button7.TabIndex = 36;
            button7.Text = ",";
            button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(318, 32);
            label1.Name = "label1";
            label1.Size = new Size(0, 37);
            label1.TabIndex = 37;
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(340, 368);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button17);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CALCULADORA";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button3;
        private Button button6;
        private Button button9;
        private Button button16;
        private Button button2;
        private Button button5;
        private Button button8;
        private Button button17;
        private Button button1;
        private Button button4;
        private Button button7;
        private Label label1;
    }
}
