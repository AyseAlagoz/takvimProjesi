namespace takvimDeneme2
{
    partial class gunlukPlanGoruntule
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
            this.gunlukList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // gunlukList
            // 
            this.gunlukList.FormattingEnabled = true;
            this.gunlukList.Location = new System.Drawing.Point(36, 26);
            this.gunlukList.Name = "gunlukList";
            this.gunlukList.Size = new System.Drawing.Size(717, 381);
            this.gunlukList.TabIndex = 0;
            this.gunlukList.SelectedIndexChanged += new System.EventHandler(this.gunlukList_SelectedIndexChanged);
            // 
            // gunlukPlanGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunlukList);
            this.Name = "gunlukPlanGoruntule";
            this.Text = "gunlukPlanGoruntule";
            this.Load += new System.EventHandler(this.gunlukPlanGoruntule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox gunlukList;
    }
}