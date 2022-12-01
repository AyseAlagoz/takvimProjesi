namespace takvimDeneme2
{
    partial class UserControlDays
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
            this.components = new System.ComponentModel.Container();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(15, 10);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(23, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "OO";
            this.lblDays.Click += new System.EventHandler(this.lblDays_Click);
            // 
            // lblPlan
            // 
            this.lblPlan.Location = new System.Drawing.Point(3, 32);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(88, 17);
            this.lblPlan.TabIndex = 1;
            this.lblPlan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlan.Click += new System.EventHandler(this.lblPlan_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.lblDays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(94, 49);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Timer timer1;
    }
}
