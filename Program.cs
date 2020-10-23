using System;
using System.IO;
using iText.Forms;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
 
 
namespace edit_pdfs
{
    public class MyConst
    {
        // CSV File for testing purposes
        public const String SrvAcntsCsvFile = "./pdfs/svcTest.csv";
        public const String DevAcntsCsvFile = "./pdfs/svcTest.csv";
        // public const String SrvAcntsCsvFile = "./pdfs/Service_Accounts.csv";
        // public const String DevAcntsCsvFile = "./pdfs/Development_Accounts.csv.csv";

        // This file needs to be unlocked/unprotected, if it isnt you will need to use the commented lines below
        public const String PdfSvcActTemplate = "./pdfs/SvcActTemplate.pdf";
    }
    public class Primary
    {
        public static void Main(String[] args)
        {
            String inpt = "SvcAcnts"; //SvcAcnts, DevAcnts, ReadPdf
            // Console.WriteLine("Enter Input:");
            // string userName = Console.ReadLine();
            Console.WriteLine("Starting");
            if (inpt == "SvcAcnts")
            {
                String CSVSRC = MyConst.SrvAcntsCsvFile;
                Console.WriteLine("Beginning to process: " + inpt + "Service File:" + CSVSRC);
                // ReadFile fone = new ReadFile();
                // fone.ReadSvcAcntsCSV(CSVSRC);
            }
            else if (inpt == "DevAcnts")
            {
                String CSVSRC = MyConst.DevAcntsCsvFile;
                Console.WriteLine("Beginning to process: " + inpt + "Service File:" + CSVSRC);
                // ReadFile fone = new ReadFile();
                // fone.ReadDevAcntsCSV(CSVSRC);
            }
            else if (inpt == "ReadPdf")
            {
                Console.WriteLine("other");
            }
            else
            {
                Console.WriteLine("Whoops, you messed up inpt, it was: " + inpt);
            }
            Console.WriteLine("Completed");
        }
    }
}