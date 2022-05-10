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
            this.avatar_picture = new System.Windows.Forms.PictureBox();
            this.birth_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.division_code_textBox = new System.Windows.Forms.TextBox();
            this.passport_date_textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.army_passport_id_label = new System.Windows.Forms.Label();
            this.division_code_label = new System.Windows.Forms.Label();
            this.series_and_number_label = new System.Windows.Forms.Label();
            this.passport_date_label = new System.Windows.Forms.Label();
            this.series_and_number_textBox = new System.Windows.Forms.TextBox();
            this.edit_info_button = new System.Windows.Forms.Button();
            this.account_id_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_picture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // avatar_picture
            // 
            this.avatar_picture.Image = ((System.Drawing.Image)(resources.GetObject("avatar_picture.Image")));
            this.avatar_picture.Location = new System.Drawing.Point(394, 41);
            this.avatar_picture.Name = "avatar_picture";
            this.avatar_picture.Size = new System.Drawing.Size(159, 163);
            this.avatar_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar_picture.TabIndex = 1;
            this.avatar_picture.TabStop = false;
            this.avatar_picture.Click += new System.EventHandler(this.avatar_picture_Click);
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
            this.groupBox1.Controls.Add(this.email_textBox);
            this.groupBox1.Controls.Add(this.email_label);
            this.groupBox1.Controls.Add(this.avatar_picture);
            this.groupBox1.Controls.Add(this.status_label);
            this.groupBox1.Controls.Add(this.fio_label);
            this.groupBox1.Controls.Add(this.birth_label);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(166, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 230);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основная информация";
            // 
            // email_textBox
            // 
            this.email_textBox.Font = new System.Drawing.Font("Calibri", 16F);
            this.email_textBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.email_textBox.Location = new System.Drawing.Point(90, 170);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(279, 34);
            this.email_textBox.TabIndex = 8;
            this.email_textBox.Visible = false;
            this.email_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // division_code_textBox
            // 
            this.division_code_textBox.Font = new System.Drawing.Font("Calibri", 16F);
            this.division_code_textBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.division_code_textBox.Location = new System.Drawing.Point(227, 128);
            this.division_code_textBox.Name = "division_code_textBox";
            this.division_code_textBox.Size = new System.Drawing.Size(339, 34);
            this.division_code_textBox.TabIndex = 7;
            this.division_code_textBox.Visible = false;
            this.division_code_textBox.TextChanged += new System.EventHandler(this.division_code_textBox_TextChanged);
            // 
            // passport_date_textBox
            // 
            this.passport_date_textBox.Font = new System.Drawing.Font("Calibri", 16F);
            this.passport_date_textBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passport_date_textBox.Location = new System.Drawing.Point(163, 82);
            this.passport_date_textBox.Name = "passport_date_textBox";
            this.passport_date_textBox.Size = new System.Drawing.Size(403, 34);
            this.passport_date_textBox.TabIndex = 6;
            this.passport_date_textBox.Visible = false;
            this.passport_date_textBox.TextChanged += new System.EventHandler(this.passport_date_textBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.division_code_textBox);
            this.groupBox2.Controls.Add(this.army_passport_id_label);
            this.groupBox2.Controls.Add(this.division_code_label);
            this.groupBox2.Controls.Add(this.passport_date_textBox);
            this.groupBox2.Controls.Add(this.series_and_number_label);
            this.groupBox2.Controls.Add(this.passport_date_label);
            this.groupBox2.Controls.Add(this.series_and_number_textBox);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(166, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 240);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Паспортные данные и военный билет";
            // 
            // army_passport_id_label
            // 
            this.army_passport_id_label.AutoSize = true;
            this.army_passport_id_label.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.army_passport_id_label.Location = new System.Drawing.Point(18, 179);
            this.army_passport_id_label.Name = "army_passport_id_label";
            this.army_passport_id_label.Size = new System.Drawing.Size(361, 27);
            this.army_passport_id_label.TabIndex = 4;
            this.army_passport_id_label.Text = "Номер военного билета: отсутствует";
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
            // series_and_number_textBox
            // 
            this.series_and_number_textBox.Font = new System.Drawing.Font("Calibri", 16F);
            this.series_and_number_textBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.series_and_number_textBox.Location = new System.Drawing.Point(183, 38);
            this.series_and_number_textBox.Name = "series_and_number_textBox";
            this.series_and_number_textBox.Size = new System.Drawing.Size(383, 34);
            this.series_and_number_textBox.TabIndex = 5;
            this.series_and_number_textBox.Visible = false;
            this.series_and_number_textBox.TextChanged += new System.EventHandler(this.series_and_number_textBox_TextChanged);
            // 
            // edit_info_button
            // 
            this.edit_info_button.BackColor = System.Drawing.Color.DarkSalmon;
            this.edit_info_button.FlatAppearance.BorderSize = 0;
            this.edit_info_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_info_button.Font = new System.Drawing.Font("Calibri", 14F);
            this.edit_info_button.Location = new System.Drawing.Point(148, 494);
            this.edit_info_button.MinimumSize = new System.Drawing.Size(629, 42);
            this.edit_info_button.Name = "edit_info_button";
            this.edit_info_button.Size = new System.Drawing.Size(629, 42);
            this.edit_info_button.TabIndex = 5;
            this.edit_info_button.Text = "Внести правки";
            this.edit_info_button.UseVisualStyleBackColor = false;
            this.edit_info_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // account_id_label
            // 
            this.account_id_label.AutoSize = true;
            this.account_id_label.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.account_id_label.ForeColor = System.Drawing.Color.Gray;
            this.account_id_label.Location = new System.Drawing.Point(833, 567);
            this.account_id_label.Name = "account_id_label";
            this.account_id_label.Size = new System.Drawing.Size(100, 27);
            this.account_id_label.TabIndex = 8;
            this.account_id_label.Text = "14691863";
            this.account_id_label.Click += new System.EventHandler(this.account_id_label_Click);
            // 
            // Form4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.account_id_label);
            this.Controls.Add(this.edit_info_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatar_picture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fio_label;
        private System.Windows.Forms.PictureBox avatar_picture;
        private System.Windows.Forms.Label birth_label;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label army_passport_id_label;
        private System.Windows.Forms.Label division_code_label;
        private System.Windows.Forms.Label series_and_number_label;
        private System.Windows.Forms.Label passport_date_label;
        private System.Windows.Forms.Button edit_info_button;
        private System.Windows.Forms.TextBox division_code_textBox;
        private System.Windows.Forms.TextBox passport_date_textBox;
        private System.Windows.Forms.TextBox series_and_number_textBox;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Label account_id_label;
    }
}