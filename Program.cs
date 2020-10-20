using System;
using System.IO;
using iText.Forms;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
 
 
namespace edit_pdfs
{
    public class Primary
    {
        // For testing purposes
        // public static readonly String CSVSRC = "./pdfs/svcTest.csv";
        public static readonly String CSVSRC = "./pdfs/Service_Accounts.csv";

        public static void Main(String[] args)
        {
            ReadFile fone = new ReadFile();
            fone.ReadCSV(CSVSRC);
        }
    }
}