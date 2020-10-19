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
        public static readonly String SRC = "C:/01-MyLocalFiles/ad_MyProjects/VSCode/pdfs/2875.pdf";
        public static readonly String DEST = "C:/01-MyLocalFiles/ad_MyProjects/VSCode/pdfs/2875-Edit.pdf";
        public static readonly String JUST_TXT = "Neal, this is now a format test" + 
        "\r\nNOW a different TEST" + 
        "\r\nAND NOW ONE MORE";
 
        public static void Main(String[] args)
        {
            FileInfo file = new FileInfo(DEST);
            file.Directory.Create();
 
            new FillForm().ManipulatePdf(DEST, JUST_TXT);
        }
 
        protected void ManipulatePdf(String dest, String JUST_TXT)
        {
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(SRC), new PdfWriter(dest));
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
 
            form.GetField("userid").SetValue("HED0425");
            form.GetField("reqdate").SetValue("20201015");
            form.GetField("justify").SetValue(JUST_TXT);
 
            pdfDoc.Close();
        }
    }
}