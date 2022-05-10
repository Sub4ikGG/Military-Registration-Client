namespace ProjectWorkWF
{
    partial class _ApplicationsForm
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
            this.find_textBox = new System.Windows.Forms.TextBox();
            this.find_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // find_textBox
            // 
            this.find_textBox.BackColor = System.Drawing.Color.White;
            this.find_textBox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_textBox.ForeColor = System.Drawing.Color.Gray;
            this.find_textBox.Location = new System.Drawing.Point(189, 22);
            this.find_textBox.Name = "find_textBox";
            this.find_textBox.Size = new System.Drawing.Size(424, 34);
            this.find_textBox.TabIndex = 0;
            this.find_textBox.Text = " Поиск заявлений";
            this.find_textBox.Enter += new System.EventHandler(this.find_enter);
            this.find_textBox.Leave += new System.EventHandler(this.find_leave);
            // 
            // find_button
            // 
            this.find_button.BackColor = System.Drawing.Color.DarkSalmon;
            this.find_button.FlatAppearance.BorderSize = 0;
            this.find_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_button.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_button.Location = new System.Drawing.Point(619, 22);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(140, 34);
            this.find_button.TabIndex = 1;
            this.find_button.Text = "Поиск";
            this.find_button.UseVisualStyleBackColor = false;
            this.find_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.find_textBox);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox find_textBox;
        private System.Windows.Forms.Button find_button;
    }
}