namespace GenshinScanner
{
    partial class ScannerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScannerForm));
            this.tooltipCharacters = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipWeapons = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressScan = new System.Windows.Forms.ProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCurrentStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboDelay = new System.Windows.Forms.ComboBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.spacer2 = new System.Windows.Forms.Label();
            this.checkWishes = new System.Windows.Forms.CheckBox();
            this.checkFurnishings = new System.Windows.Forms.CheckBox();
            this.checkPrecious = new System.Windows.Forms.CheckBox();
            this.checkQuest = new System.Windows.Forms.CheckBox();
            this.checkGadgets = new System.Windows.Forms.CheckBox();
            this.checkMaterials = new System.Windows.Forms.CheckBox();
            this.checkFood = new System.Windows.Forms.CheckBox();
            this.checkItems = new System.Windows.Forms.CheckBox();
            this.checkArtifacts = new System.Windows.Forms.CheckBox();
            this.checkWeapons = new System.Windows.Forms.CheckBox();
            this.checkCharacters = new System.Windows.Forms.CheckBox();
            this.labelItems = new System.Windows.Forms.Label();
            this.spacer1 = new System.Windows.Forms.Label();
            this.comboLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.tabControlScanner = new System.Windows.Forms.TabControl();
            this.tabCharacters = new System.Windows.Forms.TabPage();
            this.tabWeapons = new System.Windows.Forms.TabPage();
            this.tabArtifacts = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.tabFood = new System.Windows.Forms.TabPage();
            this.tabMaterials = new System.Windows.Forms.TabPage();
            this.tabGadgets = new System.Windows.Forms.TabPage();
            this.tabQuestItems = new System.Windows.Forms.TabPage();
            this.tabPrecious = new System.Windows.Forms.TabPage();
            this.tabFurnishings = new System.Windows.Forms.TabPage();
            this.tabWishes = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tooltipCharacters
            // 
            this.tooltipCharacters.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltipCharacters.ToolTipTitle = "Scan Characters";
            // 
            // tooltipWeapons
            // 
            this.tooltipWeapons.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltipWeapons.ToolTipTitle = "Scan Weapons";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem, this.helpToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.startScanToolStripMenuItem, this.cancelScanToolStripMenuItem, this.toolStripMenuItem2, this.exitToolStripMenuItem });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // startScanToolStripMenuItem
            // 
            this.startScanToolStripMenuItem.Name = "startScanToolStripMenuItem";
            this.startScanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.startScanToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.startScanToolStripMenuItem.Text = "Start Scan";
            // 
            // cancelScanToolStripMenuItem
            // 
            this.cancelScanToolStripMenuItem.Name = "cancelScanToolStripMenuItem";
            this.cancelScanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cancelScanToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cancelScanToolStripMenuItem.Text = "Cancel Scan";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.instructionsToolStripMenuItem, this.toolStripMenuItem1, this.aboutToolStripMenuItem });
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // progressScan
            // 
            this.progressScan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressScan.Location = new System.Drawing.Point(0, 622);
            this.progressScan.Name = "progressScan";
            this.progressScan.Size = new System.Drawing.Size(1083, 35);
            this.progressScan.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.labelStatus);
            this.splitContainer1.Panel1.Controls.Add(this.labelCurrentStatus);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.comboDelay);
            this.splitContainer1.Panel1.Controls.Add(this.labelDelay);
            this.splitContainer1.Panel1.Controls.Add(this.spacer2);
            this.splitContainer1.Panel1.Controls.Add(this.checkWishes);
            this.splitContainer1.Panel1.Controls.Add(this.checkFurnishings);
            this.splitContainer1.Panel1.Controls.Add(this.checkPrecious);
            this.splitContainer1.Panel1.Controls.Add(this.checkQuest);
            this.splitContainer1.Panel1.Controls.Add(this.checkGadgets);
            this.splitContainer1.Panel1.Controls.Add(this.checkMaterials);
            this.splitContainer1.Panel1.Controls.Add(this.checkFood);
            this.splitContainer1.Panel1.Controls.Add(this.checkItems);
            this.splitContainer1.Panel1.Controls.Add(this.checkArtifacts);
            this.splitContainer1.Panel1.Controls.Add(this.checkWeapons);
            this.splitContainer1.Panel1.Controls.Add(this.checkCharacters);
            this.splitContainer1.Panel1.Controls.Add(this.labelItems);
            this.splitContainer1.Panel1.Controls.Add(this.spacer1);
            this.splitContainer1.Panel1.Controls.Add(this.comboLanguage);
            this.splitContainer1.Panel1.Controls.Add(this.labelLanguage);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlScanner);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.labelOutput);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Size = new System.Drawing.Size(1083, 597);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 2;
            // 
            // labelStatus
            // 
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelStatus.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(4, 495);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(222, 23);
            this.labelStatus.TabIndex = 31;
            this.labelStatus.Text = "Status:";
            // 
            // labelCurrentStatus
            // 
            this.labelCurrentStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelCurrentStatus.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentStatus.Location = new System.Drawing.Point(4, 518);
            this.labelCurrentStatus.Name = "labelCurrentStatus";
            this.labelCurrentStatus.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.labelCurrentStatus.Size = new System.Drawing.Size(222, 23);
            this.labelCurrentStatus.TabIndex = 30;
            this.labelCurrentStatus.Text = "Ready to Scan";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 50);
            this.button1.TabIndex = 29;
            this.button1.Text = "Start Scanning";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboDelay
            // 
            this.comboDelay.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDelay.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDelay.FormattingEnabled = true;
            this.comboDelay.Items.AddRange(new object[] { "0ms", "50ms", "100ms" });
            this.comboDelay.Location = new System.Drawing.Point(4, 411);
            this.comboDelay.Name = "comboDelay";
            this.comboDelay.Size = new System.Drawing.Size(222, 28);
            this.comboDelay.TabIndex = 28;
            // 
            // labelDelay
            // 
            this.labelDelay.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDelay.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelay.Location = new System.Drawing.Point(4, 388);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(222, 23);
            this.labelDelay.TabIndex = 27;
            this.labelDelay.Text = "Scanner Delay:";
            // 
            // spacer2
            // 
            this.spacer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer2.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spacer2.Location = new System.Drawing.Point(4, 365);
            this.spacer2.Name = "spacer2";
            this.spacer2.Size = new System.Drawing.Size(222, 23);
            this.spacer2.TabIndex = 26;
            // 
            // checkWishes
            // 
            this.checkWishes.Checked = true;
            this.checkWishes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWishes.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkWishes.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkWishes.Location = new System.Drawing.Point(4, 341);
            this.checkWishes.Name = "checkWishes";
            this.checkWishes.Size = new System.Drawing.Size(222, 24);
            this.checkWishes.TabIndex = 23;
            this.checkWishes.Text = "Wish History";
            this.checkWishes.UseVisualStyleBackColor = true;
            // 
            // checkFurnishings
            // 
            this.checkFurnishings.Checked = true;
            this.checkFurnishings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFurnishings.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkFurnishings.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFurnishings.Location = new System.Drawing.Point(4, 317);
            this.checkFurnishings.Name = "checkFurnishings";
            this.checkFurnishings.Size = new System.Drawing.Size(222, 24);
            this.checkFurnishings.TabIndex = 22;
            this.checkFurnishings.Text = "Furnishings";
            this.checkFurnishings.UseVisualStyleBackColor = true;
            // 
            // checkPrecious
            // 
            this.checkPrecious.Checked = true;
            this.checkPrecious.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPrecious.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkPrecious.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPrecious.Location = new System.Drawing.Point(4, 293);
            this.checkPrecious.Name = "checkPrecious";
            this.checkPrecious.Size = new System.Drawing.Size(222, 24);
            this.checkPrecious.TabIndex = 21;
            this.checkPrecious.Text = "Precious Items";
            this.checkPrecious.UseVisualStyleBackColor = true;
            // 
            // checkQuest
            // 
            this.checkQuest.Checked = true;
            this.checkQuest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkQuest.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkQuest.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkQuest.Location = new System.Drawing.Point(4, 269);
            this.checkQuest.Name = "checkQuest";
            this.checkQuest.Size = new System.Drawing.Size(222, 24);
            this.checkQuest.TabIndex = 20;
            this.checkQuest.Text = "Quest Items";
            this.checkQuest.UseVisualStyleBackColor = true;
            // 
            // checkGadgets
            // 
            this.checkGadgets.Checked = true;
            this.checkGadgets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkGadgets.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkGadgets.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGadgets.Location = new System.Drawing.Point(4, 245);
            this.checkGadgets.Name = "checkGadgets";
            this.checkGadgets.Size = new System.Drawing.Size(222, 24);
            this.checkGadgets.TabIndex = 19;
            this.checkGadgets.Text = "Gadgets";
            this.checkGadgets.UseVisualStyleBackColor = true;
            // 
            // checkMaterials
            // 
            this.checkMaterials.Checked = true;
            this.checkMaterials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMaterials.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkMaterials.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMaterials.Location = new System.Drawing.Point(4, 221);
            this.checkMaterials.Name = "checkMaterials";
            this.checkMaterials.Size = new System.Drawing.Size(222, 24);
            this.checkMaterials.TabIndex = 18;
            this.checkMaterials.Text = "Materials";
            this.checkMaterials.UseVisualStyleBackColor = true;
            // 
            // checkFood
            // 
            this.checkFood.Checked = true;
            this.checkFood.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkFood.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFood.Location = new System.Drawing.Point(4, 197);
            this.checkFood.Name = "checkFood";
            this.checkFood.Size = new System.Drawing.Size(222, 24);
            this.checkFood.TabIndex = 17;
            this.checkFood.Text = "Food";
            this.checkFood.UseVisualStyleBackColor = true;
            // 
            // checkItems
            // 
            this.checkItems.Checked = true;
            this.checkItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkItems.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkItems.Location = new System.Drawing.Point(4, 173);
            this.checkItems.Name = "checkItems";
            this.checkItems.Size = new System.Drawing.Size(222, 24);
            this.checkItems.TabIndex = 16;
            this.checkItems.Text = "Items";
            this.checkItems.UseVisualStyleBackColor = true;
            // 
            // checkArtifacts
            // 
            this.checkArtifacts.Checked = true;
            this.checkArtifacts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkArtifacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkArtifacts.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkArtifacts.Location = new System.Drawing.Point(4, 149);
            this.checkArtifacts.Name = "checkArtifacts";
            this.checkArtifacts.Size = new System.Drawing.Size(222, 24);
            this.checkArtifacts.TabIndex = 9;
            this.checkArtifacts.Text = "Artifacts";
            this.checkArtifacts.UseVisualStyleBackColor = true;
            // 
            // checkWeapons
            // 
            this.checkWeapons.Checked = true;
            this.checkWeapons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWeapons.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkWeapons.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkWeapons.Location = new System.Drawing.Point(4, 125);
            this.checkWeapons.Name = "checkWeapons";
            this.checkWeapons.Size = new System.Drawing.Size(222, 24);
            this.checkWeapons.TabIndex = 8;
            this.checkWeapons.Text = "Weapons";
            this.tooltipWeapons.SetToolTip(this.checkWeapons, "Scan weapon stats. This includes:\r\n - Weapon Name\r\n - Level\r\n - Ascension\r\n - Ref" + "inement Level\r\n - Equipped Character\r\n - Stats (TODO)");
            this.checkWeapons.UseVisualStyleBackColor = true;
            // 
            // checkCharacters
            // 
            this.checkCharacters.Checked = true;
            this.checkCharacters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCharacters.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkCharacters.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCharacters.Location = new System.Drawing.Point(4, 101);
            this.checkCharacters.Name = "checkCharacters";
            this.checkCharacters.Size = new System.Drawing.Size(222, 24);
            this.checkCharacters.TabIndex = 7;
            this.checkCharacters.Text = "Characters";
            this.tooltipCharacters.SetToolTip(this.checkCharacters, resources.GetString("checkCharacters.ToolTip"));
            this.checkCharacters.UseVisualStyleBackColor = true;
            // 
            // labelItems
            // 
            this.labelItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelItems.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItems.Location = new System.Drawing.Point(4, 78);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(222, 23);
            this.labelItems.TabIndex = 6;
            this.labelItems.Text = "Items to Scan:";
            // 
            // spacer1
            // 
            this.spacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer1.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spacer1.Location = new System.Drawing.Point(4, 55);
            this.spacer1.Name = "spacer1";
            this.spacer1.Size = new System.Drawing.Size(222, 23);
            this.spacer1.TabIndex = 4;
            // 
            // comboLanguage
            // 
            this.comboLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguage.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLanguage.FormattingEnabled = true;
            this.comboLanguage.Items.AddRange(new object[] { "English" });
            this.comboLanguage.Location = new System.Drawing.Point(4, 27);
            this.comboLanguage.Name = "comboLanguage";
            this.comboLanguage.Size = new System.Drawing.Size(222, 28);
            this.comboLanguage.TabIndex = 1;
            // 
            // labelLanguage
            // 
            this.labelLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLanguage.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguage.Location = new System.Drawing.Point(4, 4);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(222, 23);
            this.labelLanguage.TabIndex = 0;
            this.labelLanguage.Text = "Language:";
            // 
            // tabControlScanner
            // 
            this.tabControlScanner.Controls.Add(this.tabCharacters);
            this.tabControlScanner.Controls.Add(this.tabWeapons);
            this.tabControlScanner.Controls.Add(this.tabArtifacts);
            this.tabControlScanner.Controls.Add(this.tabItems);
            this.tabControlScanner.Controls.Add(this.tabFood);
            this.tabControlScanner.Controls.Add(this.tabMaterials);
            this.tabControlScanner.Controls.Add(this.tabGadgets);
            this.tabControlScanner.Controls.Add(this.tabQuestItems);
            this.tabControlScanner.Controls.Add(this.tabPrecious);
            this.tabControlScanner.Controls.Add(this.tabFurnishings);
            this.tabControlScanner.Controls.Add(this.tabWishes);
            this.tabControlScanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlScanner.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlScanner.Location = new System.Drawing.Point(4, 74);
            this.tabControlScanner.Name = "tabControlScanner";
            this.tabControlScanner.Padding = new System.Drawing.Point(10, 10);
            this.tabControlScanner.SelectedIndex = 0;
            this.tabControlScanner.Size = new System.Drawing.Size(837, 517);
            this.tabControlScanner.TabIndex = 6;
            // 
            // tabCharacters
            // 
            this.tabCharacters.Location = new System.Drawing.Point(4, 43);
            this.tabCharacters.Name = "tabCharacters";
            this.tabCharacters.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharacters.Size = new System.Drawing.Size(829, 470);
            this.tabCharacters.TabIndex = 1;
            this.tabCharacters.Text = "Characters: 0 / 0";
            this.tabCharacters.UseVisualStyleBackColor = true;
            // 
            // tabWeapons
            // 
            this.tabWeapons.Location = new System.Drawing.Point(4, 43);
            this.tabWeapons.Name = "tabWeapons";
            this.tabWeapons.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeapons.Size = new System.Drawing.Size(829, 470);
            this.tabWeapons.TabIndex = 0;
            this.tabWeapons.Text = "Weapons: 0 / 0";
            this.tabWeapons.UseVisualStyleBackColor = true;
            // 
            // tabArtifacts
            // 
            this.tabArtifacts.Location = new System.Drawing.Point(4, 43);
            this.tabArtifacts.Name = "tabArtifacts";
            this.tabArtifacts.Size = new System.Drawing.Size(829, 470);
            this.tabArtifacts.TabIndex = 2;
            this.tabArtifacts.Text = "Artifacts: 0 / 0";
            this.tabArtifacts.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 23);
            this.label1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(4, 27);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textFilePath);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonBrowse);
            this.splitContainer2.Size = new System.Drawing.Size(837, 24);
            this.splitContainer2.SplitterDistance = 737;
            this.splitContainer2.TabIndex = 2;
            // 
            // textFilePath
            // 
            this.textFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textFilePath.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFilePath.Location = new System.Drawing.Point(0, 0);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(737, 24);
            this.textFilePath.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBrowse.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(0, 0);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(96, 24);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // labelOutput
            // 
            this.labelOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOutput.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(4, 4);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(837, 23);
            this.labelOutput.TabIndex = 1;
            this.labelOutput.Text = "Output File Location:";
            // 
            // tabItems
            // 
            this.tabItems.Location = new System.Drawing.Point(4, 43);
            this.tabItems.Name = "tabItems";
            this.tabItems.Size = new System.Drawing.Size(829, 470);
            this.tabItems.TabIndex = 3;
            this.tabItems.Text = "Items: 0 / 0";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // tabFood
            // 
            this.tabFood.Location = new System.Drawing.Point(4, 43);
            this.tabFood.Name = "tabFood";
            this.tabFood.Size = new System.Drawing.Size(829, 470);
            this.tabFood.TabIndex = 4;
            this.tabFood.Text = "Food: 0 / 0";
            this.tabFood.UseVisualStyleBackColor = true;
            // 
            // tabMaterials
            // 
            this.tabMaterials.Location = new System.Drawing.Point(4, 43);
            this.tabMaterials.Name = "tabMaterials";
            this.tabMaterials.Size = new System.Drawing.Size(829, 470);
            this.tabMaterials.TabIndex = 5;
            this.tabMaterials.Text = "Materials: 0 / 0";
            this.tabMaterials.UseVisualStyleBackColor = true;
            // 
            // tabGadgets
            // 
            this.tabGadgets.Location = new System.Drawing.Point(4, 43);
            this.tabGadgets.Name = "tabGadgets";
            this.tabGadgets.Size = new System.Drawing.Size(829, 470);
            this.tabGadgets.TabIndex = 6;
            this.tabGadgets.Text = "Gadgets: 0 / 0";
            this.tabGadgets.UseVisualStyleBackColor = true;
            // 
            // tabQuestItems
            // 
            this.tabQuestItems.Location = new System.Drawing.Point(4, 43);
            this.tabQuestItems.Name = "tabQuestItems";
            this.tabQuestItems.Size = new System.Drawing.Size(829, 470);
            this.tabQuestItems.TabIndex = 7;
            this.tabQuestItems.Text = "Quest Items: 0 / 0";
            this.tabQuestItems.UseVisualStyleBackColor = true;
            // 
            // tabPrecious
            // 
            this.tabPrecious.Location = new System.Drawing.Point(4, 43);
            this.tabPrecious.Name = "tabPrecious";
            this.tabPrecious.Size = new System.Drawing.Size(829, 470);
            this.tabPrecious.TabIndex = 8;
            this.tabPrecious.Text = "Precious Items: 0 / 0";
            this.tabPrecious.UseVisualStyleBackColor = true;
            // 
            // tabFurnishings
            // 
            this.tabFurnishings.Location = new System.Drawing.Point(4, 43);
            this.tabFurnishings.Name = "tabFurnishings";
            this.tabFurnishings.Size = new System.Drawing.Size(829, 470);
            this.tabFurnishings.TabIndex = 9;
            this.tabFurnishings.Text = "Furnishings: 0 / 0";
            this.tabFurnishings.UseVisualStyleBackColor = true;
            // 
            // tabWishes
            // 
            this.tabWishes.Location = new System.Drawing.Point(4, 43);
            this.tabWishes.Name = "tabWishes";
            this.tabWishes.Size = new System.Drawing.Size(829, 470);
            this.tabWishes.TabIndex = 10;
            this.tabWishes.Text = "Wishes: 0 / 0";
            this.tabWishes.UseVisualStyleBackColor = true;
            // 
            // ScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 657);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.progressScan);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MiHoYo_SDK_Web", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ScannerForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlScanner.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.TabPage tabFood;
        private System.Windows.Forms.TabPage tabMaterials;
        private System.Windows.Forms.TabPage tabGadgets;
        private System.Windows.Forms.TabPage tabQuestItems;
        private System.Windows.Forms.TabPage tabPrecious;
        private System.Windows.Forms.TabPage tabFurnishings;
        private System.Windows.Forms.TabPage tabWishes;

        private System.Windows.Forms.ProgressBar progressScan;

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCurrentStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboDelay;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.Label spacer2;
        private System.Windows.Forms.CheckBox checkWishes;
        private System.Windows.Forms.CheckBox checkFurnishings;
        private System.Windows.Forms.CheckBox checkPrecious;
        private System.Windows.Forms.CheckBox checkQuest;
        private System.Windows.Forms.CheckBox checkGadgets;
        private System.Windows.Forms.CheckBox checkMaterials;
        private System.Windows.Forms.CheckBox checkFood;
        private System.Windows.Forms.CheckBox checkItems;
        private System.Windows.Forms.CheckBox checkArtifacts;
        private System.Windows.Forms.CheckBox checkWeapons;
        private System.Windows.Forms.CheckBox checkCharacters;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Label spacer1;
        private System.Windows.Forms.ComboBox comboLanguage;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.TabControl tabControlScanner;
        private System.Windows.Forms.TabPage tabWeapons;
        private System.Windows.Forms.TabPage tabArtifacts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textFilePath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelOutput;

        private System.Windows.Forms.ProgressBar progressBar1;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCharacters;

        private System.Windows.Forms.TextBox text;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelScanToolStripMenuItem;

        private System.Windows.Forms.ToolTip tooltipWeapons;

        private System.Windows.Forms.ToolTip tooltipCharacters;

        private System.Windows.Forms.CheckBox checkBoxWeapons;

        private System.Windows.Forms.CheckBox checkBox1;

        #endregion
    }
}