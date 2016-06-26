namespace NK_CSharp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.text_Username = new System.Windows.Forms.TextBox();
            this.text_Password = new System.Windows.Forms.TextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_TestWarning = new System.Windows.Forms.Label();
            this.label_ReturnInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.BackColor = System.Drawing.Color.Transparent;
            this.label_Username.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label_Username.Location = new System.Drawing.Point(25, 154);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(57, 12);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "用户名：";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.Transparent;
            this.label_Password.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label_Password.Location = new System.Drawing.Point(25, 200);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(57, 12);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "密　码：";
            // 
            // text_Username
            // 
            this.text_Username.Location = new System.Drawing.Point(100, 154);
            this.text_Username.Name = "text_Username";
            this.text_Username.Size = new System.Drawing.Size(125, 21);
            this.text_Username.TabIndex = 2;
            // 
            // text_Password
            // 
            this.text_Password.Location = new System.Drawing.Point(100, 200);
            this.text_Password.Name = "text_Password";
            this.text_Password.PasswordChar = '*';
            this.text_Password.Size = new System.Drawing.Size(125, 21);
            this.text_Password.TabIndex = 3;
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(25, 271);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 23);
            this.button_Submit.TabIndex = 4;
            this.button_Submit.Text = "确认";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(150, 271);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_TestWarning
            // 
            this.label_TestWarning.AutoSize = true;
            this.label_TestWarning.BackColor = System.Drawing.Color.Transparent;
            this.label_TestWarning.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_TestWarning.ForeColor = System.Drawing.Color.Red;
            this.label_TestWarning.Location = new System.Drawing.Point(8, 9);
            this.label_TestWarning.Name = "label_TestWarning";
            this.label_TestWarning.Size = new System.Drawing.Size(96, 12);
            this.label_TestWarning.TabIndex = 6;
            this.label_TestWarning.Text = "仅用于内部测试";
            // 
            // label_ReturnInfo
            // 
            this.label_ReturnInfo.AutoSize = true;
            this.label_ReturnInfo.BackColor = System.Drawing.Color.Transparent;
            this.label_ReturnInfo.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ReturnInfo.ForeColor = System.Drawing.Color.White;
            this.label_ReturnInfo.Location = new System.Drawing.Point(29, 330);
            this.label_ReturnInfo.Name = "label_ReturnInfo";
            this.label_ReturnInfo.Size = new System.Drawing.Size(0, 12);
            this.label_ReturnInfo.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::NK_CSharp.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(250, 500);
            this.Controls.Add(this.label_ReturnInfo);
            this.Controls.Add(this.label_TestWarning);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.text_Password);
            this.Controls.Add(this.text_Username);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netkeeper-C#去检测版";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox text_Username;
        private System.Windows.Forms.TextBox text_Password;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_TestWarning;
        public System.Windows.Forms.Label label_ReturnInfo;
    }
}

