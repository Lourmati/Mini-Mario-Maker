namespace Labo5
{
    partial class Form1
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
            this.BtnNuage = new System.Windows.Forms.Button();
            this.BtnPlancher = new System.Windows.Forms.Button();
            this.BtnBrique = new System.Windows.Forms.Button();
            this.BtnCoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNuage
            // 
            this.BtnNuage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnNuage.Location = new System.Drawing.Point(977, 101);
            this.BtnNuage.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNuage.Name = "BtnNuage";
            this.BtnNuage.Size = new System.Drawing.Size(38, 41);
            this.BtnNuage.TabIndex = 0;
            this.BtnNuage.UseVisualStyleBackColor = true;
            this.BtnNuage.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnPlancher
            // 
            this.BtnPlancher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPlancher.Location = new System.Drawing.Point(977, 55);
            this.BtnPlancher.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPlancher.Name = "BtnPlancher";
            this.BtnPlancher.Size = new System.Drawing.Size(38, 41);
            this.BtnPlancher.TabIndex = 1;
            this.BtnPlancher.UseVisualStyleBackColor = true;
            this.BtnPlancher.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnBrique
            // 
            this.BtnBrique.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBrique.Location = new System.Drawing.Point(977, 10);
            this.BtnBrique.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBrique.Name = "BtnBrique";
            this.BtnBrique.Size = new System.Drawing.Size(38, 41);
            this.BtnBrique.TabIndex = 2;
            this.BtnBrique.UseVisualStyleBackColor = true;
            this.BtnBrique.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnCoin
            // 
            this.BtnCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCoin.Location = new System.Drawing.Point(977, 146);
            this.BtnCoin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCoin.Name = "BtnCoin";
            this.BtnCoin.Size = new System.Drawing.Size(38, 41);
            this.BtnCoin.TabIndex = 3;
            this.BtnCoin.UseVisualStyleBackColor = true;
            this.BtnCoin.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 511);
            this.Controls.Add(this.BtnCoin);
            this.Controls.Add(this.BtnBrique);
            this.Controls.Add(this.BtnPlancher);
            this.Controls.Add(this.BtnNuage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labo5";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNuage;
        private System.Windows.Forms.Button BtnPlancher;
        private System.Windows.Forms.Button BtnBrique;
        private System.Windows.Forms.Button BtnCoin;
    }
}

