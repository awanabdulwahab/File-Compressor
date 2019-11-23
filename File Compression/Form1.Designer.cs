namespace File_Compression
{
    partial class Form1
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
            this.txtSimple = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblUpload = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnDecompress = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSimple
            // 
            this.txtSimple.Location = new System.Drawing.Point(127, 36);
            this.txtSimple.Multiline = true;
            this.txtSimple.Name = "txtSimple";
            this.txtSimple.Size = new System.Drawing.Size(185, 93);
            this.txtSimple.TabIndex = 1;
            this.txtSimple.Text = "Enter Your Text";
            this.txtSimple.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(127, 178);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(132, 20);
            this.txtFile.TabIndex = 2;
            this.txtFile.Text = "Select a file";
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Location = new System.Drawing.Point(31, 184);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(78, 13);
            this.lblUpload.TabIndex = 3;
            this.lblUpload.Text = "From Computer";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(304, 175);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(86, 248);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(75, 23);
            this.btnCompress.TabIndex = 7;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            // 
            // btnDecompress
            // 
            this.btnDecompress.Location = new System.Drawing.Point(184, 248);
            this.btnDecompress.Name = "btnDecompress";
            this.btnDecompress.Size = new System.Drawing.Size(75, 23);
            this.btnDecompress.TabIndex = 9;
            this.btnDecompress.Text = "Decompress";
            this.btnDecompress.UseVisualStyleBackColor = true;
            this.btnDecompress.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(291, 248);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 347);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecompress);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblUpload);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtSimple);
            this.Name = "Form1";
            this.Text = "Welcome to File Compressor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSimple;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnDecompress;
        private System.Windows.Forms.Button btnEncrypt;
    }
}

