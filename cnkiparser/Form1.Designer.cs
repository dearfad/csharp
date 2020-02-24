namespace cnkiparser
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Open_Button = new System.Windows.Forms.Button();
            this.Content_TextBox = new System.Windows.Forms.TextBox();
            this.Website_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Open_Button
            // 
            this.Open_Button.Location = new System.Drawing.Point(12, 39);
            this.Open_Button.Name = "Open_Button";
            this.Open_Button.Size = new System.Drawing.Size(776, 48);
            this.Open_Button.TabIndex = 0;
            this.Open_Button.Text = "打开网址";
            this.Open_Button.UseVisualStyleBackColor = true;
            this.Open_Button.Click += new System.EventHandler(this.Open_Button_Click);
            // 
            // Content_TextBox
            // 
            this.Content_TextBox.Location = new System.Drawing.Point(12, 93);
            this.Content_TextBox.Multiline = true;
            this.Content_TextBox.Name = "Content_TextBox";
            this.Content_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Content_TextBox.Size = new System.Drawing.Size(776, 345);
            this.Content_TextBox.TabIndex = 1;
            // 
            // Website_TextBox
            // 
            this.Website_TextBox.Location = new System.Drawing.Point(12, 12);
            this.Website_TextBox.Name = "Website_TextBox";
            this.Website_TextBox.Size = new System.Drawing.Size(776, 21);
            this.Website_TextBox.TabIndex = 2;
            this.Website_TextBox.Text = "http://news.baidu.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Website_TextBox);
            this.Controls.Add(this.Content_TextBox);
            this.Controls.Add(this.Open_Button);
            this.Name = "Form1";
            this.Text = "CNKI Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open_Button;
        private System.Windows.Forms.TextBox Content_TextBox;
        private System.Windows.Forms.TextBox Website_TextBox;
    }
}

