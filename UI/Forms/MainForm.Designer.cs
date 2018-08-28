namespace GhostBinUploaderClass.UI.Forms
{
    partial class MainForm
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
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bUpload = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bUpload
            // 
            this.bUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bUpload.Location = new System.Drawing.Point(12, 204);
            this.bUpload.Name = "bUpload";
            this.bUpload.Size = new System.Drawing.Size(307, 23);
            this.bUpload.TabIndex = 0;
            this.bUpload.Text = "Upload";
            this.bUpload.UseVisualStyleBackColor = true;
            this.bUpload.Click += new System.EventHandler(this.bUpload_Click);
            // 
            // rtbText
            // 
            this.rtbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText.Location = new System.Drawing.Point(12, 66);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(307, 132);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "asdasdasd";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Location = new System.Drawing.Point(12, 12);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(307, 21);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.Text = "sfsdad";
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.Location = new System.Drawing.Point(12, 233);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(307, 21);
            this.tbMessage.TabIndex = 3;
            this.tbMessage.DoubleClick += new System.EventHandler(this.tbMessage_DoubleClick);
            // 
            // tbPass
            // 
            this.tbPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPass.Location = new System.Drawing.Point(12, 39);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(307, 21);
            this.tbPass.TabIndex = 4;
            this.tbPass.Text = "sfsdad";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 267);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.bUpload);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bUpload;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbPass;
    }
}