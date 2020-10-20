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
        // This file needs to be unlocked/unprotected, if it isnt you will need to use the commented lines below
        public static readonly String PDFSRC = "./pdfs/TEMPLATE.pdf";
 
        public void ManipulatePdf(
            String DEST,
            String USERNAME,
            String COMMENT)
        {
            // If pdf is locked or you dont know the password use below commented lines
            //PdfReader reader = new PdfReader(PDFSRC).SetUnethicalReading(true);
            //PdfDocument pdfDoc = new PdfDocument(reader, new PdfWriter(dest));
            
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(PDFSRC), new PdfWriter(DEST));
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
 
            form.GetField("userid").SetValue("  "+USERNAME);
            form.GetField("reqdate").SetValue("20201015");
            // form.GetField("justify").SetValue(COMMENT);
            form.GetField("optinfo").SetValue(COMMENT);
 
            pdfDoc.Close();
        }
    }
}