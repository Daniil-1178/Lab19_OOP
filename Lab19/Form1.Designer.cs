namespace Lab19
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
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.lstHardwareInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(85, 12);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(165, 23);
            this.btnGetInfo.TabIndex = 0;
            this.btnGetInfo.Text = "Отримати інформацію про ПК";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // lstHardwareInfo
            // 
            this.lstHardwareInfo.FormattingEnabled = true;
            this.lstHardwareInfo.Location = new System.Drawing.Point(12, 55);
            this.lstHardwareInfo.Name = "lstHardwareInfo";
            this.lstHardwareInfo.Size = new System.Drawing.Size(338, 316);
            this.lstHardwareInfo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstHardwareInfo);
            this.Controls.Add(this.btnGetInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.ListBox lstHardwareInfo;
    }
}

