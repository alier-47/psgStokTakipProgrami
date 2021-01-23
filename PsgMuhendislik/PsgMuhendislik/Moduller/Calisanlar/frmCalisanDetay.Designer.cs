namespace PsgMuhendislik.Moduller.Calisanlar
{
    partial class frmCalisanDetay
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalisanDetay));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCalisanDetay = new DevExpress.XtraGrid.GridControl();
            this.gridViewCalisanDetay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AlacakTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OdenenTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button_edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.button_delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSil = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.CalisanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OdemeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblMaas = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.lblKalan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblYapilanOdemeTutari = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcele_Aktar = new DevExpress.XtraEditors.SimpleButton();
            this.btnPDFe_Aktar = new DevExpress.XtraEditors.SimpleButton();
            this.lblCalisanAdi = new System.Windows.Forms.Label();
            this.lblCalisan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCalisanDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCalisanDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCalisanDetay;
            this.gridView1.Name = "gridView1";
            // 
            // grdCalisanDetay
            // 
            this.grdCalisanDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCalisanDetay.Location = new System.Drawing.Point(0, 0);
            this.grdCalisanDetay.MainView = this.gridViewCalisanDetay;
            this.grdCalisanDetay.Name = "grdCalisanDetay";
            this.grdCalisanDetay.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSil,
            this.Edit});
            this.grdCalisanDetay.Size = new System.Drawing.Size(713, 235);
            this.grdCalisanDetay.TabIndex = 4;
            this.grdCalisanDetay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCalisanDetay,
            this.gridView2,
            this.gridView1});
            // 
            // gridViewCalisanDetay
            // 
            this.gridViewCalisanDetay.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewCalisanDetay.Appearance.Row.Options.UseBackColor = true;
            this.gridViewCalisanDetay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AlacakTutar,
            this.OdenenTutar,
            this.Tarih,
            this.Aciklama,
            this.button_edit,
            this.button_delete,
            this.CalisanID,
            this.OdemeId});
            this.gridViewCalisanDetay.GridControl = this.grdCalisanDetay;
            this.gridViewCalisanDetay.GroupRowHeight = 1;
            this.gridViewCalisanDetay.Name = "gridViewCalisanDetay";
            this.gridViewCalisanDetay.OptionsView.RowAutoHeight = true;
            this.gridViewCalisanDetay.RowHeight = 0;
            this.gridViewCalisanDetay.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewCalisanDetay_RowStyle);
            // 
            // AlacakTutar
            // 
            this.AlacakTutar.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.AlacakTutar.AppearanceCell.Options.UseFont = true;
            this.AlacakTutar.AppearanceCell.Options.UseTextOptions = true;
            this.AlacakTutar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AlacakTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.AlacakTutar.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AlacakTutar.AppearanceHeader.Options.UseFont = true;
            this.AlacakTutar.AppearanceHeader.Options.UseForeColor = true;
            this.AlacakTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.AlacakTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AlacakTutar.Caption = "Bakiye";
            this.AlacakTutar.DisplayFormat.FormatString = "c2";
            this.AlacakTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.AlacakTutar.FieldName = "AlacakTutar";
            this.AlacakTutar.Name = "AlacakTutar";
            this.AlacakTutar.OptionsColumn.AllowMove = false;
            this.AlacakTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.AlacakTutar.Visible = true;
            this.AlacakTutar.VisibleIndex = 0;
            this.AlacakTutar.Width = 160;
            // 
            // OdenenTutar
            // 
            this.OdenenTutar.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.OdenenTutar.AppearanceCell.Options.UseFont = true;
            this.OdenenTutar.AppearanceCell.Options.UseTextOptions = true;
            this.OdenenTutar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.OdenenTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.OdenenTutar.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.OdenenTutar.AppearanceHeader.Options.UseFont = true;
            this.OdenenTutar.AppearanceHeader.Options.UseForeColor = true;
            this.OdenenTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.OdenenTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.OdenenTutar.Caption = "Ödenen Tutar";
            this.OdenenTutar.DisplayFormat.FormatString = "c2";
            this.OdenenTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.OdenenTutar.FieldName = "OdenenTutar";
            this.OdenenTutar.Name = "OdenenTutar";
            this.OdenenTutar.Visible = true;
            this.OdenenTutar.VisibleIndex = 1;
            this.OdenenTutar.Width = 160;
            // 
            // Tarih
            // 
            this.Tarih.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Tarih.AppearanceCell.Options.UseFont = true;
            this.Tarih.AppearanceCell.Options.UseTextOptions = true;
            this.Tarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Tarih.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Tarih.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Tarih.AppearanceHeader.Options.UseFont = true;
            this.Tarih.AppearanceHeader.Options.UseForeColor = true;
            this.Tarih.AppearanceHeader.Options.UseTextOptions = true;
            this.Tarih.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Tarih.Caption = "Tarih";
            this.Tarih.FieldName = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 2;
            this.Tarih.Width = 160;
            // 
            // Aciklama
            // 
            this.Aciklama.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Aciklama.AppearanceCell.Options.UseFont = true;
            this.Aciklama.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Aciklama.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Aciklama.AppearanceHeader.Options.UseFont = true;
            this.Aciklama.AppearanceHeader.Options.UseForeColor = true;
            this.Aciklama.AppearanceHeader.Options.UseTextOptions = true;
            this.Aciklama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Aciklama.Caption = "Açıklama";
            this.Aciklama.FieldName = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Visible = true;
            this.Aciklama.VisibleIndex = 3;
            this.Aciklama.Width = 160;
            // 
            // button_edit
            // 
            this.button_edit.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button_edit.AppearanceCell.Options.UseFont = true;
            this.button_edit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.button_edit.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_edit.AppearanceHeader.Options.UseFont = true;
            this.button_edit.AppearanceHeader.Options.UseForeColor = true;
            this.button_edit.Caption = "Düzenle";
            this.button_edit.ColumnEdit = this.Edit;
            this.button_edit.Name = "button_edit";
            this.button_edit.Visible = true;
            this.button_edit.VisibleIndex = 4;
            this.button_edit.Width = 37;
            // 
            // Edit
            // 
            this.Edit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.Edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.Edit.Name = "Edit";
            this.Edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.Edit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Edit_ButtonClick);
            // 
            // button_delete
            // 
            this.button_delete.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button_delete.AppearanceCell.Options.UseFont = true;
            this.button_delete.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.button_delete.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_delete.AppearanceHeader.Options.UseFont = true;
            this.button_delete.AppearanceHeader.Options.UseForeColor = true;
            this.button_delete.AppearanceHeader.Options.UseTextOptions = true;
            this.button_delete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.button_delete.Caption = "Sil";
            this.button_delete.ColumnEdit = this.btnSil;
            this.button_delete.Name = "button_delete";
            this.button_delete.OptionsColumn.FixedWidth = true;
            this.button_delete.Visible = true;
            this.button_delete.VisibleIndex = 5;
            this.button_delete.Width = 40;
            // 
            // btnSil
            // 
            this.btnSil.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnSil.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSil.Name = "btnSil";
            this.btnSil.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSil.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSil_ButtonClick);
            // 
            // CalisanID
            // 
            this.CalisanID.Caption = "Çalışan ID";
            this.CalisanID.FieldName = "CalisanID";
            this.CalisanID.Name = "CalisanID";
            // 
            // OdemeId
            // 
            this.OdemeId.Caption = "OdemeId";
            this.OdemeId.FieldName = "OdemeId";
            this.OdemeId.Name = "OdemeId";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdCalisanDetay;
            this.gridView2.Name = "gridView2";
            // 
            // lblMaas
            // 
            this.lblMaas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaas.ForeColor = System.Drawing.Color.Green;
            this.lblMaas.Location = new System.Drawing.Point(143, 17);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(87, 14);
            this.lblMaas.TabIndex = 0;
            this.lblMaas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.separatorControl1);
            this.groupControl2.Controls.Add(this.lblKalan);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.lblYapilanOdemeTutari);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.lblMaas);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 266);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(713, 101);
            this.groupControl2.TabIndex = 5;
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.Location = new System.Drawing.Point(13, 55);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(227, 19);
            this.separatorControl1.TabIndex = 1;
            // 
            // lblKalan
            // 
            this.lblKalan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblKalan.ForeColor = System.Drawing.Color.Green;
            this.lblKalan.Location = new System.Drawing.Point(143, 75);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(87, 14);
            this.lblKalan.TabIndex = 0;
            this.lblKalan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(83, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kalan";
            // 
            // lblYapilanOdemeTutari
            // 
            this.lblYapilanOdemeTutari.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblYapilanOdemeTutari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblYapilanOdemeTutari.Location = new System.Drawing.Point(143, 40);
            this.lblYapilanOdemeTutari.Name = "lblYapilanOdemeTutari";
            this.lblYapilanOdemeTutari.Size = new System.Drawing.Size(87, 14);
            this.lblYapilanOdemeTutari.TabIndex = 0;
            this.lblYapilanOdemeTutari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yapılan Ödeme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(83, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maaş";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcele_Aktar);
            this.panel1.Controls.Add(this.btnPDFe_Aktar);
            this.panel1.Controls.Add(this.lblCalisanAdi);
            this.panel1.Controls.Add(this.lblCalisan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 31);
            this.panel1.TabIndex = 6;
            // 
            // btnExcele_Aktar
            // 
            this.btnExcele_Aktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcele_Aktar.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnExcele_Aktar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExcele_Aktar.Appearance.Options.UseBackColor = true;
            this.btnExcele_Aktar.Appearance.Options.UseFont = true;
            this.btnExcele_Aktar.Location = new System.Drawing.Point(526, 3);
            this.btnExcele_Aktar.Name = "btnExcele_Aktar";
            this.btnExcele_Aktar.Size = new System.Drawing.Size(89, 24);
            this.btnExcele_Aktar.TabIndex = 7;
            this.btnExcele_Aktar.Text = "Exel\'e Aktar";
            this.btnExcele_Aktar.Click += new System.EventHandler(this.btnExcele_Aktar_Click);
            // 
            // btnPDFe_Aktar
            // 
            this.btnPDFe_Aktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDFe_Aktar.Appearance.BackColor = System.Drawing.Color.Firebrick;
            this.btnPDFe_Aktar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPDFe_Aktar.Appearance.Options.UseBackColor = true;
            this.btnPDFe_Aktar.Appearance.Options.UseFont = true;
            this.btnPDFe_Aktar.Location = new System.Drawing.Point(621, 3);
            this.btnPDFe_Aktar.Name = "btnPDFe_Aktar";
            this.btnPDFe_Aktar.Size = new System.Drawing.Size(89, 24);
            this.btnPDFe_Aktar.TabIndex = 6;
            this.btnPDFe_Aktar.Text = "PDF\'e Aktar";
            this.btnPDFe_Aktar.Click += new System.EventHandler(this.btnPDFe_Aktar_Click);
            // 
            // lblCalisanAdi
            // 
            this.lblCalisanAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalisanAdi.AutoSize = true;
            this.lblCalisanAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCalisanAdi.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCalisanAdi.ForeColor = System.Drawing.Color.White;
            this.lblCalisanAdi.Location = new System.Drawing.Point(92, 7);
            this.lblCalisanAdi.Name = "lblCalisanAdi";
            this.lblCalisanAdi.Padding = new System.Windows.Forms.Padding(2);
            this.lblCalisanAdi.Size = new System.Drawing.Size(84, 21);
            this.lblCalisanAdi.TabIndex = 0;
            this.lblCalisanAdi.Text = "Çalışan Adı :";
            this.lblCalisanAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCalisan
            // 
            this.lblCalisan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalisan.AutoSize = true;
            this.lblCalisan.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCalisan.Location = new System.Drawing.Point(7, 9);
            this.lblCalisan.Name = "lblCalisan";
            this.lblCalisan.Size = new System.Drawing.Size(80, 17);
            this.lblCalisan.TabIndex = 0;
            this.lblCalisan.Text = "Çalışan Adı :";
            this.lblCalisan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdCalisanDetay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 235);
            this.panel2.TabIndex = 7;
            // 
            // frmCalisanDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 367);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl2);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmCalisanDetay.IconOptions.SvgImage")));
            this.Name = "frmCalisanDetay";
            this.Text = "Çalışan Detay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCalisanDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCalisanDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCalisanDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl grdCalisanDetay;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewCalisanDetay;
        private DevExpress.XtraGrid.Columns.GridColumn AlacakTutar;
        private DevExpress.XtraGrid.Columns.GridColumn OdenenTutar;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn button_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Edit;
        private DevExpress.XtraGrid.Columns.GridColumn button_delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSil;
        private DevExpress.XtraGrid.Columns.GridColumn CalisanID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label lblMaas;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblYapilanOdemeTutari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCalisan;
        public System.Windows.Forms.Label lblCalisanAdi;
        private DevExpress.XtraGrid.Columns.GridColumn OdemeId;
        private DevExpress.XtraEditors.SimpleButton btnExcele_Aktar;
        private DevExpress.XtraEditors.SimpleButton btnPDFe_Aktar;
    }
}