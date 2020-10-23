using System;
using System.IO;
using iText.Forms;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
 
 
namespace edit_pdfs
{
    public class ReadFile
    {
        public void ReadSvcAcntsCSV(String CSVSRC)
        {
            Console.WriteLine("Starting to read file");
            using (StreamReader sr = new StreamReader(CSVSRC))
            {
                string rdLine;
                // currentLine will be null when the StreamReader reaches the end of file
                while((rdLine = sr.ReadLine()) != null)
                {
                    Console.WriteLine(rdLine);
                    string[] fields = rdLine.Split('|');                
                    // This will call the class FillForms and update the PDF
                    String SVR = fields[0];
                    String USR = fields[1];
                    String CMT = fields[2];
                    String HM = fields[3];
                    String GRP1 = fields[4];
                    String GRP2 = fields[5];
                    String GRP3 = fields[6];
                    //server|Username|Comment|Home|Group1|Group2|Group3
                    Console.WriteLine("Server: " + SVR + " Username: " + USR + " Comment: " + CMT + 
                        " Home: " + HM + " Group1: " + GRP1 + " Group2: " + GRP2 + " Group3: " + GRP3);

                    String BOX27 = 
                    "\r\n*** Enter specific Roles or Commands or add specific type of access for this duty specified in block 13.  All information in this box is "+
                    "\r\nREQUIRED.  If not completed the 2875 will be rejected. ***\r\n"+
                    
                    "\r\nDLA USERID: _"+USR+"____\r\n"+

                    "\r\nSelect only one Enclave:      DOE__        DME___            DAE-Ogden (Green) __           DAE-Mechanicsburg_X__\r\n"+

                    "\r\nSelect only one Environment:     Production __       Stage _X_       T&D___        COOP___ \r\n"+

                    "\r\nList Specific Application: ____________Medical DMLSS (Includes DMLSS-W, FEAMS, MEDPDB)________________"+
                    "\r\nCSHIP(s)/Host(s)/OE(s): ________________"+SVR+" _____________________________________________"+
                    "\r\nJustification/Description of functions performing:_______These Unix service accounts need to be created on the server as sudo only account."+
                    "\r\nThese are used by Application Data Managers to perform their functions regarding application processing/maintenance/troubleshooting.\r\n"+

                    "\r\nHome: "+HM+
                    "\r\nFor passwd file comments:  "+CMT+"\r\n"+

                    "\r\nPrimary Group: "+GRP1+
                    "\r\nSecondary Group: "+GRP2+"\r\n";

                    String PDEST = "./pdfs/2875s/DMLSS Application Account UNIX OS(Auth) 2875 "+SVR+" "+USR+".pdf";

                    FileInfo file = new FileInfo(PDEST);
                    file.Directory.Create();

                    FillForm form = new FillForm();
                    form.FillSvcPdf(PDEST, USR, BOX27);
                }
            }
            Console.WriteLine("Completed reading file");
        }

        public void ReadDevAcntsCSV(String CSVSRC)
        {
            Console.WriteLine("Starting to read file");
            using (StreamReader sr = new StreamReader(CSVSRC))
            {
                string rdLine;
                // currentLine will be null when the StreamReader reaches the end of file
                while((rdLine = sr.ReadLine()) != null)
                {
                    Console.WriteLine(rdLine);
                    string[] fields = rdLine.Split('|');                
                    // This will call the class FillForms and update the PDF
                    String SVR = fields[0];
                    String USR = fields[1];
                    String CMT = fields[2];
                    String HM = fields[3];
                    String GRP1 = fields[4];
                    String GRP2 = fields[5];
                    String GRP3 = fields[6];
                    //server|Username|Comment|Home|Group1|Group2|Group3
                    Console.WriteLine("Server: " + SVR + " Username: " + USR + " Comment: " + CMT + 
                        " Home: " + HM + " Group1: " + GRP1 + " Group2: " + GRP2 + " Group3: " + GRP3);

                    String BOX27 = 
                    "\r\n*** Enter specific Roles or Commands or add specific type of access for this duty specified in block 13.  All information in this box is "+
                    "\r\nREQUIRED.  If not completed the 2875 will be rejected. ***\r\n"+
                    
                    "\r\nDLA USERID: _"+USR+"____\r\n"+

                    "\r\nSelect only one Enclave:      DOE__        DME___            DAE-Ogden (Green) __           DAE-Mechanicsburg_X__\r\n"+

                    "\r\nSelect only one Environment:     Production __       Stage _X_       T&D___        COOP___ \r\n"+

                    "\r\nList Specific Application: ____________Medical DMLSS (Includes DMLSS-W, FEAMS, MEDPDB)________________"+
                    "\r\nCSHIP(s)/Host(s)/OE(s): ________________"+SVR+" _____________________________________________"+
                    "\r\nJustification/Description of functions performing:_______These Unix service accounts need to be created on the server as sudo only account."+
                    "\r\nThese are used by Application Data Managers to perform their functions regarding application processing/maintenance/troubleshooting.\r\n"+

                    "\r\nHome: "+HM+
                    "\r\nFor passwd file comments:  "+CMT+"\r\n"+

                    "\r\nPrimary Group: "+GRP1+
                    "\r\nSecondary Group: "+GRP2+"\r\n";

                    String PDEST = "./pdfs/2875s/DMLSS Application Account UNIX OS(Auth) 2875 "+SVR+" "+USR+".pdf";

                    FileInfo file = new FileInfo(PDEST);
                    file.Directory.Create();

                    FillForm form = new FillForm();
                    form.FillSvcPdf(PDEST, USR, BOX27);
                }
            }
            Console.WriteLine("Completed reading file");
        }

    }
}