namespace CSVCard
{
    partial class FieldSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._fourthField = new System.Windows.Forms.ComboBox();
            this._thirdField = new System.Windows.Forms.ComboBox();
            this._secondField = new System.Windows.Forms.ComboBox();
            this._promptLabel = new System.Windows.Forms.Label();
            this._fieldOneLabel = new System.Windows.Forms.Label();
            this._fieldTwoLabel = new System.Windows.Forms.Label();
            this._fieldThreeLabel = new System.Windows.Forms.Label();
            this._fieldFourLabel = new System.Windows.Forms.Label();
            this._headerCheckBox = new System.Windows.Forms.CheckBox();
            this._firstField = new System.Windows.Forms.ComboBox();
            this._tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 2;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel.Controls.Add(this._fourthField, 1, 4);
            this._tableLayoutPanel.Controls.Add(this._thirdField, 1, 3);
            this._tableLayoutPanel.Controls.Add(this._secondField, 1, 2);
            this._tableLayoutPanel.Controls.Add(this._promptLabel, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._fieldOneLabel, 0, 1);
            this._tableLayoutPanel.Controls.Add(this._fieldTwoLabel, 0, 2);
            this._tableLayoutPanel.Controls.Add(this._fieldThreeLabel, 0, 3);
            this._tableLayoutPanel.Controls.Add(this._fieldFourLabel, 0, 4);
            this._tableLayoutPanel.Controls.Add(this._headerCheckBox, 0, 5);
            this._tableLayoutPanel.Controls.Add(this._firstField, 1, 1);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 6;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(346, 146);
            this._tableLayoutPanel.TabIndex = 0;
            // 
            // _fourthField
            // 
            this._fourthField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fourthField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._fourthField.FormattingEnabled = true;
            this._fourthField.Location = new System.Drawing.Point(60, 99);
            this._fourthField.Name = "_fourthField";
            this._fourthField.Size = new System.Drawing.Size(283, 21);
            this._fourthField.TabIndex = 9;
            // 
            // _thirdField
            // 
            this._thirdField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._thirdField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._thirdField.FormattingEnabled = true;
            this._thirdField.Location = new System.Drawing.Point(60, 75);
            this._thirdField.Name = "_thirdField";
            this._thirdField.Size = new System.Drawing.Size(283, 21);
            this._thirdField.TabIndex = 8;
            // 
            // _secondField
            // 
            this._secondField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._secondField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._secondField.FormattingEnabled = true;
            this._secondField.Location = new System.Drawing.Point(60, 51);
            this._secondField.Name = "_secondField";
            this._secondField.Size = new System.Drawing.Size(283, 21);
            this._secondField.TabIndex = 7;
            // 
            // _promptLabel
            // 
            this._promptLabel.AutoSize = true;
            this._tableLayoutPanel.SetColumnSpan(this._promptLabel, 2);
            this._promptLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._promptLabel.Location = new System.Drawing.Point(3, 0);
            this._promptLabel.Name = "_promptLabel";
            this._promptLabel.Size = new System.Drawing.Size(340, 24);
            this._promptLabel.TabIndex = 0;
            this._promptLabel.Text = "Please select the order your CSV information is in before loading it:";
            this._promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _fieldOneLabel
            // 
            this._fieldOneLabel.AutoSize = true;
            this._fieldOneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fieldOneLabel.Location = new System.Drawing.Point(3, 24);
            this._fieldOneLabel.Name = "_fieldOneLabel";
            this._fieldOneLabel.Size = new System.Drawing.Size(51, 24);
            this._fieldOneLabel.TabIndex = 1;
            this._fieldOneLabel.Text = "Field #1: ";
            this._fieldOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _fieldTwoLabel
            // 
            this._fieldTwoLabel.AutoSize = true;
            this._fieldTwoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fieldTwoLabel.Location = new System.Drawing.Point(3, 48);
            this._fieldTwoLabel.Name = "_fieldTwoLabel";
            this._fieldTwoLabel.Size = new System.Drawing.Size(51, 24);
            this._fieldTwoLabel.TabIndex = 2;
            this._fieldTwoLabel.Text = "Field #2: ";
            this._fieldTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _fieldThreeLabel
            // 
            this._fieldThreeLabel.AutoSize = true;
            this._fieldThreeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fieldThreeLabel.Location = new System.Drawing.Point(3, 72);
            this._fieldThreeLabel.Name = "_fieldThreeLabel";
            this._fieldThreeLabel.Size = new System.Drawing.Size(51, 24);
            this._fieldThreeLabel.TabIndex = 3;
            this._fieldThreeLabel.Text = "Field #3: ";
            this._fieldThreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _fieldFourLabel
            // 
            this._fieldFourLabel.AutoSize = true;
            this._fieldFourLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fieldFourLabel.Location = new System.Drawing.Point(3, 96);
            this._fieldFourLabel.Name = "_fieldFourLabel";
            this._fieldFourLabel.Size = new System.Drawing.Size(51, 24);
            this._fieldFourLabel.TabIndex = 4;
            this._fieldFourLabel.Text = "Field #4: ";
            this._fieldFourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _headerCheckBox
            // 
            this._headerCheckBox.AutoSize = true;
            this._tableLayoutPanel.SetColumnSpan(this._headerCheckBox, 2);
            this._headerCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._headerCheckBox.Location = new System.Drawing.Point(3, 123);
            this._headerCheckBox.Name = "_headerCheckBox";
            this._headerCheckBox.Size = new System.Drawing.Size(340, 20);
            this._headerCheckBox.TabIndex = 5;
            this._headerCheckBox.Text = "CSV file contains a row of header information";
            this._headerCheckBox.UseVisualStyleBackColor = true;
            // 
            // _firstField
            // 
            this._firstField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._firstField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._firstField.FormattingEnabled = true;
            this._firstField.Location = new System.Drawing.Point(60, 27);
            this._firstField.Name = "_firstField";
            this._firstField.Size = new System.Drawing.Size(283, 21);
            this._firstField.TabIndex = 6;
            // 
            // FieldSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this._tableLayoutPanel);
            this.Name = "FieldSelector";
            this.Size = new System.Drawing.Size(346, 146);
            this.Load += new System.EventHandler(this.OnLoad);
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Label _promptLabel;
        private System.Windows.Forms.Label _fieldOneLabel;
        private System.Windows.Forms.Label _fieldTwoLabel;
        private System.Windows.Forms.Label _fieldThreeLabel;
        private System.Windows.Forms.Label _fieldFourLabel;
        private System.Windows.Forms.CheckBox _headerCheckBox;
        private System.Windows.Forms.ComboBox _fourthField;
        private System.Windows.Forms.ComboBox _thirdField;
        private System.Windows.Forms.ComboBox _secondField;
        private System.Windows.Forms.ComboBox _firstField;
    }
}
