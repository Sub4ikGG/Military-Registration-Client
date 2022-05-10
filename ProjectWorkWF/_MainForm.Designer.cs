namespace ProjectWorkWF
{
    partial class Main_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            this.plans_button = new System.Windows.Forms.Button();
            this.applications_button = new System.Windows.Forms.Button();
            this.notifications_button = new System.Windows.Forms.Button();
            this.profile_button = new System.Windows.Forms.Button();
            this.profile_panel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.exit_button);
            this.groupBox1.Controls.Add(this.help_button);
            this.groupBox1.Controls.Add(this.plans_button);
            this.groupBox1.Controls.Add(this.applications_button);
            this.groupBox1.Controls.Add(this.notifications_button);
            this.groupBox1.Controls.Add(this.profile_button);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 618);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.White;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Location = new System.Drawing.Point(15, 550);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(213, 46);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.Color.White;
            this.help_button.FlatAppearance.BorderSize = 0;
            this.help_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.help_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.help_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_button.Location = new System.Drawing.Point(15, 334);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(213, 46);
            this.help_button.TabIndex = 4;
            this.help_button.Text = "Помощь";
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // plans_button
            // 
            this.plans_button.BackColor = System.Drawing.Color.White;
            this.plans_button.FlatAppearance.BorderSize = 0;
            this.plans_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.plans_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.plans_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plans_button.Location = new System.Drawing.Point(15, 259);
            this.plans_button.Name = "plans_button";
            this.plans_button.Size = new System.Drawing.Size(213, 46);
            this.plans_button.TabIndex = 3;
            this.plans_button.Text = "Траектории";
            this.plans_button.UseVisualStyleBackColor = false;
            // 
            // applications_button
            // 
            this.applications_button.BackColor = System.Drawing.Color.White;
            this.applications_button.FlatAppearance.BorderSize = 0;
            this.applications_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.applications_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.applications_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applications_button.Location = new System.Drawing.Point(15, 183);
            this.applications_button.Name = "applications_button";
            this.applications_button.Size = new System.Drawing.Size(213, 46);
            this.applications_button.TabIndex = 2;
            this.applications_button.Text = "Заявления";
            this.applications_button.UseVisualStyleBackColor = false;
            this.applications_button.Click += new System.EventHandler(this.applications_button_Click);
            // 
            // notifications_button
            // 
            this.notifications_button.BackColor = System.Drawing.Color.White;
            this.notifications_button.FlatAppearance.BorderSize = 0;
            this.notifications_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.notifications_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.notifications_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifications_button.Location = new System.Drawing.Point(15, 109);
            this.notifications_button.Name = "notifications_button";
            this.notifications_button.Size = new System.Drawing.Size(213, 46);
            this.notifications_button.TabIndex = 1;
            this.notifications_button.Text = "Уведомления (7)";
            this.notifications_button.UseVisualStyleBackColor = false;
            this.notifications_button.Click += new System.EventHandler(this.notifications_button_Click);
            // 
            // profile_button
            // 
            this.profile_button.BackColor = System.Drawing.Color.White;
            this.profile_button.FlatAppearance.BorderSize = 0;
            this.profile_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.profile_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.profile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile_button.Location = new System.Drawing.Point(15, 36);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(213, 46);
            this.profile_button.TabIndex = 0;
            this.profile_button.Text = "Личный кабинет";
            this.profile_button.UseVisualStyleBackColor = false;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // profile_panel
            // 
            this.profile_panel.Location = new System.Drawing.Point(6, 19);
            this.profile_panel.Name = "profile_panel";
            this.profile_panel.Size = new System.Drawing.Size(932, 593);
            this.profile_panel.TabIndex = 1;
            this.profile_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.profile_panel_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.profile_panel);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(263, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(944, 618);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Main_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1219, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный военкомат";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button profile_button;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Button plans_button;
        private System.Windows.Forms.Button applications_button;
        private System.Windows.Forms.Button notifications_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel profile_panel;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}