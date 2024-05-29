namespace ceasar
{
    partial class p4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(p4));
            button8 = new Button();
            button7 = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.Location = new Point(664, 43);
            button8.Name = "button8";
            button8.Size = new Size(69, 83);
            button8.TabIndex = 15;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Peru;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.Location = new Point(23, 805);
            button7.Name = "button7";
            button7.Size = new Size(107, 53);
            button7.TabIndex = 19;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Tan;
            label1.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 175);
            label1.Name = "label1";
            label1.Size = new Size(315, 160);
            label1.TabIndex = 20;
            label1.Text = "Tip of the day.\r\nIf you have a dragon put it in the fridge.\r\nIt is hot outside.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.Font = new Font("Algerian", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(246, 391);
            button1.Name = "button1";
            button1.Size = new Size(278, 145);
            button1.TabIndex = 21;
            button1.Text = "Wls ri wkh gdb.\r\nLi brx kdyh d gudjrq sxw lw lq wkh iulgjh.\r\nLw lv krw rxwvlgh.";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Peru;
            button2.Font = new Font("Algerian", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(246, 596);
            button2.Name = "button2";
            button2.Size = new Size(278, 136);
            button2.TabIndex = 22;
            button2.Text = "Wls ri wkh gdb.\r\nLi brx kdyh d gudjrq sxw lw lq wkl iulgjh.\r\nLw lv kfe rwxvlgh.";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // p4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(765, 870);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button8);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "p4";
            Text = "p4";
            Load += p4_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button8;
        private Button button7;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}