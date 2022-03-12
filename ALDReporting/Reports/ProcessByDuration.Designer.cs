namespace ALDReporting.Reports
{
    partial class ProcessByDuration
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
            this.rptvw_ProcByDur = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptvw_ProcByDur
            // 
            this.rptvw_ProcByDur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvw_ProcByDur.LocalReport.ReportEmbeddedResource = "ALDReporting.Reports.ProcessByDuration.rdlc";
            this.rptvw_ProcByDur.Location = new System.Drawing.Point(0, 0);
            this.rptvw_ProcByDur.Name = "rptvw_ProcByDur";
            this.rptvw_ProcByDur.ServerReport.BearerToken = null;
            this.rptvw_ProcByDur.Size = new System.Drawing.Size(961, 749);
            this.rptvw_ProcByDur.TabIndex = 0;
            this.rptvw_ProcByDur.Load += new System.EventHandler(this.rptvw_ProcByDur_Load);
            // 
            // ProcessByDuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 749);
            this.Controls.Add(this.rptvw_ProcByDur);
            this.Name = "ProcessByDuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process By Duration";
            this.Load += new System.EventHandler(this.ProcessByDuration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvw_ProcByDur;
    }
}