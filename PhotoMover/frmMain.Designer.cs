namespace PhotoMover
{
    partial class frmMain
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
            this.fbSourceFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.fbDestinationBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSourceFolder = new System.Windows.Forms.Label();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.btnBrowseDestination = new System.Windows.Forms.Button();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.lblDestinationFolder = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.gvResults = new System.Windows.Forms.DataGridView();
            this.btnMoveFiles = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTouch = new System.Windows.Forms.CheckBox();
            this.txtDateFormat = new System.Windows.Forms.TextBox();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.resultLabel = new System.Windows.Forms.Label();
            this.chk_DontMove = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSourceFolder
            // 
            this.lblSourceFolder.AutoSize = true;
            this.lblSourceFolder.Location = new System.Drawing.Point(11, 9);
            this.lblSourceFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSourceFolder.Name = "lblSourceFolder";
            this.lblSourceFolder.Size = new System.Drawing.Size(73, 13);
            this.lblSourceFolder.TabIndex = 0;
            this.lblSourceFolder.Text = "Source Folder";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(11, 24);
            this.txtSourceFolder.Margin = new System.Windows.Forms.Padding(2);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(274, 20);
            this.txtSourceFolder.TabIndex = 1;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(289, 24);
            this.btnBrowseSource.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(51, 20);
            this.btnBrowseSource.TabIndex = 2;
            this.btnBrowseSource.Text = "Select";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Location = new System.Drawing.Point(289, 78);
            this.btnBrowseDestination.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Size = new System.Drawing.Size(51, 20);
            this.btnBrowseDestination.TabIndex = 5;
            this.btnBrowseDestination.Text = "Select";
            this.btnBrowseDestination.UseVisualStyleBackColor = true;
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Location = new System.Drawing.Point(11, 78);
            this.txtDestinationFolder.Margin = new System.Windows.Forms.Padding(2);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(274, 20);
            this.txtDestinationFolder.TabIndex = 4;
            // 
            // lblDestinationFolder
            // 
            this.lblDestinationFolder.AutoSize = true;
            this.lblDestinationFolder.Location = new System.Drawing.Point(11, 63);
            this.lblDestinationFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinationFolder.Name = "lblDestinationFolder";
            this.lblDestinationFolder.Size = new System.Drawing.Size(92, 13);
            this.lblDestinationFolder.TabIndex = 3;
            this.lblDestinationFolder.Text = "Destination Folder";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(11, 108);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // gvResults
            // 
            this.gvResults.AllowUserToAddRows = false;
            this.gvResults.AllowUserToDeleteRows = false;
            this.gvResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResults.Location = new System.Drawing.Point(11, 172);
            this.gvResults.Name = "gvResults";
            this.gvResults.ReadOnly = true;
            this.gvResults.Size = new System.Drawing.Size(784, 281);
            this.gvResults.TabIndex = 7;
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.Enabled = false;
            this.btnMoveFiles.Location = new System.Drawing.Point(92, 108);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(75, 23);
            this.btnMoveFiles.TabIndex = 8;
            this.btnMoveFiles.Text = "Move";
            this.btnMoveFiles.UseVisualStyleBackColor = true;
            this.btnMoveFiles.Click += new System.EventHandler(this.btnMoveFiles_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_DontMove);
            this.groupBox1.Controls.Add(this.chkTouch);
            this.groupBox1.Controls.Add(this.txtDateFormat);
            this.groupBox1.Controls.Add(this.lblDateFormat);
            this.groupBox1.Controls.Add(this.rbCopy);
            this.groupBox1.Controls.Add(this.rbMove);
            this.groupBox1.Location = new System.Drawing.Point(491, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 128);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chkTouch
            // 
            this.chkTouch.AutoSize = true;
            this.chkTouch.Location = new System.Drawing.Point(150, 21);
            this.chkTouch.Name = "chkTouch";
            this.chkTouch.Size = new System.Drawing.Size(139, 17);
            this.chkTouch.TabIndex = 4;
            this.chkTouch.Text = "Touch with Date Taken";
            this.chkTouch.UseVisualStyleBackColor = true;
            // 
            // txtDateFormat
            // 
            this.txtDateFormat.Location = new System.Drawing.Point(7, 96);
            this.txtDateFormat.Name = "txtDateFormat";
            this.txtDateFormat.Size = new System.Drawing.Size(100, 20);
            this.txtDateFormat.TabIndex = 3;
            this.txtDateFormat.Text = "yyyy-MM-dd";
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Location = new System.Drawing.Point(7, 79);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(65, 13);
            this.lblDateFormat.TabIndex = 2;
            this.lblDateFormat.Text = "Date Format";
            // 
            // rbCopy
            // 
            this.rbCopy.AutoSize = true;
            this.rbCopy.Location = new System.Drawing.Point(7, 44);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(73, 17);
            this.rbCopy.TabIndex = 1;
            this.rbCopy.Text = "Copy Files";
            this.rbCopy.UseVisualStyleBackColor = true;
            this.rbCopy.CheckedChanged += new System.EventHandler(this.rbCopy_CheckedChanged);
            // 
            // rbMove
            // 
            this.rbMove.AutoSize = true;
            this.rbMove.Checked = true;
            this.rbMove.Location = new System.Drawing.Point(7, 20);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(76, 17);
            this.rbMove.TabIndex = 0;
            this.rbMove.TabStop = true;
            this.rbMove.Text = "Move Files";
            this.rbMove.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(11, 145);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(47, 13);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "progress";
            // 
            // chk_DontMove
            // 
            this.chk_DontMove.AutoSize = true;
            this.chk_DontMove.Location = new System.Drawing.Point(150, 44);
            this.chk_DontMove.Name = "chk_DontMove";
            this.chk_DontMove.Size = new System.Drawing.Size(145, 17);
            this.chk_DontMove.TabIndex = 5;
            this.chk_DontMove.Text = "Touch Only (Don\'t Move)";
            this.chk_DontMove.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 465);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMoveFiles);
            this.Controls.Add(this.gvResults);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnBrowseDestination);
            this.Controls.Add(this.txtDestinationFolder);
            this.Controls.Add(this.lblDestinationFolder);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.lblSourceFolder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "PhotoMover - Move Photos Into Date Folders from DateTaken";
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbSourceFolder;
        private System.Windows.Forms.FolderBrowserDialog fbDestinationBrowser;
        private System.Windows.Forms.Label lblSourceFolder;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.Button btnBrowseDestination;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Label lblDestinationFolder;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.DataGridView gvResults;
        private System.Windows.Forms.Button btnMoveFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDateFormat;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.RadioButton rbCopy;
        private System.Windows.Forms.RadioButton rbMove;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.CheckBox chkTouch;
        private System.Windows.Forms.CheckBox chk_DontMove;
    }
}

