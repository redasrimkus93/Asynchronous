
namespace Asynchronous
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sync = new System.Windows.Forms.Button();
            this.webInfo = new System.Windows.Forms.RichTextBox();
            this.asyncButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sync
            // 
            this.Sync.Location = new System.Drawing.Point(221, 34);
            this.Sync.Name = "Sync";
            this.Sync.Size = new System.Drawing.Size(172, 36);
            this.Sync.TabIndex = 0;
            this.Sync.Text = "SyncDownload";
            this.Sync.UseVisualStyleBackColor = true;
            this.Sync.Click += new System.EventHandler(this.Sync_Click);
            // 
            // webInfo
            // 
            this.webInfo.Location = new System.Drawing.Point(221, 109);
            this.webInfo.Name = "webInfo";
            this.webInfo.Size = new System.Drawing.Size(418, 226);
            this.webInfo.TabIndex = 1;
            this.webInfo.Text = "";
            // 
            // asyncButton
            // 
            this.asyncButton.Location = new System.Drawing.Point(458, 34);
            this.asyncButton.Name = "asyncButton";
            this.asyncButton.Size = new System.Drawing.Size(181, 36);
            this.asyncButton.TabIndex = 2;
            this.asyncButton.Text = "AsyncDownload";
            this.asyncButton.UseVisualStyleBackColor = true;
            this.asyncButton.Click += new System.EventHandler(this.asyncButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.asyncButton);
            this.Controls.Add(this.webInfo);
            this.Controls.Add(this.Sync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sync;
        private System.Windows.Forms.RichTextBox webInfo;
        private System.Windows.Forms.Button asyncButton;
    }
}

