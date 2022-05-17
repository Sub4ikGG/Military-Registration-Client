namespace ProjectWorkWF
{
    partial class Register_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Form));
            this.last_name_textBox = new System.Windows.Forms.TextBox();
            this.first_name_textBox = new System.Windows.Forms.TextBox();
            this.date_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.man_checkBox = new System.Windows.Forms.CheckBox();
            this.woman_checkBox = new System.Windows.Forms.CheckBox();
            this.last_last_name_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.avatar_picture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.register_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.city_textBox = new System.Windows.Forms.TextBox();
            this.street_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.house_number_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.flat_number_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // last_name_textBox
            // 
            this.last_name_textBox.Location = new System.Drawing.Point(104, 37);
            this.last_name_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.last_name_textBox.Name = "last_name_textBox";
            this.last_name_textBox.Size = new System.Drawing.Size(218, 29);
            this.last_name_textBox.TabIndex = 0;
            // 
            // first_name_textBox
            // 
            this.first_name_textBox.Location = new System.Drawing.Point(68, 72);
            this.first_name_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.first_name_textBox.Name = "first_name_textBox";
            this.first_name_textBox.Size = new System.Drawing.Size(254, 29);
            this.first_name_textBox.TabIndex = 1;
            // 
            // date_TimePicker
            // 
            this.date_TimePicker.Location = new System.Drawing.Point(155, 146);
            this.date_TimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.date_TimePicker.Name = "date_TimePicker";
            this.date_TimePicker.Size = new System.Drawing.Size(167, 29);
            this.date_TimePicker.TabIndex = 2;
            this.date_TimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(91, 76);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(231, 29);
            this.password_textBox.TabIndex = 9;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(104, 38);
            this.email_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(218, 29);
            this.email_textBox.TabIndex = 10;
            // 
            // man_checkBox
            // 
            this.man_checkBox.AutoSize = true;
            this.man_checkBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.man_checkBox.Location = new System.Drawing.Point(31, 685);
            this.man_checkBox.Margin = new System.Windows.Forms.Padding(2);
            this.man_checkBox.Name = "man_checkBox";
            this.man_checkBox.Size = new System.Drawing.Size(104, 23);
            this.man_checkBox.TabIndex = 11;
            this.man_checkBox.Text = "Я мужчина";
            this.man_checkBox.UseVisualStyleBackColor = true;
            this.man_checkBox.CheckedChanged += new System.EventHandler(this.man_checkBox_CheckedChanged);
            // 
            // woman_checkBox
            // 
            this.woman_checkBox.AutoSize = true;
            this.woman_checkBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.woman_checkBox.Location = new System.Drawing.Point(258, 685);
            this.woman_checkBox.Margin = new System.Windows.Forms.Padding(2);
            this.woman_checkBox.Name = "woman_checkBox";
            this.woman_checkBox.Size = new System.Drawing.Size(107, 23);
            this.woman_checkBox.TabIndex = 12;
            this.woman_checkBox.Text = "Я женщина";
            this.woman_checkBox.UseVisualStyleBackColor = true;
            this.woman_checkBox.CheckedChanged += new System.EventHandler(this.woman_checkBox_CheckedChanged);
            // 
            // last_last_name_textBox
            // 
            this.last_last_name_textBox.Location = new System.Drawing.Point(104, 108);
            this.last_last_name_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.last_last_name_textBox.Name = "last_last_name_textBox";
            this.last_last_name_textBox.Size = new System.Drawing.Size(218, 29);
            this.last_last_name_textBox.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.last_last_name_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.last_name_textBox);
            this.groupBox1.Controls.Add(this.first_name_textBox);
            this.groupBox1.Controls.Add(this.date_TimePicker);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 13F);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 196);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основная информация:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Дата рождения:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.email_textBox);
            this.groupBox2.Controls.Add(this.password_textBox);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 13F);
            this.groupBox2.Location = new System.Drawing.Point(25, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 128);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные для доступа:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Пароль:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Эл. почта:";
            // 
            // avatar_picture
            // 
            this.avatar_picture.Image = ((System.Drawing.Image)(resources.GetObject("avatar_picture.Image")));
            this.avatar_picture.Location = new System.Drawing.Point(25, 566);
            this.avatar_picture.Name = "avatar_picture";
            this.avatar_picture.Size = new System.Drawing.Size(115, 114);
            this.avatar_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar_picture.TabIndex = 18;
            this.avatar_picture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 566);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.Wheat;
            this.register_button.FlatAppearance.BorderSize = 0;
            this.register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_button.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_button.Location = new System.Drawing.Point(25, 722);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(340, 30);
            this.register_button.TabIndex = 20;
            this.register_button.TabStop = false;
            this.register_button.Text = "Регистрация";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.flat_number_textBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.house_number_textBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.city_textBox);
            this.groupBox3.Controls.Add(this.street_textBox);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 13F);
            this.groupBox3.Location = new System.Drawing.Point(25, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 202);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Место проживания:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Улица:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Город:";
            // 
            // city_textBox
            // 
            this.city_textBox.Location = new System.Drawing.Point(79, 38);
            this.city_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.city_textBox.Name = "city_textBox";
            this.city_textBox.Size = new System.Drawing.Size(243, 29);
            this.city_textBox.TabIndex = 10;
            // 
            // street_textBox
            // 
            this.street_textBox.Location = new System.Drawing.Point(79, 76);
            this.street_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.street_textBox.Name = "street_textBox";
            this.street_textBox.Size = new System.Drawing.Size(243, 29);
            this.street_textBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 22);
            this.label10.TabIndex = 11;
            this.label10.Text = "Номер дома:";
            // 
            // house_number_textBox
            // 
            this.house_number_textBox.Location = new System.Drawing.Point(131, 115);
            this.house_number_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.house_number_textBox.Name = "house_number_textBox";
            this.house_number_textBox.Size = new System.Drawing.Size(191, 29);
            this.house_number_textBox.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 22);
            this.label11.TabIndex = 13;
            this.label11.Text = "Номер квартиры:";
            // 
            // flat_number_textBox
            // 
            this.flat_number_textBox.Location = new System.Drawing.Point(163, 152);
            this.flat_number_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.flat_number_textBox.Name = "flat_number_textBox";
            this.flat_number_textBox.Size = new System.Drawing.Size(159, 29);
            this.flat_number_textBox.TabIndex = 14;
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 771);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.avatar_picture);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.woman_checkBox);
            this.Controls.Add(this.man_checkBox);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный военкомат | Регистрация";
            this.Load += new System.EventHandler(this.Register_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox last_name_textBox;
        private System.Windows.Forms.TextBox first_name_textBox;
        private System.Windows.Forms.DateTimePicker date_TimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.CheckBox man_checkBox;
        private System.Windows.Forms.CheckBox woman_checkBox;
        private System.Windows.Forms.TextBox last_last_name_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox avatar_picture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox flat_number_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox house_number_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox city_textBox;
        private System.Windows.Forms.TextBox street_textBox;
    }
}