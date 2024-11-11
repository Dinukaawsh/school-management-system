namespace school_management_system
{
    partial class teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teachers));
            label1 = new Label();
            label2 = new Label();
            label9 = new Label();
            txt_name = new TextBox();
            txt_age = new TextBox();
            txt_phone = new TextBox();
            txt_email = new TextBox();
            txt_salary = new TextBox();
            dateTimePicker = new DateTimePicker();
            rad_male = new RadioButton();
            rad_female = new RadioButton();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_view = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(156, 20);
            label1.Name = "label1";
            label1.Size = new Size(288, 29);
            label1.TabIndex = 0;
            label1.Text = "Teacher management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 101);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(12, 11);
            label9.Name = "label9";
            label9.Size = new Size(75, 23);
            label9.TabIndex = 8;
            label9.Text = "Go back";
            label9.Click += label9_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(156, 94);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(393, 27);
            txt_name.TabIndex = 9;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(156, 140);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(125, 27);
            txt_age.TabIndex = 10;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(156, 223);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(211, 27);
            txt_phone.TabIndex = 11;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(156, 262);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(211, 27);
            txt_email.TabIndex = 12;
            // 
            // txt_salary
            // 
            txt_salary.Location = new Point(156, 305);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(211, 27);
            txt_salary.TabIndex = 13;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(156, 351);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 14;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // rad_male
            // 
            rad_male.AutoSize = true;
            rad_male.BackColor = Color.Transparent;
            rad_male.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rad_male.ForeColor = Color.Transparent;
            rad_male.Location = new Point(156, 183);
            rad_male.Name = "rad_male";
            rad_male.Size = new Size(70, 27);
            rad_male.TabIndex = 15;
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
            rad_female.Location = new Point(246, 183);
            rad_female.Name = "rad_female";
            rad_female.Size = new Size(86, 27);
            rad_female.TabIndex = 16;
            rad_female.TabStop = true;
            rad_female.Text = "female";
            rad_female.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Lime;
            btn_add.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.Black;
            btn_add.Location = new Point(55, 422);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 17;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Yellow;
            btn_update.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(187, 422);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 18;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(323, 422);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 19;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_view
            // 
            btn_view.BackColor = Color.Cyan;
            btn_view.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_view.Location = new Point(470, 422);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(94, 29);
            btn_view.TabIndex = 20;
            btn_view.Text = "View";
            btn_view.UseVisualStyleBackColor = false;
            btn_view.Click += btn_view_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(39, 351);
            label10.Name = "label10";
            label10.Size = new Size(96, 23);
            label10.TabIndex = 21;
            label10.Text = "Hired date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(39, 305);
            label11.Name = "label11";
            label11.Size = new Size(60, 23);
            label11.TabIndex = 22;
            label11.Text = "Salary";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(39, 262);
            label12.Name = "label12";
            label12.Size = new Size(61, 23);
            label12.TabIndex = 23;
            label12.Text = "E-mail";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(39, 184);
            label13.Name = "label13";
            label13.Size = new Size(68, 23);
            label13.TabIndex = 24;
            label13.Text = "Gender";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(39, 144);
            label14.Name = "label14";
            label14.Size = new Size(42, 23);
            label14.TabIndex = 25;
            label14.Text = "Age";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(39, 224);
            label15.Name = "label15";
            label15.Size = new Size(59, 23);
            label15.TabIndex = 26;
            label15.Text = "Phone";
            // 
            // teachers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(608, 483);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btn_view);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(rad_female);
            Controls.Add(rad_male);
            Controls.Add(dateTimePicker);
            Controls.Add(txt_salary);
            Controls.Add(txt_email);
            Controls.Add(txt_phone);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "teachers";
            Text = "teachers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label9;
        private TextBox txt_name;
        private TextBox txt_age;
        private TextBox txt_phone;
        private TextBox txt_email;
        private TextBox txt_salary;
        private DateTimePicker dateTimePicker;
        private RadioButton rad_male;
        private RadioButton rad_female;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_view;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}