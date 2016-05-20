namespace CSVCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._loadCSVtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exportVCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutToolStripMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._loadCSVButton = new System.Windows.Forms.Button();
            this._exportVCardButton = new System.Windows.Forms.Button();
            this._mergeCheckBox = new System.Windows.Forms.CheckBox();
            this._tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._loadedLabel = new System.Windows.Forms.Label();
            this._fieldSelector = new CSVCard.FieldSelector();
            this._mainMenuStrip.SuspendLayout();
            this._tableLayoutPanel1.SuspendLayout();
            this._tableLayoutPanel2.SuspendLayout();
            this._tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainMenuStrip
            // 
            this._mainMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem,
            this._helpToolStripMenuItem});
            this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._mainMenuStrip.Name = "_mainMenuStrip";
            this._mainMenuStrip.Size = new System.Drawing.Size(353, 24);
            this._mainMenuStrip.TabIndex = 0;
            this._mainMenuStrip.Text = "menuStrip1";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._loadCSVtoolStripMenuItem,
            this._exportVCardToolStripMenuItem,
            this.toolStripSeparator,
            this._exitToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this._fileToolStripMenuItem.Text = "&File";
            this._fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.OnFileDropDownOpening);
            // 
            // _loadCSVtoolStripMenuItem
            // 
            this._loadCSVtoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_loadCSVtoolStripMenuItem.Image")));
            this._loadCSVtoolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._loadCSVtoolStripMenuItem.Name = "_loadCSVtoolStripMenuItem";
            this._loadCSVtoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this._loadCSVtoolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this._loadCSVtoolStripMenuItem.Text = "L&oad CSV";
            this._loadCSVtoolStripMenuItem.Click += new System.EventHandler(this.OnLoadCSVClick);
            // 
            // _exportVCardToolStripMenuItem
            // 
            this._exportVCardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_exportVCardToolStripMenuItem.Image")));
            this._exportVCardToolStripMenuItem.Name = "_exportVCardToolStripMenuItem";
            this._exportVCardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this._exportVCardToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this._exportVCardToolStripMenuItem.Text = "&Export VCard";
            this._exportVCardToolStripMenuItem.Click += new System.EventHandler(this.OnExportVCardClick);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(179, 6);
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this._exitToolStripMenuItem.ShowShortcutKeys = false;
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this._exitToolStripMenuItem.Text = "E&xit";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitClick);
            // 
            // _helpToolStripMenuItem
            // 
            this._helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutToolStripMenuSubItem});
            this._helpToolStripMenuItem.Name = "_helpToolStripMenuItem";
            this._helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this._helpToolStripMenuItem.Text = "&Help";
            // 
            // _aboutToolStripMenuSubItem
            // 
            this._aboutToolStripMenuSubItem.Image = ((System.Drawing.Image)(resources.GetObject("_aboutToolStripMenuSubItem.Image")));
            this._aboutToolStripMenuSubItem.Name = "_aboutToolStripMenuSubItem";
            this._aboutToolStripMenuSubItem.Size = new System.Drawing.Size(152, 22);
            this._aboutToolStripMenuSubItem.Text = "&About...";
            this._aboutToolStripMenuSubItem.Click += new System.EventHandler(this.OnAboutClick);
            // 
            // _tableLayoutPanel1
            // 
            this._tableLayoutPanel1.ColumnCount = 1;
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel1.Controls.Add(this._fieldSelector, 0, 0);
            this._tableLayoutPanel1.Controls.Add(this._tableLayoutPanel2, 0, 1);
            this._tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this._tableLayoutPanel1.Name = "_tableLayoutPanel1";
            this._tableLayoutPanel1.RowCount = 2;
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel1.Size = new System.Drawing.Size(353, 226);
            this._tableLayoutPanel1.TabIndex = 1;
            // 
            // _tableLayoutPanel2
            // 
            this._tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this._tableLayoutPanel2.ColumnCount = 3;
            this._tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this._tableLayoutPanel2.Controls.Add(this._loadCSVButton, 0, 1);
            this._tableLayoutPanel2.Controls.Add(this._exportVCardButton, 1, 1);
            this._tableLayoutPanel2.Controls.Add(this._mergeCheckBox, 2, 1);
            this._tableLayoutPanel2.Controls.Add(this._tableLayoutPanel3, 0, 0);
            this._tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel2.Location = new System.Drawing.Point(3, 149);
            this._tableLayoutPanel2.Name = "_tableLayoutPanel2";
            this._tableLayoutPanel2.RowCount = 2;
            this._tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.18919F));
            this._tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.81081F));
            this._tableLayoutPanel2.Size = new System.Drawing.Size(347, 74);
            this._tableLayoutPanel2.TabIndex = 1;
            // 
            // _loadCSVButton
            // 
            this._loadCSVButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._loadCSVButton.Location = new System.Drawing.Point(3, 32);
            this._loadCSVButton.Name = "_loadCSVButton";
            this._loadCSVButton.Size = new System.Drawing.Size(99, 39);
            this._loadCSVButton.TabIndex = 0;
            this._loadCSVButton.Text = "Load CSV";
            this._loadCSVButton.UseVisualStyleBackColor = true;
            this._loadCSVButton.Click += new System.EventHandler(this.OnLoadCSVClick);
            // 
            // _exportVCardButton
            // 
            this._exportVCardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._exportVCardButton.Location = new System.Drawing.Point(108, 32);
            this._exportVCardButton.Name = "_exportVCardButton";
            this._exportVCardButton.Size = new System.Drawing.Size(99, 39);
            this._exportVCardButton.TabIndex = 1;
            this._exportVCardButton.Text = "Export VCard";
            this._exportVCardButton.UseVisualStyleBackColor = true;
            this._exportVCardButton.Click += new System.EventHandler(this.OnExportVCardClick);
            // 
            // _mergeCheckBox
            // 
            this._mergeCheckBox.AutoSize = true;
            this._mergeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mergeCheckBox.Location = new System.Drawing.Point(213, 32);
            this._mergeCheckBox.Name = "_mergeCheckBox";
            this._mergeCheckBox.Size = new System.Drawing.Size(131, 39);
            this._mergeCheckBox.TabIndex = 2;
            this._mergeCheckBox.Text = "Save merged VCard";
            this._mergeCheckBox.UseVisualStyleBackColor = true;
            // 
            // _tableLayoutPanel3
            // 
            this._tableLayoutPanel3.ColumnCount = 2;
            this._tableLayoutPanel2.SetColumnSpan(this._tableLayoutPanel3, 3);
            this._tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel3.Controls.Add(this._pictureBox, 0, 0);
            this._tableLayoutPanel3.Controls.Add(this._loadedLabel, 1, 0);
            this._tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this._tableLayoutPanel3.Name = "_tableLayoutPanel3";
            this._tableLayoutPanel3.RowCount = 1;
            this._tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel3.Size = new System.Drawing.Size(341, 23);
            this._tableLayoutPanel3.TabIndex = 3;
            // 
            // _pictureBox
            // 
            this._pictureBox.Location = new System.Drawing.Point(3, 3);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(16, 16);
            this._pictureBox.TabIndex = 0;
            this._pictureBox.TabStop = false;
            // 
            // _loadedLabel
            // 
            this._loadedLabel.AutoSize = true;
            this._loadedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._loadedLabel.Location = new System.Drawing.Point(25, 0);
            this._loadedLabel.Name = "_loadedLabel";
            this._loadedLabel.Size = new System.Drawing.Size(313, 23);
            this._loadedLabel.TabIndex = 1;
            this._loadedLabel.Text = "No CSV information loaded";
            this._loadedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _fieldSelector
            // 
            this._fieldSelector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._fieldSelector.Location = new System.Drawing.Point(3, 3);
            this._fieldSelector.Name = "_fieldSelector";
            this._fieldSelector.Size = new System.Drawing.Size(346, 140);
            this._fieldSelector.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 250);
            this.Controls.Add(this._tableLayoutPanel1);
            this.Controls.Add(this._mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSVCard";
            this.Load += new System.EventHandler(this.OnLoad);
            this._mainMenuStrip.ResumeLayout(false);
            this._mainMenuStrip.PerformLayout();
            this._tableLayoutPanel1.ResumeLayout(false);
            this._tableLayoutPanel2.ResumeLayout(false);
            this._tableLayoutPanel2.PerformLayout();
            this._tableLayoutPanel3.ResumeLayout(false);
            this._tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _loadCSVtoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutToolStripMenuSubItem;
        private System.Windows.Forms.ToolStripMenuItem _exportVCardToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
        private FieldSelector _fieldSelector;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel2;
        private System.Windows.Forms.Button _loadCSVButton;
        private System.Windows.Forms.Button _exportVCardButton;
        private System.Windows.Forms.CheckBox _mergeCheckBox;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel3;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.Label _loadedLabel;
    }
}