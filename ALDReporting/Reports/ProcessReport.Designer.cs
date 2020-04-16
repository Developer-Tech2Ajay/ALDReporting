namespace ALDReporting.Reports
{
    partial class ProcessReport
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
            this.lblWelcomeText = new System.Windows.Forms.Label();
            this.leftMenu1 = new ALDReporting.LeftMenu();
            this.ucHeader1 = new ALDReporting.ucHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPageHeder = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeText
            // 
            this.lblWelcomeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcomeText.AutoSize = true;
            this.lblWelcomeText.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeText.Font = new System.Drawing.Font("Arial Unicode MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeText.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeText.Location = new System.Drawing.Point(501, 361);
            this.lblWelcomeText.Name = "lblWelcomeText";
            this.lblWelcomeText.Size = new System.Drawing.Size(111, 43);
            this.lblWelcomeText.TabIndex = 2;
            this.lblWelcomeText.Text = "label4";
            // 
            // leftMenu1
            // 
            this.leftMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.leftMenu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftMenu1.Location = new System.Drawing.Point(0, 60);
            this.leftMenu1.Name = "leftMenu1";
            this.leftMenu1.Size = new System.Drawing.Size(218, 619);
            this.leftMenu1.TabIndex = 3;
            // 
            // ucHeader1
            // 
            this.ucHeader1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucHeader1.BackColor = System.Drawing.Color.White;
            this.ucHeader1.Location = new System.Drawing.Point(0, 0);
            this.ucHeader1.Name = "ucHeader1";
            this.ucHeader1.Size = new System.Drawing.Size(798, 62);
            this.ucHeader1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPageHeder);
            this.panel1.Location = new System.Drawing.Point(224, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 639);
            this.panel1.TabIndex = 5;
            // 
            // lblPageHeder
            // 
            this.lblPageHeder.AutoSize = true;
            this.lblPageHeder.BackColor = System.Drawing.Color.Transparent;
            this.lblPageHeder.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageHeder.ForeColor = System.Drawing.Color.Red;
            this.lblPageHeder.Location = new System.Drawing.Point(20, 16);
            this.lblPageHeder.Name = "lblPageHeder";
            this.lblPageHeder.Size = new System.Drawing.Size(120, 21);
            this.lblPageHeder.TabIndex = 0;
            this.lblPageHeder.Text = "Process Report";
            // 
            // ProcessReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucHeader1);
            this.Controls.Add(this.leftMenu1);
            this.Controls.Add(this.lblWelcomeText);
            this.Name = "ProcessReport";
            this.Text = "Index";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcomeText;
        private LeftMenu leftMenu1;
        private ucHeader ucHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPageHeder;
    }
}