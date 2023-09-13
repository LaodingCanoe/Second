namespace Second
{
    partial class Second
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Second));
            this.ClOsE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClOsE
            // 
            this.ClOsE.BackColor = System.Drawing.Color.Silver;
            this.ClOsE.Location = new System.Drawing.Point(73, 279);
            this.ClOsE.Name = "ClOsE";
            this.ClOsE.Size = new System.Drawing.Size(153, 55);
            this.ClOsE.TabIndex = 0;
            this.ClOsE.Text = "ClOsE";
            this.ClOsE.UseVisualStyleBackColor = false;
            this.ClOsE.Click += new System.EventHandler(this.ClOsE_Click);
            // 
            // Second
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(320, 642);
            this.Controls.Add(this.ClOsE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Second";
            this.Text = "Second";
            this.Load += new System.EventHandler(this.Second_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClOsE;
    }
}

