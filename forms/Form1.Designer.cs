namespace forms
{
    partial class Form1
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
            this.gallery1 = new forms.Gallery();
            this.galEllipse1 = new forms.GalEllipse();
            this.SuspendLayout();
            // 
            // gallery1
            // 
            this.gallery1.AutoSize = true;
            this.gallery1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallery1.ForeColor = System.Drawing.Color.White;
            this.gallery1.Location = new System.Drawing.Point(423, 120);
            this.gallery1.Name = "gallery1";
            this.gallery1.Size = new System.Drawing.Size(365, 261);
            this.gallery1.TabIndex = 0;
            this.gallery1.Text = "gallery1";
            this.gallery1.UseVisualStyleBackColor = true;
            // 
            // galEllipse1
            // 
            this.galEllipse1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galEllipse1.ForeColor = System.Drawing.Color.White;
            this.galEllipse1.Location = new System.Drawing.Point(12, 88);
            this.galEllipse1.Name = "galEllipse1";
            this.galEllipse1.Size = new System.Drawing.Size(376, 266);
            this.galEllipse1.TabIndex = 1;
            this.galEllipse1.Text = "galEllipse1";
            this.galEllipse1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.galEllipse1);
            this.Controls.Add(this.gallery1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gallery gallery1;
        private GalEllipse galEllipse1;
    }
}

