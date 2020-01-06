namespace QRcode
{
    partial class QR
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
            this.txt = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picQRcode = new System.Windows.Forms.PictureBox();
            this.logoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).BeginInit();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(24, 421);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(84, 13);
            this.txt.TabIndex = 1;
            this.txt.Text = "Create QR code";
            this.txt.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(114, 418);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(261, 20);
            this.txtInput.TabIndex = 2;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(399, 417);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(42, 23);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(".VnRevueH", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(173, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "QR CODE";
            this.toolTip1.SetToolTip(this.label1, "https://github.com/codebude/QRCoder/");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // picQRcode
            // 
            this.picQRcode.BackColor = System.Drawing.Color.White;
            this.picQRcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQRcode.ImageLocation = "";
            this.picQRcode.Location = new System.Drawing.Point(91, 89);
            this.picQRcode.Name = "picQRcode";
            this.picQRcode.Size = new System.Drawing.Size(300, 300);
            this.picQRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRcode.TabIndex = 0;
            this.picQRcode.TabStop = false;
            // 
            // logoToolStripMenuItem
            // 
            this.logoToolStripMenuItem.Name = "logoToolStripMenuItem";
            this.logoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoToolStripMenuItem.Text = "Logo";
            this.logoToolStripMenuItem.Click += new System.EventHandler(this.logoToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.picQRcode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "QR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Generation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picQRcode;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

