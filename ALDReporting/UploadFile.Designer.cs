namespace ALDReporting
{
    partial class UploadFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadFile));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPageHeader = new System.Windows.Forms.Label();
            this.lstFileUpload = new System.Windows.Forms.ListBox();
            this.lbl1FileUpload = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.lbl2FileUpload = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close-button-normal.png");
            this.imageList1.Images.SetKeyName(1, "close-button-over.png");
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ImageIndex = 0;
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(438, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // lblPageHeader
            // 
            this.lblPageHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageHeader.AutoSize = true;
            this.lblPageHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageHeader.ForeColor = System.Drawing.Color.Red;
            this.lblPageHeader.Location = new System.Drawing.Point(168, 12);
            this.lblPageHeader.Name = "lblPageHeader";
            this.lblPageHeader.Size = new System.Drawing.Size(184, 22);
            this.lblPageHeader.TabIndex = 3;
            this.lblPageHeader.Text = "Upload Before Image";
            // 
            // lstFileUpload
            // 
            this.lstFileUpload.AllowDrop = true;
            this.lstFileUpload.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFileUpload.FormattingEnabled = true;
            this.lstFileUpload.ItemHeight = 15;
            this.lstFileUpload.Location = new System.Drawing.Point(12, 40);
            this.lstFileUpload.Name = "lstFileUpload";
            this.lstFileUpload.Size = new System.Drawing.Size(458, 109);
            this.lstFileUpload.TabIndex = 4;
            this.lstFileUpload.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstFileUpload_DragDrop);
            this.lstFileUpload.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstFileUpload_DragEnter);
            // 
            // lbl1FileUpload
            // 
            this.lbl1FileUpload.AutoSize = true;
            this.lbl1FileUpload.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1FileUpload.Location = new System.Drawing.Point(150, 66);
            this.lbl1FileUpload.Name = "lbl1FileUpload";
            this.lbl1FileUpload.Size = new System.Drawing.Size(202, 20);
            this.lbl1FileUpload.TabIndex = 5;
            this.lbl1FileUpload.Text = "Drag and drop file here";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(327, 170);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(143, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.BackColor = System.Drawing.Color.Navy;
            this.btnBrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFile.ForeColor = System.Drawing.Color.White;
            this.btnBrowseFile.Location = new System.Drawing.Point(154, 105);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(198, 23);
            this.btnBrowseFile.TabIndex = 7;
            this.btnBrowseFile.Text = "BROWSE FILE";
            this.btnBrowseFile.UseVisualStyleBackColor = false;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // lbl2FileUpload
            // 
            this.lbl2FileUpload.AutoSize = true;
            this.lbl2FileUpload.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2FileUpload.Location = new System.Drawing.Point(236, 86);
            this.lbl2FileUpload.Name = "lbl2FileUpload";
            this.lbl2FileUpload.Size = new System.Drawing.Size(22, 16);
            this.lbl2FileUpload.TabIndex = 8;
            this.lbl2FileUpload.Text = "Or";
            // 
            // UploadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 208);
            this.Controls.Add(this.lbl2FileUpload);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lbl1FileUpload);
            this.Controls.Add(this.lstFileUpload);
            this.Controls.Add(this.lblPageHeader);
            this.Controls.Add(this.btnClose);
            this.Name = "UploadFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UploadFile";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPageHeader;
        private System.Windows.Forms.ListBox lstFileUpload;
        private System.Windows.Forms.Label lbl1FileUpload;
        private System.Windows.Forms.Button btnUpload;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Label lbl2FileUpload;
    }
}