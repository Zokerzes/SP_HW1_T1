namespace SP_HW1_T1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.myProcess = new System.Diagnostics.Process();
            this.btnStarnWait = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 44);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Notepad";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // myProcess
            // 
            this.myProcess.StartInfo.Domain = "";
            this.myProcess.StartInfo.LoadUserProfile = false;
            this.myProcess.StartInfo.Password = null;
            this.myProcess.StartInfo.StandardErrorEncoding = null;
            this.myProcess.StartInfo.StandardOutputEncoding = null;
            this.myProcess.StartInfo.UserName = "";
            this.myProcess.SynchronizingObject = this;
            // 
            // btnStarnWait
            // 
            this.btnStarnWait.Location = new System.Drawing.Point(203, 12);
            this.btnStarnWait.Name = "btnStarnWait";
            this.btnStarnWait.Size = new System.Drawing.Size(128, 44);
            this.btnStarnWait.TabIndex = 0;
            this.btnStarnWait.Text = "Start Notepad \r\nand Wait";
            this.btnStarnWait.UseVisualStyleBackColor = true;
            this.btnStarnWait.Click += new System.EventHandler(this.BtnStarnWait_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(12, 76);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(128, 44);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop Notepad ";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 156);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStarnWait);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(263, 107);
            this.Name = "Form1";
            this.Text = "Запуск блокнота";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Diagnostics.Process myProcess;
        private System.Windows.Forms.Button btnStarnWait;
        private System.Windows.Forms.Button btnStop;
    }
}

