namespace EncryptTest
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
            this.button_Encrypt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Source = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Encrypt = new System.Windows.Forms.TextBox();
            this.textBox_Decrypt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Encrypt
            // 
            this.button_Encrypt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Encrypt.Location = new System.Drawing.Point(315, 471);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.button_Encrypt.TabIndex = 0;
            this.button_Encrypt.Text = "Encrypt";
            this.button_Encrypt.UseVisualStyleBackColor = true;
            this.button_Encrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_Decrypt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Encrypt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Source, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 408);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // textBox_Source
            // 
            this.textBox_Source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Source.Location = new System.Drawing.Point(3, 3);
            this.textBox_Source.Multiline = true;
            this.textBox_Source.Name = "textBox_Source";
            this.textBox_Source.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Source.Size = new System.Drawing.Size(711, 130);
            this.textBox_Source.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox_Encrypt
            // 
            this.textBox_Encrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Encrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Encrypt.Location = new System.Drawing.Point(3, 139);
            this.textBox_Encrypt.Multiline = true;
            this.textBox_Encrypt.Name = "textBox_Encrypt";
            this.textBox_Encrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Encrypt.Size = new System.Drawing.Size(711, 129);
            this.textBox_Encrypt.TabIndex = 4;
            // 
            // textBox_Decrypt
            // 
            this.textBox_Decrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Decrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Decrypt.Location = new System.Drawing.Point(3, 274);
            this.textBox_Decrypt.Multiline = true;
            this.textBox_Decrypt.Name = "textBox_Decrypt";
            this.textBox_Decrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Decrypt.Size = new System.Drawing.Size(711, 131);
            this.textBox_Decrypt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_Encrypt);
            this.Name = "Form1";
            this.Text = "EncryptTest";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Encrypt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_Source;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Decrypt;
        private System.Windows.Forms.TextBox textBox_Encrypt;
    }
}

