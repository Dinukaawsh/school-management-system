namespace school_management_system
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            label1 = new Label();
            lbl_logout = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(106, 65);
            label1.Name = "label1";
            label1.Size = new Size(297, 35);
            label1.TabIndex = 0;
            label1.Text = "Admin dashboard";
            // 
            // lbl_logout
            // 
            lbl_logout.AutoSize = true;
            lbl_logout.BackColor = Color.Transparent;
            lbl_logout.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_logout.ForeColor = Color.White;
            lbl_logout.Location = new Point(4, 7);
            lbl_logout.Name = "lbl_logout";
            lbl_logout.Size = new Size(66, 23);
            lbl_logout.TabIndex = 1;
            lbl_logout.Text = "logout";
            lbl_logout.Click += lbl_logout_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(66, 298);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 2;
            button1.Text = " Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(326, 298);
            button2.Name = "button2";
            button2.Size = new Size(94, 40);
            button2.TabIndex = 3;
            button2.Text = "Teachers";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(126, 184);
            label2.Name = "label2";
            label2.Size = new Size(245, 23);
            label2.TabIndex = 4;
            label2.Text = "select from below to manage";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(232, 307);
            label3.Name = "label3";
            label3.Size = new Size(34, 23);
            label3.TabIndex = 5;
            label3.Text = "OR";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(507, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbl_logout);
            Controls.Add(label1);
            Name = "dashboard";
            Text = "dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_logout;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}