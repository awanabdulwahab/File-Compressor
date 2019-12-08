namespace AOA_Project
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
            this.FileDialogue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Broswer = new System.Windows.Forms.Button();
            this.btn_Compress = new System.Windows.Forms.Button();
            this.btn_Decompress = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileDialogue
            // 
            this.FileDialogue.Location = new System.Drawing.Point(204, 120);
            this.FileDialogue.Multiline = true;
            this.FileDialogue.Name = "FileDialogue";
            this.FileDialogue.Size = new System.Drawing.Size(374, 30);
            this.FileDialogue.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select a File";
            // 
            // btn_Broswer
            // 
            this.btn_Broswer.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.btn_Broswer.Location = new System.Drawing.Point(619, 117);
            this.btn_Broswer.Name = "btn_Broswer";
            this.btn_Broswer.Size = new System.Drawing.Size(96, 33);
            this.btn_Broswer.TabIndex = 6;
            this.btn_Broswer.Text = "Broswer";
            this.btn_Broswer.UseVisualStyleBackColor = true;
            this.btn_Broswer.Click += new System.EventHandler(this.btn_Broswer_Click);
            // 
            // btn_Compress
            // 
            this.btn_Compress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Compress.Location = new System.Drawing.Point(204, 184);
            this.btn_Compress.Name = "btn_Compress";
            this.btn_Compress.Size = new System.Drawing.Size(95, 32);
            this.btn_Compress.TabIndex = 10;
            this.btn_Compress.Text = "Compress";
            this.btn_Compress.UseVisualStyleBackColor = true;
            this.btn_Compress.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Decompress
            // 
            this.btn_Decompress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Decompress.Location = new System.Drawing.Point(471, 184);
            this.btn_Decompress.Name = "btn_Decompress";
            this.btn_Decompress.Size = new System.Drawing.Size(107, 32);
            this.btn_Decompress.TabIndex = 11;
            this.btn_Decompress.Text = "Decompress";
            this.btn_Decompress.UseVisualStyleBackColor = true;
            this.btn_Decompress.Click += new System.EventHandler(this.btn_Decompress_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(310, 24);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(158, 42);
            this.Welcome.TabIndex = 13;
            this.Welcome.Text = "Welcome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.btn_Decompress);
            this.Controls.Add(this.btn_Compress);
            this.Controls.Add(this.FileDialogue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Broswer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileDialogue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Broswer;
        private System.Windows.Forms.Button btn_Compress;
        private System.Windows.Forms.Button btn_Decompress;
        private System.Windows.Forms.Label Welcome;
    }
}

