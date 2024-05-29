namespace ceasar
{
    partial class p1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(p1));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button8 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Tan;
            label1.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 187);
            label1.Name = "label1";
            label1.Size = new Size(465, 160);
            label1.TabIndex = 0;
            label1.Text = "Brx kdyh vxffhhghg, wkh surjudp vhoi-ghvwuxfwlrq zloo ehjlq diwhu wkuhh vhfrqgv. Zh zlvk brx d vxffhvvixo mrxuqhb wr ghdwk.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.Font = new Font("Algerian", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(166, 395);
            button1.Name = "button1";
            button1.Size = new Size(405, 148);
            button1.TabIndex = 3;
            button1.Text = "You have succeeded, the program self-destruction will begin after three seconds. We wish you a successful journey to death.";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Peru;
            button2.Font = new Font("Algerian", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(166, 564);
            button2.Name = "button2";
            button2.Size = new Size(405, 148);
            button2.TabIndex = 4;
            button2.Text = "You have succeeded, the progrem self-destruction will bigen after three seconds. We wish you a successfel journey to daeth.\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.Location = new Point(665, 39);
            button8.Name = "button8";
            button8.Size = new Size(69, 83);
            button8.TabIndex = 12;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Peru;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.Location = new Point(30, 798);
            button7.Name = "button7";
            button7.Size = new Size(107, 53);
            button7.TabIndex = 13;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // p1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(770, 873);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "p1";
            Text = " p1";
            Load += p1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button8;
        private Button button7;
    }
}