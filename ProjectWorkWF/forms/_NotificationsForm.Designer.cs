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
            this.sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifications_label = new System.Windows.Forms.Label();
            this.only_first_class_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // notifications_listView
            // 
            this.notifications_listView.BackColor = System.Drawing.Color.White;
            this.notifications_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sender,
            this.content});
            this.notifications_listView.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notifications_listView.FullRowSelect = true;
            this.notifications_listView.GridLines = true;
            this.notifications_listView.HideSelection = false;
            this.notifications_listView.Location = new System.Drawing.Point(151, 59);
            this.notifications_listView.Name = "notifications_listView";
            this.notifications_listView.Size = new System.Drawing.Size(702, 407);
            this.notifications_listView.TabIndex = 0;
            this.notifications_listView.UseCompatibleStateImageBehavior = false;
            this.notifications_listView.View = System.Windows.Forms.View.Details;
            this.notifications_listView.SelectedIndexChanged += new System.EventHandler(this.notifications_listView_SelectedIndexChanged);
            // 
            // sender
            // 
            this.sender.Text = "Отправитель";
            this.sender.Width = 119;
            // 
            // content
            // 
            this.content.Text = "Содержание";
            this.content.Width = 577;
            // 
            // notifications_label
            // 
            this.notifications_label.AutoSize = true;
            this.notifications_label.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notifications_label.Location = new System.Drawing.Point(149, 26);
            this.notifications_label.Name = "notifications_label";
            this.notifications_label.Size = new System.Drawing.Size(140, 27);
            this.notifications_label.TabIndex = 1;
            this.notifications_label.Text = "Уведомления";
            // 
            // only_first_class_checkBox
            // 
            this.only_first_class_checkBox.AutoSize = true;
            this.only_first_class_checkBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.only_first_class_checkBox.Location = new System.Drawing.Point(154, 472);
            this.only_first_class_checkBox.Name = "only_first_class_checkBox";
            this.only_first_class_checkBox.Size = new System.Drawing.Size(442, 27);
            this.only_first_class_checkBox.TabIndex = 3;
            this.only_first_class_checkBox.Text = "Отобразить только важные (временно недоступно)";
            this.only_first_class_checkBox.UseVisualStyleBackColor = true;
            this.only_first_class_checkBox.CheckedChanged += new System.EventHandler(this.only_first_class_checkBox_CheckedChanged);
            // 
            // _NotificationsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.only_first_class_checkBox);
            this.Controls.Add(this.notifications_label);
            this.Controls.Add(this.notifications_listView);
            this.Name = "_NotificationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Уведомления";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView notifications_listView;
        private System.Windows.Forms.Label notifications_label;
        private System.Windows.Forms.CheckBox only_first_class_checkBox;
        private System.Windows.Forms.ColumnHeader sender;
        private System.Windows.Forms.ColumnHeader content;
    }
}