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
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl2 = this.Factory.CreateRibbonDialogLauncher();
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl3 = this.Factory.CreateRibbonDialogLauncher();
            this.Patent_tools = this.Factory.CreateRibbonTab();
            this.Author_data = this.Factory.CreateRibbonGroup();
            this.Help = this.Factory.CreateRibbonButton();
            this.Github_details = this.Factory.CreateRibbonMenu();
            this.Github_repo = this.Factory.CreateRibbonButton();
            this.Author = this.Factory.CreateRibbonButton();
            this.License = this.Factory.CreateRibbonButton();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.Hyperlinker = this.Factory.CreateRibbonGroup();
            this.G_patents = this.Factory.CreateRibbonButton();
            this.Espacenet = this.Factory.CreateRibbonButton();
            this.USPTO = this.Factory.CreateRibbonButton();
            this.PDF_Link = this.Factory.CreateRibbonGroup();
            this.USPTO_PDF = this.Factory.CreateRibbonButton();
            this.PatRegister = this.Factory.CreateRibbonGroup();
            this.USPTO_Assign = this.Factory.CreateRibbonButton();
            this.EP_reg = this.Factory.CreateRibbonButton();
            this.Global_dos = this.Factory.CreateRibbonButton();
            this.Patent_tools.SuspendLayout();
            this.Author_data.SuspendLayout();
            this.Hyperlinker.SuspendLayout();
            this.PDF_Link.SuspendLayout();
            this.PatRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // Patent_tools
            // 
            this.Patent_tools.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Patent_tools.Groups.Add(this.Author_data);
            this.Patent_tools.Groups.Add(this.Hyperlinker);
            this.Patent_tools.Groups.Add(this.PDF_Link);
            this.Patent_tools.Groups.Add(this.PatRegister);
            this.Patent_tools.Label = "IP productivity Tools";
            this.Patent_tools.Name = "Patent_tools";
            // 
            // Author_data
            // 
            this.Author_data.Items.Add(this.Help);
            this.Author_data.Items.Add(this.Github_details);
            this.Author_data.Items.Add(this.label1);
            this.Author_data.Label = "About";
            this.Author_data.Name = "Author_data";
            // 
            // Help
            // 
            this.Help.Label = "Help";
            this.Help.Name = "Help";
            this.Help.ScreenTip = "Click to Get help on the usage";
            this.Help.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Help_Click);
            // 
            // Github_details
            // 
            this.Github_details.Items.Add(this.Github_repo);
            this.Github_details.Items.Add(this.Author);
            this.Github_details.Items.Add(this.License);
            this.Github_details.Label = "Github Details";
            this.Github_details.Name = "Github_details";
            // 
            // Github_repo
            // 
            this.Github_repo.Label = "Github Repository";
            this.Github_repo.Name = "Github_repo";
            this.Github_repo.ShowImage = true;
            this.Github_repo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Github_repo_Click);
            // 
            // Author
            // 
            this.Author.Label = "Author";
            this.Author.Name = "Author";
            this.Author.ShowImage = true;
            this.Author.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Author_Click);
            // 
            // License
            // 
            this.License.Label = "MIT License";
            this.License.Name = "License";
            this.License.ShowImage = true;
            this.License.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.License_Click);
            // 
            // label1
            // 
            this.label1.Label = "© 2020, Vedaprakash M S";
            this.label1.Name = "label1";
            // 
            // Hyperlinker
            // 
            this.Hyperlinker.DialogLauncher = ribbonDialogLauncherImpl1;
            this.Hyperlinker.Items.Add(this.G_patents);
            this.Hyperlinker.Items.Add(this.Espacenet);
            this.Hyperlinker.Items.Add(this.USPTO);
            this.Hyperlinker.Label = "Hyperlinker";
            this.Hyperlinker.Name = "Hyperlinker";
            // 
            // G_patents
            // 
            this.G_patents.Label = "Google patents";
            this.G_patents.Name = "G_patents";
            this.G_patents.ScreenTip = "Select a Range to hyperlink to google patents";
            this.G_patents.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.G_patents_Click);
            // 
            // Espacenet
            // 
            this.Espacenet.Label = "Espacenet";
            this.Espacenet.Name = "Espacenet";
            this.Espacenet.ScreenTip = "Select a Range to hyperlink to Espacenet";
            this.Espacenet.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Espacenet_Click);
            // 
            // USPTO
            // 
            this.USPTO.Label = "USPTO";
            this.USPTO.Name = "USPTO";
            this.USPTO.ScreenTip = "Select a Range to hyperlink to USPTO";
            this.USPTO.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.USPTO_Click);
            // 
            // PDF_Link
            // 
            this.PDF_Link.DialogLauncher = ribbonDialogLauncherImpl2;
            this.PDF_Link.Items.Add(this.USPTO_PDF);
            this.PDF_Link.Label = "PDF links";
            this.PDF_Link.Name = "PDF_Link";
            // 
            // USPTO_PDF
            // 
            this.USPTO_PDF.Label = "USPTO";
            this.USPTO_PDF.Name = "USPTO_PDF";
            this.USPTO_PDF.ScreenTip = "Select a Range to hyperlink to USPTO pdfs";
            this.USPTO_PDF.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.USPTO_PDF_Click);
            // 
            // PatRegister
            // 
            this.PatRegister.DialogLauncher = ribbonDialogLauncherImpl3;
            this.PatRegister.Items.Add(this.USPTO_Assign);
            this.PatRegister.Items.Add(this.EP_reg);
            this.PatRegister.Items.Add(this.Global_dos);
            this.PatRegister.Label = "Register";
            this.PatRegister.Name = "PatRegister";
            // 
            // USPTO_Assign
            // 
            this.USPTO_Assign.Label = "USPTO Assiginment";
            this.USPTO_Assign.Name = "USPTO_Assign";
            this.USPTO_Assign.ScreenTip = "Select a Range to hyperlink to US assiginments";
            this.USPTO_Assign.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.USPTO_Assign_Click);
            // 
            // EP_reg
            // 
            this.EP_reg.Label = "EP Register";
            this.EP_reg.Name = "EP_reg";
            this.EP_reg.ScreenTip = "Select a Range to hyperlink to EP register";
            this.EP_reg.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.EP_reg_Click);
            // 
            // Global_dos
            // 
            this.Global_dos.Label = "Global Dossier";
            this.Global_dos.Name = "Global_dos";
            this.Global_dos.ScreenTip = "Select a Range to hyperlink to Global Dossier";
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.Patent_tools);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.Patent_tools.ResumeLayout(false);
            this.Patent_tools.PerformLayout();
            this.Author_data.ResumeLayout(false);
            this.Author_data.PerformLayout();
            this.Hyperlinker.ResumeLayout(false);
            this.Hyperlinker.PerformLayout();
            this.PDF_Link.ResumeLayout(false);
            this.PDF_Link.PerformLayout();
            this.PatRegister.ResumeLayout(false);
            this.PatRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Patent_tools;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Hyperlinker;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton G_patents;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Espacenet;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton USPTO;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup PDF_Link;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Author_data;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Help;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu Github_details;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Github_repo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Author;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton License;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton USPTO_PDF;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup PatRegister;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton USPTO_Assign;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton EP_reg;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Global_dos;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
