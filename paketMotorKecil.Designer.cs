namespace Final_Project_Vispro
{
    partial class paketMotorKecil
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbPaket = new System.Windows.Forms.ComboBox();
            this.txtTipeKendaraan = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cbPaket);
            this.panel2.Controls.Add(this.txtTipeKendaraan);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtDate);
            this.panel2.Controls.Add(this.txtCost);
            this.panel2.Controls.Add(this.txtLicensePlate);
            this.panel2.Location = new System.Drawing.Point(750, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 177);
            this.panel2.TabIndex = 90;
            // 
            // cbPaket
            // 
            this.cbPaket.FormattingEnabled = true;
            this.cbPaket.Items.AddRange(new object[] {
            "basic wash",
            "deep wash"});
            this.cbPaket.Location = new System.Drawing.Point(160, 74);
            this.cbPaket.Name = "cbPaket";
            this.cbPaket.Size = new System.Drawing.Size(135, 28);
            this.cbPaket.TabIndex = 99;
            this.cbPaket.SelectedIndexChanged += new System.EventHandler(this.cbPaket_SelectedIndexChanged);
            // 
            // txtTipeKendaraan
            // 
            this.txtTipeKendaraan.Location = new System.Drawing.Point(54, 121);
            this.txtTipeKendaraan.Name = "txtTipeKendaraan";
            this.txtTipeKendaraan.Size = new System.Drawing.Size(100, 30);
            this.txtTipeKendaraan.TabIndex = 98;
            this.txtTipeKendaraan.Text = "motor kecil";
            this.txtTipeKendaraan.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(301, 121);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex = 95;
            this.btnPrint.Text = "print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(177, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(84, 34);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(272, 26);
            this.txtDate.TabIndex = 55;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(301, 76);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 26);
            this.txtCost.TabIndex = 63;
            this.txtCost.Text = "Cost";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(54, 76);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(100, 26);
            this.txtLicensePlate.TabIndex = 61;
            this.txtLicensePlate.Text = "License";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1051, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 300);
            this.button1.TabIndex = 93;
            this.button1.Text = "Deep Wash\r\n  Rp.70.000\r\n\r\n-Pembersihan lebih mendalam\r\n-Menggunakan sikat khusus " +
    "dan\r\n  cairan pembersih\r\n-Finishing dengan semir ban dan\r\n  penkilap bodi\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(504, 488);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(400, 300);
            this.button5.TabIndex = 92;
            this.button5.Text = "Basic wash:\r\n  Rp.50.000\r\n\r\n-Bagian luar motor\r\n-Pengguna sabun dan \r\n  air berte" +
    "kanan\r\n-Pengering Premium\r\n\r\n\r\n";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1643, 875);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 50);
            this.button3.TabIndex = 94;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // paketMotorKecil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Final_Project_Vispro.Properties.Resources.Lio_bjat5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "paketMotorKecil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paketMotorKecil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.paketMotorKecil_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button txtTipeKendaraan;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbPaket;
    }
}