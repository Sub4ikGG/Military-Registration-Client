namespace ProjectWorkWF
{
    partial class Login_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.register_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.remember_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email_TextBox
            // 
            this.email_TextBox.Font = new System.Drawing.Font("Calibri", 13F);
            this.email_TextBox.ForeColor = System.Drawing.Color.Gray;
            this.email_TextBox.Location = new System.Drawing.Point(140, 14);
            this.email_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Size = new System.Drawing.Size(200, 29);
            this.email_TextBox.TabIndex = 0;
            this.email_TextBox.Text = "someone@example.com";
            this.email_TextBox.Click += new System.EventHandler(this.email_click_textBox);
            this.email_TextBox.TextChanged += new System.EventHandler(this.login_textBox_Changed);
            this.email_TextBox.Enter += new System.EventHandler(this.email_enter);
            this.email_TextBox.Leave += new System.EventHandler(this.email_leave_textBox);
            // 
            // password_TextBox
            // 
            this.password_TextBox.Font = new System.Drawing.Font("Calibri", 13F);
            this.password_TextBox.ForeColor = System.Drawing.Color.Gray;
            this.password_TextBox.Location = new System.Drawing.Point(140, 47);
            this.password_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.PasswordChar = '*';
            this.password_TextBox.Size = new System.Drawing.Size(200, 29);
            this.password_TextBox.TabIndex = 1;
            this.password_TextBox.Text = "qwertyuiopasdfghjkl";
            this.password_TextBox.Click += new System.EventHandler(this.password_click_textBox);
            this.password_TextBox.Enter += new System.EventHandler(this.password_enter);
            this.password_TextBox.Leave += new System.EventHandler(this.password_leave_textBox);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Wheat;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Calibri", 13F);
            this.login_button.Location = new System.Drawing.Point(54, 131);
            this.login_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(286, 30);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Войти";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Font = new System.Drawing.Font("Calibri", 13F);
            this.register_label.Location = new System.Drawing.Point(215, 91);
            this.register_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(125, 22);
            this.register_label.TabIndex = 3;
            this.register_label.Text = "Нет акккаунта?";
            this.register_label.Click += new System.EventHandler(this.register_label_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(11, 605);
            this.login_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(101, 13);
            this.login_label.TabIndex = 4;
            this.login_label.Text = "evoenkomat@mil.ru";
            // 
            // remember_checkBox
            // 
            this.remember_checkBox.AutoSize = true;
            this.remember_checkBox.Font = new System.Drawing.Font("Calibri", 13F);
            this.remember_checkBox.Location = new System.Drawing.Point(54, 89);
            this.remember_checkBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.remember_checkBox.Name = "remember_checkBox";
            this.remember_checkBox.Size = new System.Drawing.Size(157, 26);
            this.remember_checkBox.TabIndex = 5;
            this.remember_checkBox.Text = "Запомнить меня";
            this.remember_checkBox.UseVisualStyleBackColor = true;
            this.remember_checkBox.CheckedChanged += new System.EventHandler(this.remember_checkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F);
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Эл. почта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F);
            this.label2.Location = new System.Drawing.Point(50, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль:";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 176);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remember_checkBox);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.email_TextBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный военкомат | Авторизация";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.CheckBox remember_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

