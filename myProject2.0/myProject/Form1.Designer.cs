namespace myProject
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.upcount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ccount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注意事项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结果说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upcount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ccount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "系统设置";
            // 
            // upcount
            // 
            this.upcount.Location = new System.Drawing.Point(250, 90);
            this.upcount.Name = "upcount";
            this.upcount.Size = new System.Drawing.Size(120, 25);
            this.upcount.TabIndex = 3;
            this.upcount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入一条船最大载人量：";
            // 
            // ccount
            // 
            this.ccount.Location = new System.Drawing.Point(250, 40);
            this.ccount.Name = "ccount";
            this.ccount.Size = new System.Drawing.Size(120, 25);
            this.ccount.TabIndex = 1;
            this.ccount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入传教士/野人的渡河数量";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 141);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始计算渡河方案";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(13, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 362);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "渡河方案";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(538, 332);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.说明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 说明ToolStripMenuItem
            // 
            this.说明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注意事项ToolStripMenuItem,
            this.结果说明ToolStripMenuItem});
            this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            this.说明ToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.说明ToolStripMenuItem.Text = "点击查看使用说明";
            // 
            // 注意事项ToolStripMenuItem
            // 
            this.注意事项ToolStripMenuItem.Name = "注意事项ToolStripMenuItem";
            this.注意事项ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.注意事项ToolStripMenuItem.Text = "注意事项";
            this.注意事项ToolStripMenuItem.Click += new System.EventHandler(this.注意事项ToolStripMenuItem_Click);
            // 
            // 结果说明ToolStripMenuItem
            // 
            this.结果说明ToolStripMenuItem.Name = "结果说明ToolStripMenuItem";
            this.结果说明ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.结果说明ToolStripMenuItem.Text = "结果说明";
            this.结果说明ToolStripMenuItem.Click += new System.EventHandler(this.结果说明ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "传教士与野人渡河 ©wjw";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ccount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown upcount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注意事项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结果说明ToolStripMenuItem;
    }
}

