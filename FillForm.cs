using System;
using System.IO;
using iText.Forms;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
 
 
namespace edit_pdfs
{
    public class FillForm
    {
        public void FillSvcPdf(
            String DEST,
            String USERNAME,
            String COMMENT)
        {
            String PDFSRC = MyConst.PdfSvcActTemplate;
            // If pdf is locked or you dont know the password use below commented lines
            //PdfReader reader = new PdfReader(PDFSRC).SetUnethicalReading(true);
            //PdfDocument pdfDoc = new PdfDocument(reader, new PdfWriter(dest));
            
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(PDFSRC), new PdfWriter(DEST));
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
 
            form.GetField("userid").SetValue("  "+USERNAME);
            form.GetField("reqdate").SetValue("20201015");
            // form.GetField("justify").SetValue(COMMENT); //THIS IS BOX 13
            form.GetField("optinfo").SetValue(COMMENT);
 
            pdfDoc.Close();
        }
    }
}