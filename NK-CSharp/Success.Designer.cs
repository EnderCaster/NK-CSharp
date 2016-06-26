namespace NK_CSharp
{
    partial class Success
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Success));
            this.button_HangUp = new System.Windows.Forms.Button();
            this.button_ToTaskBar = new System.Windows.Forms.Button();
            this.Netkeeper = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // button_HangUp
            // 
            this.button_HangUp.BackgroundImage = global::NK_CSharp.Properties.Resources.hangUp;
            this.button_HangUp.FlatAppearance.BorderSize = 0;
            this.button_HangUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HangUp.Location = new System.Drawing.Point(0, 0);
            this.button_HangUp.Margin = new System.Windows.Forms.Padding(0);
            this.button_HangUp.Name = "button_HangUp";
            this.button_HangUp.Size = new System.Drawing.Size(250, 250);
            this.button_HangUp.TabIndex = 0;
            this.button_HangUp.UseVisualStyleBackColor = true;
            this.button_HangUp.Click += new System.EventHandler(this.button_HangUp_Click);
            // 
            // button_ToTaskBar
            // 
            this.button_ToTaskBar.BackColor = System.Drawing.Color.Transparent;
            this.button_ToTaskBar.FlatAppearance.BorderSize = 0;
            this.button_ToTaskBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ToTaskBar.Location = new System.Drawing.Point(0, 250);
            this.button_ToTaskBar.Margin = new System.Windows.Forms.Padding(0);
            this.button_ToTaskBar.Name = "button_ToTaskBar";
            this.button_ToTaskBar.Size = new System.Drawing.Size(250, 50);
            this.button_ToTaskBar.TabIndex = 1;
            this.button_ToTaskBar.Text = "缩小到任务栏";
            this.button_ToTaskBar.UseVisualStyleBackColor = false;
            this.button_ToTaskBar.Click += new System.EventHandler(this.button_ToTaskBar_Click);
            // 
            // Netkeeper
            // 
            this.Netkeeper.Icon = ((System.Drawing.Icon)(resources.GetObject("Netkeeper.Icon")));
            this.Netkeeper.Text = "点击以显示窗口";
            this.Netkeeper.Click += new System.EventHandler(this.Netkeeper_Click);
            // 
            // Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 300);
            this.Controls.Add(this.button_ToTaskBar);
            this.Controls.Add(this.button_HangUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Success";
            this.Text = "Success";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_HangUp;
        private System.Windows.Forms.Button button_ToTaskBar;
        private System.Windows.Forms.NotifyIcon Netkeeper;
    }
}