namespace ceasar
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.Font = new Font("Wide Latin", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(377, 239);
            button1.Name = "button1";
            button1.Size = new Size(336, 55);
            button1.TabIndex = 1;
            button1.Text = "Encryption";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Peru;
            button2.Font = new Font("Wide Latin", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(377, 332);
            button2.Name = "button2";
            button2.Size = new Size(336, 55);
            button2.TabIndex = 2;
            button2.Text = "Dycryption";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Peru;
            button3.Font = new Font("Wide Latin", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(377, 431);
            button3.Name = "button3";
            button3.Size = new Size(336, 55);
            button3.TabIndex = 3;
            button3.Text = "Puzzles";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Peru;
            button4.Font = new Font("Wide Latin", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(377, 533);
            button4.Name = "button4";
            button4.Size = new Size(336, 55);
            button4.TabIndex = 4;
            button4.Text = "History";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.Location = new Point(45, 598);
            button5.Name = "button5";
            button5.Size = new Size(105, 53);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Peru;
            button6.Font = new Font("Wide Latin", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(377, 144);
            button6.Name = "button6";
            button6.Size = new Size(336, 55);
            button6.TabIndex = 6;
            button6.Text = "How It Work";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1033, 681);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}