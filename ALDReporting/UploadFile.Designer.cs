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
            this.txtFileUpload = new System.Windows.Forms.TextBox();
            this.pnlFileUpload = new System.Windows.Forms.Panel();
            this.lblDragFile = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPageHeader = new System.Windows.Forms.Label();
            this.pnlFileUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileUpload
            // 
            this.txtFileUpload.AllowDrop = true;
            this.txtFileUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileUpload.Location = new System.Drawing.Point(65, 198);
            this.txtFileUpload.Multiline = true;
            this.txtFileUpload.Name = "txtFileUpload";
            this.txtFileUpload.Size = new System.Drawing.Size(414, 54);
            this.txtFileUpload.TabIndex = 0;
            this.txtFileUpload.DragOver += new System.Windows.Forms.DragEventHandler(this.txtFileUpload_DragOver);
            // 
            // pnlFileUpload
            // 
            this.pnlFileUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFileUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFileUpload.Controls.Add(this.lblDragFile);
            this.pnlFileUpload.Location = new System.Drawing.Point(65, 55);
            this.pnlFileUpload.Name = "pnlFileUpload";
            this.pnlFileUpload.Size = new System.Drawing.Size(414, 100);
            this.pnlFileUpload.TabIndex = 1;
            this.pnlFileUpload.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlFileUpload_DragOver);
            // 
            // lblDragFile
            // 
            this.lblDragFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDragFile.AutoSize = true;
            this.lblDragFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDragFile.Location = new System.Drawing.Point(114, 25);
            this.lblDragFile.Name = "lblDragFile";
            this.lblDragFile.Size = new System.Drawing.Size(168, 19);
            this.lblDragFile.TabIndex = 0;
            this.lblDragFile.Text = "Drag and drop file here ";
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
            this.btnClose.Location = new System.Drawing.Point(531, 12);
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
            // UploadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 323);
            this.Controls.Add(this.lblPageHeader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlFileUpload);
            this.Controls.Add(this.txtFileUpload);
            this.Name = "UploadFile";
            this.Text = "UploadFile";
            this.pnlFileUpload.ResumeLayout(false);
            this.pnlFileUpload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileUpload;
        private System.Windows.Forms.Panel pnlFileUpload;
        private System.Windows.Forms.Label lblDragFile;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPageHeader;
    }
}