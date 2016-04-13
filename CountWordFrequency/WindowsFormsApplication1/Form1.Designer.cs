namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UniqueFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UnqiueFilePath = new System.Windows.Forms.TextBox();
            this.ManyFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ManyFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DicFile = new System.Windows.Forms.Button();
            this.DicFilePath = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.many = new System.Windows.Forms.RadioButton();
            this.unique = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UniqueFile
            // 
            this.UniqueFile.Location = new System.Drawing.Point(745, 42);
            this.UniqueFile.Name = "UniqueFile";
            this.UniqueFile.Size = new System.Drawing.Size(99, 33);
            this.UniqueFile.TabIndex = 0;
            this.UniqueFile.Text = "选择文件";
            this.UniqueFile.UseVisualStyleBackColor = true;
            this.UniqueFile.Click += new System.EventHandler(this.UniqueFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "待分析文件：";
            // 
            // UnqiueFilePath
            // 
            this.UnqiueFilePath.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UnqiueFilePath.Location = new System.Drawing.Point(32, 49);
            this.UnqiueFilePath.Name = "UnqiueFilePath";
            this.UnqiueFilePath.Size = new System.Drawing.Size(682, 21);
            this.UnqiueFilePath.TabIndex = 2;
            // 
            // ManyFile
            // 
            this.ManyFile.Location = new System.Drawing.Point(745, 120);
            this.ManyFile.Name = "ManyFile";
            this.ManyFile.Size = new System.Drawing.Size(99, 34);
            this.ManyFile.TabIndex = 3;
            this.ManyFile.Text = "选择文件夹";
            this.ManyFile.UseVisualStyleBackColor = true;
            this.ManyFile.Click += new System.EventHandler(this.ManyFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "文件路径：";
            // 
            // ManyFilePath
            // 
            this.ManyFilePath.Location = new System.Drawing.Point(32, 128);
            this.ManyFilePath.Name = "ManyFilePath";
            this.ManyFilePath.Size = new System.Drawing.Size(682, 21);
            this.ManyFilePath.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(30, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "字典文件：";
            // 
            // DicFile
            // 
            this.DicFile.Location = new System.Drawing.Point(745, 200);
            this.DicFile.Name = "DicFile";
            this.DicFile.Size = new System.Drawing.Size(99, 33);
            this.DicFile.TabIndex = 7;
            this.DicFile.Text = "选择文件";
            this.DicFile.UseVisualStyleBackColor = true;
            this.DicFile.Click += new System.EventHandler(this.DicFile_Click);
            // 
            // DicFilePath
            // 
            this.DicFilePath.Location = new System.Drawing.Point(32, 207);
            this.DicFilePath.Name = "DicFilePath";
            this.DicFilePath.Size = new System.Drawing.Size(682, 21);
            this.DicFilePath.TabIndex = 8;
            // 
            // Run
            // 
            this.Run.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Run.Location = new System.Drawing.Point(745, 279);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(99, 37);
            this.Run.TabIndex = 9;
            this.Run.Text = "开始统计";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.many);
            this.groupBox1.Controls.Add(this.unique);
            this.groupBox1.Location = new System.Drawing.Point(540, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 92);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // many
            // 
            this.many.AutoSize = true;
            this.many.ForeColor = System.Drawing.SystemColors.Highlight;
            this.many.Location = new System.Drawing.Point(28, 58);
            this.many.Name = "many";
            this.many.Size = new System.Drawing.Size(95, 16);
            this.many.TabIndex = 1;
            this.many.TabStop = true;
            this.many.Text = "多个文件统计";
            this.many.UseVisualStyleBackColor = true;
            // 
            // unique
            // 
            this.unique.AutoSize = true;
            this.unique.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.unique.Checked = true;
            this.unique.ForeColor = System.Drawing.SystemColors.Highlight;
            this.unique.Location = new System.Drawing.Point(28, 21);
            this.unique.Name = "unique";
            this.unique.Size = new System.Drawing.Size(95, 16);
            this.unique.TabIndex = 0;
            this.unique.TabStop = true;
            this.unique.Text = "单个文件统计";
            this.unique.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.qrcode_for_gh_6896906abba9_258;
            this.pictureBox1.Location = new System.Drawing.Point(32, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 260);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(856, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.DicFilePath);
            this.Controls.Add(this.DicFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ManyFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ManyFile);
            this.Controls.Add(this.UnqiueFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UniqueFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "词频统计小工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UniqueFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UnqiueFilePath;
        private System.Windows.Forms.Button ManyFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ManyFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DicFile;
        private System.Windows.Forms.TextBox DicFilePath;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton many;
        private System.Windows.Forms.RadioButton unique;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

