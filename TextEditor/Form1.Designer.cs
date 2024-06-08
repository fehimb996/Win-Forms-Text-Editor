namespace TextEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RT = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontBoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontItalicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikethroughToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontFamilyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFindAndReplace = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.DFont = new System.Windows.Forms.FontDialog();
            this.DColor = new System.Windows.Forms.ColorDialog();
            this.wordCountStatusLabel = new System.Windows.Forms.Label();
            this.characterCountStatusLabel = new System.Windows.Forms.Label();
            this.lineCountLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RT
            // 
            this.RT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RT.ContextMenuStrip = this.contextMenuStrip1;
            this.RT.Location = new System.Drawing.Point(12, 63);
            this.RT.Name = "RT";
            this.RT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RT.Size = new System.Drawing.Size(776, 375);
            this.RT.TabIndex = 0;
            this.RT.Text = "";
            this.RT.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.RT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontBoldToolStripMenuItem,
            this.fontItalicToolStripMenuItem,
            this.fontColorToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.strikethroughToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.toolStripSeparator1,
            this.fontFamilyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 178);
            // 
            // fontBoldToolStripMenuItem
            // 
            this.fontBoldToolStripMenuItem.Name = "fontBoldToolStripMenuItem";
            this.fontBoldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.fontBoldToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.fontBoldToolStripMenuItem.Text = "Font &bold";
            this.fontBoldToolStripMenuItem.Click += new System.EventHandler(this.fontBoldToolStripMenuItem_Click_1);
            // 
            // fontItalicToolStripMenuItem
            // 
            this.fontItalicToolStripMenuItem.Name = "fontItalicToolStripMenuItem";
            this.fontItalicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.fontItalicToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.fontItalicToolStripMenuItem.Text = "Font &italic";
            this.fontItalicToolStripMenuItem.Click += new System.EventHandler(this.fontItalicToolStripMenuItem_Click_1);
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.fontColorToolStripMenuItem.Text = "Font c&olor";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click_1);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.underlineToolStripMenuItem.Text = "&Underline";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // strikethroughToolStripMenuItem
            // 
            this.strikethroughToolStripMenuItem.Name = "strikethroughToolStripMenuItem";
            this.strikethroughToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.strikethroughToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.strikethroughToolStripMenuItem.Text = "S&trikethrough";
            this.strikethroughToolStripMenuItem.Click += new System.EventHandler(this.strikethroughToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // fontFamilyToolStripMenuItem
            // 
            this.fontFamilyToolStripMenuItem.Name = "fontFamilyToolStripMenuItem";
            this.fontFamilyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fontFamilyToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.fontFamilyToolStripMenuItem.Text = "Select &Font";
            this.fontFamilyToolStripMenuItem.Click += new System.EventHandler(this.fontFamilyToolStripMenuItem_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(12, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(109, 52);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "&Otvori fajl";
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(681, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 52);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Zatvori program";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(481, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Snimi fajl";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSave_KeyPress);
            // 
            // btnFindAndReplace
            // 
            this.btnFindAndReplace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFindAndReplace.Image = ((System.Drawing.Image)(resources.GetObject("btnFindAndReplace.Image")));
            this.btnFindAndReplace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindAndReplace.Location = new System.Drawing.Point(362, 5);
            this.btnFindAndReplace.Name = "btnFindAndReplace";
            this.btnFindAndReplace.Size = new System.Drawing.Size(113, 52);
            this.btnFindAndReplace.TabIndex = 4;
            this.btnFindAndReplace.Text = "&Pronađi i zameni";
            this.btnFindAndReplace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindAndReplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindAndReplace.UseVisualStyleBackColor = true;
            this.btnFindAndReplace.Click += new System.EventHandler(this.btnFindAndReplace_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFind.Location = new System.Drawing.Point(256, 5);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 22);
            this.txtFind.TabIndex = 5;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // txtReplace
            // 
            this.txtReplace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReplace.Location = new System.Drawing.Point(256, 33);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(100, 22);
            this.txtReplace.TabIndex = 6;
            this.txtReplace.TextChanged += new System.EventHandler(this.txtReplace_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pronađi:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zameni sa:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // DFont
            // 
            this.DFont.Apply += new System.EventHandler(this.DFont_Apply);
            // 
            // wordCountStatusLabel
            // 
            this.wordCountStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wordCountStatusLabel.AutoSize = true;
            this.wordCountStatusLabel.Location = new System.Drawing.Point(647, 441);
            this.wordCountStatusLabel.Name = "wordCountStatusLabel";
            this.wordCountStatusLabel.Size = new System.Drawing.Size(59, 16);
            this.wordCountStatusLabel.TabIndex = 9;
            this.wordCountStatusLabel.Text = "Broj reči:";
            // 
            // characterCountStatusLabel
            // 
            this.characterCountStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.characterCountStatusLabel.AutoSize = true;
            this.characterCountStatusLabel.Location = new System.Drawing.Point(478, 441);
            this.characterCountStatusLabel.Name = "characterCountStatusLabel";
            this.characterCountStatusLabel.Size = new System.Drawing.Size(94, 16);
            this.characterCountStatusLabel.TabIndex = 10;
            this.characterCountStatusLabel.Text = "Broj karaktera:";
            // 
            // lineCountLabel
            // 
            this.lineCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lineCountLabel.AutoSize = true;
            this.lineCountLabel.Location = new System.Drawing.Point(359, 441);
            this.lineCountLabel.Name = "lineCountLabel";
            this.lineCountLabel.Size = new System.Drawing.Size(41, 16);
            this.lineCountLabel.TabIndex = 11;
            this.lineCountLabel.Text = "Linija:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lineCountLabel);
            this.Controls.Add(this.characterCountStatusLabel);
            this.Controls.Add(this.wordCountStatusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnFindAndReplace);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.RT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feim Bajrami IT 53/2021";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RT;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFindAndReplace;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.FontDialog DFont;
        private System.Windows.Forms.ColorDialog DColor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontBoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontItalicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontFamilyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikethroughToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label wordCountStatusLabel;
        private System.Windows.Forms.Label characterCountStatusLabel;
        private System.Windows.Forms.Label lineCountLabel;
    }
}

