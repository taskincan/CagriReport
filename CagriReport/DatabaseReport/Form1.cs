using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;

namespace CagriReport
{
    public partial class FrmRapor : Form
    {
        SqlConnection connection = new SqlConnection("data source = ITOE07PC0000111\\SQLEXPRESS12; integrated security = true; Initial catalog = Cagri");
        public FrmRapor()
        {
            InitializeComponent();
        }
        //Form yüklendiği anda comboboxlar dolduruluyor
        private void FrmRapor_Load(object sender, EventArgs e)
        {
            dtp_BaslangicTarih.EditValue = DateTime.Today.AddYears(-1);
            dtp_BitisTarih.EditValue = DateTime.Today;
            OpenConnection();
            DoldurGrupKriteri();
            DoldurCagriMerkezKod();
            DoldurCagriKonuAd();
            DoldurCagriDurumu();
            DoldurIlgilenenYetkili();
            DoldurAcanKullaniciAdKod();
            DoldurAcanKullaniciDepartman();
            GizleChart();
            CloseConnection();
        }

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            DoldurVeriler();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_Veriler.DataSource = null;
                cb_AcanKullaniciAdKod.SelectedIndex = cb_AcanKullaniciAdKod.FindStringExact("");
                cb_AcanKullaniciDepartman.SelectedIndex = cb_AcanKullaniciDepartman.FindStringExact("");
                cb_CagriDurumu.SelectedIndex = cb_CagriDurumu.FindStringExact("");
                cb_CagriMerkezKod.SelectedIndex = cb_CagriMerkezKod.FindStringExact("");
                cb_CagriKonuAd.SelectedIndex = cb_CagriKonuAd.FindStringExact("");
                cb_GrupKriteri.SelectedIndex = 0;
                cb_IlgilenenYetkili.SelectedIndex = cb_IlgilenenYetkili.FindStringExact("");
                dtp_BaslangicTarih.EditValue = DateTime.Today.AddYears(-1);
                dtp_BitisTarih.EditValue = DateTime.Today;
                GizleChart();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private class GrupKriteriItems
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void DoldurGrupKriteri()
        {
            List<GrupKriteriItems> kriterListe = new List<GrupKriteriItems>();

            kriterListe.Add(new GrupKriteriItems { Text = "Çağrı Merkezi", Value = 0 });
            kriterListe.Add(new GrupKriteriItems { Text = "İlgilenen Yetkili", Value = 1 });
            kriterListe.Add(new GrupKriteriItems { Text = "Çağrı Konusu", Value = 2 });
            kriterListe.Add(new GrupKriteriItems { Text = "Açan Kullanıcı", Value = 3 });
            kriterListe.Add(new GrupKriteriItems { Text = "Açan Kullanıcı Departmanı", Value = 4 });
            kriterListe.Add(new GrupKriteriItems { Text = "Kapatan Yetkili", Value = 5 });
            kriterListe.Add(new GrupKriteriItems { Text = "Haftalık Veriler", Value = 6 });
            kriterListe.Add(new GrupKriteriItems { Text = "Aylık Veriler", Value = 7 });
            kriterListe.Add(new GrupKriteriItems { Text = "Yıllık Veriler", Value = 8 });

            for (var i = 0; i < kriterListe.Count; i++)
            {
                cb_GrupKriteri.Properties.Items.Add(kriterListe[i]);
            }

            cb_GrupKriteri.SelectedIndex = 0;

        }

