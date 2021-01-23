using DevExpress.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using PsgMuhendislik.Moduller.Calisanlar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsgMuhendislik.Fonksiyonlar
{
    public static class formIslem
    {

        public static void islem(Keys keyData, string formName)
        {
            Formlar form = new Formlar();
            if (keyData == Keys.F5)
            {
                switch (formName)
                {
                    case "MusteriEkle":
                        form.MusteriEkle(true);
                        break;
                    case "FirmaEkle":
                        form.FirmaEkle(true);
                        break;
                    case "CalisanEkle":
                        form.CalisanEkle(true);
                        break;
                    case "GelenOdemeEkle":
                        form.GelenOdemeEkle(true);
                        break;
                    case "HarcamaEkle":
                        form.HarcamaEkle(true);
                        break;
                    case "idrisAlinanParaEkle":
                        form.idrisAlinanParaEkle(true);
                        break;

                }
            }
            if (keyData == Keys.Escape)
            {
                var formN = Application.OpenForms[formName];
                if (formN != null)
                    formN.Close();
            }
        }

        public static bool Excel_Aktar(GridView grd, string filename)
        {
            Mesajlar msj = new Mesajlar();
            try
            {
                if (grd.FocusedRowHandle < 0)
                {
                    msj.Hata("Aktarılacak Herhangi Bir Veri Bulunamadı!");
                }
                else
                {
                    grd.OptionsSelection.MultiSelect = false;
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Excel'e Aktar";
                    dialog.FileName = filename;
                    dialog.Filter = @"Microsoft Excel|*.xlsx";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        grd.ColumnPanelRowHeight = 40;
                        grd.OptionsPrint.ShowPrintExportProgress = true;
                        grd.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = @"Sheet1";
                        grd.Columns[grd.VisibleColumns.Count - 1].Visible = false;
                        grd.Columns[grd.VisibleColumns.Count - 1].Visible = false;
                        ExportSettings.DefaultExportType = ExportType.Default;
                        grd.ExportToXlsx(dialog.FileName, options);
                        XtraMessageBox.Show("Excele Aktarıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Hata " + e, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public static bool Pdf_Aktar(GridView grd, string filename)
        {
            Mesajlar msj = new Mesajlar();
            try
            {

                if (grd.FocusedRowHandle < 0)
                {
                    msj.Hata("Aktarılacak Herhangi Bir Veri Bulunamadı!");
                }
                else
                {
                    grd.OptionsSelection.MultiSelect = false;
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"PDF'e Aktar";
                    dialog.FileName = filename;
                    dialog.Filter = @"Microsoft Pdf|*.pdf";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        // Specify PDF-specific export options.
                        PdfExportOptions pdfOptions = new PdfExportOptions();
                        // Specify the quality of exported images.
                        pdfOptions.ConvertImagesToJpeg = false;
                        pdfOptions.ImageQuality = PdfJpegImageQuality.Medium;

                        // Specify the PDF/A-compatibility.
                        pdfOptions.PdfACompatibility = PdfACompatibility.PdfA3b;
                        pdfOptions.DocumentOptions.Application = "Test Application";
                        pdfOptions.DocumentOptions.Author = "DX Documentation Team";
                        pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF";
                        pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString();
                        pdfOptions.DocumentOptions.Subject = "Document Subject";
                        pdfOptions.DocumentOptions.Title = "Document Title";

                        grd.Columns[grd.VisibleColumns.Count - 1].Visible = false;
                        grd.Columns[grd.VisibleColumns.Count - 1].Visible = false;
                        grd.ExportToPdf(dialog.FileName, pdfOptions);
                        XtraMessageBox.Show("PDFe Aktarıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e)
            {

                XtraMessageBox.Show("Hata " + e, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public static bool Renklendir(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.IsRowSelected(e.RowHandle) || view.FocusedRowHandle == e.RowHandle)
            {
                e.Appearance.BackColor = Color.FromArgb(148, 252, 228);
                e.HighPriority = true;
            }
                return true;
        }
    }
}
