
namespace Bank
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonWplac = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonBackToLogin = new System.Windows.Forms.Button();
            this.operationsTable = new System.Windows.Forms.DataGridView();
            this.typOperacji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kwotaOperacji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonStats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.operationsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Konto Podstawowe",
            "Konto Premium"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.wybur);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(313, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "zatwierdz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonWplac
            // 
            this.buttonWplac.Location = new System.Drawing.Point(12, 128);
            this.buttonWplac.Name = "buttonWplac";
            this.buttonWplac.Size = new System.Drawing.Size(223, 48);
            this.buttonWplac.TabIndex = 3;
            this.buttonWplac.Text = "wplac";
            this.buttonWplac.UseVisualStyleBackColor = true;
            this.buttonWplac.Click += new System.EventHandler(this.buttonWplac_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(241, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "wyplac";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonWyplac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "procent",
            "kwota"});
            this.comboBox2.Location = new System.Drawing.Point(12, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(431, 23);
            this.comboBox2.TabIndex = 6;
            // 
            // buttonBackToLogin
            // 
            this.buttonBackToLogin.Location = new System.Drawing.Point(12, 41);
            this.buttonBackToLogin.Name = "buttonBackToLogin";
            this.buttonBackToLogin.Size = new System.Drawing.Size(431, 23);
            this.buttonBackToLogin.TabIndex = 8;
            this.buttonBackToLogin.Text = "wyloguj";
            this.buttonBackToLogin.UseVisualStyleBackColor = true;
            this.buttonBackToLogin.Click += new System.EventHandler(this.buttonBackToLogin_Click);
            // 
            // operationsTable
            // 
            this.operationsTable.AllowUserToAddRows = false;
            this.operationsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.operationsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.operationsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.operationsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typOperacji,
            this.kwotaOperacji,
            this.saldo});
            this.operationsTable.Location = new System.Drawing.Point(12, 321);
            this.operationsTable.Name = "operationsTable";
            this.operationsTable.RowTemplate.Height = 25;
            this.operationsTable.Size = new System.Drawing.Size(431, 600);
            this.operationsTable.TabIndex = 9;
            // 
            // typOperacji
            // 
            this.typOperacji.HeaderText = "Typ operacji";
            this.typOperacji.Name = "typOperacji";
            this.typOperacji.ReadOnly = true;
            // 
            // kwotaOperacji
            // 
            this.kwotaOperacji.HeaderText = "Kwota operacji";
            this.kwotaOperacji.Name = "kwotaOperacji";
            this.kwotaOperacji.ReadOnly = true;
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Stan konta";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // buttonStats
            // 
            this.buttonStats.Location = new System.Drawing.Point(345, 182);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(90, 118);
            this.buttonStats.TabIndex = 10;
            this.buttonStats.Text = "Statystyki";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 942);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.operationsTable);
            this.Controls.Add(this.buttonBackToLogin);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonWplac);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.operationsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonWplac;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonBackToLogin;
        private System.Windows.Forms.DataGridView operationsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn typOperacji;
        private System.Windows.Forms.DataGridViewTextBoxColumn kwotaOperacji;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.Button buttonStats;
    }
}

