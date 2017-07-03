namespace Super.Lotto
{
    partial class FrmLotto
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
            this.gboLotto = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPostzone1 = new System.Windows.Forms.Label();
            this.lblPostzone0 = new System.Windows.Forms.Label();
            this.lblProzone0 = new System.Windows.Forms.Label();
            this.lblProzone4 = new System.Windows.Forms.Label();
            this.lblProzone3 = new System.Windows.Forms.Label();
            this.lblProzone2 = new System.Windows.Forms.Label();
            this.lblProzone1 = new System.Windows.Forms.Label();
            this.gboLotto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboLotto
            // 
            this.gboLotto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboLotto.Controls.Add(this.btnStop);
            this.gboLotto.Controls.Add(this.btnStart);
            this.gboLotto.Controls.Add(this.lblPostzone1);
            this.gboLotto.Controls.Add(this.lblPostzone0);
            this.gboLotto.Controls.Add(this.lblProzone0);
            this.gboLotto.Controls.Add(this.lblProzone4);
            this.gboLotto.Controls.Add(this.lblProzone3);
            this.gboLotto.Controls.Add(this.lblProzone2);
            this.gboLotto.Controls.Add(this.lblProzone1);
            this.gboLotto.Location = new System.Drawing.Point(33, 12);
            this.gboLotto.Name = "gboLotto";
            this.gboLotto.Size = new System.Drawing.Size(687, 210);
            this.gboLotto.TabIndex = 0;
            this.gboLotto.TabStop = false;
            this.gboLotto.Text = "大乐透结果区";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(411, 150);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 33);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "结束";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(185, 150);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 33);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPostzone1
            // 
            this.lblPostzone1.AutoSize = true;
            this.lblPostzone1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPostzone1.Location = new System.Drawing.Point(592, 53);
            this.lblPostzone1.Name = "lblPostzone1";
            this.lblPostzone1.Size = new System.Drawing.Size(23, 15);
            this.lblPostzone1.TabIndex = 6;
            this.lblPostzone1.Text = "00";
            // 
            // lblPostzone0
            // 
            this.lblPostzone0.AutoSize = true;
            this.lblPostzone0.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPostzone0.Location = new System.Drawing.Point(505, 53);
            this.lblPostzone0.Name = "lblPostzone0";
            this.lblPostzone0.Size = new System.Drawing.Size(23, 15);
            this.lblPostzone0.TabIndex = 5;
            this.lblPostzone0.Text = "00";
            // 
            // lblProzone0
            // 
            this.lblProzone0.AutoSize = true;
            this.lblProzone0.ForeColor = System.Drawing.Color.Crimson;
            this.lblProzone0.Location = new System.Drawing.Point(417, 53);
            this.lblProzone0.Name = "lblProzone0";
            this.lblProzone0.Size = new System.Drawing.Size(23, 15);
            this.lblProzone0.TabIndex = 4;
            this.lblProzone0.Text = "00";
            // 
            // lblProzone4
            // 
            this.lblProzone4.AutoSize = true;
            this.lblProzone4.ForeColor = System.Drawing.Color.Crimson;
            this.lblProzone4.Location = new System.Drawing.Point(329, 53);
            this.lblProzone4.Name = "lblProzone4";
            this.lblProzone4.Size = new System.Drawing.Size(23, 15);
            this.lblProzone4.TabIndex = 3;
            this.lblProzone4.Text = "00";
            // 
            // lblProzone3
            // 
            this.lblProzone3.AutoSize = true;
            this.lblProzone3.ForeColor = System.Drawing.Color.Crimson;
            this.lblProzone3.Location = new System.Drawing.Point(238, 53);
            this.lblProzone3.Name = "lblProzone3";
            this.lblProzone3.Size = new System.Drawing.Size(23, 15);
            this.lblProzone3.TabIndex = 2;
            this.lblProzone3.Text = "00";
            // 
            // lblProzone2
            // 
            this.lblProzone2.AutoSize = true;
            this.lblProzone2.ForeColor = System.Drawing.Color.Crimson;
            this.lblProzone2.Location = new System.Drawing.Point(150, 53);
            this.lblProzone2.Name = "lblProzone2";
            this.lblProzone2.Size = new System.Drawing.Size(23, 15);
            this.lblProzone2.TabIndex = 1;
            this.lblProzone2.Text = "00";
            // 
            // lblProzone1
            // 
            this.lblProzone1.AutoSize = true;
            this.lblProzone1.ForeColor = System.Drawing.Color.Crimson;
            this.lblProzone1.Location = new System.Drawing.Point(64, 53);
            this.lblProzone1.Name = "lblProzone1";
            this.lblProzone1.Size = new System.Drawing.Size(23, 15);
            this.lblProzone1.TabIndex = 0;
            this.lblProzone1.Text = "00";
            // 
            // FrmLotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 246);
            this.Controls.Add(this.gboLotto);
            this.Name = "FrmLotto";
            this.Text = "超级大乐透";
            this.gboLotto.ResumeLayout(false);
            this.gboLotto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboLotto;
        private System.Windows.Forms.Label lblProzone1;
        private System.Windows.Forms.Label lblProzone0;
        private System.Windows.Forms.Label lblProzone4;
        private System.Windows.Forms.Label lblProzone3;
        private System.Windows.Forms.Label lblProzone2;
        private System.Windows.Forms.Label lblPostzone1;
        private System.Windows.Forms.Label lblPostzone0;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
    }
}