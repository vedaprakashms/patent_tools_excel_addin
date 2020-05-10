using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using office = Microsoft.Office.Core;
using System.Text.RegularExpressions;

namespace ExcelAddIn1
{
    public partial class Ribbon1
    {

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void G_patents_Click(object sender, RibbonControlEventArgs e)
        {
            
            Excel.Worksheet activeworksheet = Globals.ThisAddIn.Application.ActiveSheet;
            Excel.Range range = Globals.ThisAddIn.Application.Selection;
            foreach(Excel.Range k in range.Cells)
            {
                string pattern = "\\s+";
                string temp = k.Text;
                string replacement = "";
                Regex rgx = new Regex(pattern);
                string result = rgx.Replace(temp, replacement);
                k.Value2 = result;
                k.Hyperlinks.Add(k, "https://patents.google.com/patent/" + result+"/en");
            }
        }

        private void Espacenet_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet activeworksheet = Globals.ThisAddIn.Application.ActiveSheet;
            Excel.Range range = Globals.ThisAddIn.Application.Selection;
            foreach (Excel.Range k in range.Cells)
            {
                string pattern = "\\s+";
                string temp = k.Text;
                string replacement = "";
                Regex rgx = new Regex(pattern);
                string result = rgx.Replace(temp, replacement);
                k.Value2 = result;
                k.Hyperlinks.Add(k, "https://worldwide.espacenet.com/patent/search?q=" + result );
            }
        }

        private void USPTO_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet activeworksheet = Globals.ThisAddIn.Application.ActiveSheet;
            Excel.Range range = Globals.ThisAddIn.Application.Selection;
            foreach (Excel.Range k in range.Cells)
            {
                string pattern = "\\s+";
                string temp = k.Text;
                string replacement = "";
                Regex rgx = new Regex(pattern);
                string result = rgx.Replace(temp, replacement);
                k.Value2 = result;
                pattern = "US";
                rgx = new Regex(pattern);
                result = rgx.Replace(result, replacement);
                pattern = "[A|B|C].";
                rgx = new Regex(pattern);
                result = rgx.Replace(result, replacement);


                if (result.Length <11)
                {
                    k.Hyperlinks.Add(k, "http://patft.uspto.gov/netacgi/nph-Parser?TERM1="+result+"&Sect1=PTO1&Sect2=HITOFF&d=PALL&p=1&u=%2Fnetahtml%2FPTO%2Fsrchnum.htm&r=0&f=S&l=50");
                }
                else
                {
                    k.Hyperlinks.Add(k, "http://appft.uspto.gov/netacgi/nph-Parser?Sect1=PTO1&Sect2=HITOFF&d=PG01&p=1&u=%2Fnetahtml%2FPTO%2Fsrchnum.html&r=1&f=G&l=50&s1=%22"+result+"%22.PGNR.&OS=DN/"+result+"&RS=DN/"+result);
                }

            }
        }

        private void PDF_USPTO_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet activeworksheet = Globals.ThisAddIn.Application.ActiveSheet;
            Excel.Range range = Globals.ThisAddIn.Application.Selection;
            foreach (Excel.Range k in range.Cells)
            {
                k.Hyperlinks.Add(k, "https://worldwide.espacenet.com/patent/search?q=" + k.Text);
                
            }
        }

        private void Help_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vedaprakashms.github.io/");
        }

        private void Github_repo_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/vedaprakashms/patent_tools_excel_addin");
        }

        private void Author_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/vedaprakashms/patent_tools_excel_addin/blob/master/Author_about");
        }

        private void License_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/vedaprakashms/patent_tools_excel_addin/blob/master/LICENSE");
        }

        private void USPTO_PDF_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet activeworksheet = Globals.ThisAddIn.Application.ActiveSheet;
            Excel.Range range = Globals.ThisAddIn.Application.Selection;
            foreach (Excel.Range k in range.Cells)
            {
                string pattern = "\\s+";
                string temp = k.Text;
                string replacement = "";
                Regex rgx = new Regex(pattern);
                string result = rgx.Replace(temp, replacement);
                k.Value2 = result;
                pattern = "US";
                rgx = new Regex(pattern);
                result = rgx.Replace(result, replacement);
                pattern = "[A|B|C].";
                rgx = new Regex(pattern);
                result = rgx.Replace(result, replacement);


                if (result.Length < 11)
                {
                    k.Hyperlinks.Add(k, "https://pdfpiw.uspto.gov/.piw?PageNum=0&docid="+result);
                }
                else
                {
                    k.Hyperlinks.Add(k, "https://pdfaiw.uspto.gov/.aiw?PageNum=0&docid=" + result);
                }

            }
        }
    }
}
