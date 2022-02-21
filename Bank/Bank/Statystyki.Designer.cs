
namespace Bank
{
    partial class Statystyki
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
            this.labelMax = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMinimun = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSrednia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(12, 56);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(38, 15);
            this.labelMax.TabIndex = 0;
            this.labelMax.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maxsymalna Tranzakcja:";
            // 
            // labelMinimun
            // 
            this.labelMinimun.AutoSize = true;
            this.labelMinimun.Location = new System.Drawing.Point(12, 151);
            this.labelMinimun.Name = "labelMinimun";
            this.labelMinimun.Size = new System.Drawing.Size(38, 15);
            this.labelMinimun.TabIndex = 2;
            this.labelMinimun.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Minimalna Tranzakcja:";
            // 
            // labelSrednia
            // 
            this.labelSrednia.AutoSize = true;
            this.labelSrednia.Location = new System.Drawing.Point(13, 236);
            this.labelSrednia.Name = "labelSrednia";
            this.labelSrednia.Size = new System.Drawing.Size(38, 15);
            this.labelSrednia.TabIndex = 4;
            this.labelSrednia.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Średnia tranzakcji:";
            // 
            // Statystyki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 382);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelSrednia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMinimun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMax);
            this.Name = "Statystyki";
            this.Text = "Statystyki";
            this.Load += new System.EventHandler(this.Statystyki_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMinimun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSrednia;
        private System.Windows.Forms.Label label6;
    }
}