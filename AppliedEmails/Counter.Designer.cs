namespace AppliedEmails
{
    partial class frmCounter
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
            this.CounterBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // CounterBar
            // 
            this.CounterBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CounterBar.Location = new System.Drawing.Point(13, 17);
            this.CounterBar.Name = "CounterBar";
            this.CounterBar.Size = new System.Drawing.Size(626, 23);
            this.CounterBar.TabIndex = 0;
            // 
            // frmCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 51);
            this.Controls.Add(this.CounterBar);
            this.Name = "frmCounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Counter";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar CounterBar;
    }
}