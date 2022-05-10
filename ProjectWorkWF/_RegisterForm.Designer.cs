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
            this.last_name_textBox = new System.Windows.Forms.TextBox();
            this.first_name_textBox = new System.Windows.Forms.TextBox();
            this.date_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.register_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mainInfo_label = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.man_checkBox = new System.Windows.Forms.CheckBox();
            this.woman_checkBox = new System.Windows.Forms.CheckBox();
            this.birth_date_label = new System.Windows.Forms.Label();
            this.enterance_data_label = new System.Windows.Forms.Label();
            this.last_last_name_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // last_name_textBox
            // 
            this.last_name_textBox.Location = new System.Drawing.Point(180, 55);
            this.last_name_textBox.Name = "last_name_textBox";
            this.last_name_textBox.Size = new System.Drawing.Size(194, 22);
            this.last_name_textBox.TabIndex = 0;
            // 
            // first_name_textBox
            // 
            this.first_name_textBox.Location = new System.Drawing.Point(180, 83);
            this.first_name_textBox.Name = "first_name_textBox";
            this.first_name_textBox.Size = new System.Drawing.Size(194, 22);
            this.first_name_textBox.TabIndex = 1;
            // 
            // date_TimePicker
            // 
            this.date_TimePicker.Location = new System.Drawing.Point(182, 162);
            this.date_TimePicker.Name = "date_TimePicker";
            this.date_TimePicker.Size = new System.Drawing.Size(194, 22);
            this.date_TimePicker.TabIndex = 2;
            this.date_TimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(182, 300);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(194, 33);
            this.register_button.TabIndex = 6;
            this.register_button.Text = "Регистрация";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 7;
            // 
            // mainInfo_label
            // 
            this.mainInfo_label.AutoSize = true;
            this.mainInfo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainInfo_label.Location = new System.Drawing.Point(176, 32);
            this.mainInfo_label.Name = "mainInfo_label";
            this.mainInfo_label.Size = new System.Drawing.Size(204, 20);
            this.mainInfo_label.TabIndex = 8;
            this.mainInfo_label.Text = "Основная информация";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(182, 272);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(194, 22);
            this.password_textBox.TabIndex = 9;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(182, 244);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(194, 22);
            this.email_textBox.TabIndex = 10;
            // 
            // man_checkBox
            // 
            this.man_checkBox.AutoSize = true;
            this.man_checkBox.Location = new System.Drawing.Point(470, 34);
            this.man_checkBox.Name = "man_checkBox";
            this.man_checkBox.Size = new System.Drawing.Size(100, 20);
            this.man_checkBox.TabIndex = 11;
            this.man_checkBox.Text = "Я мужчина";
            this.man_checkBox.UseVisualStyleBackColor = true;
            this.man_checkBox.CheckedChanged += new System.EventHandler(this.man_checkBox_CheckedChanged);
            // 
            // woman_checkBox
            // 
            this.woman_checkBox.AutoSize = true;
            this.woman_checkBox.Location = new System.Drawing.Point(470, 60);
            this.woman_checkBox.Name = "woman_checkBox";
            this.woman_checkBox.Size = new System.Drawing.Size(100, 20);
            this.woman_checkBox.TabIndex = 12;
            this.woman_checkBox.Text = "Я женщина";
            this.woman_checkBox.UseVisualStyleBackColor = true;
            this.woman_checkBox.CheckedChanged += new System.EventHandler(this.woman_checkBox_CheckedChanged);
            // 
            // birth_date_label
            // 
            this.birth_date_label.AutoSize = true;
            this.birth_date_label.Location = new System.Drawing.Point(225, 143);
            this.birth_date_label.Name = "birth_date_label";
            this.birth_date_label.Size = new System.Drawing.Size(106, 16);
            this.birth_date_label.TabIndex = 13;
            this.birth_date_label.Text = "Дата рождения";
            // 
            // enterance_data_label
            // 
            this.enterance_data_label.AutoSize = true;
            this.enterance_data_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterance_data_label.Location = new System.Drawing.Point(186, 221);
            this.enterance_data_label.Name = "enterance_data_label";
            this.enterance_data_label.Size = new System.Drawing.Size(185, 20);
            this.enterance_data_label.TabIndex = 14;
            this.enterance_data_label.Text = "Данные для доступа";
            this.enterance_data_label.Click += new System.EventHandler(this.enterance_data_label_Click);
            // 
            // last_last_name_textBox
            // 
            this.last_last_name_textBox.Location = new System.Drawing.Point(180, 111);
            this.last_last_name_textBox.Name = "last_last_name_textBox";
            this.last_last_name_textBox.Size = new System.Drawing.Size(194, 22);
            this.last_last_name_textBox.TabIndex = 15;
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.last_last_name_textBox);
            this.Controls.Add(this.enterance_data_label);
            this.Controls.Add(this.birth_date_label);
            this.Controls.Add(this.woman_checkBox);
            this.Controls.Add(this.man_checkBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.mainInfo_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.date_TimePicker);
            this.Controls.Add(this.first_name_textBox);
            this.Controls.Add(this.last_name_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Register_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный военкомат | Регистрация";
            this.Load += new System.EventHandler(this.Register_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox last_name_textBox;
        private System.Windows.Forms.TextBox first_name_textBox;
        private System.Windows.Forms.DateTimePicker date_TimePicker;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mainInfo_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.CheckBox man_checkBox;
        private System.Windows.Forms.CheckBox woman_checkBox;
        private System.Windows.Forms.Label birth_date_label;
        private System.Windows.Forms.Label enterance_data_label;
        private System.Windows.Forms.TextBox last_last_name_textBox;
    }
}