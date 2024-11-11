namespace school_management_system
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            label1 = new Label();
            label3 = new Label();
            name_txt = new TextBox();
            txt_address = new TextBox();
            txt_phone = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            male_rad = new RadioButton();
            female_rad = new RadioButton();
            btn_add = new Button();
            Update_btn = new Button();
            Delete_btn = new Button();
            View_btn = new Button();
            lbl_back = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(171, 19);
            label1.Name = "label1";
            label1.Size = new Size(286, 29);
            label1.TabIndex = 0;
            label1.Text = "Student management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 121);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // name_txt
            // 
            name_txt.Location = new Point(142, 118);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(462, 27);
            name_txt.TabIndex = 8;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(142, 243);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(462, 27);
            txt_address.TabIndex = 11;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(142, 290);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(188, 27);
            txt_phone.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(142, 163);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // male_rad
            // 
            male_rad.AutoSize = true;
            male_rad.BackColor = Color.Transparent;
            male_rad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            male_rad.ForeColor = Color.Transparent;
            male_rad.Location = new Point(142, 206);
            male_rad.Name = "male_rad";
            male_rad.Size = new Size(70, 27);
            male_rad.TabIndex = 14;
            male_rad.TabStop = true;
            male_rad.Text = "Male";
            male_rad.UseVisualStyleBackColor = false;
            // 
            // female_rad
            // 
            female_rad.AutoSize = true;
            female_rad.BackColor = Color.Transparent;
            female_rad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            female_rad.ForeColor = Color.White;
            female_rad.Location = new Point(252, 206);
            female_rad.Name = "female_rad";
            female_rad.Size = new Size(88, 27);
            female_rad.TabIndex = 15;
            female_rad.TabStop = true;
            female_rad.Text = "Female";
            female_rad.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Lime;
            btn_add.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(44, 384);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 16;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // Update_btn
            // 
            Update_btn.BackColor = Color.Yellow;
            Update_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_btn.Location = new Point(187, 384);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(94, 29);
            Update_btn.TabIndex = 17;
            Update_btn.Text = "Update";
            Update_btn.UseVisualStyleBackColor = false;
            Update_btn.Click += Update_btn_Click;
            // 
            // Delete_btn
            // 
            Delete_btn.BackColor = Color.Red;
            Delete_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_btn.Location = new Point(337, 384);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(94, 29);
            Delete_btn.TabIndex = 18;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = false;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // View_btn
            // 
            View_btn.BackColor = Color.Cyan;
            View_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            View_btn.Location = new Point(495, 384);
            View_btn.Name = "View_btn";
            View_btn.Size = new Size(94, 29);
            View_btn.TabIndex = 19;
            View_btn.Text = "View";
            View_btn.UseVisualStyleBackColor = false;
            View_btn.Click += View_btn_Click;
            // 
            // lbl_back
            // 
            lbl_back.AutoSize = true;
            lbl_back.BackColor = Color.Transparent;
            lbl_back.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_back.ForeColor = Color.White;
            lbl_back.Location = new Point(10, 9);
            lbl_back.Name = "lbl_back";
            lbl_back.Size = new Size(75, 23);
            lbl_back.TabIndex = 20;
            lbl_back.Text = "Go back";
            lbl_back.Click += lbl_back_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 167);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 21;
            label2.Text = "D.O.B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 208);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 22;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 247);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 23;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(28, 294);
            label6.Name = "label6";
            label6.Size = new Size(60, 23);
            label6.TabIndex = 24;
            label6.Text = "phone";
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lbl_back);
            Controls.Add(View_btn);
            Controls.Add(Delete_btn);
            Controls.Add(Update_btn);
            Controls.Add(btn_add);
            Controls.Add(female_rad);
            Controls.Add(male_rad);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_phone);
            Controls.Add(txt_address);
            Controls.Add(name_txt);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Students";
            Text = "Students";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox name_txt;
        private TextBox txt_address;
        private TextBox txt_phone;
        private DateTimePicker dateTimePicker1;
        private RadioButton male_rad;
        private RadioButton female_rad;
        private Button btn_add;
        private Button Update_btn;
        private Button Delete_btn;
        private Button View_btn;
        private Label lbl_back;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}