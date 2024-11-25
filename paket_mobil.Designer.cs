namespace Final_Project_Vispro
{
    partial class paket_mobil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paket_mobil));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbPaket = new System.Windows.Forms.ComboBox();
            this.txtTipeKendaraan = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(1316, 505);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(400, 300);
            this.button3.TabIndex = 68;
            this.button3.Text = resources.GetString("button3.Text");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(209, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 300);
            this.button2.TabIndex = 67;
            this.button2.Text = "Basic Wash \r\n  Rp.100.000\r\n\r\n-Pencucian eksterior\r\n-Pengeringan mobil\r\n-pembersih" +
    "an sederhana\r\n  (roda dan ban)\r\n-Waktu pengerjaan 20-30mnt\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(768, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 300);
            this.button1.TabIndex = 66;
            this.button1.Text = "Deep Wash:\r\n  Rp.150.000\r\n\r\n-Semua layanan pada basic wash\r\n-Pembersihan menyelur" +
    "uh \r\n-Pembersihan kolong mobil\r\n-Vakum karpet dan kursi\r\n-Waktu pengerjaan 45-60" +
    "mnt\r\n\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
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
            this.panel2.TabIndex = 65;
            // 
            // cbPaket
            // 
            this.cbPaket.FormattingEnabled = true;
            this.cbPaket.Items.AddRange(new object[] {
            "basic wash",
            "deep wash",
            "premium"});
            this.cbPaket.Location = new System.Drawing.Point(170, 73);
            this.cbPaket.Name = "cbPaket";
            this.cbPaket.Size = new System.Drawing.Size(121, 28);
            this.cbPaket.TabIndex = 98;
            this.cbPaket.SelectedIndexChanged += new System.EventHandler(this.cbPaket_SelectedIndexChanged);
            // 
            // txtTipeKendaraan
            // 
            this.txtTipeKendaraan.Location = new System.Drawing.Point(54, 119);
            this.txtTipeKendaraan.Name = "txtTipeKendaraan";
            this.txtTipeKendaraan.Size = new System.Drawing.Size(100, 30);
            this.txtTipeKendaraan.TabIndex = 97;
            this.txtTipeKendaraan.Text = "mobil besar";
            this.txtTipeKendaraan.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(301, 119);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex = 96;
            this.btnPrint.Text = "print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(180, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(84, 34);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(272, 26);
            this.txtDate.TabIndex = 55;
            this.txtDate.ValueChanged += new System.EventHandler(this.TxtDate_ValueChanged);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(301, 76);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 26);
            this.txtCost.TabIndex = 63;
            this.txtCost.Text = "Cost";
            this.txtCost.TextChanged += new System.EventHandler(this.TxtCost_TextChanged);
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(54, 76);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(100, 26);
            this.txtLicensePlate.TabIndex = 61;
            this.txtLicensePlate.Text = "License";
            this.txtLicensePlate.TextChanged += new System.EventHandler(this.TxtLicensePlate_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1643, 875);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 50);
            this.button4.TabIndex = 69;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // paket_mobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Final_Project_Vispro.Properties.Resources.Lio_bjat4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.Name = "paket_mobil";
            this.Text = "paket_mobil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Paket_mobil_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button txtTipeKendaraan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cbPaket;
    }
}