        private void DoldurVeriler()
        {
            string strVeriler = @"select FIELDNAMEVAR, HarcananDakika=sum(HarcananSure), HarcananSaat=(sum(HarcananSure)/60.0), Sayi=count(*) from cmCagriView 
                where AcilisTarih between @baslangicTarih and @bitisTarih
                and (@CagriMerkezKod = '' or CagriMerkezKod = @CagriMerkezKod) 
                and (@IlgilenenYetkili = '' or IlgilenenYetkili = @IlgilenenYetkili) 
                and (@CagriKonuAd = '' or CagriKonuAd = @CagriKonuAd)
                and (@CagriDurumAd = '' or CagriDurumAd = @CagriDurumAd)
                and (@AcanKullaniciAdKod = '' or AcanKullaniciAdKod = @AcanKullaniciAdKod)
                and (@AcanKullaniciDepartman = '' or AcanKullaniciDepartman = @AcanKullaniciDepartman) 
                --and isNull(FIELDNAMEVAR, '') <> '' 
                    group by NAME order by NAME";

            string selectField = "";
            if (cb_GrupKriteri.SelectedIndex == 0)
                selectField = "CagriMerkezKod";
            else if (cb_GrupKriteri.SelectedIndex == 1)
                selectField = "IlgilenenYetkili";
            else if (cb_GrupKriteri.SelectedIndex == 2)
                selectField = "CagriKonuAd";
            else if (cb_GrupKriteri.SelectedIndex == 3)
                selectField = "AcanKullaniciAdKod";
            else if (cb_GrupKriteri.SelectedIndex == 4)
                selectField = "AcanKullaniciDepartman";
            else if (cb_GrupKriteri.SelectedIndex == 5)
                selectField = "KapatanYetkili";
            else if (cb_GrupKriteri.SelectedIndex == 6)
                selectField = "Haftalik=datepart(week,AcilisTarih)";
            else if (cb_GrupKriteri.SelectedIndex == 7)
                selectField = "Aylik=month(AcilisTarih)";
            else if (cb_GrupKriteri.SelectedIndex == 8)
                selectField = "Yillik=year(AcilisTarih)";

            strVeriler = strVeriler.Replace("FIELDNAMEVAR", selectField);
            strVeriler = strVeriler.Replace("NAME", GrupSecim(cb_GrupKriteri.SelectedIndex));
       
            SqlCommand komutVeriler = new SqlCommand(strVeriler, connection);

            komutVeriler.Parameters.AddWithValue("@CagriKonuAd", cb_CagriKonuAd.Text);
            komutVeriler.Parameters.AddWithValue("@CagriMerkezKod", cb_CagriMerkezKod.Text);
            komutVeriler.Parameters.AddWithValue("@IlgilenenYetkili", cb_IlgilenenYetkili.Text);
            komutVeriler.Parameters.AddWithValue("@CagriDurumAd", cb_CagriDurumu.Text);
            komutVeriler.Parameters.AddWithValue("@AcanKullaniciAdKod", cb_AcanKullaniciAdKod.Text);
            komutVeriler.Parameters.AddWithValue("@AcanKullaniciDepartman", cb_AcanKullaniciDepartman.Text);
            komutVeriler.Parameters.AddWithValue("@BaslangicTarih", dtp_BaslangicTarih.EditValue);
            komutVeriler.Parameters.AddWithValue("@BitisTarih", dtp_BitisTarih.EditValue);

            var daVeriler = new SqlDataAdapter(komutVeriler);
            var dtVeriler = new DataTable();
            var dsVeriler = new DataSet();

            daVeriler.Fill(dsVeriler, "Veriler");
            dtVeriler = dsVeriler.Tables["Veriler"];
            VVeriler.Columns.Clear();

            dgv_Veriler.DataSource = dtVeriler;

            //Sütunların toplam değerleri hesaplanıyor
            VVeriler.Columns[0].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            VVeriler.Columns[0].SummaryItem.DisplayFormat = "{0} Kayıt Bulundu";
            VVeriler.Columns[1].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            VVeriler.Columns[1].SummaryItem.DisplayFormat = "Dakika: {0:n2}";
            VVeriler.Columns[2].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            VVeriler.Columns[2].SummaryItem.DisplayFormat = "Saat: {0:n2}";
            VVeriler.Columns[3].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            VVeriler.Columns[3].SummaryItem.DisplayFormat = "Sayı: {0:n0}";

            VVeriler.Columns[1].DisplayFormat.FormatType = FormatType.Numeric;
            VVeriler.Columns[1].DisplayFormat.FormatString = "n2";
            VVeriler.Columns[2].DisplayFormat.FormatType = FormatType.Numeric;
            VVeriler.Columns[2].DisplayFormat.FormatString = "n2";
            VVeriler.Columns[3].DisplayFormat.FormatType = FormatType.Numeric;
            VVeriler.Columns[3].DisplayFormat.FormatString = "n0";

            if ((cb_GrupKriteri.SelectedIndex <= 2) || (cb_GrupKriteri.SelectedIndex <= 8))
            {
                //İlk grafik temizleniyor
                DxChart1.SeriesDataMember = "";
                DxChart1.SeriesTemplate.ArgumentDataMember = "";
                DxChart1.SeriesTemplate.ValueDataMembers.Clear();
                //İlk grafik dolduruluyor
                DxChart1.DataSource = dsVeriler.Tables[0];
                DxChart1.SeriesDataMember = KolonSecim(cb_GrupKriteri.SelectedIndex);
                DxChart1.SeriesTemplate.ArgumentDataMember = KolonSecim(cb_GrupKriteri.SelectedIndex);
                DxChart1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "HarcananSaat" });
                DxChart1.SeriesTemplate.View = new SideBySideBarSeriesView();
                DxChart1.SeriesTemplate.CrosshairLabelPattern = "{S} : {V:n2}";
                DxChart1.Visible = true;
                //İkinci grafik temizleniyor
                DxChart2.SeriesDataMember = "";
                DxChart2.SeriesTemplate.ArgumentDataMember = "";
                DxChart2.SeriesTemplate.ValueDataMembers.Clear();
                //İkinci grafik dolduruluyor
                DxChart2.DataSource = dsVeriler.Tables[0];
                DxChart2.SeriesDataMember = KolonSecim(cb_GrupKriteri.SelectedIndex);
                DxChart2.SeriesTemplate.ArgumentDataMember = KolonSecim(cb_GrupKriteri.SelectedIndex);
                DxChart2.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Sayi" });
                DxChart2.SeriesTemplate.View = new SideBySideBarSeriesView();
                DxChart1.SeriesTemplate.CrosshairLabelPattern = "{S} : {V:n0}";
                DxChart2.Visible = true;
            }
            else
            {
                DxChart1.Visible = false;
                DxChart2.Visible = false;
            }

        }

        private void DoldurCagriMerkezKod()
        {
            try
            {
                string strCagriMerkezKod = "select distinct CagriMerkezKod from cmCagriView where isNull(CagriMerkezKod, '') <> '' order by CagriMerkezKod";
                var daCagriMerkezKod = new SqlDataAdapter(strCagriMerkezKod, connection);
                var dsCagriMerkezKod = new DataSet();
                daCagriMerkezKod.Fill(dsCagriMerkezKod, "CagriMerkez");
                cb_CagriMerkezKod.DisplayMember = "CagriMerkezKod";
                cb_CagriMerkezKod.ValueMember = "CagriMerkezKod";
                cb_CagriMerkezKod.DataSource = dsCagriMerkezKod.Tables["CagriMerkez"];
                var newRow = dsCagriMerkezKod.Tables["CagriMerkez"].NewRow();
                newRow["CagriMerkezKod"] = "";
                dsCagriMerkezKod.Tables["CagriMerkez"].Rows.InsertAt(newRow, 0);
                cb_CagriMerkezKod.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoldurCagriKonuAd()
        {
            try
            {
                string strCagriKonuAd = "select distinct CagriKonuAd from cmCagriView where isNull(CagriKonuAd, '') <> '' order by CagriKonuAd";
                var daCagriKonuAd = new SqlDataAdapter(strCagriKonuAd, connection);
                var dsCagriKonuAd = new DataSet();
                daCagriKonuAd.Fill(dsCagriKonuAd, "CagriKonu");
                cb_CagriKonuAd.DisplayMember = "CagriKonuAd";
                cb_CagriKonuAd.ValueMember = "CagriKonuAd";
                cb_CagriKonuAd.DataSource = dsCagriKonuAd.Tables["CagriKonu"];
                var newRow = dsCagriKonuAd.Tables["CagriKonu"].NewRow();
                newRow["CagriKonuAd"] = "";
                dsCagriKonuAd.Tables["CagriKonu"].Rows.InsertAt(newRow, 0);
                cb_CagriKonuAd.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoldurCagriDurumu()
        {
            try
            {
                string strCagriDurumu = "select distinct CagriDurumAd from cmCagriView where isNull(CagriDurumAd, '') <> '' order by CagriDurumAd";
                var daCagriDurumu = new SqlDataAdapter(strCagriDurumu, connection);
                var dsCagriDurumu = new DataSet();
                daCagriDurumu.Fill(dsCagriDurumu, "CagriDurum");
                cb_CagriDurumu.DisplayMember = "CagriDurumAd";
                cb_CagriDurumu.ValueMember = "CagriDurumAd";
                cb_CagriDurumu.DataSource = dsCagriDurumu.Tables["CagriDurum"];
                var newRow = dsCagriDurumu.Tables["CagriDurum"].NewRow();
                newRow["CagriDurumAd"] = "";
                dsCagriDurumu.Tables["CagriDurum"].Rows.InsertAt(newRow, 0);
                cb_CagriDurumu.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoldurIlgilenenYetkili()
        {
            try
            {
                string strIlgilenenYetkili = "select distinct IlgilenenYetkili from cmCagriView where isNull(IlgilenenYetkili, '') <> '' order by IlgilenenYetkili";
                var daIlgilenenYetkili = new SqlDataAdapter(strIlgilenenYetkili, connection);
                var dsIlgilenenYetkili = new DataSet();
                daIlgilenenYetkili.Fill(dsIlgilenenYetkili, "Ilgilenen");
                cb_IlgilenenYetkili.DisplayMember = "IlgilenenYetkili";
                cb_IlgilenenYetkili.ValueMember = "IlgilenenYetkili";
                cb_IlgilenenYetkili.DataSource = dsIlgilenenYetkili.Tables["Ilgilenen"];
                var newRow = dsIlgilenenYetkili.Tables["Ilgilenen"].NewRow();
                newRow["IlgilenenYetkili"] = "";
                dsIlgilenenYetkili.Tables["Ilgilenen"].Rows.InsertAt(newRow, 0);
                cb_IlgilenenYetkili.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoldurAcanKullaniciAdKod()
        {
            try
            {
                string strAcanKullaniciAdKod = "select distinct AcanKullaniciAdKod from cmCagriView where isNull(AcanKullaniciAdKod, '') <> '' order by AcanKullaniciAdKod";
                SqlDataAdapter daAcanKullaniciAdKod = new SqlDataAdapter(strAcanKullaniciAdKod, connection);
                DataSet dsAcanKullaniciAdKod = new DataSet();
                daAcanKullaniciAdKod.Fill(dsAcanKullaniciAdKod, "AcanKullanici");
                cb_AcanKullaniciAdKod.DisplayMember = "AcanKullaniciAdKod";
                cb_AcanKullaniciAdKod.ValueMember = "AcanKullaniciAdKod";
                cb_AcanKullaniciAdKod.DataSource = dsAcanKullaniciAdKod.Tables["AcanKullanici"];
                DataRow newRow = dsAcanKullaniciAdKod.Tables["AcanKullanici"].NewRow();
                newRow["AcanKullaniciAdKod"] = "";
                dsAcanKullaniciAdKod.Tables["AcanKullanici"].Rows.InsertAt(newRow, 0);
                cb_AcanKullaniciAdKod.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoldurAcanKullaniciDepartman()
        {
            try
            {
                var strAcanKullaniciDepartman = "select distinct AcanKullaniciDepartman from cmCagriView where isNull(AcanKullaniciDepartman, '') <> '' order by AcanKullaniciDepartman";
                var daAcanKullaniciDepartman = new SqlDataAdapter(strAcanKullaniciDepartman, connection);
                var dsAcanKullaniciDepartman = new DataSet();
                daAcanKullaniciDepartman.Fill(dsAcanKullaniciDepartman, "AcanDepartman");
                cb_AcanKullaniciDepartman.DisplayMember = "AcanKullaniciDepartman";
                cb_AcanKullaniciDepartman.ValueMember = "AcanKullaniciDepartman";
                cb_AcanKullaniciDepartman.DataSource = dsAcanKullaniciDepartman.Tables["AcanDepartman"];
                var newRow = dsAcanKullaniciDepartman.Tables["AcanDepartman"].NewRow();
                newRow["AcanKullaniciDepartman"] = "";
                dsAcanKullaniciDepartman.Tables["AcanDepartman"].Rows.InsertAt(newRow, 0);
                cb_AcanKullaniciDepartman.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OpenConnection()
        {
            connection.Open();
        }

        private void CloseConnection()
        {
            connection.Close();
        }

        private void GizleChart()
        {

            DxChart1.Visible = false;
            DxChart2.Visible = false;
        }
        //Kaydet butonuna basıldığında rapor oluşturulup kullanıcıya sunuluyor
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            var composLink = new CompositeLink(new PrintingSystem());
            composLink.CreateMarginalHeaderArea += new CreateAreaEventHandler(composLink_CreateMarginalHeaderArea);
            var pcLink1 = new PrintableComponentLink();
            var pcLink2 = new PrintableComponentLink();
            var pcLink3 = new PrintableComponentLink();
            var linkGridReport = new Link();
            linkGridReport.CreateDetailArea += new CreateAreaEventHandler(linkGridReport_CreateDetailArea);
            var linkChart1Report = new Link();
            linkChart1Report.CreateDetailArea += new CreateAreaEventHandler(linkChart1Report_CreateDetailArea);
            var linkChart2Report = new Link();
            linkChart2Report.CreateDetailArea += new CreateAreaEventHandler(linkChart2Report_CreateDetailArea);

            pcLink1.Component = dgv_Veriler;
            pcLink2.Component = DxChart1;
            pcLink3.Component = DxChart2;

            composLink.Links.Add(linkGridReport);
            composLink.Links.Add(linkChart1Report);
            composLink.Links.Add(linkChart2Report);
            composLink.Links.Add(pcLink1);
            composLink.Links.Add(pcLink2);
            composLink.Links.Add(pcLink3);

            composLink.ShowPreviewDialog();
        }

        // Sayfaların üzerine zamanı gösteren başlık ekleniyor
        void composLink_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            e.Graph.DrawPageInfo(PageInfo.DateTime, "{0:hhhh:mmmm:ssss}", Color.Black,
                new RectangleF(0, 0, 200, 20), BorderSide.None);
        }

        // Grid bileşenini için başlık oluşturuluyor
        void linkGridReport_CreateDetailArea(object sender, CreateAreaEventArgs e)
        {
            var tb = new TextBrick();
            tb.Font = new Font("Arial", 15);
            tb.Rect = new RectangleF(0, 0, 300, 25);
            tb.BorderWidth = 0;
            tb.BackColor = Color.Transparent;
            tb.HorzAlignment = HorzAlignment.Near;
            e.Graph.DrawBrick(tb);
        }

        // İlk grafik için başlık oluşturuluyor
        void linkChart1Report_CreateDetailArea(object sender, CreateAreaEventArgs e)
        {
            var tb = new TextBrick();
            tb.Font = new Font("Arial", 15);
            tb.Rect = new RectangleF(0, 0, 300, 25);
            tb.BorderWidth = 0;
            tb.BackColor = Color.Transparent;
            tb.HorzAlignment = HorzAlignment.Near;
            e.Graph.DrawBrick(tb);
        }

        // İkinci grafik  için başlık oluşturuluyor
        void linkChart2Report_CreateDetailArea(object sender, CreateAreaEventArgs e)
        {
            TextBrick tb = new TextBrick();
            //tb.Text = "Suppliers";
            tb.Font = new Font("Arial", 15);
            tb.Rect = new RectangleF(0, 0, 300, 25);
            tb.BorderWidth = 0;
            tb.BackColor = Color.Transparent;
            tb.HorzAlignment = HorzAlignment.Near;
            e.Graph.DrawBrick(tb);
        }

        private string GrupSecim(int index)
        {
            string secildi = "";

            if (index == 0)
                secildi = "CagriMerkezKod";
            else if (index == 1)
                secildi = "IlgilenenYetkili";
            else if (index == 2)
                secildi = "CagriKonuAd";
            else if (index == 3)
                secildi = "AcanKullaniciAdKod";
            else if (index == 4)
                secildi = "AcanKullaniciDepartman";
            else if (index == 5)
                secildi = "KapatanYetkili";
            else if (index == 6)
                secildi = "datepart(week,AcilisTarih)";
            else if (index == 7)
                secildi = "month(AcilisTarih)";
            else if (index == 8)
                secildi = "year(AcilisTarih)";

            return secildi;
        }

        private string KolonSecim(int index)
        {
            string secildi = "";

            if (index == 0)
                secildi = "CagriMerkezKod";
            else if (index == 1)
                secildi = "IlgilenenYetkili";
            else if (index == 2)
                secildi = "CagriKonuAd";
            else if (index == 3)
                secildi = "AcanKullaniciAdKod";
            else if (index == 4)
                secildi = "AcanKullaniciDepartman";
            else if (index == 5)
                secildi = "KapatanYetkili";
            else if (index == 6)
                secildi = "Haftalik";
            else if (index == 7)
                secildi = "Aylik";
            else if (index == 8)
                secildi = "Yillik";

            return secildi;
        }
    }
}
