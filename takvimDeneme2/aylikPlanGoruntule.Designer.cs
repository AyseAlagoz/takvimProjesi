namespace takvimDeneme2
{
    partial class aylikPlanGoruntule
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
            this.aylıkList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // aylıkList
            // 
            this.aylıkList.FormattingEnabled = true;
            this.aylıkList.Location = new System.Drawing.Point(34, 22);
            this.aylıkList.Name = "aylıkList";
            this.aylıkList.Size = new System.Drawing.Size(732, 381);
            this.aylıkList.TabIndex = 0;
            this.aylıkList.SelectedIndexChanged += new System.EventHandler(this.aylıkList_SelectedIndexChanged);
            // 
            // aylikPlanGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aylıkList);
            this.Name = "aylikPlanGoruntule";
            this.Text = "aylikPlanGoruntule";
            this.Load += new System.EventHandler(this.aylikPlanGoruntule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox aylıkList;
    }
}