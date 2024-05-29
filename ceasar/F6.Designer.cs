namespace ceasar
{
    partial class F6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F6));
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.BurlyWood;
            label1.Font = new Font("Wide Latin", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 72);
            label1.Name = "label1";
            label1.Size = new Size(480, 220);
            label1.TabIndex = 3;
            label1.Text = "wrong answer.\r\nAre you sure you read the message correctly?\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.Peru;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(29, 401);
            button2.Name = "button2";
            button2.Size = new Size(107, 53);
            button2.TabIndex = 12;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(635, 386);
            button3.Name = "button3";
            button3.Size = new Size(69, 83);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // F6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(737, 490);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "F6";
            Text = "F6";
            Load += F6_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button3;
    }
}