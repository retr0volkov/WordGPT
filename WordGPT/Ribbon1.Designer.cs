namespace WordGPT
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
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl2 = this.Factory.CreateRibbonDialogLauncher();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl7 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.tab2 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.editBox1 = this.Factory.CreateRibbonEditBox();
            this.dropDown1 = this.Factory.CreateRibbonDropDown();
            this.box1 = this.Factory.CreateRibbonBox();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.editBox2 = this.Factory.CreateRibbonEditBox();
            this.dropDown2 = this.Factory.CreateRibbonDropDown();
            this.box2 = this.Factory.CreateRibbonBox();
            this.label2 = this.Factory.CreateRibbonLabel();
            this.button3 = this.Factory.CreateRibbonButton();
            this.button4 = this.Factory.CreateRibbonButton();
            this.button5 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.group1.SuspendLayout();
            this.box1.SuspendLayout();
            this.group2.SuspendLayout();
            this.box2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // tab2
            // 
            this.tab2.Groups.Add(this.group1);
            this.tab2.Groups.Add(this.group2);
            this.tab2.Label = "ChatGPT";
            this.tab2.Name = "tab2";
            // 
            // group1
            // 
            ribbonDialogLauncherImpl1.ScreenTip = "Big query";
            ribbonDialogLauncherImpl1.SuperTip = "Opens a dialog where you can write a big text or multiple lines of text";
            this.group1.DialogLauncher = ribbonDialogLauncherImpl1;
            this.group1.Items.Add(this.editBox1);
            this.group1.Items.Add(this.dropDown1);
            this.group1.Items.Add(this.box1);
            this.group1.Label = "Generation";
            this.group1.Name = "group1";
            this.group1.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.group1_DialogLauncherClick);
            // 
            // editBox1
            // 
            this.editBox1.Label = "Query";
            this.editBox1.MaxLength = 255;
            this.editBox1.Name = "editBox1";
            this.editBox1.ScreenTip = "Query text";
            this.editBox1.SuperTip = "Short query text for fast work";
            this.editBox1.Text = null;
            this.editBox1.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.editBox1_TextChanged);
            // 
            // dropDown1
            // 
            ribbonDropDownItemImpl1.Label = "Pro writer";
            ribbonDropDownItemImpl2.Label = "Science fiction";
            ribbonDropDownItemImpl3.Label = "Journalist";
            ribbonDropDownItemImpl4.Label = "Researcher";
            this.dropDown1.Items.Add(ribbonDropDownItemImpl1);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl2);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl3);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl4);
            this.dropDown1.Label = "Style";
            this.dropDown1.Name = "dropDown1";
            this.dropDown1.ScreenTip = "Writer\'s style";
            this.dropDown1.SuperTip = "Specify style of written text among these options";
            // 
            // box1
            // 
            this.box1.Items.Add(this.label1);
            this.box1.Items.Add(this.button1);
            this.box1.Items.Add(this.button2);
            this.box1.Name = "box1";
            // 
            // label1
            // 
            this.label1.Label = "Generate:";
            this.label1.Name = "label1";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = global::WordGPT.Properties.Resources.gen_big;
            this.button1.Label = "1";
            this.button1.Name = "button1";
            this.button1.ScreenTip = "Generate long";
            this.button1.ShowImage = true;
            this.button1.ShowLabel = false;
            this.button1.SuperTip = "Generate long response";
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Image = global::WordGPT.Properties.Resources.gen_less;
            this.button2.Label = "2";
            this.button2.Name = "button2";
            this.button2.ScreenTip = "Generate short";
            this.button2.ShowImage = true;
            this.button2.ShowLabel = false;
            this.button2.SuperTip = "Generate short response";
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button2_Click);
            // 
            // group2
            // 
            this.group2.DialogLauncher = ribbonDialogLauncherImpl2;
            this.group2.Items.Add(this.editBox2);
            this.group2.Items.Add(this.dropDown2);
            this.group2.Items.Add(this.box2);
            this.group2.Label = "Variation";
            this.group2.Name = "group2";
            this.group2.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.group2_DialogLauncherClick);
            // 
            // editBox2
            // 
            this.editBox2.Label = "Theme";
            this.editBox2.Name = "editBox2";
            this.editBox2.ScreenTip = "Theme for rewriting";
            this.editBox2.SuperTip = "You can keep it empty for keeping the theme of original text.";
            this.editBox2.Text = null;
            // 
            // dropDown2
            // 
            ribbonDropDownItemImpl5.Label = "Neutral";
            ribbonDropDownItemImpl5.ScreenTip = "Keeps style";
            ribbonDropDownItemImpl6.Label = "Official";
            ribbonDropDownItemImpl6.ScreenTip = "Uses more official words";
            ribbonDropDownItemImpl7.Label = "Daily";
            ribbonDropDownItemImpl7.ScreenTip = "Simplifies text";
            this.dropDown2.Items.Add(ribbonDropDownItemImpl5);
            this.dropDown2.Items.Add(ribbonDropDownItemImpl6);
            this.dropDown2.Items.Add(ribbonDropDownItemImpl7);
            this.dropDown2.Label = "Style";
            this.dropDown2.Name = "dropDown2";
            this.dropDown2.ScreenTip = "Select style";
            this.dropDown2.SuperTip = "Style of rewritten text.";
            // 
            // box2
            // 
            this.box2.Items.Add(this.label2);
            this.box2.Items.Add(this.button3);
            this.box2.Items.Add(this.button4);
            this.box2.Items.Add(this.button5);
            this.box2.Name = "box2";
            // 
            // label2
            // 
            this.label2.Label = "Generate:";
            this.label2.Name = "label2";
            // 
            // button3
            // 
            this.button3.Image = global::WordGPT.Properties.Resources.gen_less;
            this.button3.Label = "-";
            this.button3.Name = "button3";
            this.button3.ScreenTip = "Generate less";
            this.button3.ShowImage = true;
            this.button3.ShowLabel = false;
            this.button3.SuperTip = "Rewrites selection, while shortening it";
            this.button3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = global::WordGPT.Properties.Resources.gen_mid;
            this.button4.Label = "O";
            this.button4.Name = "button4";
            this.button4.ScreenTip = "Generate same";
            this.button4.ShowImage = true;
            this.button4.ShowLabel = false;
            this.button4.SuperTip = "Rewrites selection, while keeping it\'s size";
            this.button4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Image = global::WordGPT.Properties.Resources.gen_big;
            this.button5.Label = "+";
            this.button5.Name = "button5";
            this.button5.ScreenTip = "Generate more";
            this.button5.ShowImage = true;
            this.button5.ShowLabel = false;
            this.button5.SuperTip = "Rewrites selection, while elongating it";
            this.button5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button5_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.tab2);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        private Microsoft.Office.Tools.Ribbon.RibbonTab tab2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox1;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox2;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box2;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button5;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown2;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
