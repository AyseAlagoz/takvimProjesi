namespace takvimDeneme2
{
    partial class anaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAylik = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Günlük";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 49);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "Haftalık";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAylik
            // 
            this.btnAylik.Location = new System.Drawing.Point(309, 49);
            this.btnAylik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAylik.Name = "btnAylik";
            this.btnAylik.Size = new System.Drawing.Size(140, 41);
            this.btnAylik.TabIndex = 0;
            this.btnAylik.Text = "Aylık";
            this.btnAylik.UseVisualStyleBackColor = true;
            this.btnAylik.Click += new System.EventHandler(this.btnAylik_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(457, 49);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(140, 41);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni Plan Girişi";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 229);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnAylik);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "anaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takvim";
            this.Load += new System.EventHandler(this.anaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAylik;
        private System.Windows.Forms.Button btnYeni;
    }
}