namespace school_management_system
{
    partial class delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete));
            label2 = new Label();
            label8 = new Label();
            btn_delete = new Button();
            btn_id_search = new Button();
            txt_search = new TextBox();
            txt_name = new TextBox();
            txt_phone = new TextBox();
            txt_address = new TextBox();
            rad_male = new RadioButton();
            rad_female = new RadioButton();
            dateTimePicker = new DateTimePicker();
            label3 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 150);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 1;
            label2.Text = "name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 8);
            label8.Name = "label8";
            label8.Size = new Size(75, 23);
            label8.TabIndex = 7;
            label8.Text = "Go back";
            label8.Click += label8_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(294, 409);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_id_search
            // 
            btn_id_search.BackColor = Color.Cyan;
            btn_id_search.Location = new Point(480, 60);
            btn_id_search.Name = "btn_id_search";
            btn_id_search.Size = new Size(89, 29);
            btn_id_search.TabIndex = 9;
            btn_id_search.Text = "search";
            btn_id_search.UseVisualStyleBackColor = false;
            btn_id_search.Click += btn_id_search_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(377, 60);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(86, 27);
            txt_search.TabIndex = 10;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(126, 150);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(474, 27);
            txt_name.TabIndex = 11;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(126, 349);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(239, 27);
            txt_phone.TabIndex = 12;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(126, 296);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(474, 27);
            txt_address.TabIndex = 13;
            // 
            // rad_male
            // 
            rad_male.AutoSize = true;
            rad_male.BackColor = Color.Transparent;
            rad_male.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rad_male.ForeColor = Color.White;
            rad_male.Location = new Point(126, 250);
            rad_male.Name = "rad_male";
            rad_male.Size = new Size(70, 27);
            rad_male.TabIndex = 14;
            rad_male.TabStop = true;
            rad_male.Text = "male";
            rad_male.UseVisualStyleBackColor = false;
            // 
            // rad_female
            // 
            rad_female.AutoSize = true;
            rad_female.BackColor = Color.Transparent;
            rad_female.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rad_female.ForeColor = Color.White;
            rad_female.Location = new Point(237, 250);
            rad_female.Name = "rad_female";
            rad_female.Size = new Size(86, 27);
            rad_female.TabIndex = 15;
            rad_female.TabStop = true;
            rad_female.Text = "female";
            rad_female.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(126, 201);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 205);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 18;
            label3.Text = "D.O.B";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(233, 114);
            label9.Name = "label9";
            label9.Size = new Size(132, 23);
            label9.TabIndex = 19;
            label9.Text = "Student details";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(24, 252);
            label10.Name = "label10";
            label10.Size = new Size(68, 23);
            label10.TabIndex = 20;
            label10.Text = "Gender";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(24, 349);
            label11.Name = "label11";
            label11.Size = new Size(59, 23);
            label11.TabIndex = 21;
            label11.Text = "Phone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(24, 297);
            label12.Name = "label12";
            label12.Size = new Size(74, 23);
            label12.TabIndex = 22;
            label12.Text = "Address";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(211, 9);
            label13.Name = "label13";
            label13.Size = new Size(214, 29);
            label13.TabIndex = 23;
            label13.Text = "Delete student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 60);
            label1.Name = "label1";
            label1.Size = new Size(300, 23);
            label1.TabIndex = 24;
            label1.Text = "Enter the Id of the student to delete";
            // 
            // delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(674, 450);
            Controls.Add(label1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(dateTimePicker);
            Controls.Add(rad_female);
            Controls.Add(rad_male);
            Controls.Add(txt_address);
            Controls.Add(txt_phone);
            Controls.Add(txt_name);
            Controls.Add(txt_search);
            Controls.Add(btn_id_search);
            Controls.Add(btn_delete);
            Controls.Add(label8);
            Controls.Add(label2);
            Name = "delete";
            Text = "delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label8;
        private Button btn_delete;
        private Button btn_id_search;
        private TextBox txt_search;
        private TextBox txt_name;
        private TextBox txt_phone;
        private TextBox txt_address;
        private RadioButton rad_male;
        private RadioButton rad_female;
        private DateTimePicker dateTimePicker;
        private Label label3;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label1;
    }
}