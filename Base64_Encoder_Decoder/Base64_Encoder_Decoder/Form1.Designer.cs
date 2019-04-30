namespace Base64_Encoder_Decoder
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDecoded = new System.Windows.Forms.TextBox();
            this.lblDecoded = new System.Windows.Forms.Label();
            this.txtEncoded = new System.Windows.Forms.TextBox();
            this.lblEncoded = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.lblPlaintext = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(472, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 38);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtDecoded
            // 
            this.txtDecoded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDecoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecoded.Location = new System.Drawing.Point(280, 264);
            this.txtDecoded.Multiline = true;
            this.txtDecoded.Name = "txtDecoded";
            this.txtDecoded.Size = new System.Drawing.Size(288, 92);
            this.txtDecoded.TabIndex = 16;
            // 
            // lblDecoded
            // 
            this.lblDecoded.AutoSize = true;
            this.lblDecoded.BackColor = System.Drawing.Color.Transparent;
            this.lblDecoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecoded.ForeColor = System.Drawing.Color.White;
            this.lblDecoded.Location = new System.Drawing.Point(122, 296);
            this.lblDecoded.Name = "lblDecoded";
            this.lblDecoded.Size = new System.Drawing.Size(152, 20);
            this.lblDecoded.TabIndex = 15;
            this.lblDecoded.Text = "Base64 Decoded:";
            // 
            // txtEncoded
            // 
            this.txtEncoded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEncoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncoded.Location = new System.Drawing.Point(280, 149);
            this.txtEncoded.Multiline = true;
            this.txtEncoded.Name = "txtEncoded";
            this.txtEncoded.Size = new System.Drawing.Size(288, 92);
            this.txtEncoded.TabIndex = 14;
            // 
            // lblEncoded
            // 
            this.lblEncoded.AutoSize = true;
            this.lblEncoded.BackColor = System.Drawing.Color.Transparent;
            this.lblEncoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncoded.ForeColor = System.Drawing.Color.White;
            this.lblEncoded.Location = new System.Drawing.Point(123, 184);
            this.lblEncoded.Name = "lblEncoded";
            this.lblEncoded.Size = new System.Drawing.Size(151, 20);
            this.lblEncoded.TabIndex = 13;
            this.lblEncoded.Text = "Base64 Encoded:";
            // 
            // btnDecode
            // 
            this.btnDecode.BackColor = System.Drawing.Color.Green;
            this.btnDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.Location = new System.Drawing.Point(574, 235);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(104, 35);
            this.btnDecode.TabIndex = 12;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = false;
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaintext.Location = new System.Drawing.Point(280, 32);
            this.txtPlaintext.Multiline = true;
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(288, 92);
            this.txtPlaintext.TabIndex = 11;
            // 
            // lblPlaintext
            // 
            this.lblPlaintext.AutoSize = true;
            this.lblPlaintext.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaintext.ForeColor = System.Drawing.Color.White;
            this.lblPlaintext.Location = new System.Drawing.Point(123, 68);
            this.lblPlaintext.Name = "lblPlaintext";
            this.lblPlaintext.Size = new System.Drawing.Size(83, 20);
            this.lblPlaintext.TabIndex = 10;
            this.lblPlaintext.Text = "Plaintext:";
            // 
            // btnEncode
            // 
            this.btnEncode.BackColor = System.Drawing.Color.Teal;
            this.btnEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncode.Location = new System.Drawing.Point(574, 120);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(104, 35);
            this.btnEncode.TabIndex = 9;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDecoded);
            this.Controls.Add(this.lblDecoded);
            this.Controls.Add(this.txtEncoded);
            this.Controls.Add(this.lblEncoded);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.txtPlaintext);
            this.Controls.Add(this.lblPlaintext);
            this.Controls.Add(this.btnEncode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base64 Encoder & Decoder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDecoded;
        private System.Windows.Forms.Label lblDecoded;
        private System.Windows.Forms.TextBox txtEncoded;
        private System.Windows.Forms.Label lblEncoded;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.Label lblPlaintext;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

