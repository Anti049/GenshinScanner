namespace GenshinScanner
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCurrentStatus = new System.Windows.Forms.Label();
            this.buttonScan = new System.Windows.Forms.Button();
            this.comboDelay = new System.Windows.Forms.ComboBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.spacerItems = new System.Windows.Forms.Label();
            this.checkWishHistory = new System.Windows.Forms.CheckBox();
            this.checkFurnishings = new System.Windows.Forms.CheckBox();
            this.checkPreciousItems = new System.Windows.Forms.CheckBox();
            this.checkQuestItems = new System.Windows.Forms.CheckBox();
            this.checkGadgets = new System.Windows.Forms.CheckBox();
            this.checkMaterials = new System.Windows.Forms.CheckBox();
            this.checkFood = new System.Windows.Forms.CheckBox();
            this.checkItems = new System.Windows.Forms.CheckBox();
            this.checkArtifacts = new System.Windows.Forms.CheckBox();
            this.checkWeapons = new System.Windows.Forms.CheckBox();
            this.checkCharacters = new System.Windows.Forms.CheckBox();
            this.labelItems = new System.Windows.Forms.Label();
            this.spacerLanguage = new System.Windows.Forms.Label();
            this.comboLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCharacters = new System.Windows.Forms.TabPage();
            this.splitContainerCharacters = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainerCharacterDetails = new System.Windows.Forms.SplitContainer();
            this.panelCharacterImage = new GenshinScanner.Components.DoubleBufferedPanel();
            this.pictureCharacterImage = new GenshinScanner.Components.DoubleBufferedPanel();
            this.panelCharacterDetails = new GenshinScanner.Components.DoubleBufferedPanel();
            this.tabWeapons = new System.Windows.Forms.TabPage();
            this.tabArtifacts = new System.Windows.Forms.TabPage();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.tabFood = new System.Windows.Forms.TabPage();
            this.tabMaterials = new System.Windows.Forms.TabPage();
            this.tabGadgets = new System.Windows.Forms.TabPage();
            this.tabQuestItems = new System.Windows.Forms.TabPage();
            this.tabPreciousItems = new System.Windows.Forms.TabPage();
            this.tabFurnishings = new System.Windows.Forms.TabPage();
            this.tabWishHistory = new System.Windows.Forms.TabPage();
            this.spacerOutputLog = new System.Windows.Forms.Label();
            this.labelOutputLog = new System.Windows.Forms.Label();
            this.panelOutputLog = new System.Windows.Forms.Panel();
            this.textOutputLog = new System.Windows.Forms.RichTextBox();
            this.spacerOutputFileLocation = new System.Windows.Forms.Label();
            this.panelOutputFileLocation = new System.Windows.Forms.Panel();
            this.textOutputFileLocation = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelOutputFileLocation = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCharacterName = new System.Windows.Forms.Label();
            this.pictureCharacterElement = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureCharacterClass = new System.Windows.Forms.PictureBox();
            this.labelCharacterClass = new System.Windows.Forms.Label();
            this.spacerCharacterClass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCharacterDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCharacters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCharacters)).BeginInit();
            this.splitContainerCharacters.Panel1.SuspendLayout();
            this.splitContainerCharacters.Panel2.SuspendLayout();
            this.splitContainerCharacters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCharacterDetails)).BeginInit();
            this.splitContainerCharacterDetails.Panel1.SuspendLayout();
            this.splitContainerCharacterDetails.Panel2.SuspendLayout();
            this.splitContainerCharacterDetails.SuspendLayout();
            this.panelCharacterImage.SuspendLayout();
            this.panelCharacterDetails.SuspendLayout();
            this.panelOutputLog.SuspendLayout();
            this.panelOutputFileLocation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCharacterElement)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCharacterClass)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.splitContainerMain, "splitContainerMain");
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.labelStatus);
            this.splitContainerMain.Panel1.Controls.Add(this.labelCurrentStatus);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonScan);
            this.splitContainerMain.Panel1.Controls.Add(this.comboDelay);
            this.splitContainerMain.Panel1.Controls.Add(this.labelDelay);
            this.splitContainerMain.Panel1.Controls.Add(this.spacerItems);
            this.splitContainerMain.Panel1.Controls.Add(this.checkWishHistory);
            this.splitContainerMain.Panel1.Controls.Add(this.checkFurnishings);
            this.splitContainerMain.Panel1.Controls.Add(this.checkPreciousItems);
            this.splitContainerMain.Panel1.Controls.Add(this.checkQuestItems);
            this.splitContainerMain.Panel1.Controls.Add(this.checkGadgets);
            this.splitContainerMain.Panel1.Controls.Add(this.checkMaterials);
            this.splitContainerMain.Panel1.Controls.Add(this.checkFood);
            this.splitContainerMain.Panel1.Controls.Add(this.checkItems);
            this.splitContainerMain.Panel1.Controls.Add(this.checkArtifacts);
            this.splitContainerMain.Panel1.Controls.Add(this.checkWeapons);
            this.splitContainerMain.Panel1.Controls.Add(this.checkCharacters);
            this.splitContainerMain.Panel1.Controls.Add(this.labelItems);
            this.splitContainerMain.Panel1.Controls.Add(this.spacerLanguage);
            this.splitContainerMain.Panel1.Controls.Add(this.comboLanguage);
            this.splitContainerMain.Panel1.Controls.Add(this.labelLanguage);
            resources.ApplyResources(this.splitContainerMain.Panel1, "splitContainerMain.Panel1");
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tabControl1);
            this.splitContainerMain.Panel2.Controls.Add(this.spacerOutputLog);
            this.splitContainerMain.Panel2.Controls.Add(this.labelOutputLog);
            this.splitContainerMain.Panel2.Controls.Add(this.panelOutputLog);
            this.splitContainerMain.Panel2.Controls.Add(this.spacerOutputFileLocation);
            this.splitContainerMain.Panel2.Controls.Add(this.panelOutputFileLocation);
            this.splitContainerMain.Panel2.Controls.Add(this.labelOutputFileLocation);
            resources.ApplyResources(this.splitContainerMain.Panel2, "splitContainerMain.Panel2");
            // 
            // labelStatus
            // 
            resources.ApplyResources(this.labelStatus, "labelStatus");
            this.labelStatus.Name = "labelStatus";
            // 
            // labelCurrentStatus
            // 
            resources.ApplyResources(this.labelCurrentStatus, "labelCurrentStatus");
            this.labelCurrentStatus.Name = "labelCurrentStatus";
            // 
            // buttonScan
            // 
            resources.ApplyResources(this.buttonScan, "buttonScan");
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.UseVisualStyleBackColor = true;
            // 
            // comboDelay
            // 
            resources.ApplyResources(this.comboDelay, "comboDelay");
            this.comboDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDelay.FormattingEnabled = true;
            this.comboDelay.Items.AddRange(new object[] {
            resources.GetString("comboDelay.Items"),
            resources.GetString("comboDelay.Items1"),
            resources.GetString("comboDelay.Items2")});
            this.comboDelay.Name = "comboDelay";
            // 
            // labelDelay
            // 
            resources.ApplyResources(this.labelDelay, "labelDelay");
            this.labelDelay.Name = "labelDelay";
            // 
            // spacerItems
            // 
            resources.ApplyResources(this.spacerItems, "spacerItems");
            this.spacerItems.Name = "spacerItems";
            // 
            // checkWishHistory
            // 
            resources.ApplyResources(this.checkWishHistory, "checkWishHistory");
            this.checkWishHistory.Checked = true;
            this.checkWishHistory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWishHistory.Name = "checkWishHistory";
            this.checkWishHistory.UseVisualStyleBackColor = true;
            // 
            // checkFurnishings
            // 
            resources.ApplyResources(this.checkFurnishings, "checkFurnishings");
            this.checkFurnishings.Checked = true;
            this.checkFurnishings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFurnishings.Name = "checkFurnishings";
            this.checkFurnishings.UseVisualStyleBackColor = true;
            // 
            // checkPreciousItems
            // 
            resources.ApplyResources(this.checkPreciousItems, "checkPreciousItems");
            this.checkPreciousItems.Checked = true;
            this.checkPreciousItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPreciousItems.Name = "checkPreciousItems";
            this.checkPreciousItems.UseVisualStyleBackColor = true;
            // 
            // checkQuestItems
            // 
            resources.ApplyResources(this.checkQuestItems, "checkQuestItems");
            this.checkQuestItems.Checked = true;
            this.checkQuestItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkQuestItems.Name = "checkQuestItems";
            this.checkQuestItems.UseVisualStyleBackColor = true;
            // 
            // checkGadgets
            // 
            resources.ApplyResources(this.checkGadgets, "checkGadgets");
            this.checkGadgets.Checked = true;
            this.checkGadgets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkGadgets.Name = "checkGadgets";
            this.checkGadgets.UseVisualStyleBackColor = true;
            // 
            // checkMaterials
            // 
            resources.ApplyResources(this.checkMaterials, "checkMaterials");
            this.checkMaterials.Checked = true;
            this.checkMaterials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMaterials.Name = "checkMaterials";
            this.checkMaterials.UseVisualStyleBackColor = true;
            // 
            // checkFood
            // 
            resources.ApplyResources(this.checkFood, "checkFood");
            this.checkFood.Checked = true;
            this.checkFood.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFood.Name = "checkFood";
            this.checkFood.UseVisualStyleBackColor = true;
            // 
            // checkItems
            // 
            resources.ApplyResources(this.checkItems, "checkItems");
            this.checkItems.Checked = true;
            this.checkItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkItems.Name = "checkItems";
            this.checkItems.UseVisualStyleBackColor = true;
            // 
            // checkArtifacts
            // 
            resources.ApplyResources(this.checkArtifacts, "checkArtifacts");
            this.checkArtifacts.Checked = true;
            this.checkArtifacts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkArtifacts.Name = "checkArtifacts";
            this.checkArtifacts.UseVisualStyleBackColor = true;
            // 
            // checkWeapons
            // 
            resources.ApplyResources(this.checkWeapons, "checkWeapons");
            this.checkWeapons.Checked = true;
            this.checkWeapons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWeapons.Name = "checkWeapons";
            this.checkWeapons.UseVisualStyleBackColor = true;
            // 
            // checkCharacters
            // 
            resources.ApplyResources(this.checkCharacters, "checkCharacters");
            this.checkCharacters.Checked = true;
            this.checkCharacters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCharacters.Name = "checkCharacters";
            this.checkCharacters.UseVisualStyleBackColor = true;
            // 
            // labelItems
            // 
            resources.ApplyResources(this.labelItems, "labelItems");
            this.labelItems.Name = "labelItems";
            // 
            // spacerLanguage
            // 
            resources.ApplyResources(this.spacerLanguage, "spacerLanguage");
            this.spacerLanguage.Name = "spacerLanguage";
            // 
            // comboLanguage
            // 
            resources.ApplyResources(this.comboLanguage, "comboLanguage");
            this.comboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguage.FormattingEnabled = true;
            this.comboLanguage.Items.AddRange(new object[] {
            resources.GetString("comboLanguage.Items"),
            resources.GetString("comboLanguage.Items1"),
            resources.GetString("comboLanguage.Items2"),
            resources.GetString("comboLanguage.Items3"),
            resources.GetString("comboLanguage.Items4"),
            resources.GetString("comboLanguage.Items5"),
            resources.GetString("comboLanguage.Items6")});
            this.comboLanguage.Name = "comboLanguage";
            // 
            // labelLanguage
            // 
            resources.ApplyResources(this.labelLanguage, "labelLanguage");
            this.labelLanguage.Name = "labelLanguage";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCharacters);
            this.tabControl1.Controls.Add(this.tabWeapons);
            this.tabControl1.Controls.Add(this.tabArtifacts);
            this.tabControl1.Controls.Add(this.tabItems);
            this.tabControl1.Controls.Add(this.tabFood);
            this.tabControl1.Controls.Add(this.tabMaterials);
            this.tabControl1.Controls.Add(this.tabGadgets);
            this.tabControl1.Controls.Add(this.tabQuestItems);
            this.tabControl1.Controls.Add(this.tabPreciousItems);
            this.tabControl1.Controls.Add(this.tabFurnishings);
            this.tabControl1.Controls.Add(this.tabWishHistory);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabCharacters
            // 
            this.tabCharacters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCharacters.Controls.Add(this.splitContainerCharacters);
            resources.ApplyResources(this.tabCharacters, "tabCharacters");
            this.tabCharacters.Name = "tabCharacters";
            this.tabCharacters.UseVisualStyleBackColor = true;
            // 
            // splitContainerCharacters
            // 
            this.splitContainerCharacters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.splitContainerCharacters, "splitContainerCharacters");
            this.splitContainerCharacters.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerCharacters.Name = "splitContainerCharacters";
            // 
            // splitContainerCharacters.Panel1
            // 
            this.splitContainerCharacters.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainerCharacters.Panel2
            // 
            this.splitContainerCharacters.Panel2.Controls.Add(this.splitContainerCharacterDetails);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            resources.GetString("listBox1.Items"),
            resources.GetString("listBox1.Items1"),
            resources.GetString("listBox1.Items2"),
            resources.GetString("listBox1.Items3"),
            resources.GetString("listBox1.Items4"),
            resources.GetString("listBox1.Items5")});
            this.listBox1.Name = "listBox1";
            // 
            // splitContainerCharacterDetails
            // 
            this.splitContainerCharacterDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.splitContainerCharacterDetails, "splitContainerCharacterDetails");
            this.splitContainerCharacterDetails.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerCharacterDetails.Name = "splitContainerCharacterDetails";
            // 
            // splitContainerCharacterDetails.Panel1
            // 
            this.splitContainerCharacterDetails.Panel1.Controls.Add(this.panelCharacterImage);
            // 
            // splitContainerCharacterDetails.Panel2
            // 
            this.splitContainerCharacterDetails.Panel2.Controls.Add(this.panelCharacterDetails);
            // 
            // panelCharacterImage
            // 
            this.panelCharacterImage.BackgroundImage = global::GenshinScanner.Resources._5star;
            resources.ApplyResources(this.panelCharacterImage, "panelCharacterImage");
            this.panelCharacterImage.Controls.Add(this.pictureCharacterImage);
            this.panelCharacterImage.Name = "panelCharacterImage";
            // 
            // pictureCharacterImage
            // 
            this.pictureCharacterImage.BackgroundImage = global::GenshinScanner.Resources.Example_Character;
            resources.ApplyResources(this.pictureCharacterImage, "pictureCharacterImage");
            this.pictureCharacterImage.Name = "pictureCharacterImage";
            // 
            // panelCharacterDetails
            // 
            this.panelCharacterDetails.BackgroundImage = global::GenshinScanner.Resources.Background;
            resources.ApplyResources(this.panelCharacterDetails, "panelCharacterDetails");
            this.panelCharacterDetails.Controls.Add(this.labelCharacterDescription);
            this.panelCharacterDetails.Controls.Add(this.label2);
            this.panelCharacterDetails.Controls.Add(this.label1);
            this.panelCharacterDetails.Controls.Add(this.spacerCharacterClass);
            this.panelCharacterDetails.Controls.Add(this.panel3);
            this.panelCharacterDetails.Controls.Add(this.panel2);
            this.panelCharacterDetails.ForeColor = System.Drawing.Color.White;
            this.panelCharacterDetails.Name = "panelCharacterDetails";
            this.panelCharacterDetails.Resize += new System.EventHandler(this.panelCharacterDetails_Resize);
            // 
            // tabWeapons
            // 
            resources.ApplyResources(this.tabWeapons, "tabWeapons");
            this.tabWeapons.Name = "tabWeapons";
            this.tabWeapons.UseVisualStyleBackColor = true;
            // 
            // tabArtifacts
            // 
            resources.ApplyResources(this.tabArtifacts, "tabArtifacts");
            this.tabArtifacts.Name = "tabArtifacts";
            this.tabArtifacts.UseVisualStyleBackColor = true;
            // 
            // tabItems
            // 
            resources.ApplyResources(this.tabItems, "tabItems");
            this.tabItems.Name = "tabItems";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // tabFood
            // 
            resources.ApplyResources(this.tabFood, "tabFood");
            this.tabFood.Name = "tabFood";
            this.tabFood.UseVisualStyleBackColor = true;
            // 
            // tabMaterials
            // 
            resources.ApplyResources(this.tabMaterials, "tabMaterials");
            this.tabMaterials.Name = "tabMaterials";
            this.tabMaterials.UseVisualStyleBackColor = true;
            // 
            // tabGadgets
            // 
            resources.ApplyResources(this.tabGadgets, "tabGadgets");
            this.tabGadgets.Name = "tabGadgets";
            this.tabGadgets.UseVisualStyleBackColor = true;
            // 
            // tabQuestItems
            // 
            resources.ApplyResources(this.tabQuestItems, "tabQuestItems");
            this.tabQuestItems.Name = "tabQuestItems";
            this.tabQuestItems.UseVisualStyleBackColor = true;
            // 
            // tabPreciousItems
            // 
            resources.ApplyResources(this.tabPreciousItems, "tabPreciousItems");
            this.tabPreciousItems.Name = "tabPreciousItems";
            this.tabPreciousItems.UseVisualStyleBackColor = true;
            // 
            // tabFurnishings
            // 
            resources.ApplyResources(this.tabFurnishings, "tabFurnishings");
            this.tabFurnishings.Name = "tabFurnishings";
            this.tabFurnishings.UseVisualStyleBackColor = true;
            // 
            // tabWishHistory
            // 
            resources.ApplyResources(this.tabWishHistory, "tabWishHistory");
            this.tabWishHistory.Name = "tabWishHistory";
            this.tabWishHistory.UseVisualStyleBackColor = true;
            // 
            // spacerOutputLog
            // 
            resources.ApplyResources(this.spacerOutputLog, "spacerOutputLog");
            this.spacerOutputLog.Name = "spacerOutputLog";
            // 
            // labelOutputLog
            // 
            resources.ApplyResources(this.labelOutputLog, "labelOutputLog");
            this.labelOutputLog.Name = "labelOutputLog";
            // 
            // panelOutputLog
            // 
            this.panelOutputLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutputLog.Controls.Add(this.textOutputLog);
            resources.ApplyResources(this.panelOutputLog, "panelOutputLog");
            this.panelOutputLog.Name = "panelOutputLog";
            // 
            // textOutputLog
            // 
            this.textOutputLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textOutputLog, "textOutputLog");
            this.textOutputLog.Name = "textOutputLog";
            // 
            // spacerOutputFileLocation
            // 
            resources.ApplyResources(this.spacerOutputFileLocation, "spacerOutputFileLocation");
            this.spacerOutputFileLocation.Name = "spacerOutputFileLocation";
            // 
            // panelOutputFileLocation
            // 
            this.panelOutputFileLocation.Controls.Add(this.textOutputFileLocation);
            this.panelOutputFileLocation.Controls.Add(this.buttonBrowse);
            resources.ApplyResources(this.panelOutputFileLocation, "panelOutputFileLocation");
            this.panelOutputFileLocation.Name = "panelOutputFileLocation";
            // 
            // textOutputFileLocation
            // 
            this.textOutputFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textOutputFileLocation, "textOutputFileLocation");
            this.textOutputFileLocation.Name = "textOutputFileLocation";
            // 
            // buttonBrowse
            // 
            resources.ApplyResources(this.buttonBrowse, "buttonBrowse");
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // labelOutputFileLocation
            // 
            resources.ApplyResources(this.labelOutputFileLocation, "labelOutputFileLocation");
            this.labelOutputFileLocation.Name = "labelOutputFileLocation";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startScanToolStripMenuItem,
            this.cancelScanToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // startScanToolStripMenuItem
            // 
            this.startScanToolStripMenuItem.Name = "startScanToolStripMenuItem";
            resources.ApplyResources(this.startScanToolStripMenuItem, "startScanToolStripMenuItem");
            // 
            // cancelScanToolStripMenuItem
            // 
            this.cancelScanToolStripMenuItem.Name = "cancelScanToolStripMenuItem";
            resources.ApplyResources(this.cancelScanToolStripMenuItem, "cancelScanToolStripMenuItem");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem,
            this.reportErrorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            resources.ApplyResources(this.instructionsToolStripMenuItem, "instructionsToolStripMenuItem");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // reportErrorToolStripMenuItem
            // 
            this.reportErrorToolStripMenuItem.Name = "reportErrorToolStripMenuItem";
            resources.ApplyResources(this.reportErrorToolStripMenuItem, "reportErrorToolStripMenuItem");
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.splitContainerMain);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureCharacterElement);
            this.panel2.Controls.Add(this.labelCharacterName);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // labelCharacterName
            // 
            resources.ApplyResources(this.labelCharacterName, "labelCharacterName");
            this.labelCharacterName.Name = "labelCharacterName";
            // 
            // pictureCharacterElement
            // 
            this.pictureCharacterElement.BackgroundImage = global::GenshinScanner.Resources.Cryo;
            resources.ApplyResources(this.pictureCharacterElement, "pictureCharacterElement");
            this.pictureCharacterElement.Name = "pictureCharacterElement";
            this.pictureCharacterElement.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelCharacterClass);
            this.panel3.Controls.Add(this.pictureCharacterClass);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // pictureCharacterClass
            // 
            this.pictureCharacterClass.BackgroundImage = global::GenshinScanner.Resources.Bow;
            resources.ApplyResources(this.pictureCharacterClass, "pictureCharacterClass");
            this.pictureCharacterClass.Name = "pictureCharacterClass";
            this.pictureCharacterClass.TabStop = false;
            // 
            // labelCharacterClass
            // 
            resources.ApplyResources(this.labelCharacterClass, "labelCharacterClass");
            this.labelCharacterClass.Name = "labelCharacterClass";
            // 
            // spacerCharacterClass
            // 
            resources.ApplyResources(this.spacerCharacterClass, "spacerCharacterClass");
            this.spacerCharacterClass.Name = "spacerCharacterClass";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // labelCharacterDescription
            // 
            resources.ApplyResources(this.labelCharacterDescription, "labelCharacterDescription");
            this.labelCharacterDescription.Name = "labelCharacterDescription";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCharacters.ResumeLayout(false);
            this.splitContainerCharacters.Panel1.ResumeLayout(false);
            this.splitContainerCharacters.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCharacters)).EndInit();
            this.splitContainerCharacters.ResumeLayout(false);
            this.splitContainerCharacterDetails.Panel1.ResumeLayout(false);
            this.splitContainerCharacterDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCharacterDetails)).EndInit();
            this.splitContainerCharacterDetails.ResumeLayout(false);
            this.panelCharacterImage.ResumeLayout(false);
            this.panelCharacterDetails.ResumeLayout(false);
            this.panelCharacterDetails.PerformLayout();
            this.panelOutputLog.ResumeLayout(false);
            this.panelOutputFileLocation.ResumeLayout(false);
            this.panelOutputFileLocation.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCharacterElement)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCharacterClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportErrorToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.CheckBox checkWishHistory;
        private System.Windows.Forms.CheckBox checkFurnishings;
        private System.Windows.Forms.CheckBox checkPreciousItems;
        private System.Windows.Forms.CheckBox checkQuestItems;
        private System.Windows.Forms.CheckBox checkGadgets;
        private System.Windows.Forms.CheckBox checkMaterials;
        private System.Windows.Forms.CheckBox checkFood;
        private System.Windows.Forms.CheckBox checkItems;
        private System.Windows.Forms.CheckBox checkArtifacts;
        private System.Windows.Forms.CheckBox checkWeapons;
        private System.Windows.Forms.CheckBox checkCharacters;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Label spacerLanguage;
        private System.Windows.Forms.ComboBox comboLanguage;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCurrentStatus;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.ComboBox comboDelay;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.Label spacerItems;
        private System.Windows.Forms.Label spacerOutputFileLocation;
        private System.Windows.Forms.Panel panelOutputFileLocation;
        private System.Windows.Forms.TextBox textOutputFileLocation;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelOutputFileLocation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCharacters;
        private System.Windows.Forms.TabPage tabWeapons;
        private System.Windows.Forms.Label spacerOutputLog;
        private System.Windows.Forms.Label labelOutputLog;
        private System.Windows.Forms.Panel panelOutputLog;
        private System.Windows.Forms.RichTextBox textOutputLog;
        private System.Windows.Forms.SplitContainer splitContainerCharacters;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainerCharacterDetails;
        private System.Windows.Forms.TabPage tabArtifacts;
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.TabPage tabFood;
        private System.Windows.Forms.TabPage tabMaterials;
        private System.Windows.Forms.TabPage tabGadgets;
        private System.Windows.Forms.TabPage tabQuestItems;
        private System.Windows.Forms.TabPage tabPreciousItems;
        private System.Windows.Forms.TabPage tabFurnishings;
        private System.Windows.Forms.TabPage tabWishHistory;
        private Components.DoubleBufferedPanel panelCharacterImage;
        private Components.DoubleBufferedPanel panelCharacterDetails;
        private Components.DoubleBufferedPanel pictureCharacterImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureCharacterElement;
        private System.Windows.Forms.Label labelCharacterName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelCharacterClass;
        private System.Windows.Forms.PictureBox pictureCharacterClass;
        private System.Windows.Forms.Label spacerCharacterClass;
        private System.Windows.Forms.Label labelCharacterDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}