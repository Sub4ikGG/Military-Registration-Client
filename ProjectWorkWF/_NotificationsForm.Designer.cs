namespace ProjectWorkWF
{
    partial class _NotificationsForm
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
            this.notifications_listView = new System.Windows.Forms.ListView();
            this.notifications_label = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.only_first_class_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // notifications_listView
            // 
            this.notifications_listView.HideSelection = false;
            this.notifications_listView.Location = new System.Drawing.Point(151, 59);
            this.notifications_listView.Name = "notifications_listView";
            this.notifications_listView.Size = new System.Drawing.Size(702, 407);
            this.notifications_listView.TabIndex = 0;
            this.notifications_listView.UseCompatibleStateImageBehavior = false;
            // 
            // notifications_label
            // 
            this.notifications_label.AutoSize = true;
            this.notifications_label.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notifications_label.Location = new System.Drawing.Point(149, 21);
            this.notifications_label.Name = "notifications_label";
            this.notifications_label.Size = new System.Drawing.Size(170, 27);
            this.notifications_label.TabIndex = 1;
            this.notifications_label.Text = "Уведомления (7)";
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.DarkSalmon;
            this.clear_button.FlatAppearance.BorderSize = 0;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_button.Location = new System.Drawing.Point(654, 472);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(199, 39);
            this.clear_button.TabIndex = 2;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // only_first_class_checkBox
            // 
            this.only_first_class_checkBox.AutoSize = true;
            this.only_first_class_checkBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.only_first_class_checkBox.Location = new System.Drawing.Point(154, 472);
            this.only_first_class_checkBox.Name = "only_first_class_checkBox";
            this.only_first_class_checkBox.Size = new System.Drawing.Size(248, 27);
            this.only_first_class_checkBox.TabIndex = 3;
            this.only_first_class_checkBox.Text = "Отобразить только важные";
            this.only_first_class_checkBox.UseVisualStyleBackColor = true;
            this.only_first_class_checkBox.CheckedChanged += new System.EventHandler(this.only_first_class_checkBox_CheckedChanged);
            // 
            // Form5
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.only_first_class_checkBox);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.notifications_label);
            this.Controls.Add(this.notifications_listView);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView notifications_listView;
        private System.Windows.Forms.Label notifications_label;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.CheckBox only_first_class_checkBox;
    }
}