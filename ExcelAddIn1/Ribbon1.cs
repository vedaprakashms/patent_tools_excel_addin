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
                if (result.Length > 8)
                {
                    //http://patft.uspto.gov/netacgi/nph-Parser?TERM1=10298608&Sect1=PTO1&Sect2=HITOFF&d=PALL&p=1&u=%2Fnetahtml%2FPTO%2Fsrchnum.htm&r=0&f=S&l=50;
                    k.Hyperlinks.Add(k, "https://worldwide.espacenet.com/patent/search?q=" + k.Text);
                }
                else
                {
                    k.Hyperlinks.Add(k, "https://worldwide.espacenet.com/patent/search?q=" + k.Text);
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
    }
}
