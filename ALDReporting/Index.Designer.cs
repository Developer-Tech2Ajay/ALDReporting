namespace ALDReporting.Reports
{
    partial class Index
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
            this.ucHeader1 = new ALDReporting.ucHeader();
            this.leftMenu1 = new LeftMenu();
            this.SuspendLayout();
            // 
            // lblWelcomeText
            // 
            this.lblWelcomeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcomeText.AutoSize = true;
            this.lblWelcomeText.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeText.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeText.Location = new System.Drawing.Point(501, 361);
            this.lblWelcomeText.Name = "lblWelcomeText";
            this.lblWelcomeText.Size = new System.Drawing.Size(108, 37);
            this.lblWelcomeText.TabIndex = 2;
            this.lblWelcomeText.Text = "label4";
            // 
            // ucHeader1
            // 
            this.ucHeader1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucHeader1.BackColor = System.Drawing.Color.White;
            this.ucHeader1.Location = new System.Drawing.Point(0, 0);
            this.ucHeader1.Name = "ucHeader1";
            this.ucHeader1.Size = new System.Drawing.Size(798, 80);
            this.ucHeader1.TabIndex = 4;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ALDReporting.ProjectResource.Background;
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.ucHeader1);
            this.Controls.Add(this.lblWelcomeText);
            this.Controls.Add(this.leftMenu1);
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.leftMenu1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom |
                                                                            System.Windows.Forms.AnchorStyles.Left))));
            this.leftMenu1.Location = new System.Drawing.Point(0, 78);


        }

        #endregion
        private System.Windows.Forms.Label lblWelcomeText;
        private LeftMenu leftMenu1;
        private ucHeader ucHeader1;
    }
}