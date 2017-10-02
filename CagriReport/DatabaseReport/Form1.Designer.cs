namespace CagriReport
{
    partial class FrmRapor
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ToolTipFreePosition toolTipFreePosition1 = new DevExpress.XtraCharts.ToolTipFreePosition();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRapor));
            this.lbl_BitisTarih = new System.Windows.Forms.Label();
            this.lbl_BaslangicTarih = new System.Windows.Forms.Label();
            this.lbl_AcanKullaniciDepartman = new System.Windows.Forms.Label();
            this.lbl_AcanKullaniciAdKod = new System.Windows.Forms.Label();
            this.lbl_IlgilenenYetkili = new System.Windows.Forms.Label();
            this.lbl_CagriKonusu = new System.Windows.Forms.Label();
            this.lbl_CagriDurumu = new System.Windows.Forms.Label();
            this.lbl_CagriMerkezKodu = new System.Windows.Forms.Label();
            this.lbl_GrupKriteri = new System.Windows.Forms.Label();
            this.DxChart2 = new DevExpress.XtraCharts.ChartControl();
            this.DxChart1 = new DevExpress.XtraCharts.ChartControl();
            this.sqlChart = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.dgv_Veriler = new DevExpress.XtraGrid.GridControl();
            this.VVeriler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tlp_Grafikler = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Filtreler = new System.Windows.Forms.TableLayoutPanel();
            this.cb_AcanKullaniciDepartman = new System.Windows.Forms.ComboBox();
            this.cb_AcanKullaniciAdKod = new System.Windows.Forms.ComboBox();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.cb_IlgilenenYetkili = new System.Windows.Forms.ComboBox();
            this.cb_CagriDurumu = new System.Windows.Forms.ComboBox();
            this.btn_Getir = new DevExpress.XtraEditors.SimpleButton();
            this.cb_CagriKonuAd = new System.Windows.Forms.ComboBox();
            this.cb_CagriMerkezKod = new System.Windows.Forms.ComboBox();
            this.btn_Temizle = new DevExpress.XtraEditors.SimpleButton();
            this.tlp_Tarihler = new System.Windows.Forms.TableLayoutPanel();
            this.cb_GrupKriteri = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtp_BitisTarih = new DevExpress.XtraEditors.DateEdit();
            this.dtp_BaslangicTarih = new DevExpress.XtraEditors.DateEdit();
            this.tlp_Sol = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Form = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DxChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DxChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Veriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VVeriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tlp_Grafikler.SuspendLayout();
            this.tlp_Filtreler.SuspendLayout();
            this.tlp_Tarihler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_GrupKriteri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_BitisTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_BitisTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_BaslangicTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_BaslangicTarih.Properties)).BeginInit();
            this.tlp_Sol.SuspendLayout();
            this.tlp_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_BitisTarih
            // 
            this.lbl_BitisTarih.AutoSize = true;
            this.lbl_BitisTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_BitisTarih.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_BitisTarih.Location = new System.Drawing.Point(210, 0);
            this.lbl_BitisTarih.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_BitisTarih.Name = "lbl_BitisTarih";
            this.lbl_BitisTarih.Size = new System.Drawing.Size(210, 15);
            this.lbl_BitisTarih.TabIndex = 9;
            this.lbl_BitisTarih.Text = "Bitiş Tarihi";
            this.lbl_BitisTarih.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_BaslangicTarih
            // 
            this.lbl_BaslangicTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_BaslangicTarih.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BaslangicTarih.Location = new System.Drawing.Point(0, 0);
            this.lbl_BaslangicTarih.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_BaslangicTarih.Name = "lbl_BaslangicTarih";
            this.lbl_BaslangicTarih.Size = new System.Drawing.Size(210, 15);
            this.lbl_BaslangicTarih.TabIndex = 8;
            this.lbl_BaslangicTarih.Text = "Başlangıç Tarihi";
            this.lbl_BaslangicTarih.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_AcanKullaniciDepartman
            // 
            this.lbl_AcanKullaniciDepartman.AutoSize = true;
            this.lbl_AcanKullaniciDepartman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_AcanKullaniciDepartman.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_AcanKullaniciDepartman.Location = new System.Drawing.Point(210, 46);
            this.lbl_AcanKullaniciDepartman.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_AcanKullaniciDepartman.Name = "lbl_AcanKullaniciDepartman";
            this.lbl_AcanKullaniciDepartman.Size = new System.Drawing.Size(105, 23);
            this.lbl_AcanKullaniciDepartman.TabIndex = 23;
            this.lbl_AcanKullaniciDepartman.Text = "Kullanıcı Dept:";
            this.lbl_AcanKullaniciDepartman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_AcanKullaniciAdKod
            // 
            this.lbl_AcanKullaniciAdKod.AutoSize = true;
            this.lbl_AcanKullaniciAdKod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_AcanKullaniciAdKod.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_AcanKullaniciAdKod.Location = new System.Drawing.Point(210, 23);
            this.lbl_AcanKullaniciAdKod.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_AcanKullaniciAdKod.Name = "lbl_AcanKullaniciAdKod";
            this.lbl_AcanKullaniciAdKod.Size = new System.Drawing.Size(105, 23);
            this.lbl_AcanKullaniciAdKod.TabIndex = 21;
            this.lbl_AcanKullaniciAdKod.Text = "Açan Kullanıcı:";
            this.lbl_AcanKullaniciAdKod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_IlgilenenYetkili
            // 
            this.lbl_IlgilenenYetkili.AutoSize = true;
            this.lbl_IlgilenenYetkili.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_IlgilenenYetkili.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_IlgilenenYetkili.Location = new System.Drawing.Point(210, 0);
            this.lbl_IlgilenenYetkili.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_IlgilenenYetkili.Name = "lbl_IlgilenenYetkili";
            this.lbl_IlgilenenYetkili.Size = new System.Drawing.Size(105, 23);
            this.lbl_IlgilenenYetkili.TabIndex = 20;
            this.lbl_IlgilenenYetkili.Text = "İlgilenen Yetkili:";
            this.lbl_IlgilenenYetkili.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_CagriKonusu
            // 
            this.lbl_CagriKonusu.AutoSize = true;
            this.lbl_CagriKonusu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_CagriKonusu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_CagriKonusu.Location = new System.Drawing.Point(0, 23);
            this.lbl_CagriKonusu.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_CagriKonusu.Name = "lbl_CagriKonusu";
            this.lbl_CagriKonusu.Size = new System.Drawing.Size(105, 23);
            this.lbl_CagriKonusu.TabIndex = 18;
            this.lbl_CagriKonusu.Text = "Çağrı Konusu:";
            this.lbl_CagriKonusu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_CagriDurumu
            // 
            this.lbl_CagriDurumu.AutoSize = true;
            this.lbl_CagriDurumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_CagriDurumu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_CagriDurumu.Location = new System.Drawing.Point(0, 46);
            this.lbl_CagriDurumu.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_CagriDurumu.Name = "lbl_CagriDurumu";
            this.lbl_CagriDurumu.Size = new System.Drawing.Size(105, 23);
            this.lbl_CagriDurumu.TabIndex = 19;
            this.lbl_CagriDurumu.Text = "Çağrı Durumu:";
            this.lbl_CagriDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_CagriMerkezKodu
            // 
            this.lbl_CagriMerkezKodu.AutoSize = true;
            this.lbl_CagriMerkezKodu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_CagriMerkezKodu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_CagriMerkezKodu.Location = new System.Drawing.Point(0, 0);
            this.lbl_CagriMerkezKodu.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_CagriMerkezKodu.Name = "lbl_CagriMerkezKodu";
            this.lbl_CagriMerkezKodu.Size = new System.Drawing.Size(105, 23);
            this.lbl_CagriMerkezKodu.TabIndex = 17;
            this.lbl_CagriMerkezKodu.Text = "Çağrı Merkez Kodu:";
            this.lbl_CagriMerkezKodu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_GrupKriteri
            // 
            this.lbl_GrupKriteri.AutoSize = true;
            this.lbl_GrupKriteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_GrupKriteri.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_GrupKriteri.Location = new System.Drawing.Point(420, 0);
            this.lbl_GrupKriteri.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_GrupKriteri.Name = "lbl_GrupKriteri";
            this.lbl_GrupKriteri.Size = new System.Drawing.Size(107, 15);
            this.lbl_GrupKriteri.TabIndex = 16;
            this.lbl_GrupKriteri.Text = "Grup Kriteri:";
            this.lbl_GrupKriteri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DxChart2
            // 
            this.DxChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DxChart2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.DxChart2.Location = new System.Drawing.Point(3, 325);
            this.DxChart2.Name = "DxChart2";
            this.DxChart2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.DxChart2.Size = new System.Drawing.Size(457, 316);
            this.DxChart2.TabIndex = 27;
            chartTitle1.Text = "Sayı";
            this.DxChart2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // DxChart1
            // 
            this.DxChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DxChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.DxChart1.Location = new System.Drawing.Point(3, 3);
            this.DxChart1.Name = "DxChart1";
            this.DxChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.DxChart1.Size = new System.Drawing.Size(457, 316);
            this.DxChart1.TabIndex = 26;
            chartTitle2.Text = "Harcanan Saat";
            this.DxChart1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            this.DxChart1.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.DxChart1.ToolTipOptions.ShowForSeries = true;
            this.DxChart1.ToolTipOptions.ToolTipPosition = toolTipFreePosition1;
            // 
            // sqlChart
            // 
            this.sqlChart.ConnectionName = "BGLSQL01_Cagri_Connection";
            this.sqlChart.Name = "sqlChart";
            customSqlQuery1.Name = "CustomSqlQuery";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlChart.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlChart.ResultSchemaSerializable = resources.GetString("sqlChart.ResultSchemaSerializable");
            // 
            // dgv_Veriler
            // 
            this.dgv_Veriler.DataSource = this.sqlChart;
            this.dgv_Veriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Veriler.Location = new System.Drawing.Point(3, 124);
            this.dgv_Veriler.MainView = this.VVeriler;
            this.dgv_Veriler.Name = "dgv_Veriler";
            this.dgv_Veriler.Size = new System.Drawing.Size(527, 517);
            this.dgv_Veriler.TabIndex = 34;
            this.dgv_Veriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.VVeriler,
            this.gridView1});
            // 
            // VVeriler
            // 
            this.VVeriler.GridControl = this.dgv_Veriler;
            this.VVeriler.Name = "VVeriler";
            this.VVeriler.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.VVeriler.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.VVeriler.OptionsBehavior.Editable = false;
            this.VVeriler.OptionsView.ShowFooter = true;
            this.VVeriler.OptionsView.ShowGroupPanel = false;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgv_Veriler;
            this.gridView1.Name = "gridView1";
            // 
            // tlp_Grafikler
            // 
            this.tlp_Grafikler.AutoSize = true;
            this.tlp_Grafikler.ColumnCount = 1;
            this.tlp_Grafikler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Grafikler.Controls.Add(this.DxChart1, 0, 0);
            this.tlp_Grafikler.Controls.Add(this.DxChart2, 0, 1);
            this.tlp_Grafikler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Grafikler.Location = new System.Drawing.Point(542, 3);
            this.tlp_Grafikler.Name = "tlp_Grafikler";
            this.tlp_Grafikler.RowCount = 2;
            this.tlp_Grafikler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Grafikler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Grafikler.Size = new System.Drawing.Size(463, 644);
            this.tlp_Grafikler.TabIndex = 35;
            // 
            // tlp_Filtreler
            // 
            this.tlp_Filtreler.ColumnCount = 5;
            this.tlp_Filtreler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Filtreler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Filtreler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Filtreler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Filtreler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Filtreler.Controls.Add(this.cb_AcanKullaniciDepartman, 3, 2);
            this.tlp_Filtreler.Controls.Add(this.cb_AcanKullaniciAdKod, 3, 1);
            this.tlp_Filtreler.Controls.Add(this.btn_Kaydet, 4, 2);
            this.tlp_Filtreler.Controls.Add(this.cb_IlgilenenYetkili, 3, 0);
            this.tlp_Filtreler.Controls.Add(this.cb_CagriDurumu, 1, 2);
            this.tlp_Filtreler.Controls.Add(this.btn_Getir, 4, 0);
            this.tlp_Filtreler.Controls.Add(this.cb_CagriKonuAd, 1, 1);
            this.tlp_Filtreler.Controls.Add(this.cb_CagriMerkezKod, 1, 0);
            this.tlp_Filtreler.Controls.Add(this.btn_Temizle, 4, 1);
            this.tlp_Filtreler.Controls.Add(this.lbl_CagriMerkezKodu, 0, 0);
            this.tlp_Filtreler.Controls.Add(this.lbl_CagriKonusu, 0, 1);
            this.tlp_Filtreler.Controls.Add(this.lbl_CagriDurumu, 0, 2);
            this.tlp_Filtreler.Controls.Add(this.lbl_AcanKullaniciDepartman, 2, 2);
            this.tlp_Filtreler.Controls.Add(this.lbl_IlgilenenYetkili, 2, 0);
            this.tlp_Filtreler.Controls.Add(this.lbl_AcanKullaniciAdKod, 2, 1);
            this.tlp_Filtreler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Filtreler.Location = new System.Drawing.Point(3, 49);
            this.tlp_Filtreler.Name = "tlp_Filtreler";
            this.tlp_Filtreler.RowCount = 3;
            this.tlp_Filtreler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Filtreler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Filtreler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Filtreler.Size = new System.Drawing.Size(527, 69);
            this.tlp_Filtreler.TabIndex = 36;
            // 
            // cb_AcanKullaniciDepartman
            // 
            this.cb_AcanKullaniciDepartman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_AcanKullaniciDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AcanKullaniciDepartman.FormattingEnabled = true;
            this.cb_AcanKullaniciDepartman.Location = new System.Drawing.Point(318, 49);
            this.cb_AcanKullaniciDepartman.Name = "cb_AcanKullaniciDepartman";
            this.cb_AcanKullaniciDepartman.Size = new System.Drawing.Size(99, 21);
            this.cb_AcanKullaniciDepartman.TabIndex = 45;
            // 
            // cb_AcanKullaniciAdKod
            // 
            this.cb_AcanKullaniciAdKod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_AcanKullaniciAdKod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AcanKullaniciAdKod.FormattingEnabled = true;
            this.cb_AcanKullaniciAdKod.Location = new System.Drawing.Point(318, 26);
            this.cb_AcanKullaniciAdKod.Name = "cb_AcanKullaniciAdKod";
            this.cb_AcanKullaniciAdKod.Size = new System.Drawing.Size(99, 21);
            this.cb_AcanKullaniciAdKod.TabIndex = 44;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.btn_Kaydet.Appearance.Options.UseFont = true;
            this.btn_Kaydet.AutoSize = true;
            this.btn_Kaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Kaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.Image")));
            this.btn_Kaydet.Location = new System.Drawing.Point(420, 46);
            this.btn_Kaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(107, 23);
            this.btn_Kaydet.TabIndex = 42;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // cb_IlgilenenYetkili
            // 
            this.cb_IlgilenenYetkili.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_IlgilenenYetkili.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_IlgilenenYetkili.FormattingEnabled = true;
            this.cb_IlgilenenYetkili.Location = new System.Drawing.Point(318, 3);
            this.cb_IlgilenenYetkili.Name = "cb_IlgilenenYetkili";
            this.cb_IlgilenenYetkili.Size = new System.Drawing.Size(99, 21);
            this.cb_IlgilenenYetkili.TabIndex = 43;
            // 
            // cb_CagriDurumu
            // 
            this.cb_CagriDurumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_CagriDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CagriDurumu.FormattingEnabled = true;
            this.cb_CagriDurumu.Location = new System.Drawing.Point(108, 49);
            this.cb_CagriDurumu.Name = "cb_CagriDurumu";
            this.cb_CagriDurumu.Size = new System.Drawing.Size(99, 21);
            this.cb_CagriDurumu.TabIndex = 42;
            // 
            // btn_Getir
            // 
            this.btn_Getir.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Getir.Appearance.Options.UseFont = true;
            this.btn_Getir.AutoSize = true;
            this.btn_Getir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Getir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Getir.Image")));
            this.btn_Getir.Location = new System.Drawing.Point(420, 0);
            this.btn_Getir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Getir.Name = "btn_Getir";
            this.btn_Getir.Size = new System.Drawing.Size(107, 23);
            this.btn_Getir.TabIndex = 40;
            this.btn_Getir.Text = "Getir";
            this.btn_Getir.Click += new System.EventHandler(this.btn_Getir_Click);
            // 
            // cb_CagriKonuAd
            // 
            this.cb_CagriKonuAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_CagriKonuAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CagriKonuAd.FormattingEnabled = true;
            this.cb_CagriKonuAd.Location = new System.Drawing.Point(108, 26);
            this.cb_CagriKonuAd.Name = "cb_CagriKonuAd";
            this.cb_CagriKonuAd.Size = new System.Drawing.Size(99, 21);
            this.cb_CagriKonuAd.TabIndex = 41;
            // 
            // cb_CagriMerkezKod
            // 
            this.cb_CagriMerkezKod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_CagriMerkezKod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CagriMerkezKod.FormattingEnabled = true;
            this.cb_CagriMerkezKod.Location = new System.Drawing.Point(108, 3);
            this.cb_CagriMerkezKod.Name = "cb_CagriMerkezKod";
            this.cb_CagriMerkezKod.Size = new System.Drawing.Size(99, 21);
            this.cb_CagriMerkezKod.TabIndex = 40;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.btn_Temizle.Appearance.Options.UseFont = true;
            this.btn_Temizle.AutoSize = true;
            this.btn_Temizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Temizle.Image")));
            this.btn_Temizle.Location = new System.Drawing.Point(420, 23);
            this.btn_Temizle.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(107, 23);
            this.btn_Temizle.TabIndex = 41;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // tlp_Tarihler
            // 
            this.tlp_Tarihler.ColumnCount = 3;
            this.tlp_Tarihler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_Tarihler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_Tarihler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Tarihler.Controls.Add(this.cb_GrupKriteri, 2, 1);
            this.tlp_Tarihler.Controls.Add(this.dtp_BitisTarih, 1, 1);
            this.tlp_Tarihler.Controls.Add(this.lbl_BaslangicTarih, 0, 0);
            this.tlp_Tarihler.Controls.Add(this.dtp_BaslangicTarih, 0, 1);
            this.tlp_Tarihler.Controls.Add(this.lbl_BitisTarih, 1, 0);
            this.tlp_Tarihler.Controls.Add(this.lbl_GrupKriteri, 2, 0);
            this.tlp_Tarihler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Tarihler.Location = new System.Drawing.Point(3, 3);
            this.tlp_Tarihler.Name = "tlp_Tarihler";
            this.tlp_Tarihler.RowCount = 2;
            this.tlp_Tarihler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tlp_Tarihler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61F));
            this.tlp_Tarihler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Tarihler.Size = new System.Drawing.Size(527, 40);
            this.tlp_Tarihler.TabIndex = 37;
            // 
            // cb_GrupKriteri
            // 
            this.cb_GrupKriteri.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_GrupKriteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_GrupKriteri.Location = new System.Drawing.Point(423, 18);
            this.cb_GrupKriteri.Name = "cb_GrupKriteri";
            this.cb_GrupKriteri.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.cb_GrupKriteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_GrupKriteri.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.cb_GrupKriteri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cb_GrupKriteri.Size = new System.Drawing.Size(101, 20);
            this.cb_GrupKriteri.TabIndex = 40;
            // 
            // dtp_BitisTarih
            // 
            this.dtp_BitisTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_BitisTarih.EditValue = null;
            this.dtp_BitisTarih.Location = new System.Drawing.Point(213, 18);
            this.dtp_BitisTarih.Name = "dtp_BitisTarih";
            this.dtp_BitisTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_BitisTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_BitisTarih.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtp_BitisTarih.Properties.Mask.EditMask = "D";
            this.dtp_BitisTarih.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtp_BitisTarih.Size = new System.Drawing.Size(204, 20);
            this.dtp_BitisTarih.TabIndex = 41;
            // 
            // dtp_BaslangicTarih
            // 
            this.dtp_BaslangicTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_BaslangicTarih.EditValue = null;
            this.dtp_BaslangicTarih.Location = new System.Drawing.Point(3, 18);
            this.dtp_BaslangicTarih.Name = "dtp_BaslangicTarih";
            this.dtp_BaslangicTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_BaslangicTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_BaslangicTarih.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtp_BaslangicTarih.Properties.Mask.EditMask = "D";
            this.dtp_BaslangicTarih.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtp_BaslangicTarih.Size = new System.Drawing.Size(204, 20);
            this.dtp_BaslangicTarih.TabIndex = 40;
            // 
            // tlp_Sol
            // 
            this.tlp_Sol.ColumnCount = 1;
            this.tlp_Sol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Sol.Controls.Add(this.dgv_Veriler, 0, 2);
            this.tlp_Sol.Controls.Add(this.tlp_Filtreler, 0, 1);
            this.tlp_Sol.Controls.Add(this.tlp_Tarihler, 0, 0);
            this.tlp_Sol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Sol.Location = new System.Drawing.Point(3, 3);
            this.tlp_Sol.Name = "tlp_Sol";
            this.tlp_Sol.RowCount = 3;
            this.tlp_Sol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.149342F));
            this.tlp_Sol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.68521F));
            this.tlp_Sol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.16544F));
            this.tlp_Sol.Size = new System.Drawing.Size(533, 644);
            this.tlp_Sol.TabIndex = 38;
            // 
            // tlp_Form
            // 
            this.tlp_Form.ColumnCount = 2;
            this.tlp_Form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.5F));
            this.tlp_Form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.5F));
            this.tlp_Form.Controls.Add(this.tlp_Grafikler, 1, 0);
            this.tlp_Form.Controls.Add(this.tlp_Sol, 0, 0);
            this.tlp_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Form.Location = new System.Drawing.Point(0, 0);
            this.tlp_Form.Name = "tlp_Form";
            this.tlp_Form.RowCount = 1;
            this.tlp_Form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Form.Size = new System.Drawing.Size(1008, 650);
            this.tlp_Form.TabIndex = 39;
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 650);
            this.Controls.Add(this.tlp_Form);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı Raporlama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DxChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DxChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Veriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VVeriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tlp_Grafikler.ResumeLayout(false);
            this.tlp_Filtreler.ResumeLayout(false);
            this.tlp_Filtreler.PerformLayout();
            this.tlp_Tarihler.ResumeLayout(false);
            this.tlp_Tarihler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_GrupKriteri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_BitisTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_BitisTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_BaslangicTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_BaslangicTarih.Properties)).EndInit();
            this.tlp_Sol.ResumeLayout(false);
            this.tlp_Form.ResumeLayout(false);
            this.tlp_Form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_BitisTarih;
        private System.Windows.Forms.Label lbl_BaslangicTarih;
        private System.Windows.Forms.Label lbl_AcanKullaniciDepartman;
        private System.Windows.Forms.Label lbl_AcanKullaniciAdKod;
        private System.Windows.Forms.Label lbl_IlgilenenYetkili;
        private System.Windows.Forms.Label lbl_CagriKonusu;
        private System.Windows.Forms.Label lbl_CagriDurumu;
        private System.Windows.Forms.Label lbl_CagriMerkezKodu;
        private System.Windows.Forms.Label lbl_GrupKriteri;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlChart;
        private DevExpress.XtraCharts.ChartControl DxChart1;
        private DevExpress.XtraCharts.ChartControl DxChart2;
        private DevExpress.XtraGrid.GridControl dgv_Veriler;
        private DevExpress.XtraGrid.Views.Grid.GridView VVeriler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tlp_Grafikler;
        private System.Windows.Forms.TableLayoutPanel tlp_Filtreler;
        private System.Windows.Forms.TableLayoutPanel tlp_Tarihler;
        private System.Windows.Forms.TableLayoutPanel tlp_Sol;
        private System.Windows.Forms.TableLayoutPanel tlp_Form;
        private DevExpress.XtraEditors.SimpleButton btn_Getir;
        private DevExpress.XtraEditors.SimpleButton btn_Temizle;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private DevExpress.XtraEditors.DateEdit dtp_BaslangicTarih;
        private DevExpress.XtraEditors.DateEdit dtp_BitisTarih;
        private DevExpress.XtraEditors.ComboBoxEdit cb_GrupKriteri;
        private System.Windows.Forms.ComboBox cb_AcanKullaniciDepartman;
        private System.Windows.Forms.ComboBox cb_AcanKullaniciAdKod;
        private System.Windows.Forms.ComboBox cb_IlgilenenYetkili;
        private System.Windows.Forms.ComboBox cb_CagriDurumu;
        private System.Windows.Forms.ComboBox cb_CagriKonuAd;
        private System.Windows.Forms.ComboBox cb_CagriMerkezKod;
    }
}

