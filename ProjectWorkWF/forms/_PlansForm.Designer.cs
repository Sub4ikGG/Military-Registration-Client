namespace ProjectWorkWF
{
    partial class _PlansForm
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
            this.button_plan_1 = new System.Windows.Forms.Button();
            this.button_plan_2 = new System.Windows.Forms.Button();
            this.button_plan_3 = new System.Windows.Forms.Button();
            this.button_plan_4 = new System.Windows.Forms.Button();
            this.birth_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_plan_1
            // 
            this.button_plan_1.BackColor = System.Drawing.Color.Wheat;
            this.button_plan_1.FlatAppearance.BorderSize = 0;
            this.button_plan_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_plan_1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plan_1.Location = new System.Drawing.Point(17, 58);
            this.button_plan_1.Name = "button_plan_1";
            this.button_plan_1.Size = new System.Drawing.Size(199, 39);
            this.button_plan_1.TabIndex = 4;
            this.button_plan_1.TabStop = false;
            this.button_plan_1.Text = "Отправить заявление";
            this.button_plan_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_plan_1.UseVisualStyleBackColor = false;
            this.button_plan_1.Click += new System.EventHandler(this.button_plan_1_Click);
            // 
            // button_plan_2
            // 
            this.button_plan_2.BackColor = System.Drawing.Color.Wheat;
            this.button_plan_2.FlatAppearance.BorderSize = 0;
            this.button_plan_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_plan_2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plan_2.Location = new System.Drawing.Point(17, 103);
            this.button_plan_2.Name = "button_plan_2";
            this.button_plan_2.Size = new System.Drawing.Size(169, 39);
            this.button_plan_2.TabIndex = 5;
            this.button_plan_2.TabStop = false;
            this.button_plan_2.Text = "Получить ID-карту";
            this.button_plan_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_plan_2.UseVisualStyleBackColor = false;
            this.button_plan_2.Click += new System.EventHandler(this.button_plan_2_Click);
            // 
            // button_plan_3
            // 
            this.button_plan_3.BackColor = System.Drawing.Color.Wheat;
            this.button_plan_3.FlatAppearance.BorderSize = 0;
            this.button_plan_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_plan_3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plan_3.Location = new System.Drawing.Point(17, 148);
            this.button_plan_3.Name = "button_plan_3";
            this.button_plan_3.Size = new System.Drawing.Size(420, 39);
            this.button_plan_3.TabIndex = 6;
            this.button_plan_3.TabStop = false;
            this.button_plan_3.Text = "Пройти мед. комиссию в ближайшем военкомате";
            this.button_plan_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_plan_3.UseVisualStyleBackColor = false;
            this.button_plan_3.Click += new System.EventHandler(this.button_plan_3_Click);
            // 
            // button_plan_4
            // 
            this.button_plan_4.BackColor = System.Drawing.Color.Wheat;
            this.button_plan_4.FlatAppearance.BorderSize = 0;
            this.button_plan_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_plan_4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plan_4.Location = new System.Drawing.Point(17, 193);
            this.button_plan_4.Name = "button_plan_4";
            this.button_plan_4.Size = new System.Drawing.Size(314, 39);
            this.button_plan_4.TabIndex = 7;
            this.button_plan_4.TabStop = false;
            this.button_plan_4.Text = "Получить результаты мед. комиссии";
            this.button_plan_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_plan_4.UseVisualStyleBackColor = false;
            this.button_plan_4.Click += new System.EventHandler(this.button_plan_4_Click);
            // 
            // birth_label
            // 
            this.birth_label.AutoSize = true;
            this.birth_label.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birth_label.Location = new System.Drawing.Point(12, 9);
            this.birth_label.Name = "birth_label";
            this.birth_label.Size = new System.Drawing.Size(407, 27);
            this.birth_label.TabIndex = 8;
            this.birth_label.Text = "Траектория: постановка на воинский учет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(18, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Нажмите на ячейку, чтобы завершить её";
            // 
            // _PlansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birth_label);
            this.Controls.Add(this.button_plan_4);
            this.Controls.Add(this.button_plan_3);
            this.Controls.Add(this.button_plan_2);
            this.Controls.Add(this.button_plan_1);
            this.Name = "_PlansForm";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this._PlansForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_plan_1;
        private System.Windows.Forms.Button button_plan_2;
        private System.Windows.Forms.Button button_plan_3;
        private System.Windows.Forms.Button button_plan_4;
        private System.Windows.Forms.Label birth_label;
        private System.Windows.Forms.Label label1;
    }
}