namespace EapClientManager
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
            this.stBtn = new System.Windows.Forms.Button();
            this.ipTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countTxt = new System.Windows.Forms.TextBox();
            this.logTxt = new System.Windows.Forms.TextBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileTxt = new System.Windows.Forms.TextBox();
            this.fileBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stBtn
            // 
            this.stBtn.Location = new System.Drawing.Point(775, 33);
            this.stBtn.Name = "stBtn";
            this.stBtn.Size = new System.Drawing.Size(87, 41);
            this.stBtn.TabIndex = 0;
            this.stBtn.Text = "Start";
            this.stBtn.UseVisualStyleBackColor = true;
            this.stBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ipTxt
            // 
            this.ipTxt.Location = new System.Drawing.Point(116, 45);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(260, 29);
            this.ipTxt.TabIndex = 1;
            this.ipTxt.Text = "192.168.218.128";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host IP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client Count :";
            // 
            // countTxt
            // 
            this.countTxt.Location = new System.Drawing.Point(531, 45);
            this.countTxt.Name = "countTxt";
            this.countTxt.Size = new System.Drawing.Size(58, 29);
            this.countTxt.TabIndex = 4;
            this.countTxt.Text = "1";
            // 
            // logTxt
            // 
            this.logTxt.Location = new System.Drawing.Point(42, 157);
            this.logTxt.Multiline = true;
            this.logTxt.Name = "logTxt";
            this.logTxt.Size = new System.Drawing.Size(986, 204);
            this.logTxt.TabIndex = 5;
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(886, 33);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(87, 41);
            this.stopBtn.TabIndex = 0;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileTxt
            // 
            this.fileTxt.Location = new System.Drawing.Point(116, 110);
            this.fileTxt.Name = "fileTxt";
            this.fileTxt.Size = new System.Drawing.Size(622, 29);
            this.fileTxt.TabIndex = 1;
            // 
            // fileBtn
            // 
            this.fileBtn.Location = new System.Drawing.Point(775, 98);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(87, 49);
            this.fileBtn.TabIndex = 0;
            this.fileBtn.Text = "Select File";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exec File :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 385);
            this.Controls.Add(this.logTxt);
            this.Controls.Add(this.countTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileTxt);
            this.Controls.Add(this.ipTxt);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.fileBtn);
            this.Controls.Add(this.stBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stBtn;
        private System.Windows.Forms.TextBox ipTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countTxt;
        private System.Windows.Forms.TextBox logTxt;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox fileTxt;
        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.Label label3;
    }
}

