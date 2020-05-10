namespace ExcelAddIn1
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Patent_tools = this.Factory.CreateRibbonTab();
            this.Hyperlinker = this.Factory.CreateRibbonGroup();
            this.G_patents = this.Factory.CreateRibbonButton();
            this.Espacenet = this.Factory.CreateRibbonButton();
            this.USPTO = this.Factory.CreateRibbonButton();
            this.PDF_Link = this.Factory.CreateRibbonGroup();
            this.Patent_tools.SuspendLayout();
            this.Hyperlinker.SuspendLayout();
            this.SuspendLayout();
            // 
            // Patent_tools
            // 
            this.Patent_tools.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Patent_tools.Groups.Add(this.Hyperlinker);
            this.Patent_tools.Groups.Add(this.PDF_Link);
            this.Patent_tools.Label = "Patent_Tools";
            this.Patent_tools.Name = "Patent_tools";
            // 
            // Hyperlinker
            // 
            this.Hyperlinker.Items.Add(this.G_patents);
            this.Hyperlinker.Items.Add(this.Espacenet);
            this.Hyperlinker.Items.Add(this.USPTO);
            this.Hyperlinker.Label = "Hyperlinker";
            this.Hyperlinker.Name = "Hyperlinker";
            // 
            // G_patents
            // 
            this.G_patents.Label = "G_patents";
            this.G_patents.Name = "G_patents";
            this.G_patents.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.G_patents_Click);
            // 
            // Espacenet
            // 
            this.Espacenet.Label = "Espacenet";
            this.Espacenet.Name = "Espacenet";
            this.Espacenet.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Espacenet_Click);
            // 
            // USPTO
            // 
            this.USPTO.Label = "USPTO";
            this.USPTO.Name = "USPTO";
            this.USPTO.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.USPTO_Click);
            // 
            // PDF_Link
            // 
            this.PDF_Link.Label = "PDF links";
            this.PDF_Link.Name = "PDF_Link";
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.Patent_tools);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.Patent_tools.ResumeLayout(false);
            this.Patent_tools.PerformLayout();
            this.Hyperlinker.ResumeLayout(false);
            this.Hyperlinker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Patent_tools;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Hyperlinker;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton G_patents;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Espacenet;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton USPTO;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup PDF_Link;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
