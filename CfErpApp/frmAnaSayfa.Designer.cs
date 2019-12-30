namespace CfErpApp
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.pnlUst = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDolar = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnAdminIslemleri = new System.Windows.Forms.Button();
            this.btnFaturaIslemleri = new System.Windows.Forms.Button();
            this.btnDepoIslemleri = new System.Windows.Forms.Button();
            this.btnUrunIslemleri = new System.Windows.Forms.Button();
            this.btnBilgiGiris = new System.Windows.Forms.Button();
            this.gbLeft = new System.Windows.Forms.GroupBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnUrunGiris = new System.Windows.Forms.Button();
            this.btnCariGiris = new System.Windows.Forms.Button();
            this.btnPersonelGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMiddle1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.btnUrunSatisListe = new System.Windows.Forms.Button();
            this.btnUrunSatis = new System.Windows.Forms.Button();
            this.btnUrunAlisListe = new System.Windows.Forms.Button();
            this.btnUrunAlis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUst.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbLeft.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlMiddle1.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.pnlUst.Controls.Add(this.panel1);
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Controls.Add(this.btnAdminIslemleri);
            this.pnlUst.Controls.Add(this.btnFaturaIslemleri);
            this.pnlUst.Controls.Add(this.btnDepoIslemleri);
            this.pnlUst.Controls.Add(this.btnUrunIslemleri);
            this.pnlUst.Controls.Add(this.btnBilgiGiris);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1029, 65);
            this.pnlUst.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.txtDolar);
            this.panel1.Controls.Add(this.txtEuro);
            this.panel1.Location = new System.Drawing.Point(724, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 47);
            this.panel1.TabIndex = 1;
            // 
            // txtDolar
            // 
            this.txtDolar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtDolar.Location = new System.Drawing.Point(104, 7);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(77, 33);
            this.txtDolar.TabIndex = 0;
            this.txtDolar.Text = "$";
            this.txtDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEuro
            // 
            this.txtEuro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEuro.ForeColor = System.Drawing.Color.Red;
            this.txtEuro.Location = new System.Drawing.Point(12, 7);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(77, 33);
            this.txtEuro.TabIndex = 0;
            this.txtEuro.Text = "€";
            this.txtEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnKapat.BackgroundImage = global::CfErpApp.Properties.Resources.off;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(938, 6);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(54, 47);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAdminIslemleri
            // 
            this.btnAdminIslemleri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdminIslemleri.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminIslemleri.ForeColor = System.Drawing.Color.Navy;
            this.btnAdminIslemleri.Image = global::CfErpApp.Properties.Resources.profile;
            this.btnAdminIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminIslemleri.Location = new System.Drawing.Point(560, 6);
            this.btnAdminIslemleri.Name = "btnAdminIslemleri";
            this.btnAdminIslemleri.Size = new System.Drawing.Size(131, 47);
            this.btnAdminIslemleri.TabIndex = 0;
            this.btnAdminIslemleri.Text = "Admin İşlemleri";
            this.btnAdminIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminIslemleri.UseVisualStyleBackColor = false;
            this.btnAdminIslemleri.Click += new System.EventHandler(this.btnAdminIslemleri_Click);
            // 
            // btnFaturaIslemleri
            // 
            this.btnFaturaIslemleri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFaturaIslemleri.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaIslemleri.ForeColor = System.Drawing.Color.Navy;
            this.btnFaturaIslemleri.Image = global::CfErpApp.Properties.Resources.invoice;
            this.btnFaturaIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturaIslemleri.Location = new System.Drawing.Point(423, 6);
            this.btnFaturaIslemleri.Name = "btnFaturaIslemleri";
            this.btnFaturaIslemleri.Size = new System.Drawing.Size(131, 47);
            this.btnFaturaIslemleri.TabIndex = 0;
            this.btnFaturaIslemleri.Text = "Fatura İşlemleri";
            this.btnFaturaIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFaturaIslemleri.UseVisualStyleBackColor = false;
            this.btnFaturaIslemleri.Click += new System.EventHandler(this.btnFaturaIslemleri_Click);
            // 
            // btnDepoIslemleri
            // 
            this.btnDepoIslemleri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDepoIslemleri.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepoIslemleri.ForeColor = System.Drawing.Color.Teal;
            this.btnDepoIslemleri.Image = global::CfErpApp.Properties.Resources.storage;
            this.btnDepoIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepoIslemleri.Location = new System.Drawing.Point(286, 6);
            this.btnDepoIslemleri.Name = "btnDepoIslemleri";
            this.btnDepoIslemleri.Size = new System.Drawing.Size(131, 47);
            this.btnDepoIslemleri.TabIndex = 0;
            this.btnDepoIslemleri.Text = "Depo İşlemleri";
            this.btnDepoIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepoIslemleri.UseVisualStyleBackColor = false;
            this.btnDepoIslemleri.Click += new System.EventHandler(this.btnDepoIslemleri_Click);
            // 
            // btnUrunIslemleri
            // 
            this.btnUrunIslemleri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUrunIslemleri.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunIslemleri.ForeColor = System.Drawing.Color.Green;
            this.btnUrunIslemleri.Image = global::CfErpApp.Properties.Resources.factory;
            this.btnUrunIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunIslemleri.Location = new System.Drawing.Point(149, 6);
            this.btnUrunIslemleri.Name = "btnUrunIslemleri";
            this.btnUrunIslemleri.Size = new System.Drawing.Size(131, 47);
            this.btnUrunIslemleri.TabIndex = 0;
            this.btnUrunIslemleri.Text = "Ürün İşlemleri";
            this.btnUrunIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunIslemleri.UseVisualStyleBackColor = false;
            this.btnUrunIslemleri.Click += new System.EventHandler(this.btnUrunIslemleri_Click);
            // 
            // btnBilgiGiris
            // 
            this.btnBilgiGiris.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBilgiGiris.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiGiris.ForeColor = System.Drawing.Color.Maroon;
            this.btnBilgiGiris.Image = global::CfErpApp.Properties.Resources.content;
            this.btnBilgiGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilgiGiris.Location = new System.Drawing.Point(12, 6);
            this.btnBilgiGiris.Name = "btnBilgiGiris";
            this.btnBilgiGiris.Size = new System.Drawing.Size(131, 47);
            this.btnBilgiGiris.TabIndex = 0;
            this.btnBilgiGiris.Text = "Bilgi Giriş";
            this.btnBilgiGiris.UseVisualStyleBackColor = false;
            this.btnBilgiGiris.Click += new System.EventHandler(this.btnBilgiGiris_Click);
            // 
            // gbLeft
            // 
            this.gbLeft.BackColor = System.Drawing.Color.DarkGray;
            this.gbLeft.Controls.Add(this.pnlLeft);
            this.gbLeft.Controls.Add(this.pnlRight);
            this.gbLeft.Controls.Add(this.pnlMiddle1);
            this.gbLeft.Controls.Add(this.pnlMiddle);
            this.gbLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbLeft.Location = new System.Drawing.Point(0, 65);
            this.gbLeft.Name = "gbLeft";
            this.gbLeft.Size = new System.Drawing.Size(166, 429);
            this.gbLeft.TabIndex = 1;
            this.gbLeft.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Silver;
            this.pnlLeft.Controls.Add(this.btnUrunGiris);
            this.pnlLeft.Controls.Add(this.btnCariGiris);
            this.pnlLeft.Controls.Add(this.btnPersonelGiris);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(495, 16);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(164, 410);
            this.pnlLeft.TabIndex = 0;
            this.pnlLeft.Visible = false;
            // 
            // btnUrunGiris
            // 
            this.btnUrunGiris.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUrunGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGiris.ForeColor = System.Drawing.Color.Maroon;
            this.btnUrunGiris.Image = global::CfErpApp.Properties.Resources.checklist;
            this.btnUrunGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunGiris.Location = new System.Drawing.Point(9, 175);
            this.btnUrunGiris.Name = "btnUrunGiris";
            this.btnUrunGiris.Size = new System.Drawing.Size(148, 52);
            this.btnUrunGiris.TabIndex = 2;
            this.btnUrunGiris.Text = "Ürün Giriş";
            this.btnUrunGiris.UseVisualStyleBackColor = false;
            this.btnUrunGiris.Click += new System.EventHandler(this.btnUrunGiris_Click);
            // 
            // btnCariGiris
            // 
            this.btnCariGiris.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCariGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariGiris.ForeColor = System.Drawing.Color.Maroon;
            this.btnCariGiris.Image = global::CfErpApp.Properties.Resources.factorycar;
            this.btnCariGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCariGiris.Location = new System.Drawing.Point(9, 105);
            this.btnCariGiris.Name = "btnCariGiris";
            this.btnCariGiris.Size = new System.Drawing.Size(148, 52);
            this.btnCariGiris.TabIndex = 2;
            this.btnCariGiris.Text = "Cari Giriş";
            this.btnCariGiris.UseVisualStyleBackColor = false;
            this.btnCariGiris.Click += new System.EventHandler(this.btnCariGiris_Click);
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPersonelGiris.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGiris.ForeColor = System.Drawing.Color.Maroon;
            this.btnPersonelGiris.Image = global::CfErpApp.Properties.Resources.profile;
            this.btnPersonelGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelGiris.Location = new System.Drawing.Point(9, 36);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(148, 52);
            this.btnPersonelGiris.TabIndex = 1;
            this.btnPersonelGiris.Text = "Personel Giriş";
            this.btnPersonelGiris.UseVisualStyleBackColor = false;
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgi Girişi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Silver;
            this.pnlRight.Controls.Add(this.label3);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRight.Location = new System.Drawing.Point(331, 16);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(164, 410);
            this.pnlRight.TabIndex = 0;
            this.pnlRight.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Depo İşlemleri";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMiddle1
            // 
            this.pnlMiddle1.BackColor = System.Drawing.Color.Silver;
            this.pnlMiddle1.Controls.Add(this.label4);
            this.pnlMiddle1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMiddle1.Location = new System.Drawing.Point(167, 16);
            this.pnlMiddle1.Name = "pnlMiddle1";
            this.pnlMiddle1.Size = new System.Drawing.Size(164, 410);
            this.pnlMiddle1.TabIndex = 1;
            this.pnlMiddle1.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fatura İşlemleri";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.Silver;
            this.pnlMiddle.Controls.Add(this.btnUrunSatisListe);
            this.pnlMiddle.Controls.Add(this.btnUrunSatis);
            this.pnlMiddle.Controls.Add(this.btnUrunAlisListe);
            this.pnlMiddle.Controls.Add(this.btnUrunAlis);
            this.pnlMiddle.Controls.Add(this.label2);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMiddle.Location = new System.Drawing.Point(3, 16);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(164, 410);
            this.pnlMiddle.TabIndex = 0;
            this.pnlMiddle.Visible = false;
            // 
            // btnUrunSatisListe
            // 
            this.btnUrunSatisListe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUrunSatisListe.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSatisListe.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUrunSatisListe.Image = global::CfErpApp.Properties.Resources.listtt;
            this.btnUrunSatisListe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunSatisListe.Location = new System.Drawing.Point(10, 174);
            this.btnUrunSatisListe.Name = "btnUrunSatisListe";
            this.btnUrunSatisListe.Size = new System.Drawing.Size(147, 41);
            this.btnUrunSatisListe.TabIndex = 1;
            this.btnUrunSatisListe.Text = "Satış Listesi";
            this.btnUrunSatisListe.UseVisualStyleBackColor = false;
            this.btnUrunSatisListe.Click += new System.EventHandler(this.btnUrunSatisListe_Click);
            // 
            // btnUrunSatis
            // 
            this.btnUrunSatis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUrunSatis.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSatis.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUrunSatis.Image = global::CfErpApp.Properties.Resources.productss;
            this.btnUrunSatis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunSatis.Location = new System.Drawing.Point(10, 128);
            this.btnUrunSatis.Name = "btnUrunSatis";
            this.btnUrunSatis.Size = new System.Drawing.Size(147, 41);
            this.btnUrunSatis.TabIndex = 1;
            this.btnUrunSatis.Text = "Ürün Satış";
            this.btnUrunSatis.UseVisualStyleBackColor = false;
            this.btnUrunSatis.Click += new System.EventHandler(this.btnUrunSatis_Click);
            // 
            // btnUrunAlisListe
            // 
            this.btnUrunAlisListe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUrunAlisListe.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunAlisListe.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUrunAlisListe.Image = global::CfErpApp.Properties.Resources.checklist1;
            this.btnUrunAlisListe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunAlisListe.Location = new System.Drawing.Point(10, 82);
            this.btnUrunAlisListe.Name = "btnUrunAlisListe";
            this.btnUrunAlisListe.Size = new System.Drawing.Size(147, 41);
            this.btnUrunAlisListe.TabIndex = 1;
            this.btnUrunAlisListe.Text = "Alış Listesi";
            this.btnUrunAlisListe.UseVisualStyleBackColor = false;
            this.btnUrunAlisListe.Click += new System.EventHandler(this.btnUrunAlisListe_Click);
            // 
            // btnUrunAlis
            // 
            this.btnUrunAlis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUrunAlis.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunAlis.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUrunAlis.Image = global::CfErpApp.Properties.Resources.shopping_bag;
            this.btnUrunAlis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunAlis.Location = new System.Drawing.Point(10, 36);
            this.btnUrunAlis.Name = "btnUrunAlis";
            this.btnUrunAlis.Size = new System.Drawing.Size(147, 41);
            this.btnUrunAlis.TabIndex = 1;
            this.btnUrunAlis.Text = "Ürün Alış";
            this.btnUrunAlis.UseVisualStyleBackColor = false;
            this.btnUrunAlis.Click += new System.EventHandler(this.btnUrunAlis_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün İşlemleri";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1029, 494);
            this.Controls.Add(this.gbLeft);
            this.Controls.Add(this.pnlUst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmAnaSayfa";
            this.Text = "frmAnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnaSayfa_FormClosing);
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.pnlUst.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbLeft.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlMiddle1.ResumeLayout(false);
            this.pnlMiddle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnFaturaIslemleri;
        private System.Windows.Forms.Button btnDepoIslemleri;
        private System.Windows.Forms.Button btnUrunIslemleri;
        private System.Windows.Forms.Button btnBilgiGiris;
        private System.Windows.Forms.GroupBox gbLeft;
        private System.Windows.Forms.Panel pnlMiddle1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPersonelGiris;
        private System.Windows.Forms.Button btnCariGiris;
        private System.Windows.Forms.Button btnUrunGiris;
        private System.Windows.Forms.Button btnUrunSatisListe;
        private System.Windows.Forms.Button btnUrunSatis;
        private System.Windows.Forms.Button btnUrunAlisListe;
        private System.Windows.Forms.Button btnUrunAlis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtDolar;
        private System.Windows.Forms.Label txtEuro;
        private System.Windows.Forms.Button btnAdminIslemleri;
    }
}