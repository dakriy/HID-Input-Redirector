namespace DeviceSelector
{
    partial class HIDRedirector
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
            this.hookLabel = new System.Windows.Forms.Label();
            this.deviceBox = new System.Windows.Forms.ComboBox();
            this.applicationBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doHook = new System.Windows.Forms.Button();
            this.doUnhook = new System.Windows.Forms.Button();
            this.doRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hookLabel
            // 
            this.hookLabel.AutoSize = true;
            this.hookLabel.Location = new System.Drawing.Point(9, 33);
            this.hookLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hookLabel.Name = "hookLabel";
            this.hookLabel.Size = new System.Drawing.Size(0, 16);
            this.hookLabel.TabIndex = 1;
            this.hookLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deviceBox
            // 
            this.deviceBox.FormattingEnabled = true;
            this.deviceBox.Location = new System.Drawing.Point(12, 151);
            this.deviceBox.Name = "deviceBox";
            this.deviceBox.Size = new System.Drawing.Size(295, 24);
            this.deviceBox.TabIndex = 2;
            // 
            // applicationBox
            // 
            this.applicationBox.FormattingEnabled = true;
            this.applicationBox.Location = new System.Drawing.Point(313, 151);
            this.applicationBox.Name = "applicationBox";
            this.applicationBox.Size = new System.Drawing.Size(381, 24);
            this.applicationBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a device";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select an application";
            // 
            // doHook
            // 
            this.doHook.Location = new System.Drawing.Point(186, 275);
            this.doHook.Name = "doHook";
            this.doHook.Size = new System.Drawing.Size(75, 23);
            this.doHook.TabIndex = 6;
            this.doHook.Text = "Hook";
            this.doHook.UseVisualStyleBackColor = true;
            this.doHook.Click += new System.EventHandler(this.doHook_Click);
            // 
            // doUnhook
            // 
            this.doUnhook.Location = new System.Drawing.Point(437, 275);
            this.doUnhook.Name = "doUnhook";
            this.doUnhook.Size = new System.Drawing.Size(75, 23);
            this.doUnhook.TabIndex = 7;
            this.doUnhook.Text = "Unhook";
            this.doUnhook.UseVisualStyleBackColor = true;
            this.doUnhook.Click += new System.EventHandler(this.doUnhook_Click);
            // 
            // doRefresh
            // 
            this.doRefresh.Location = new System.Drawing.Point(313, 275);
            this.doRefresh.Name = "doRefresh";
            this.doRefresh.Size = new System.Drawing.Size(75, 23);
            this.doRefresh.TabIndex = 8;
            this.doRefresh.Text = "Refresh";
            this.doRefresh.UseVisualStyleBackColor = true;
            this.doRefresh.Click += new System.EventHandler(this.doRefresh_Click);
            // 
            // HIDRedirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 326);
            this.Controls.Add(this.doRefresh);
            this.Controls.Add(this.doUnhook);
            this.Controls.Add(this.doHook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.applicationBox);
            this.Controls.Add(this.deviceBox);
            this.Controls.Add(this.hookLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HIDRedirector";
            this.Text = "Input Redirector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hookLabel;
        private System.Windows.Forms.ComboBox deviceBox;
        private System.Windows.Forms.ComboBox applicationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button doHook;
        private System.Windows.Forms.Button doUnhook;
        private System.Windows.Forms.Button doRefresh;
    }
}

