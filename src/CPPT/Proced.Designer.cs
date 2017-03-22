namespace CPPT
{
    partial class Proced
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
            this.components = new System.ComponentModel.Container();
            this.sglProgress = new System.Windows.Forms.ProgressBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.allProgress = new System.Windows.Forms.ProgressBar();
            this.btnMinisize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.sglLabel = new System.Windows.Forms.Label();
            this.allLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sglProgress
            // 
            this.sglProgress.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.sglProgress.Location = new System.Drawing.Point(34, 54);
            this.sglProgress.Name = "sglProgress";
            this.sglProgress.Size = new System.Drawing.Size(455, 22);
            this.sglProgress.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(45, 143);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(135, 34);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // allProgress
            // 
            this.allProgress.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.allProgress.Location = new System.Drawing.Point(34, 114);
            this.allProgress.Name = "allProgress";
            this.allProgress.Size = new System.Drawing.Size(455, 22);
            this.allProgress.TabIndex = 4;
            // 
            // btnMinisize
            // 
            this.btnMinisize.Location = new System.Drawing.Point(340, 143);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(135, 34);
            this.btnMinisize.TabIndex = 7;
            this.btnMinisize.Text = "隐藏";
            this.btnMinisize.UseVisualStyleBackColor = true;
            this.btnMinisize.Click += new System.EventHandler(this.btnMinisize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPPT";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "CPPT";
            this.notifyIcon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseMove);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // sglLabel
            // 
            this.sglLabel.AutoSize = true;
            this.sglLabel.Location = new System.Drawing.Point(32, 29);
            this.sglLabel.Name = "sglLabel";
            this.sglLabel.Size = new System.Drawing.Size(95, 12);
            this.sglLabel.TabIndex = 9;
            this.sglLabel.Text = "正在检索页数...";
            // 
            // allLabel
            // 
            this.allLabel.AutoSize = true;
            this.allLabel.Location = new System.Drawing.Point(32, 89);
            this.allLabel.Name = "allLabel";
            this.allLabel.Size = new System.Drawing.Size(107, 12);
            this.allLabel.TabIndex = 10;
            this.allLabel.Text = "正在检索文件数...";
            // 
            // Proced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(520, 206);
            this.Controls.Add(this.allLabel);
            this.Controls.Add(this.sglLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinisize);
            this.Controls.Add(this.allProgress);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.sglProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proced";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proced";
            this.Load += new System.EventHandler(this.Proced_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Proced_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Proced_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Proced_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar sglProgress;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ProgressBar allProgress;
        private System.Windows.Forms.Button btnMinisize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label sglLabel;
        private System.Windows.Forms.Label allLabel;
    }
}