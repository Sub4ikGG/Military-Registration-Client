namespace ProjectWorkWF
{
    partial class _ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ProfileForm));
            this.fio_label = new System.Windows.Forms.Label();
            this.man_picture = new System.Windows.Forms.PictureBox();
            this.birth_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.email_panel = new System.Windows.Forms.Panel();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.division_code_panel = new System.Windows.Forms.Panel();
            this.division_code_textBox = new System.Windows.Forms.TextBox();
            this.date_panel = new System.Windows.Forms.Panel();
            this.passport_date_textBox = new System.Windows.Forms.TextBox();
            this.series_and_number_panel = new System.Windows.Forms.Panel();
            this.series_and_number_textBox = new System.Windows.Forms.TextBox();
            this.army_passport_id_label = new System.Windows.Forms.Label();
            this.division_code_label = new System.Windows.Forms.Label();
            this.series_and_number_label = new System.Windows.Forms.Label();
            this.passport_date_label = new System.Windows.Forms.Label();
            this.edit_info_button = new System.Windows.Forms.Button();
            this.to_address_button = new System.Windows.Forms.Label();
            this.to_passport_button = new System.Windows.Forms.Label();
            this.woman_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.man_picture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.email_panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.division_code_panel.SuspendLayout();
            this.date_panel.SuspendLayout();
            this.series_and_number_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.woman_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // fio_label
            // 
            this.fio_label.AutoSize = true;
            this.fio_label.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_label.Location = new System.Drawing.Point(18, 41);
            this.fio_label.Name = "fio_label";
            this.fio_label.Size = new System.Drawing.Size(234, 27);
            this.fio_label.TabIndex = 0;
            this.fio_label.Text = "Иванов Иван Иванович";
            this.fio_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // man_picture
            // 
            this.man_picture.Image = ((System.Drawing.Image)(resources.GetObject("man_picture.Image")));
            this.man_picture.Location = new System.Drawing.Point(394, 41);
            this.man_picture.Name = "man_picture";
            this.man_picture.Size = new System.Drawing.Size(159, 163);
            this.man_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.man_picture.TabIndex = 1;
            this.man_picture.TabStop = false;
            this.man_picture.Click += new System.EventHandler(this.avatar_picture_Click);
            // 
            // birth_label
            // 
            this.birth_label.AutoSize = true;
            this.birth_label.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birth_label.Location = new System.Drawing.Point(18, 85);
            this.birth_label.Name = "birth_label";
            this.birth_label.Size = new System.Drawing.Size(254, 27);
            this.birth_label.TabIndex = 2;
            this.birth_label.Text = "Год рождения: 09.09.2003";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_label.Location = new System.Drawing.Point(18, 131);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(191, 27);
            this.status_label.TabIndex = 3;
            this.status_label.Text = "Статус: отсутствует";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.woman_picture);
            this.groupBox1.Controls.Add(this.email_panel);
            this.groupBox1.Controls.Add(this.email_label);
            this.groupBox1.Controls.Add(this.man_picture);
            this.groupBox1.Controls.Add(this.status_label);
            this.groupBox1.Controls.Add(this.fio_label);
            this.groupBox1.Controls.Add(this.birth_label);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(172, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 230);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основная информация";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // email_panel
            // 
            this.email_panel.BackColor = System.Drawing.SystemColors.Control;
            this.email_panel.Controls.Add(this.email_textBox);
            this.email_panel.Location = new System.Drawing.Point(90, 171);
            this.email_panel.Name = "email_panel";
            this.email_panel.Padding = new System.Windows.Forms.Padding(10);
            this.email_panel.Size = new System.Drawing.Size(278, 34);
            this.email_panel.TabIndex = 6;
            this.email_panel.Visible = false;
            this.email_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.email_panel_Paint);
            // 
            // email_textBox
            // 
            this.email_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.email_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_textBox.Font = new System.Drawing.Font("Calibri", 16F);
            this.email_textBox.ForeColor = System.Drawing.Color.Black;
            this.email_textBox.Location = new System.Drawing.Point(13, 3);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(253, 27);
            this.email_textBox.TabIndex = 0;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_label.Location = new System.Drawing.Point(18, 173);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(313, 27);
            this.email_label.TabIndex = 4;
            this.email_label.Text = "Почта: zerotanker33@gmail.com";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.division_code_panel);
            this.groupBox2.Controls.Add(this.date_panel);
            this.groupBox2.Controls.Add(this.series_and_number_panel);
            this.groupBox2.Controls.Add(this.army_passport_id_label);
            this.groupBox2.Controls.Add(this.division_code_label);
            this.groupBox2.Controls.Add(this.series_and_number_label);
            this.groupBox2.Controls.Add(this.passport_date_label);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(172, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 240);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Паспортные данные и военный билет";
            // 
            // division_code_panel
            // 
            this.division_code_panel.BackColor = System.Drawing.SystemColors.Control;
            this.division_code_panel.Controls.Add(this.division_code_textBox);
            this.division_code_panel.Location = new System.Drawing.Point(220, 128);
            this.division_code_panel.Name = "division_code_panel";
            this.division_code_panel.Padding = new System.Windows.Forms.Padding(10);
            this.division_code_panel.Size = new System.Drawing.Size(339, 34);
            this.division_code_panel.TabIndex = 9;
            this.division_code_panel.Visible = false;
            this.division_code_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.division_code_panel_Paint);
            // 
            // division_code_textBox
            // 
            this.division_code_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.division_code_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.division_code_textBox.Font = new System.Drawing.Font("Calibri", 16F);
            this.division_code_textBox.ForeColor = System.Drawing.Color.Black;
            this.division_code_textBox.Location = new System.Drawing.Point(13, 3);
            this.division_code_textBox.Name = "division_code_textBox";
            this.division_code_textBox.Size = new System.Drawing.Size(313, 27);
            this.division_code_textBox.TabIndex = 0;
            this.division_code_textBox.TextChanged += new System.EventHandler(this.division_code_textBox_TextChanged);
            // 
            // date_panel
            // 
            this.date_panel.BackColor = System.Drawing.SystemColors.Control;
            this.date_panel.Controls.Add(this.passport_date_textBox);
            this.date_panel.Location = new System.Drawing.Point(156, 83);
            this.date_panel.Name = "date_panel";
            this.date_panel.Padding = new System.Windows.Forms.Padding(10);
            this.date_panel.Size = new System.Drawing.Size(403, 34);
            this.date_panel.TabIndex = 8;
            this.date_panel.Visible = false;
            this.date_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.date_panel_Paint);
            // 
            // passport_date_textBox
            // 
            this.passport_date_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.passport_date_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passport_date_textBox.Font = new System.Drawing.Font("Calibri", 16F);
            this.passport_date_textBox.ForeColor = System.Drawing.Color.Black;
            this.passport_date_textBox.Location = new System.Drawing.Point(13, 3);
            this.passport_date_textBox.Name = "passport_date_textBox";
            this.passport_date_textBox.Size = new System.Drawing.Size(377, 27);
            this.passport_date_textBox.TabIndex = 0;
            this.passport_date_textBox.TextChanged += new System.EventHandler(this.passport_date_textBox_TextChanged);
            // 
            // series_and_number_panel
            // 
            this.series_and_number_panel.BackColor = System.Drawing.SystemColors.Control;
            this.series_and_number_panel.Controls.Add(this.series_and_number_textBox);
            this.series_and_number_panel.Location = new System.Drawing.Point(176, 38);
            this.series_and_number_panel.Name = "series_and_number_panel";
            this.series_and_number_panel.Padding = new System.Windows.Forms.Padding(10);
            this.series_and_number_panel.Size = new System.Drawing.Size(383, 34);
            this.series_and_number_panel.TabIndex = 7;
            this.series_and_number_panel.Visible = false;
            this.series_and_number_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.series_and_number_panel_Paint);
            // 
            // series_and_number_textBox
            // 
            this.series_and_number_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.series_and_number_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.series_and_number_textBox.Font = new System.Drawing.Font("Calibri", 16F);
            this.series_and_number_textBox.ForeColor = System.Drawing.Color.Black;
            this.series_and_number_textBox.Location = new System.Drawing.Point(13, 3);
            this.series_and_number_textBox.Name = "series_and_number_textBox";
            this.series_and_number_textBox.Size = new System.Drawing.Size(357, 27);
            this.series_and_number_textBox.TabIndex = 0;
            this.series_and_number_textBox.TextChanged += new System.EventHandler(this.series_and_number_textBox_TextChanged);
            // 
            // army_passport_id_label
            // 
            this.army_passport_id_label.AutoSize = true;
            this.army_passport_id_label.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.army_passport_id_label.Location = new System.Drawing.Point(18, 179);
            this.army_passport_id_label.Name = "army_passport_id_label";
            this.army_passport_id_label.Size = new System.Drawing.Size(211, 27);
            this.army_passport_id_label.TabIndex = 4;
            this.army_passport_id_label.Text = "ID-карта: отсутствует";
            // 
            // division_code_label
            // 
            this.division_code_label.AutoSize = true;
            this.division_code_label.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division_code_label.Location = new System.Drawing.Point(18, 131);
            this.division_code_label.Name = "division_code_label";
            this.division_code_label.Size = new System.Drawing.Size(203, 27);
            this.division_code_label.TabIndex = 3;
            this.division_code_label.Text = "Код подразделения:";
            // 
            // series_and_number_label
            // 
            this.series_and_number_label.AutoSize = true;
            this.series_and_number_label.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.series_and_number_label.Location = new System.Drawing.Point(18, 41);
            this.series_and_number_label.Name = "series_and_number_label";
            this.series_and_number_label.Size = new System.Drawing.Size(159, 27);
            this.series_and_number_label.TabIndex = 0;
            this.series_and_number_label.Text = "Серия и номер:";
            // 
            // passport_date_label
            // 
            this.passport_date_label.AutoSize = true;
            this.passport_date_label.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passport_date_label.Location = new System.Drawing.Point(18, 85);
            this.passport_date_label.Name = "passport_date_label";
            this.passport_date_label.Size = new System.Drawing.Size(139, 27);
            this.passport_date_label.TabIndex = 2;
            this.passport_date_label.Text = "Дата выдачи:";
            // 
            // edit_info_button
            // 
            this.edit_info_button.BackColor = System.Drawing.Color.Wheat;
            this.edit_info_button.FlatAppearance.BorderSize = 0;
            this.edit_info_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_info_button.Font = new System.Drawing.Font("Calibri", 14F);
            this.edit_info_button.Location = new System.Drawing.Point(157, 513);
            this.edit_info_button.MinimumSize = new System.Drawing.Size(629, 42);
            this.edit_info_button.Name = "edit_info_button";
            this.edit_info_button.Size = new System.Drawing.Size(629, 42);
            this.edit_info_button.TabIndex = 5;
            this.edit_info_button.TabStop = false;
            this.edit_info_button.Text = "Внести правки";
            this.edit_info_button.UseVisualStyleBackColor = false;
            this.edit_info_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // to_address_button
            // 
            this.to_address_button.AutoSize = true;
            this.to_address_button.Font = new System.Drawing.Font("Calibri", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_address_button.Location = new System.Drawing.Point(769, 363);
            this.to_address_button.Name = "to_address_button";
            this.to_address_button.Size = new System.Drawing.Size(44, 53);
            this.to_address_button.TabIndex = 10;
            this.to_address_button.Text = ">";
            this.to_address_button.Click += new System.EventHandler(this.to_address_button_Click);
            // 
            // to_passport_button
            // 
            this.to_passport_button.AutoSize = true;
            this.to_passport_button.Font = new System.Drawing.Font("Calibri", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_passport_button.Location = new System.Drawing.Point(122, 363);
            this.to_passport_button.Name = "to_passport_button";
            this.to_passport_button.Size = new System.Drawing.Size(44, 53);
            this.to_passport_button.TabIndex = 11;
            this.to_passport_button.Text = "<";
            this.to_passport_button.Visible = false;
            this.to_passport_button.Click += new System.EventHandler(this.to_passport_button_Click);
            // 
            // woman_picture
            // 
            this.woman_picture.Image = ((System.Drawing.Image)(resources.GetObject("woman_picture.Image")));
            this.woman_picture.Location = new System.Drawing.Point(394, 41);
            this.woman_picture.Name = "woman_picture";
            this.woman_picture.Size = new System.Drawing.Size(159, 163);
            this.woman_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.woman_picture.TabIndex = 7;
            this.woman_picture.TabStop = false;
            // 
            // _ProfileForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 607);
            this.Controls.Add(this.to_passport_button);
            this.Controls.Add(this.to_address_button);
            this.Controls.Add(this.edit_info_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.man_picture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.email_panel.ResumeLayout(false);
            this.email_panel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.division_code_panel.ResumeLayout(false);
            this.division_code_panel.PerformLayout();
            this.date_panel.ResumeLayout(false);
            this.date_panel.PerformLayout();
            this.series_and_number_panel.ResumeLayout(false);
            this.series_and_number_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.woman_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fio_label;
        private System.Windows.Forms.PictureBox man_picture;
        private System.Windows.Forms.Label birth_label;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label army_passport_id_label;
        private System.Windows.Forms.Label division_code_label;
        private System.Windows.Forms.Label series_and_number_label;
        private System.Windows.Forms.Label passport_date_label;
        private System.Windows.Forms.Button edit_info_button;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Panel email_panel;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Panel division_code_panel;
        private System.Windows.Forms.TextBox division_code_textBox;
        private System.Windows.Forms.Panel date_panel;
        private System.Windows.Forms.TextBox passport_date_textBox;
        private System.Windows.Forms.Panel series_and_number_panel;
        private System.Windows.Forms.TextBox series_and_number_textBox;
        private System.Windows.Forms.Label to_address_button;
        private System.Windows.Forms.Label to_passport_button;
        private System.Windows.Forms.PictureBox woman_picture;
    }
}