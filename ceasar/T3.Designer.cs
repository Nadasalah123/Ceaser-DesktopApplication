﻿namespace ceasar
{
    partial class T3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(T3));
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.BurlyWood;
            label1.Font = new Font("Wide Latin", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 102);
            label1.Name = "label1";
            label1.Size = new Size(588, 227);
            label1.TabIndex = 1;
            label1.Text = "Correct answer.\r\n You are great at decrypt messages. Are you a wizard or something?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(622, 394);
            button3.Name = "button3";
            button3.Size = new Size(69, 83);
            button3.TabIndex = 10;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Peru;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(37, 409);
            button2.Name = "button2";
            button2.Size = new Size(107, 53);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // T3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(713, 501);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "T3";
            Text = "T3";
            Load += T3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button button2;
    }
}