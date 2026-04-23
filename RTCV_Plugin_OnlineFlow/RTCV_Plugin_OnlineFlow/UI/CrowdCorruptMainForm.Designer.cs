namespace ONLINEFLOW.UI
{
    partial class CrowdCorruptMainForm
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

        private void InitializeComponent()
        {
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnLogsCard = new System.Windows.Forms.Panel();
            this.tbLogs = new System.Windows.Forms.TextBox();
            this.lblLogsTitle = new System.Windows.Forms.Label();
            this.pnChannelCard = new System.Windows.Forms.Panel();
            this.btnChannelUnlink = new System.Windows.Forms.Button();
            this.btnChannelEnable = new System.Windows.Forms.Button();
            this.lblChannelEnabled = new System.Windows.Forms.Label();
            this.lblChannelLive = new System.Windows.Forms.Label();
            this.lblChannelId = new System.Windows.Forms.Label();
            this.lblChannelName = new System.Windows.Forms.Label();
            this.lblChannelStatus = new System.Windows.Forms.Label();
            this.lblChannelTitle = new System.Windows.Forms.Label();
            this.pnRight = new System.Windows.Forms.Panel();
            this.pnRewardCard = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnRewardRows = new System.Windows.Forms.Panel();
            this.lblRewardTitle = new System.Windows.Forms.Label();
            this.pnLeft.SuspendLayout();
            this.pnLogsCard.SuspendLayout();
            this.pnChannelCard.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.pnRewardCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.pnLogsCard);
            this.pnLeft.Controls.Add(this.pnChannelCard);
            this.pnLeft.Location = new System.Drawing.Point(12, 12);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(360, 677);
            this.pnLeft.TabIndex = 0;
            // 
            // pnLogsCard
            // 
            this.pnLogsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.pnLogsCard.Controls.Add(this.tbLogs);
            this.pnLogsCard.Controls.Add(this.lblLogsTitle);
            this.pnLogsCard.Location = new System.Drawing.Point(0, 236);
            this.pnLogsCard.Name = "pnLogsCard";
            this.pnLogsCard.Size = new System.Drawing.Size(360, 441);
            this.pnLogsCard.TabIndex = 1;
            // 
            // tbLogs
            // 
            this.tbLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tbLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLogs.Font = new System.Drawing.Font("Consolas", 9F);
            this.tbLogs.ForeColor = System.Drawing.Color.White;
            this.tbLogs.Location = new System.Drawing.Point(23, 54);
            this.tbLogs.Multiline = true;
            this.tbLogs.Name = "tbLogs";
            this.tbLogs.ReadOnly = true;
            this.tbLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLogs.Size = new System.Drawing.Size(314, 364);
            this.tbLogs.TabIndex = 1;
            this.tbLogs.Text = "[01:30:27] PixelPouncer redeemed Manual Blast\r\n[01:30:41] ByteBunny redeemed Auto" +
    "-Corrupt"; // Placeholder text for logs
            // 
            // lblLogsTitle
            // 
            this.lblLogsTitle.AutoSize = true;
            this.lblLogsTitle.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblLogsTitle.ForeColor = System.Drawing.Color.White;
            this.lblLogsTitle.Location = new System.Drawing.Point(18, 15);
            this.lblLogsTitle.Name = "lblLogsTitle";
            this.lblLogsTitle.Size = new System.Drawing.Size(58, 30);
            this.lblLogsTitle.TabIndex = 0;
            this.lblLogsTitle.Text = "Logs";
            // 
            // pnChannelCard
            // 
            this.pnChannelCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.pnChannelCard.Controls.Add(this.btnChannelUnlink);
            this.pnChannelCard.Controls.Add(this.btnChannelEnable);
            this.pnChannelCard.Controls.Add(this.lblChannelEnabled);
            this.pnChannelCard.Controls.Add(this.lblChannelLive);
            this.pnChannelCard.Controls.Add(this.lblChannelId);
            this.pnChannelCard.Controls.Add(this.lblChannelName);
            this.pnChannelCard.Controls.Add(this.lblChannelStatus);
            this.pnChannelCard.Controls.Add(this.lblChannelTitle);
            this.pnChannelCard.Location = new System.Drawing.Point(0, 0);
            this.pnChannelCard.Name = "pnChannelCard";
            this.pnChannelCard.Size = new System.Drawing.Size(360, 220);
            this.pnChannelCard.TabIndex = 0;
            // 
            // btnChannelUnlink
            // 
            this.btnChannelUnlink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnChannelUnlink.FlatAppearance.BorderSize = 0;
            this.btnChannelUnlink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChannelUnlink.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnChannelUnlink.ForeColor = System.Drawing.Color.White;
            this.btnChannelUnlink.Location = new System.Drawing.Point(139, 173);
            this.btnChannelUnlink.Name = "btnChannelUnlink";
            this.btnChannelUnlink.Size = new System.Drawing.Size(110, 32);
            this.btnChannelUnlink.TabIndex = 7;
            this.btnChannelUnlink.Text = "Unlink";
            this.btnChannelUnlink.UseVisualStyleBackColor = false;
            // 
            // btnChannelEnable
            // 
            this.btnChannelEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnChannelEnable.FlatAppearance.BorderSize = 0;
            this.btnChannelEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChannelEnable.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnChannelEnable.ForeColor = System.Drawing.Color.White;
            this.btnChannelEnable.Location = new System.Drawing.Point(23, 173);
            this.btnChannelEnable.Name = "btnChannelEnable";
            this.btnChannelEnable.Size = new System.Drawing.Size(110, 32);
            this.btnChannelEnable.TabIndex = 6;
            this.btnChannelEnable.Text = "Enable";
            this.btnChannelEnable.UseVisualStyleBackColor = false;
            // 
            // lblChannelEnabled
            // 
            this.lblChannelEnabled.AutoSize = true;
            this.lblChannelEnabled.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChannelEnabled.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChannelEnabled.Location = new System.Drawing.Point(21, 139);
            this.lblChannelEnabled.Name = "lblChannelEnabled";
            this.lblChannelEnabled.Size = new System.Drawing.Size(117, 19);
            this.lblChannelEnabled.TabIndex = 5;
            this.lblChannelEnabled.Text = "CrowdCorrupt off";
            // 
            // lblChannelLive
            // 
            this.lblChannelLive.AutoSize = true;
            this.lblChannelLive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChannelLive.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChannelLive.Location = new System.Drawing.Point(20, 120);
            this.lblChannelLive.Name = "lblChannelLive";
            this.lblChannelLive.Size = new System.Drawing.Size(49, 19);
            this.lblChannelLive.TabIndex = 4;
            this.lblChannelLive.Text = "Offline";
            // 
            // lblChannelId
            // 
            this.lblChannelId.AutoSize = true;
            this.lblChannelId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChannelId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChannelId.Location = new System.Drawing.Point(20, 101);
            this.lblChannelId.Name = "lblChannelId";
            this.lblChannelId.Size = new System.Drawing.Size(140, 19);
            this.lblChannelId.TabIndex = 3;
            this.lblChannelId.Text = "Channel ID: 9379248";
            // 
            // lblChannelName
            // 
            this.lblChannelName.AutoSize = true;
            this.lblChannelName.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblChannelName.ForeColor = System.Drawing.Color.White;
            this.lblChannelName.Location = new System.Drawing.Point(18, 69);
            this.lblChannelName.Name = "lblChannelName";
            this.lblChannelName.Size = new System.Drawing.Size(225, 32);
            this.lblChannelName.TabIndex = 2;
            this.lblChannelName.Text = "prettybananasibling"; // i like kagamine len
            // 
            // lblChannelStatus
            // 
            this.lblChannelStatus.AutoSize = true;
            this.lblChannelStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblChannelStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChannelStatus.Location = new System.Drawing.Point(21, 54);
            this.lblChannelStatus.Name = "lblChannelStatus";
            this.lblChannelStatus.Size = new System.Drawing.Size(117, 15);
            this.lblChannelStatus.TabIndex = 1;
            this.lblChannelStatus.Text = "Connected to Twitch";
            // 
            // lblChannelTitle
            // 
            this.lblChannelTitle.AutoSize = true;
            this.lblChannelTitle.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblChannelTitle.ForeColor = System.Drawing.Color.White;
            this.lblChannelTitle.Location = new System.Drawing.Point(18, 15);
            this.lblChannelTitle.Name = "lblChannelTitle";
            this.lblChannelTitle.Size = new System.Drawing.Size(91, 30);
            this.lblChannelTitle.TabIndex = 0;
            this.lblChannelTitle.Text = "Channel";
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.pnRewardCard);
            this.pnRight.Location = new System.Drawing.Point(388, 12);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(784, 677);
            this.pnRight.TabIndex = 1;
            // 
            // pnRewardCard
            // 
            this.pnRewardCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.pnRewardCard.Controls.Add(this.btnApply);
            this.pnRewardCard.Controls.Add(this.btnSave);
            this.pnRewardCard.Controls.Add(this.btnLoad);
            this.pnRewardCard.Controls.Add(this.btnReset);
            this.pnRewardCard.Controls.Add(this.btnAdd);
            this.pnRewardCard.Controls.Add(this.pnRewardRows);
            this.pnRewardCard.Controls.Add(this.lblRewardTitle);
            this.pnRewardCard.Location = new System.Drawing.Point(0, 0);
            this.pnRewardCard.Name = "pnRewardCard";
            this.pnRewardCard.Size = new System.Drawing.Size(784, 677);
            this.pnRewardCard.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(20)))), ((int)(((byte)(87)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(655, 621);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(104, 35);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(549, 621);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(443, 621);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 35);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(131, 621);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 35);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 621);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // pnRewardRows
            // 
            this.pnRewardRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnRewardRows.Location = new System.Drawing.Point(25, 54);
            this.pnRewardRows.Name = "pnRewardRows";
            this.pnRewardRows.Size = new System.Drawing.Size(734, 551);
            this.pnRewardRows.TabIndex = 1;
            // 
            // lblRewardTitle
            // 
            this.lblRewardTitle.AutoSize = true;
            this.lblRewardTitle.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblRewardTitle.ForeColor = System.Drawing.Color.White;
            this.lblRewardTitle.Location = new System.Drawing.Point(20, 15);
            this.lblRewardTitle.Name = "lblRewardTitle";
            this.lblRewardTitle.Size = new System.Drawing.Size(178, 30);
            this.lblRewardTitle.TabIndex = 0;
            this.lblRewardTitle.Text = "Reward Manager"; // put shit in here.
            // 
            // CrowdCorruptMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1184, 701);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnLeft);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "CrowdCorruptMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrowdCorrupt";
            this.pnLeft.ResumeLayout(false);
            this.pnLogsCard.ResumeLayout(false);
            this.pnLogsCard.PerformLayout();
            this.pnChannelCard.ResumeLayout(false);
            this.pnChannelCard.PerformLayout();
            this.pnRight.ResumeLayout(false);
            this.pnRewardCard.ResumeLayout(false);
            this.pnRewardCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnChannelCard;
        private System.Windows.Forms.Label lblChannelTitle;
        private System.Windows.Forms.Label lblChannelStatus;
        private System.Windows.Forms.Label lblChannelName;
        private System.Windows.Forms.Label lblChannelId;
        private System.Windows.Forms.Label lblChannelLive;
        private System.Windows.Forms.Label lblChannelEnabled;
        private System.Windows.Forms.Button btnChannelEnable;
        private System.Windows.Forms.Button btnChannelUnlink;

        private System.Windows.Forms.Panel pnLogsCard;
        private System.Windows.Forms.Label lblLogsTitle;
        private System.Windows.Forms.TextBox tbLogs;

        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnRewardCard;
        private System.Windows.Forms.Label lblRewardTitle;
        private System.Windows.Forms.Panel pnRewardRows;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnApply;
    }
}