using System;

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
            this.btnUniFormity = new System.Windows.Forms.Button();
            this.cmbUniformityBatch = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.rdbtnProcRpt = new System.Windows.Forms.RadioButton();
            this.rdbtnAuditRpt = new System.Windows.Forms.RadioButton();
            this.rdbtnAlarmRpt = new System.Windows.Forms.RadioButton();
            this.dtPEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDateTime = new System.Windows.Forms.Label();
            this.dtPStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimeBaseReport = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnUploadImagesAfter = new System.Windows.Forms.Button();
            this.btnUploadImagesBefore = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadTC = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(290, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Report";
            // 
            // lblBatchID
            // 
            this.lblBatchID.AutoSize = true;
            this.lblBatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchID.ForeColor = System.Drawing.Color.White;
            this.lblBatchID.Location = new System.Drawing.Point(22, 20);
            this.lblBatchID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatchID.Name = "lblBatchID";
            this.lblBatchID.Size = new System.Drawing.Size(49, 13);
            this.lblBatchID.TabIndex = 1;
            this.lblBatchID.Text = "Batch ID";
            // 
            // btnVRProcess
            // 
            this.btnVRProcess.BackColor = System.Drawing.Color.Navy;
            this.btnVRProcess.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVRProcess.ForeColor = System.Drawing.Color.White;
            this.btnVRProcess.Location = new System.Drawing.Point(22, 66);
            this.btnVRProcess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVRProcess.Name = "btnVRProcess";
            this.btnVRProcess.Size = new System.Drawing.Size(250, 25);
            this.btnVRProcess.TabIndex = 7;
            this.btnVRProcess.Text = "VIEW REPORT";
            this.btnVRProcess.UseVisualStyleBackColor = false;
            this.btnVRProcess.Click += new System.EventHandler(this.btnVRProcess_Click);
            // 
            // cmbProcessBatch
            // 
            this.cmbProcessBatch.FormattingEnabled = true;
            this.cmbProcessBatch.Location = new System.Drawing.Point(22, 37);
            this.cmbProcessBatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbProcessBatch.Name = "cmbProcessBatch";
            this.cmbProcessBatch.Size = new System.Drawing.Size(250, 21);
            this.cmbProcessBatch.TabIndex = 2;
            this.cmbProcessBatch.SelectionChangeCommitted += new System.EventHandler(this.cmbProcessBatch_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnUniFormity);
            this.groupBox2.Controls.Add(this.cmbUniformityBatch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 120);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(290, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uniformity Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uniformity Batch ID";
            // 
            // btnUniFormity
            // 
            this.btnUniFormity.BackColor = System.Drawing.Color.Navy;
            this.btnUniFormity.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUniFormity.ForeColor = System.Drawing.Color.White;
            this.btnUniFormity.Location = new System.Drawing.Point(21, 64);
            this.btnUniFormity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUniFormity.Name = "btnUniFormity";
            this.btnUniFormity.Size = new System.Drawing.Size(251, 25);
            this.btnUniFormity.TabIndex = 7;
            this.btnUniFormity.Text = "VIEW REPORT";
            this.btnUniFormity.UseVisualStyleBackColor = false;
            this.btnUniFormity.Click += new System.EventHandler(this.btnUniFormity_Click);
            // 
            // cmbUniformityBatch
            // 
            this.cmbUniformityBatch.FormattingEnabled = true;
            this.cmbUniformityBatch.Location = new System.Drawing.Point(21, 37);
            this.cmbUniformityBatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbUniformityBatch.Name = "cmbUniformityBatch";
            this.cmbUniformityBatch.Size = new System.Drawing.Size(251, 21);
            this.cmbUniformityBatch.TabIndex = 2;
            this.cmbUniformityBatch.SelectionChangeCommitted += new System.EventHandler(this.cmbUniformityBatch_SelectionChangeCommitted);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtEndTime);
            this.groupBox4.Controls.Add(this.dtStartTime);
            this.groupBox4.Controls.Add(this.rdbtnProcRpt);
            this.groupBox4.Controls.Add(this.rdbtnAuditRpt);
            this.groupBox4.Controls.Add(this.rdbtnAlarmRpt);
            this.groupBox4.Controls.Add(this.dtPEndDate);
            this.groupBox4.Controls.Add(this.lblEndDateTime);
            this.groupBox4.Controls.Add(this.dtPStartDate);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnTimeBaseReport);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(14, 332);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(290, 192);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Time Base Report";
            // 
            // dtEndTime
            // 
            this.dtEndTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndTime.Checked = false;
            this.dtEndTime.CustomFormat = "";
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(161, 137);
            this.dtEndTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(113, 20);
            this.dtEndTime.TabIndex = 15;
            // 
            // dtStartTime
            // 
            this.dtStartTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartTime.Checked = false;
            this.dtStartTime.CustomFormat = "";
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(161, 96);
            this.dtStartTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(113, 20);
            this.dtStartTime.TabIndex = 14;
            // 
            // rdbtnProcRpt
            // 
            this.rdbtnProcRpt.AutoSize = true;
            this.rdbtnProcRpt.Location = new System.Drawing.Point(24, 56);
            this.rdbtnProcRpt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbtnProcRpt.Name = "rdbtnProcRpt";
            this.rdbtnProcRpt.Size = new System.Drawing.Size(112, 17);
            this.rdbtnProcRpt.TabIndex = 13;
            this.rdbtnProcRpt.TabStop = true;
            this.rdbtnProcRpt.Text = "Process Report";
            this.rdbtnProcRpt.UseVisualStyleBackColor = true;
            // 
            // rdbtnAuditRpt
            // 
            this.rdbtnAuditRpt.AutoSize = true;
            this.rdbtnAuditRpt.Location = new System.Drawing.Point(23, 36);
            this.rdbtnAuditRpt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbtnAuditRpt.Name = "rdbtnAuditRpt";
            this.rdbtnAuditRpt.Size = new System.Drawing.Size(96, 17);
            this.rdbtnAuditRpt.TabIndex = 12;
            this.rdbtnAuditRpt.TabStop = true;
            this.rdbtnAuditRpt.Text = "Audit Report";
            this.rdbtnAuditRpt.UseVisualStyleBackColor = true;
            // 
            // rdbtnAlarmRpt
            // 
            this.rdbtnAlarmRpt.AutoSize = true;
            this.rdbtnAlarmRpt.Location = new System.Drawing.Point(23, 16);
            this.rdbtnAlarmRpt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbtnAlarmRpt.Name = "rdbtnAlarmRpt";
            this.rdbtnAlarmRpt.Size = new System.Drawing.Size(98, 17);
            this.rdbtnAlarmRpt.TabIndex = 11;
            this.rdbtnAlarmRpt.TabStop = true;
            this.rdbtnAlarmRpt.Text = "Alarm Report";
            this.rdbtnAlarmRpt.UseVisualStyleBackColor = true;
            // 
            // dtPEndDate
            // 
            this.dtPEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPEndDate.Checked = false;
            this.dtPEndDate.CustomFormat = "";
            this.dtPEndDate.Location = new System.Drawing.Point(24, 137);
            this.dtPEndDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtPEndDate.Name = "dtPEndDate";
            this.dtPEndDate.Size = new System.Drawing.Size(129, 20);
            this.dtPEndDate.TabIndex = 10;
            // 
            // lblEndDateTime
            // 
            this.lblEndDateTime.AutoSize = true;
            this.lblEndDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDateTime.ForeColor = System.Drawing.Color.White;
            this.lblEndDateTime.Location = new System.Drawing.Point(21, 121);
            this.lblEndDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDateTime.Name = "lblEndDateTime";
            this.lblEndDateTime.Size = new System.Drawing.Size(80, 13);
            this.lblEndDateTime.TabIndex = 9;
            this.lblEndDateTime.Text = "End Date/Time";
            // 
            // dtPStartDate
            // 
            this.dtPStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPStartDate.Checked = false;
            this.dtPStartDate.CustomFormat = "";
            this.dtPStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPStartDate.Location = new System.Drawing.Point(24, 96);
            this.dtPStartDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtPStartDate.Name = "dtPStartDate";
            this.dtPStartDate.Size = new System.Drawing.Size(129, 20);
            this.dtPStartDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Start Date/Time";
            // 
            // btnTimeBaseReport
            // 
            this.btnTimeBaseReport.BackColor = System.Drawing.Color.Navy;
            this.btnTimeBaseReport.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeBaseReport.ForeColor = System.Drawing.Color.White;
            this.btnTimeBaseReport.Location = new System.Drawing.Point(23, 161);
            this.btnTimeBaseReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTimeBaseReport.Name = "btnTimeBaseReport";
            this.btnTimeBaseReport.Size = new System.Drawing.Size(251, 25);
            this.btnTimeBaseReport.TabIndex = 7;
            this.btnTimeBaseReport.Text = "VIEW REPORT";
            this.btnTimeBaseReport.UseVisualStyleBackColor = false;
            this.btnTimeBaseReport.Click += new System.EventHandler(this.btnTimeBaseReport_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnUploadImagesAfter);
            this.groupBox5.Controls.Add(this.btnUploadImagesBefore);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(15, 530);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(290, 100);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Upload Images";
            // 
            // btnUploadImagesAfter
            // 
            this.btnUploadImagesAfter.BackColor = System.Drawing.Color.Navy;
            this.btnUploadImagesAfter.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagesAfter.ForeColor = System.Drawing.Color.White;
            this.btnUploadImagesAfter.Location = new System.Drawing.Point(28, 60);
            this.btnUploadImagesAfter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUploadImagesAfter.Name = "btnUploadImagesAfter";
            this.btnUploadImagesAfter.Size = new System.Drawing.Size(240, 25);
            this.btnUploadImagesAfter.TabIndex = 9;
            this.btnUploadImagesAfter.Text = "AFTER";
            this.btnUploadImagesAfter.UseVisualStyleBackColor = false;
            this.btnUploadImagesAfter.Click += new System.EventHandler(this.btnUploadImagesAfter_Click);
            // 
            // btnUploadImagesBefore
            // 
            this.btnUploadImagesBefore.BackColor = System.Drawing.Color.Navy;
            this.btnUploadImagesBefore.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagesBefore.ForeColor = System.Drawing.Color.White;
            this.btnUploadImagesBefore.Location = new System.Drawing.Point(28, 29);
            this.btnUploadImagesBefore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUploadImagesBefore.Name = "btnUploadImagesBefore";
            this.btnUploadImagesBefore.Size = new System.Drawing.Size(240, 25);
            this.btnUploadImagesBefore.TabIndex = 8;
            this.btnUploadImagesBefore.Text = "BEFORE";
            this.btnUploadImagesBefore.UseVisualStyleBackColor = false;
            this.btnUploadImagesBefore.Click += new System.EventHandler(this.btnUploadImagesBefore_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnLoadTC);
            this.groupBox3.Controls.Add(this.cmbLoadTCBatch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 226);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(290, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Load TC  Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Batch ID";
            // 
            // btnLoadTC
            // 
            this.btnLoadTC.BackColor = System.Drawing.Color.Navy;
            this.btnLoadTC.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadTC.ForeColor = System.Drawing.Color.White;
            this.btnLoadTC.Location = new System.Drawing.Point(20, 65);
            this.btnLoadTC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadTC.Name = "btnLoadTC";
            this.btnLoadTC.Size = new System.Drawing.Size(251, 25);
            this.btnLoadTC.TabIndex = 7;
            this.btnLoadTC.Text = "VIEW REPORT";
            this.btnLoadTC.UseVisualStyleBackColor = false;
            this.btnLoadTC.Click += new System.EventHandler(this.btnLoadTC_Click);
            // 
            // cmbLoadTCBatch
            // 
            this.cmbLoadTCBatch.FormattingEnabled = true;
            this.cmbLoadTCBatch.Location = new System.Drawing.Point(20, 38);
            this.cmbLoadTCBatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbLoadTCBatch.Name = "cmbLoadTCBatch";
            this.cmbLoadTCBatch.Size = new System.Drawing.Size(251, 21);
            this.cmbLoadTCBatch.TabIndex = 2;
            this.cmbLoadTCBatch.SelectionChangeCommitted += new System.EventHandler(this.cmbLoadTCBatch_SelectionChangeCommitted);
            // 
            // LeftMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LeftMenu";
            this.Size = new System.Drawing.Size(309, 633);
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
        private System.Windows.Forms.Button btnUniFormity;
        private System.Windows.Forms.ComboBox cmbUniformityBatch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtPEndDate;
        private System.Windows.Forms.Label lblEndDateTime;
        private System.Windows.Forms.DateTimePicker dtPStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimeBaseReport;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnUploadImagesAfter;
        private System.Windows.Forms.Button btnUploadImagesBefore;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadTC;
        private System.Windows.Forms.ComboBox cmbLoadTCBatch;
        private System.Windows.Forms.RadioButton rdbtnProcRpt;
        private System.Windows.Forms.RadioButton rdbtnAuditRpt;
        private System.Windows.Forms.RadioButton rdbtnAlarmRpt;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.DateTimePicker dtStartTime;
    }
}
