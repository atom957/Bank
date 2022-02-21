
namespace Bank
{
    partial class Logowanie
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCreateAcount = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(50, 221);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(285, 23);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "zaloguj";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 23);
            this.textBox1.TabIndex = 2;
            // 
            // buttonCreateAcount
            // 
            this.buttonCreateAcount.Location = new System.Drawing.Point(50, 110);
            this.buttonCreateAcount.Name = "buttonCreateAcount";
            this.buttonCreateAcount.Size = new System.Drawing.Size(285, 23);
            this.buttonCreateAcount.TabIndex = 3;
            this.buttonCreateAcount.Text = "utwórz konto";
            this.buttonCreateAcount.UseVisualStyleBackColor = true;
            this.buttonCreateAcount.Click += new System.EventHandler(this.buttonCreateAcount_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Konto Podstawowe",
            "Konto Premium"});
            this.comboBox2.Location = new System.Drawing.Point(50, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(285, 23);
            this.comboBox2.TabIndex = 4;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 359);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.buttonCreateAcount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.comboBox1);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCreateAcount;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}