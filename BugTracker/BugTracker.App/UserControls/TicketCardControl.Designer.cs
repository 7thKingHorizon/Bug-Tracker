namespace BugTracker.App.UserControls
{
    partial class TicketCardControl
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
            this.LnkTitle = new System.Windows.Forms.LinkLabel();
            this.LnkFollow = new System.Windows.Forms.LinkLabel();
            this.LblLastUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LnkTitle
            // 
            this.LnkTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkTitle.Location = new System.Drawing.Point(3, 9);
            this.LnkTitle.Name = "LnkTitle";
            this.LnkTitle.Size = new System.Drawing.Size(244, 89);
            this.LnkTitle.TabIndex = 0;
            this.LnkTitle.TabStop = true;
            this.LnkTitle.Text = "Place Holder Title";
            // 
            // LnkFollow
            // 
            this.LnkFollow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LnkFollow.AutoSize = true;
            this.LnkFollow.Location = new System.Drawing.Point(3, 107);
            this.LnkFollow.Name = "LnkFollow";
            this.LnkFollow.Size = new System.Drawing.Size(37, 13);
            this.LnkFollow.TabIndex = 1;
            this.LnkFollow.TabStop = true;
            this.LnkFollow.Text = "Follow";
            // 
            // LblLastUpdate
            // 
            this.LblLastUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLastUpdate.AutoSize = true;
            this.LblLastUpdate.Location = new System.Drawing.Point(148, 107);
            this.LblLastUpdate.Name = "LblLastUpdate";
            this.LblLastUpdate.Size = new System.Drawing.Size(99, 13);
            this.LblLastUpdate.TabIndex = 2;
            this.LblLastUpdate.Text = " 06-30-2020 @6:30";
            // 
            // TicketCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LblLastUpdate);
            this.Controls.Add(this.LnkFollow);
            this.Controls.Add(this.LnkTitle);
            this.Name = "TicketCardControl";
            this.Size = new System.Drawing.Size(250, 131);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LnkTitle;
        private System.Windows.Forms.LinkLabel LnkFollow;
        private System.Windows.Forms.Label LblLastUpdate;
    }
}
