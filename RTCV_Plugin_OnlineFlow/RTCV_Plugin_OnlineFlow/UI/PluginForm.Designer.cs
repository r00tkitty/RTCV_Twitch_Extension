namespace ONLINEFLOW.UI
{
    partial class PluginForm
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
            this.pnModule = new System.Windows.Forms.Panel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnToggleEnabled = new System.Windows.Forms.Button();
            this.lblLastActionValue = new System.Windows.Forms.Label();
            this.lblLastActionCaption = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnModule
            // 
            this.pnModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnModule.Controls.Add(this.btnOptions);
            this.pnModule.Controls.Add(this.btnToggleEnabled);
            this.pnModule.Controls.Add(this.lblLastActionValue);
            this.pnModule.Controls.Add(this.lblLastActionCaption);
            this.pnModule.Controls.Add(this.lblConnectionStatus);
            this.pnModule.Controls.Add(this.lblTitle);
            this.pnModule.Location = new System.Drawing.Point(0, 0);
            this.pnModule.Name = "pnModule";
            this.pnModule.Size = new System.Drawing.Size(150, 118);
            this.pnModule.TabIndex = 0;
            this.pnModule.Tag = "color:dark2";
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Location = new System.Drawing.Point(77, 92);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(64, 22);
            this.btnOptions.TabIndex = 6;
            this.btnOptions.Tag = "color:dark3";
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnToggleEnabled
            // 
            this.btnToggleEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnToggleEnabled.FlatAppearance.BorderSize = 0;
            this.btnToggleEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleEnabled.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnToggleEnabled.ForeColor = System.Drawing.Color.White;
            this.btnToggleEnabled.Location = new System.Drawing.Point(9, 92);
            this.btnToggleEnabled.Name = "btnToggleEnabled";
            this.btnToggleEnabled.Size = new System.Drawing.Size(64, 22);
            this.btnToggleEnabled.TabIndex = 5;
            this.btnToggleEnabled.Tag = "color:dark3";
            this.btnToggleEnabled.Text = "Disabled";
            this.btnToggleEnabled.UseVisualStyleBackColor = false;
            this.btnToggleEnabled.Click += new System.EventHandler(this.btnToggleEnabled_Click);
            // 
            // lblLastActionValue
            // 
            this.lblLastActionValue.AutoEllipsis = true;
            this.lblLastActionValue.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblLastActionValue.ForeColor = System.Drawing.Color.White;
            this.lblLastActionValue.Location = new System.Drawing.Point(9, 70);
            this.lblLastActionValue.Name = "lblLastActionValue";
            this.lblLastActionValue.Size = new System.Drawing.Size(132, 15);
            this.lblLastActionValue.TabIndex = 4;
            this.lblLastActionValue.Text = "No actions yet";
            // 
            // lblLastActionCaption
            // 
            this.lblLastActionCaption.AutoSize = true;
            this.lblLastActionCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLastActionCaption.ForeColor = System.Drawing.Color.White;
            this.lblLastActionCaption.Location = new System.Drawing.Point(9, 54);
            this.lblLastActionCaption.Name = "lblLastActionCaption";
            this.lblLastActionCaption.Size = new System.Drawing.Size(65, 13);
            this.lblLastActionCaption.TabIndex = 3;
            this.lblLastActionCaption.Text = "Last action:";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoEllipsis = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.White;
            this.lblConnectionStatus.Location = new System.Drawing.Point(9, 34);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(132, 14);
            this.lblConnectionStatus.TabIndex = 1;
            this.lblConnectionStatus.Text = "Not connected";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(9, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CrowdCorrupt";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(150, 118);
            this.Controls.Add(this.pnModule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PluginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "color:dark3";
            this.Text = "CrowdCorrupt";
            this.Load += new System.EventHandler(this.PluginForm_Load);
            this.pnModule.ResumeLayout(false);
            this.pnModule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnModule;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblLastActionCaption;
        private System.Windows.Forms.Label lblLastActionValue;
        private System.Windows.Forms.Button btnToggleEnabled;
        private System.Windows.Forms.Button btnOptions;
    }
}