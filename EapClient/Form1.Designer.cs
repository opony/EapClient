namespace EapClient
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.hostTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.contBtn = new System.Windows.Forms.Button();
            this.discontBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLab = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.dataTxt = new System.Windows.Forms.TextBox();
            this.freqTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logTxt = new System.Windows.Forms.TextBox();
            this.sendOnceBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status :";
            // 
            // hostTxt
            // 
            this.hostTxt.Location = new System.Drawing.Point(48, 52);
            this.hostTxt.Name = "hostTxt";
            this.hostTxt.Size = new System.Drawing.Size(148, 22);
            this.hostTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port :";
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(286, 52);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(80, 22);
            this.portTxt.TabIndex = 1;
            // 
            // contBtn
            // 
            this.contBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.contBtn.Location = new System.Drawing.Point(495, 50);
            this.contBtn.Name = "contBtn";
            this.contBtn.Size = new System.Drawing.Size(75, 23);
            this.contBtn.TabIndex = 2;
            this.contBtn.Text = "Connect";
            this.contBtn.UseVisualStyleBackColor = false;
            this.contBtn.Click += new System.EventHandler(this.contBtn_Click);
            // 
            // discontBtn
            // 
            this.discontBtn.BackColor = System.Drawing.Color.Red;
            this.discontBtn.Enabled = false;
            this.discontBtn.Location = new System.Drawing.Point(604, 50);
            this.discontBtn.Name = "discontBtn";
            this.discontBtn.Size = new System.Drawing.Size(75, 23);
            this.discontBtn.TabIndex = 2;
            this.discontBtn.Text = "Disconnect";
            this.discontBtn.UseVisualStyleBackColor = false;
            this.discontBtn.Click += new System.EventHandler(this.discontBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Host :";
            // 
            // statusLab
            // 
            this.statusLab.AutoSize = true;
            this.statusLab.BackColor = System.Drawing.Color.Red;
            this.statusLab.Location = new System.Drawing.Point(56, 20);
            this.statusLab.Name = "statusLab";
            this.statusLab.Size = new System.Drawing.Size(67, 12);
            this.statusLab.TabIndex = 0;
            this.statusLab.Text = "Disconnected";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sendOnceBtn);
            this.groupBox1.Controls.Add(this.stopBtn);
            this.groupBox1.Controls.Add(this.startBtn);
            this.groupBox1.Controls.Add(this.applyBtn);
            this.groupBox1.Controls.Add(this.dataTxt);
            this.groupBox1.Controls.Add(this.freqTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 295);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(508, 19);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Location = new System.Drawing.Point(389, 19);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.Enabled = false;
            this.applyBtn.Location = new System.Drawing.Point(272, 19);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 2;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // dataTxt
            // 
            this.dataTxt.Location = new System.Drawing.Point(8, 78);
            this.dataTxt.Multiline = true;
            this.dataTxt.Name = "dataTxt";
            this.dataTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataTxt.Size = new System.Drawing.Size(651, 211);
            this.dataTxt.TabIndex = 1;
            // 
            // freqTxt
            // 
            this.freqTxt.Location = new System.Drawing.Point(44, 21);
            this.freqTxt.Name = "freqTxt";
            this.freqTxt.Size = new System.Drawing.Size(65, 22);
            this.freqTxt.TabIndex = 1;
            this.freqTxt.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data Format :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Freq :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logTxt);
            this.groupBox2.Location = new System.Drawing.Point(14, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 157);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // logTxt
            // 
            this.logTxt.Location = new System.Drawing.Point(6, 21);
            this.logTxt.Multiline = true;
            this.logTxt.Name = "logTxt";
            this.logTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTxt.Size = new System.Drawing.Size(653, 130);
            this.logTxt.TabIndex = 0;
            // 
            // sendOnceBtn
            // 
            this.sendOnceBtn.Enabled = false;
            this.sendOnceBtn.Location = new System.Drawing.Point(508, 48);
            this.sendOnceBtn.Name = "sendOnceBtn";
            this.sendOnceBtn.Size = new System.Drawing.Size(75, 23);
            this.sendOnceBtn.TabIndex = 2;
            this.sendOnceBtn.Text = "Send Once";
            this.sendOnceBtn.UseVisualStyleBackColor = true;
            this.sendOnceBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 568);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.discontBtn);
            this.Controls.Add(this.contBtn);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.hostTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusLab);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hostTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.Button contBtn;
        private System.Windows.Forms.Button discontBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusLab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox freqTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dataTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox logTxt;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button sendOnceBtn;
    }
}

