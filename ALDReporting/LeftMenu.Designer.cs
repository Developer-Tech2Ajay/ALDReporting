namespace ALDReporting
{
    partial class LeftMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBatchID = new System.Windows.Forms.Label();
            this.btnVRProcess = new System.Windows.Forms.Button();
            this.cmbProcessBatch = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbUniformityBatch = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtPEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDateTime = new System.Windows.Forms.Label();
            this.dtPStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnUploadImagesAfter = new System.Windows.Forms.Button();
            this.btnUploadImagesBefore = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbLoadTCBatch = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBatchID);
            this.groupBox1.Controls.Add(this.btnVRProcess);
            this.groupBox1.Controls.Add(this.cmbProcessBatch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Report";
            // 
            // lblBatchID
            // 
            this.lblBatchID.AutoSize = true;
            this.lblBatchID.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchID.ForeColor = System.Drawing.Color.White;
            this.lblBatchID.Location = new System.Drawing.Point(15, 26);
            this.lblBatchID.Name = "lblBatchID";
            this.lblBatchID.Size = new System.Drawing.Size(49, 15);
            this.lblBatchID.TabIndex = 1;
            this.lblBatchID.Text = "Batch ID";
            // 
            // btnVRProcess
            // 
            this.btnVRProcess.BackColor = System.Drawing.Color.MediumBlue;
            this.btnVRProcess.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVRProcess.ForeColor = System.Drawing.Color.White;
            this.btnVRProcess.Location = new System.Drawing.Point(15, 71);
            this.btnVRProcess.Name = "btnVRProcess";
            this.btnVRProcess.Size = new System.Drawing.Size(152, 25);
            this.btnVRProcess.TabIndex = 7;
            this.btnVRProcess.Text = "VIEW REPORT";
            this.btnVRProcess.UseVisualStyleBackColor = false;
            this.btnVRProcess.Click += new System.EventHandler(this.btnVRProcess_Click);
            // 
            // cmbProcessBatch
            // 
            this.cmbProcessBatch.FormattingEnabled = true;
            this.cmbProcessBatch.Location = new System.Drawing.Point(15, 44);
            this.cmbProcessBatch.Name = "cmbProcessBatch";
            this.cmbProcessBatch.Size = new System.Drawing.Size(152, 21);
            this.cmbProcessBatch.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cmbUniformityBatch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uniformity Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uniformity Batch ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "VIEW REPORT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cmbUniformityBatch
            // 
            this.cmbUniformityBatch.FormattingEnabled = true;
            this.cmbUniformityBatch.Location = new System.Drawing.Point(15, 44);
            this.cmbUniformityBatch.Name = "cmbUniformityBatch";
            this.cmbUniformityBatch.Size = new System.Drawing.Size(152, 21);
            this.cmbUniformityBatch.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtPEndDate);
            this.groupBox4.Controls.Add(this.lblEndDateTime);
            this.groupBox4.Controls.Add(this.dtPStartDate);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 147);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alarm Report";
            // 
            // dtPEndDate
            // 
            this.dtPEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPEndDate.CustomFormat = "";
            this.dtPEndDate.Location = new System.Drawing.Point(18, 86);
            this.dtPEndDate.Name = "dtPEndDate";
            this.dtPEndDate.Size = new System.Drawing.Size(148, 20);
            this.dtPEndDate.TabIndex = 10;
            this.dtPEndDate.Value = new System.DateTime(2020, 3, 25, 0, 0, 0, 0);
            // 
            // lblEndDateTime
            // 
            this.lblEndDateTime.AutoSize = true;
            this.lblEndDateTime.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDateTime.ForeColor = System.Drawing.Color.White;
            this.lblEndDateTime.Location = new System.Drawing.Point(15, 67);
            this.lblEndDateTime.Name = "lblEndDateTime";
            this.lblEndDateTime.Size = new System.Drawing.Size(78, 15);
            this.lblEndDateTime.TabIndex = 9;
            this.lblEndDateTime.Text = "End Date/Time";
            // 
            // dtPStartDate
            // 
            this.dtPStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPStartDate.CustomFormat = "";
            this.dtPStartDate.Location = new System.Drawing.Point(18, 45);
            this.dtPStartDate.Name = "dtPStartDate";
            this.dtPStartDate.Size = new System.Drawing.Size(148, 20);
            this.dtPStartDate.TabIndex = 8;
            this.dtPStartDate.Value = new System.DateTime(2020, 3, 25, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Start Date/Time";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumBlue;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(17, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "VIEW REPORT";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox5.Controls.Add(this.btnUploadImagesAfter);
            this.groupBox5.Controls.Add(this.btnUploadImagesBefore);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(13, 498);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(193, 100);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Upload Images";
            // 
            // btnUploadImagesAfter
            // 
            this.btnUploadImagesAfter.BackColor = System.Drawing.Color.MediumBlue;
            this.btnUploadImagesAfter.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagesAfter.ForeColor = System.Drawing.Color.White;
            this.btnUploadImagesAfter.Location = new System.Drawing.Point(19, 60);
            this.btnUploadImagesAfter.Name = "btnUploadImagesAfter";
            this.btnUploadImagesAfter.Size = new System.Drawing.Size(149, 25);
            this.btnUploadImagesAfter.TabIndex = 9;
            this.btnUploadImagesAfter.Text = "AFTER";
            this.btnUploadImagesAfter.UseVisualStyleBackColor = false;
            // 
            // btnUploadImagesBefore
            // 
            this.btnUploadImagesBefore.BackColor = System.Drawing.Color.MediumBlue;
            this.btnUploadImagesBefore.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagesBefore.ForeColor = System.Drawing.Color.White;
            this.btnUploadImagesBefore.Location = new System.Drawing.Point(19, 29);
            this.btnUploadImagesBefore.Name = "btnUploadImagesBefore";
            this.btnUploadImagesBefore.Size = new System.Drawing.Size(149, 25);
            this.btnUploadImagesBefore.TabIndex = 8;
            this.btnUploadImagesBefore.Text = "BEFORE";
            this.btnUploadImagesBefore.UseVisualStyleBackColor = false;
            this.btnUploadImagesBefore.Click += new System.EventHandler(this.btnUploadImagesBefore_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.cmbLoadTCBatch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Load TC  Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Batch ID";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(15, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "VIEW REPORT";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cmbLoadTCBatch
            // 
            this.cmbLoadTCBatch.FormattingEnabled = true;
            this.cmbLoadTCBatch.Location = new System.Drawing.Point(15, 44);
            this.cmbLoadTCBatch.Name = "cmbLoadTCBatch";
            this.cmbLoadTCBatch.Size = new System.Drawing.Size(152, 21);
            this.cmbLoadTCBatch.TabIndex = 2;
            // 
            // LeftMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LeftMenu";
            this.Size = new System.Drawing.Size(211, 601);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBatchID;
        private System.Windows.Forms.Button btnVRProcess;
        private System.Windows.Forms.ComboBox cmbProcessBatch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbUniformityBatch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtPEndDate;
        private System.Windows.Forms.Label lblEndDateTime;
        private System.Windows.Forms.DateTimePicker dtPStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnUploadImagesAfter;
        private System.Windows.Forms.Button btnUploadImagesBefore;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbLoadTCBatch;
    }
}
