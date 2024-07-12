namespace RegistrationMark2
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
            this.LogBox = new System.Windows.Forms.TextBox();
            this.PasBox = new System.Windows.Forms.TextBox();
            this.RegBtn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.LogBtn = new System.Windows.Forms.Button();
            this.Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(50, 87);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(100, 22);
            this.LogBox.TabIndex = 0;
            // 
            // PasBox
            // 
            this.PasBox.Location = new System.Drawing.Point(50, 157);
            this.PasBox.Name = "PasBox";
            this.PasBox.Size = new System.Drawing.Size(100, 22);
            this.PasBox.TabIndex = 1;
            // 
            // RegBtn
            // 
            this.RegBtn.Location = new System.Drawing.Point(63, 214);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(75, 23);
            this.RegBtn.TabIndex = 2;
            this.RegBtn.Text = "reg";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(63, 284);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "button2";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // LogBtn
            // 
            this.LogBtn.Location = new System.Drawing.Point(63, 214);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(75, 23);
            this.LogBtn.TabIndex = 4;
            this.LogBtn.Text = "Log";
            this.LogBtn.UseVisualStyleBackColor = true;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(63, 284);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(75, 23);
            this.Btn.TabIndex = 5;
            this.Btn.Text = "button";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 453);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.PasBox);
            this.Controls.Add(this.LogBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TextBox PasBox;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button LogBtn;
        private System.Windows.Forms.Button Btn;
    }
}

