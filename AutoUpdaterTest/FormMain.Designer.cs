﻿namespace AutoUpdaterTest
{
    partial class FormMain
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
            this.buttonCheckForUpdate = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCheckForUpdate
            // 
            this.buttonCheckForUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckForUpdate.Location = new System.Drawing.Point(12, 53);
            this.buttonCheckForUpdate.Name = "buttonCheckForUpdate";
            this.buttonCheckForUpdate.Size = new System.Drawing.Size(270, 57);
            this.buttonCheckForUpdate.TabIndex = 0;
            this.buttonCheckForUpdate.Text = "Check for update";
            this.buttonCheckForUpdate.UseVisualStyleBackColor = true;
            this.buttonCheckForUpdate.Click += new System.EventHandler(this.buttonCheckForUpdate_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(12, 19);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(160, 20);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Current version : 1.0.0.0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 122);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonCheckForUpdate);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "AutoUpdaterTest";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckForUpdate;
        private System.Windows.Forms.Label labelVersion;
    }
}