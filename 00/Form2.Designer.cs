namespace WindowsFormsApplication1
{
    partial class frmStatisticsForm
    {
        frmMainWindow objectOfMain;
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
            this.btnFocusToMainWindow = new System.Windows.Forms.Button();
            this.btnShowSelectedEntryInResultBox = new System.Windows.Forms.Button();
            this.btnClearSelectedEntry = new System.Windows.Forms.Button();
            this.btnClearAllEntry = new System.Windows.Forms.Button();
            this.lblStataticsEntryCount = new System.Windows.Forms.Label();
            this.lbxStatisticsEntries = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFocusToMainWindow
            // 
            this.btnFocusToMainWindow.Location = new System.Drawing.Point(17, 108);
            this.btnFocusToMainWindow.Name = "btnFocusToMainWindow";
            this.btnFocusToMainWindow.Size = new System.Drawing.Size(47, 26);
            this.btnFocusToMainWindow.TabIndex = 1;
            this.btnFocusToMainWindow.Text = "RET";
            this.btnFocusToMainWindow.UseVisualStyleBackColor = true;
            this.btnFocusToMainWindow.Click += new System.EventHandler(this.FocusToMainWindowForm);
            // 
            // btnShowSelectedEntryInResultBox
            // 
            this.btnShowSelectedEntryInResultBox.Location = new System.Drawing.Point(70, 108);
            this.btnShowSelectedEntryInResultBox.Name = "btnShowSelectedEntryInResultBox";
            this.btnShowSelectedEntryInResultBox.Size = new System.Drawing.Size(47, 26);
            this.btnShowSelectedEntryInResultBox.TabIndex = 1;
            this.btnShowSelectedEntryInResultBox.Text = "LOAD";
            this.btnShowSelectedEntryInResultBox.UseVisualStyleBackColor = true;
            this.btnShowSelectedEntryInResultBox.Click += new System.EventHandler(this.CopySelectedEntryToMainWindowTextBox);
            // 
            // btnClearSelectedEntry
            // 
            this.btnClearSelectedEntry.Location = new System.Drawing.Point(123, 108);
            this.btnClearSelectedEntry.Name = "btnClearSelectedEntry";
            this.btnClearSelectedEntry.Size = new System.Drawing.Size(47, 26);
            this.btnClearSelectedEntry.TabIndex = 1;
            this.btnClearSelectedEntry.Text = "CD";
            this.btnClearSelectedEntry.UseVisualStyleBackColor = true;
            this.btnClearSelectedEntry.Click += new System.EventHandler(this.DeleteSelectedEntry);
            // 
            // btnClearAllEntry
            // 
            this.btnClearAllEntry.Location = new System.Drawing.Point(176, 108);
            this.btnClearAllEntry.Name = "btnClearAllEntry";
            this.btnClearAllEntry.Size = new System.Drawing.Size(47, 26);
            this.btnClearAllEntry.TabIndex = 1;
            this.btnClearAllEntry.Text = "CAD";
            this.btnClearAllEntry.UseVisualStyleBackColor = true;
            this.btnClearAllEntry.Click += new System.EventHandler(this.ClearAllStatisticEntries);
            // 
            // lblStataticsEntryCount
            // 
            this.lblStataticsEntryCount.AutoSize = true;
            this.lblStataticsEntryCount.Location = new System.Drawing.Point(105, 141);
            this.lblStataticsEntryCount.Name = "lblStataticsEntryCount";
            this.lblStataticsEntryCount.Size = new System.Drawing.Size(25, 13);
            this.lblStataticsEntryCount.TabIndex = 2;
            this.lblStataticsEntryCount.Text = "n=0";
            // 
            // lbxStatisticsEntries
            // 
            this.lbxStatisticsEntries.FormattingEnabled = true;
            this.lbxStatisticsEntries.Location = new System.Drawing.Point(17, 12);
            this.lbxStatisticsEntries.Name = "lbxStatisticsEntries";
            this.lbxStatisticsEntries.Size = new System.Drawing.Size(206, 82);
            this.lbxStatisticsEntries.TabIndex = 3;
            // 
            // frmStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 163);
            this.Controls.Add(this.lbxStatisticsEntries);
            this.Controls.Add(this.lblStataticsEntryCount);
            this.Controls.Add(this.btnClearAllEntry);
            this.Controls.Add(this.btnClearSelectedEntry);
            this.Controls.Add(this.btnShowSelectedEntryInResultBox);
            this.Controls.Add(this.btnFocusToMainWindow);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStatisticsForm";
            this.ShowIcon = false;
            this.Text = "Statistics Box";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisableStatisticsButtons);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFocusToMainWindow;
        private System.Windows.Forms.Button btnShowSelectedEntryInResultBox;
        private System.Windows.Forms.Button btnClearSelectedEntry;
        private System.Windows.Forms.Button btnClearAllEntry;
        public System.Windows.Forms.Label lblStataticsEntryCount;
        public System.Windows.Forms.ListBox lbxStatisticsEntries;
    }
}