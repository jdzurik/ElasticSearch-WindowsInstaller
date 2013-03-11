namespace SetElasticsearchSettings
{
  partial class Form1
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
				 System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
				 this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
				 this.label3 = new System.Windows.Forms.Label();
				 this.label4 = new System.Windows.Forms.Label();
				 this.btnSave = new System.Windows.Forms.Button();
				 this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
				 this.txtMaxMem = new System.Windows.Forms.TextBox();
				 this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
				 this.txtMinMem = new System.Windows.Forms.TextBox();
				 this.btnSetJava = new System.Windows.Forms.Button();
				 this.label1 = new System.Windows.Forms.Label();
				 this.txtJavaHome = new System.Windows.Forms.TextBox();
				 this.txtESHome = new System.Windows.Forms.TextBox();
				 this.btnSetEsHome = new System.Windows.Forms.Button();
				 this.label2 = new System.Windows.Forms.Label();
				 this.txtOutput = new System.Windows.Forms.TextBox();
				 this.btnOpenPorts = new System.Windows.Forms.Button();
				 this.btnStopService = new System.Windows.Forms.Button();
				 this.btnStartService = new System.Windows.Forms.Button();
				 this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
				 this.tabControl1 = new System.Windows.Forms.TabControl();
				 this.tabSettings = new System.Windows.Forms.TabPage();
				 this.tabConfig = new System.Windows.Forms.TabPage();
				 this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
				 this.btnSaveConfig = new System.Windows.Forms.Button();
				 this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
				 this.label6 = new System.Windows.Forms.Label();
				 this.btnLoadConfig = new System.Windows.Forms.Button();
				 this.tabConfigText = new System.Windows.Forms.TabControl();
				 this.tabCT = new System.Windows.Forms.TabPage();
				 this.txtConfig = new System.Windows.Forms.TextBox();
				 this.tabYaml = new System.Windows.Forms.TabPage();
				 this.tviYaml = new System.Windows.Forms.TreeView();
				 this.tabFirewall = new System.Windows.Forms.TabPage();
				 this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
				 this.lblFirewallRAL = new System.Windows.Forms.Label();
				 this.txtRemoteAddress = new System.Windows.Forms.TextBox();
				 this.label8 = new System.Windows.Forms.Label();
				 this.tabService = new System.Windows.Forms.TabPage();
				 this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
				 this.label5 = new System.Windows.Forms.Label();
				 this.tabLogging = new System.Windows.Forms.TabPage();
				 this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
				 this.txtLogging = new System.Windows.Forms.TextBox();
				 this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
				 this.label7 = new System.Windows.Forms.Label();
				 this.lblLastUpdatedLog = new System.Windows.Forms.Label();
				 this.btnLogMonitor = new System.Windows.Forms.Button();
				 this.fswLogFile = new System.IO.FileSystemWatcher();
				 this.tableLayoutPanel1.SuspendLayout();
				 this.tableLayoutPanel2.SuspendLayout();
				 this.tableLayoutPanel3.SuspendLayout();
				 this.tabControl1.SuspendLayout();
				 this.tabSettings.SuspendLayout();
				 this.tabConfig.SuspendLayout();
				 this.tableLayoutPanel6.SuspendLayout();
				 this.tableLayoutPanel8.SuspendLayout();
				 this.tabConfigText.SuspendLayout();
				 this.tabCT.SuspendLayout();
				 this.tabYaml.SuspendLayout();
				 this.tabFirewall.SuspendLayout();
				 this.tableLayoutPanel5.SuspendLayout();
				 this.tabService.SuspendLayout();
				 this.tableLayoutPanel4.SuspendLayout();
				 this.tabLogging.SuspendLayout();
				 this.tableLayoutPanel7.SuspendLayout();
				 this.tableLayoutPanel9.SuspendLayout();
				 ((System.ComponentModel.ISupportInitialize)(this.fswLogFile)).BeginInit();
				 this.SuspendLayout();
				 // 
				 // tableLayoutPanel1
				 // 
				 this.tableLayoutPanel1.ColumnCount = 3;
				 this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.68354F));
				 this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.31645F));
				 this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
				 this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
				 this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
				 this.tableLayoutPanel1.Controls.Add(this.btnSave, 2, 4);
				 this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
				 this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
				 this.tableLayoutPanel1.Controls.Add(this.btnSetJava, 2, 1);
				 this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
				 this.tableLayoutPanel1.Controls.Add(this.txtJavaHome, 1, 1);
				 this.tableLayoutPanel1.Controls.Add(this.txtESHome, 1, 0);
				 this.tableLayoutPanel1.Controls.Add(this.btnSetEsHome, 2, 0);
				 this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
				 this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
				 this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
				 this.tableLayoutPanel1.Name = "tableLayoutPanel1";
				 this.tableLayoutPanel1.RowCount = 6;
				 this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
				 this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
				 this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
				 this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
				 this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
				 this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
				 this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 448);
				 this.tableLayoutPanel1.TabIndex = 0;
				 // 
				 // label3
				 // 
				 this.label3.AutoSize = true;
				 this.label3.Location = new System.Drawing.Point(3, 60);
				 this.label3.Name = "label3";
				 this.label3.Size = new System.Drawing.Size(88, 13);
				 this.label3.TabIndex = 2;
				 this.label3.Text = "Minimum Memory";
				 // 
				 // label4
				 // 
				 this.label4.AutoSize = true;
				 this.label4.Location = new System.Drawing.Point(3, 90);
				 this.label4.Name = "label4";
				 this.label4.Size = new System.Drawing.Size(91, 13);
				 this.label4.TabIndex = 3;
				 this.label4.Text = "Maximum Memory";
				 // 
				 // btnSave
				 // 
				 this.btnSave.Location = new System.Drawing.Point(523, 123);
				 this.btnSave.Name = "btnSave";
				 this.btnSave.Size = new System.Drawing.Size(114, 23);
				 this.btnSave.TabIndex = 10;
				 this.btnSave.Text = "Save Settings";
				 this.btnSave.UseVisualStyleBackColor = true;
				 this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
				 // 
				 // tableLayoutPanel2
				 // 
				 this.tableLayoutPanel2.ColumnCount = 2;
				 this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.12903F));
				 this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.87096F));
				 this.tableLayoutPanel2.Controls.Add(this.txtMaxMem, 0, 0);
				 this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
				 this.tableLayoutPanel2.Location = new System.Drawing.Point(131, 93);
				 this.tableLayoutPanel2.Name = "tableLayoutPanel2";
				 this.tableLayoutPanel2.RowCount = 1;
				 this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
				 this.tableLayoutPanel2.Size = new System.Drawing.Size(386, 24);
				 this.tableLayoutPanel2.TabIndex = 15;
				 // 
				 // txtMaxMem
				 // 
				 this.txtMaxMem.Location = new System.Drawing.Point(3, 3);
				 this.txtMaxMem.Name = "txtMaxMem";
				 this.txtMaxMem.Size = new System.Drawing.Size(48, 20);
				 this.txtMaxMem.TabIndex = 4;
				 this.txtMaxMem.Text = "1g";
				 // 
				 // tableLayoutPanel3
				 // 
				 this.tableLayoutPanel3.ColumnCount = 2;
				 this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.98113F));
				 this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.01887F));
				 this.tableLayoutPanel3.Controls.Add(this.txtMinMem, 0, 0);
				 this.tableLayoutPanel3.Location = new System.Drawing.Point(131, 63);
				 this.tableLayoutPanel3.Name = "tableLayoutPanel3";
				 this.tableLayoutPanel3.RowCount = 1;
				 this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
				 this.tableLayoutPanel3.Size = new System.Drawing.Size(318, 24);
				 this.tableLayoutPanel3.TabIndex = 16;
				 // 
				 // txtMinMem
				 // 
				 this.txtMinMem.Location = new System.Drawing.Point(3, 3);
				 this.txtMinMem.Name = "txtMinMem";
				 this.txtMinMem.Size = new System.Drawing.Size(47, 20);
				 this.txtMinMem.TabIndex = 5;
				 this.txtMinMem.Text = "256m";
				 // 
				 // btnSetJava
				 // 
				 this.btnSetJava.Location = new System.Drawing.Point(523, 33);
				 this.btnSetJava.Name = "btnSetJava";
				 this.btnSetJava.Size = new System.Drawing.Size(123, 23);
				 this.btnSetJava.TabIndex = 8;
				 this.btnSetJava.Text = "Set Java Directory";
				 this.btnSetJava.UseVisualStyleBackColor = true;
				 this.btnSetJava.Click += new System.EventHandler(this.btnSetJava_Click);
				 // 
				 // label1
				 // 
				 this.label1.AutoSize = true;
				 this.label1.Location = new System.Drawing.Point(3, 30);
				 this.label1.Name = "label1";
				 this.label1.Size = new System.Drawing.Size(61, 13);
				 this.label1.TabIndex = 0;
				 this.label1.Text = "Java Home";
				 // 
				 // txtJavaHome
				 // 
				 this.txtJavaHome.Dock = System.Windows.Forms.DockStyle.Top;
				 this.txtJavaHome.Location = new System.Drawing.Point(131, 33);
				 this.txtJavaHome.Name = "txtJavaHome";
				 this.txtJavaHome.Size = new System.Drawing.Size(386, 20);
				 this.txtJavaHome.TabIndex = 6;
				 // 
				 // txtESHome
				 // 
				 this.txtESHome.Dock = System.Windows.Forms.DockStyle.Top;
				 this.txtESHome.Location = new System.Drawing.Point(131, 3);
				 this.txtESHome.Name = "txtESHome";
				 this.txtESHome.Size = new System.Drawing.Size(386, 20);
				 this.txtESHome.TabIndex = 7;
				 // 
				 // btnSetEsHome
				 // 
				 this.btnSetEsHome.Location = new System.Drawing.Point(523, 3);
				 this.btnSetEsHome.Name = "btnSetEsHome";
				 this.btnSetEsHome.Size = new System.Drawing.Size(123, 23);
				 this.btnSetEsHome.TabIndex = 9;
				 this.btnSetEsHome.Text = "Set ES Directory";
				 this.btnSetEsHome.UseVisualStyleBackColor = true;
				 this.btnSetEsHome.Click += new System.EventHandler(this.btnSetEsHome_Click);
				 // 
				 // label2
				 // 
				 this.label2.AutoSize = true;
				 this.label2.Location = new System.Drawing.Point(3, 0);
				 this.label2.Name = "label2";
				 this.label2.Size = new System.Drawing.Size(103, 13);
				 this.label2.TabIndex = 1;
				 this.label2.Text = "ElasticSearch Home";
				 // 
				 // txtOutput
				 // 
				 this.tableLayoutPanel4.SetColumnSpan(this.txtOutput, 3);
				 this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
				 this.txtOutput.Location = new System.Drawing.Point(3, 36);
				 this.txtOutput.Multiline = true;
				 this.txtOutput.Name = "txtOutput";
				 this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
				 this.txtOutput.Size = new System.Drawing.Size(652, 409);
				 this.txtOutput.TabIndex = 14;
				 // 
				 // btnOpenPorts
				 // 
				 this.btnOpenPorts.Location = new System.Drawing.Point(518, 23);
				 this.btnOpenPorts.Name = "btnOpenPorts";
				 this.btnOpenPorts.Size = new System.Drawing.Size(111, 23);
				 this.btnOpenPorts.TabIndex = 17;
				 this.btnOpenPorts.Text = "Open Firewall Ports";
				 this.btnOpenPorts.UseVisualStyleBackColor = true;
				 this.btnOpenPorts.Click += new System.EventHandler(this.btnOpenPorts_Click);
				 // 
				 // btnStopService
				 // 
				 this.btnStopService.Location = new System.Drawing.Point(558, 3);
				 this.btnStopService.Name = "btnStopService";
				 this.btnStopService.Size = new System.Drawing.Size(91, 23);
				 this.btnStopService.TabIndex = 13;
				 this.btnStopService.Text = "Stop Service";
				 this.btnStopService.UseVisualStyleBackColor = true;
				 this.btnStopService.Click += new System.EventHandler(this.btnStopService_Click);
				 // 
				 // btnStartService
				 // 
				 this.btnStartService.Location = new System.Drawing.Point(3, 3);
				 this.btnStartService.Name = "btnStartService";
				 this.btnStartService.Size = new System.Drawing.Size(114, 23);
				 this.btnStartService.TabIndex = 11;
				 this.btnStartService.Text = "Start Service";
				 this.btnStartService.UseVisualStyleBackColor = true;
				 this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
				 // 
				 // tabControl1
				 // 
				 this.tabControl1.Controls.Add(this.tabSettings);
				 this.tabControl1.Controls.Add(this.tabConfig);
				 this.tabControl1.Controls.Add(this.tabFirewall);
				 this.tabControl1.Controls.Add(this.tabService);
				 this.tabControl1.Controls.Add(this.tabLogging);
				 this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
				 this.tabControl1.Location = new System.Drawing.Point(0, 0);
				 this.tabControl1.Name = "tabControl1";
				 this.tabControl1.SelectedIndex = 0;
				 this.tabControl1.Size = new System.Drawing.Size(672, 480);
				 this.tabControl1.TabIndex = 1;
				 // 
				 // tabSettings
				 // 
				 this.tabSettings.Controls.Add(this.tableLayoutPanel1);
				 this.tabSettings.Location = new System.Drawing.Point(4, 22);
				 this.tabSettings.Name = "tabSettings";
				 this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
				 this.tabSettings.Size = new System.Drawing.Size(664, 454);
				 this.tabSettings.TabIndex = 0;
				 this.tabSettings.Text = "Settings";
				 this.tabSettings.UseVisualStyleBackColor = true;
				 // 
				 // tabConfig
				 // 
				 this.tabConfig.Controls.Add(this.tableLayoutPanel6);
				 this.tabConfig.Location = new System.Drawing.Point(4, 22);
				 this.tabConfig.Name = "tabConfig";
				 this.tabConfig.Size = new System.Drawing.Size(664, 454);
				 this.tabConfig.TabIndex = 4;
				 this.tabConfig.Text = "Config";
				 this.tabConfig.UseVisualStyleBackColor = true;
				 // 
				 // tableLayoutPanel6
				 // 
				 this.tableLayoutPanel6.ColumnCount = 1;
				 this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
				 this.tableLayoutPanel6.Controls.Add(this.btnSaveConfig, 0, 2);
				 this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 0, 0);
				 this.tableLayoutPanel6.Controls.Add(this.tabConfigText, 0, 1);
				 this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
				 this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
				 this.tableLayoutPanel6.Name = "tableLayoutPanel6";
				 this.tableLayoutPanel6.RowCount = 3;
				 this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
				 this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 378F));
				 this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
				 this.tableLayoutPanel6.Size = new System.Drawing.Size(664, 454);
				 this.tableLayoutPanel6.TabIndex = 0;
				 // 
				 // btnSaveConfig
				 // 
				 this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
				 this.btnSaveConfig.Location = new System.Drawing.Point(586, 420);
				 this.btnSaveConfig.Name = "btnSaveConfig";
				 this.btnSaveConfig.Size = new System.Drawing.Size(75, 23);
				 this.btnSaveConfig.TabIndex = 0;
				 this.btnSaveConfig.Text = "Save Config";
				 this.btnSaveConfig.UseVisualStyleBackColor = true;
				 this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
				 // 
				 // tableLayoutPanel8
				 // 
				 this.tableLayoutPanel8.ColumnCount = 2;
				 this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
				 this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
				 this.tableLayoutPanel8.Controls.Add(this.label6, 0, 0);
				 this.tableLayoutPanel8.Controls.Add(this.btnLoadConfig, 1, 0);
				 this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
				 this.tableLayoutPanel8.Name = "tableLayoutPanel8";
				 this.tableLayoutPanel8.RowCount = 1;
				 this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
				 this.tableLayoutPanel8.Size = new System.Drawing.Size(249, 30);
				 this.tableLayoutPanel8.TabIndex = 3;
				 // 
				 // label6
				 // 
				 this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
				 this.label6.AutoSize = true;
				 this.label6.Location = new System.Drawing.Point(3, 17);
				 this.label6.Name = "label6";
				 this.label6.Size = new System.Drawing.Size(102, 13);
				 this.label6.TabIndex = 2;
				 this.label6.Text = "Elasticsearch.config";
				 // 
				 // btnLoadConfig
				 // 
				 this.btnLoadConfig.Location = new System.Drawing.Point(132, 3);
				 this.btnLoadConfig.Name = "btnLoadConfig";
				 this.btnLoadConfig.Size = new System.Drawing.Size(75, 23);
				 this.btnLoadConfig.TabIndex = 3;
				 this.btnLoadConfig.Text = "Load Config";
				 this.btnLoadConfig.UseVisualStyleBackColor = true;
				 this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
				 // 
				 // tabConfigText
				 // 
				 this.tabConfigText.Controls.Add(this.tabCT);
				 this.tabConfigText.Controls.Add(this.tabYaml);
				 this.tabConfigText.Dock = System.Windows.Forms.DockStyle.Fill;
				 this.tabConfigText.Location = new System.Drawing.Point(3, 42);
				 this.tabConfigText.Name = "tabConfigText";
				 this.tabConfigText.SelectedIndex = 0;
				 this.tabConfigText.Size = new System.Drawing.Size(658, 372);
				 this.tabConfigText.TabIndex = 4;
				 this.tabConfigText.SelectedIndexChanged += new System.EventHandler(this.tabConfigText_SelectedIndexChanged);
				 // 
				 // tabCT
				 // 
				 this.tabCT.Controls.Add(this.txtConfig);
				 this.tabCT.Location = new System.Drawing.Point(4, 22);
				 this.tabCT.Name = "tabCT";
				 this.tabCT.Padding = new System.Windows.Forms.Padding(3);
				 this.tabCT.Size = new System.Drawing.Size(650, 346);
				 this.tabCT.TabIndex = 1;
				 this.tabCT.Text = "Config Text";
				 this.tabCT.UseVisualStyleBackColor = true;
				 // 
				 // txtConfig
				 // 
				 this.txtConfig.Dock = System.Windows.Forms.DockStyle.Fill;
				 this.txtConfig.Location = new System.Drawing.Point(3, 3);
				 this.txtConfig.Multiline = true;
				 this.txtConfig.Name = "txtConfig";
				 this.txtConfig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
				 this.txtConfig.Size = new System.Drawing.Size(644, 340);
				 this.txtConfig.TabIndex = 1;
				 // 
				 // tabYaml
				 // 
				 this.tabYaml.Controls.Add(this.tviYaml);
				 this.tabYaml.Location = new System.Drawing.Point(4, 22);
				 this.tabYaml.Name = "tabYaml";
				 this.tabYaml.Padding = new System.Windows.Forms.Padding(3);
				 this.tabYaml.Size = new System.Drawing.Size(650, 346);
				 this.tabYaml.TabIndex = 0;
				 this.tabYaml.Text = "Yaml Check";
				 this.tabYaml.UseVisualStyleBackColor = true;
				 // 
				 // tviYaml
				 // 
				 this.tviYaml.Dock = System.Windows.Forms.DockStyle.Fill;
				 this.tviYaml.Location = new System.Drawing.Point(3, 3);
				 this.tviYaml.Name = "tviYaml";
				 this.tviYaml.Size = new System.Drawing.Size(644, 340);
				 this.tviYaml.TabIndex = 0;
				 // 
				 // tabFirewall
				 // 
				 this.tabFirewall.Controls.Add(this.tableLayoutPanel5);
				 this.tabFirewall.Location = new System.Drawing.Point(4, 22);
				 this.tabFirewall.Name = "tabFirewall";
				 this.tabFirewall.Padding = new System.Windows.Forms.Padding(3);
				 this.tabFirewall.Size = new System.Drawing.Size(664, 454);
				 this.tabFirewall.TabIndex = 1;
				 this.tabFirewall.Text = "Firewall";
				 this.tabFirewall.UseVisualStyleBackColor = true;
				 // 
				 // tableLayoutPanel5
				 // 
				 this.tableLayoutPanel5.ColumnCount = 2;
				 this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 515F));
				 this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
				 this.tableLayoutPanel5.Controls.Add(this.lblFirewallRAL, 0, 0);
				 this.tableLayoutPanel5.Controls.Add(this.btnOpenPorts, 1, 1);
				 this.tableLayoutPanel5.Controls.Add(this.txtRemoteAddress, 0, 1);
				 this.tableLayoutPanel5.Controls.Add(this.label8, 0, 2);
				 this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
				 this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
				 this.tableLayoutPanel5.Name = "tableLayoutPanel5";
				 this.tableLayoutPanel5.RowCount = 3;
				 this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
				 this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
				 this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
				 this.tableLayoutPanel5.Size = new System.Drawing.Size(658, 448);
				 this.tableLayoutPanel5.TabIndex = 0;
				 // 
				 // lblFirewallRAL
				 // 
				 this.lblFirewallRAL.AutoSize = true;
				 this.lblFirewallRAL.Location = new System.Drawing.Point(3, 0);
				 this.lblFirewallRAL.Name = "lblFirewallRAL";
				 this.lblFirewallRAL.Size = new System.Drawing.Size(235, 13);
				 this.lblFirewallRAL.TabIndex = 19;
				 this.lblFirewallRAL.Text = "Enter Remote Addresses below to alow access: ";
				 // 
				 // txtRemoteAddress
				 // 
				 this.txtRemoteAddress.Location = new System.Drawing.Point(3, 23);
				 this.txtRemoteAddress.Multiline = true;
				 this.txtRemoteAddress.Name = "txtRemoteAddress";
				 this.txtRemoteAddress.Size = new System.Drawing.Size(413, 100);
				 this.txtRemoteAddress.TabIndex = 20;
				 // 
				 // label8
				 // 
				 this.label8.AutoSize = true;
				 this.label8.Location = new System.Drawing.Point(3, 148);
				 this.label8.Name = "label8";
				 this.label8.Size = new System.Drawing.Size(509, 182);
				 this.label8.TabIndex = 21;
				 this.label8.Text = resources.GetString("label8.Text");
				 // 
				 // tabService
				 // 
				 this.tabService.Controls.Add(this.tableLayoutPanel4);
				 this.tabService.Location = new System.Drawing.Point(4, 22);
				 this.tabService.Name = "tabService";
				 this.tabService.Padding = new System.Windows.Forms.Padding(3);
				 this.tabService.Size = new System.Drawing.Size(664, 454);
				 this.tabService.TabIndex = 2;
				 this.tabService.Text = "Service";
				 this.tabService.UseVisualStyleBackColor = true;
				 // 
				 // tableLayoutPanel4
				 // 
				 this.tableLayoutPanel4.ColumnCount = 3;
				 this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
				 this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
				 this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
				 this.tableLayoutPanel4.Controls.Add(this.btnStartService, 0, 0);
				 this.tableLayoutPanel4.Controls.Add(this.btnStopService, 2, 0);
				 this.tableLayoutPanel4.Controls.Add(this.txtOutput, 0, 1);
				 this.tableLayoutPanel4.Controls.Add(this.label5, 1, 0);
				 this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
				 this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
				 this.tableLayoutPanel4.Name = "tableLayoutPanel4";
				 this.tableLayoutPanel4.RowCount = 2;
				 this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
				 this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
				 this.tableLayoutPanel4.Size = new System.Drawing.Size(658, 448);
				 this.tableLayoutPanel4.TabIndex = 0;
				 // 
				 // label5
				 // 
				 this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
				 this.label5.AutoSize = true;
				 this.label5.Location = new System.Drawing.Point(134, 20);
				 this.label5.Name = "label5";
				 this.label5.Size = new System.Drawing.Size(418, 13);
				 this.label5.TabIndex = 0;
				 this.label5.Text = "Service Response:";
				 // 
				 // tabLogging
				 // 
				 this.tabLogging.Controls.Add(this.tableLayoutPanel7);
				 this.tabLogging.Location = new System.Drawing.Point(4, 22);
				 this.tabLogging.Name = "tabLogging";
				 this.tabLogging.Size = new System.Drawing.Size(664, 454);
				 this.tabLogging.TabIndex = 3;
				 this.tabLogging.Text = "Log";
				 this.tabLogging.UseVisualStyleBackColor = true;
				 // 
				 // tableLayoutPanel7
				 // 
				 this.tableLayoutPanel7.ColumnCount = 1;
				 this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
				 this.tableLayoutPanel7.Controls.Add(this.txtLogging, 0, 1);
				 this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 0);
				 this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
				 this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
				 this.tableLayoutPanel7.Name = "tableLayoutPanel7";
				 this.tableLayoutPanel7.RowCount = 2;
				 this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
				 this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
				 this.tableLayoutPanel7.Size = new System.Drawing.Size(664, 454);
				 this.tableLayoutPanel7.TabIndex = 0;
				 // 
				 // txtLogging
				 // 
				 this.txtLogging.Dock = System.Windows.Forms.DockStyle.Fill;
				 this.txtLogging.Location = new System.Drawing.Point(3, 38);
				 this.txtLogging.Multiline = true;
				 this.txtLogging.Name = "txtLogging";
				 this.txtLogging.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
				 this.txtLogging.Size = new System.Drawing.Size(658, 413);
				 this.txtLogging.TabIndex = 1;
				 // 
				 // tableLayoutPanel9
				 // 
				 this.tableLayoutPanel9.ColumnCount = 3;
				 this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.59933F));
				 this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.40067F));
				 this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
				 this.tableLayoutPanel9.Controls.Add(this.label7, 0, 0);
				 this.tableLayoutPanel9.Controls.Add(this.lblLastUpdatedLog, 2, 0);
				 this.tableLayoutPanel9.Controls.Add(this.btnLogMonitor, 1, 0);
				 this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
				 this.tableLayoutPanel9.Name = "tableLayoutPanel9";
				 this.tableLayoutPanel9.RowCount = 1;
				 this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
				 this.tableLayoutPanel9.Size = new System.Drawing.Size(448, 29);
				 this.tableLayoutPanel9.TabIndex = 2;
				 // 
				 // label7
				 // 
				 this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
				 this.label7.AutoSize = true;
				 this.label7.Location = new System.Drawing.Point(3, 16);
				 this.label7.Name = "label7";
				 this.label7.Size = new System.Drawing.Size(63, 13);
				 this.label7.TabIndex = 0;
				 this.label7.Text = "Log Output:";
				 // 
				 // lblLastUpdatedLog
				 // 
				 this.lblLastUpdatedLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
				 this.lblLastUpdatedLog.AutoSize = true;
				 this.lblLastUpdatedLog.Location = new System.Drawing.Point(296, 16);
				 this.lblLastUpdatedLog.Name = "lblLastUpdatedLog";
				 this.lblLastUpdatedLog.Size = new System.Drawing.Size(74, 13);
				 this.lblLastUpdatedLog.TabIndex = 1;
				 this.lblLastUpdatedLog.Text = "Last Updated:";
				 // 
				 // btnLogMonitor
				 // 
				 this.btnLogMonitor.Location = new System.Drawing.Point(81, 3);
				 this.btnLogMonitor.Name = "btnLogMonitor";
				 this.btnLogMonitor.Size = new System.Drawing.Size(160, 23);
				 this.btnLogMonitor.TabIndex = 2;
				 this.btnLogMonitor.Text = "Start Monitoring Log";
				 this.btnLogMonitor.UseVisualStyleBackColor = true;
				 this.btnLogMonitor.Click += new System.EventHandler(this.btnLogMonitor_Click);
				 // 
				 // fswLogFile
				 // 
				 this.fswLogFile.EnableRaisingEvents = true;
				 this.fswLogFile.SynchronizingObject = this;
				 this.fswLogFile.Changed += new System.IO.FileSystemEventHandler(this.fswLogFile_Changed);
				 // 
				 // Form1
				 // 
				 this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				 this.ClientSize = new System.Drawing.Size(672, 480);
				 this.Controls.Add(this.tabControl1);
				 this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
				 this.Name = "Form1";
				 this.Text = "Elasticsearch Settings";
				 this.tableLayoutPanel1.ResumeLayout(false);
				 this.tableLayoutPanel1.PerformLayout();
				 this.tableLayoutPanel2.ResumeLayout(false);
				 this.tableLayoutPanel2.PerformLayout();
				 this.tableLayoutPanel3.ResumeLayout(false);
				 this.tableLayoutPanel3.PerformLayout();
				 this.tabControl1.ResumeLayout(false);
				 this.tabSettings.ResumeLayout(false);
				 this.tabConfig.ResumeLayout(false);
				 this.tableLayoutPanel6.ResumeLayout(false);
				 this.tableLayoutPanel8.ResumeLayout(false);
				 this.tableLayoutPanel8.PerformLayout();
				 this.tabConfigText.ResumeLayout(false);
				 this.tabCT.ResumeLayout(false);
				 this.tabCT.PerformLayout();
				 this.tabYaml.ResumeLayout(false);
				 this.tabFirewall.ResumeLayout(false);
				 this.tableLayoutPanel5.ResumeLayout(false);
				 this.tableLayoutPanel5.PerformLayout();
				 this.tabService.ResumeLayout(false);
				 this.tableLayoutPanel4.ResumeLayout(false);
				 this.tableLayoutPanel4.PerformLayout();
				 this.tabLogging.ResumeLayout(false);
				 this.tableLayoutPanel7.ResumeLayout(false);
				 this.tableLayoutPanel7.PerformLayout();
				 this.tableLayoutPanel9.ResumeLayout(false);
				 this.tableLayoutPanel9.PerformLayout();
				 ((System.ComponentModel.ISupportInitialize)(this.fswLogFile)).EndInit();
				 this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtMaxMem;
    private System.Windows.Forms.TextBox txtMinMem;
    private System.Windows.Forms.TextBox txtJavaHome;
    private System.Windows.Forms.TextBox txtESHome;
    private System.Windows.Forms.Button btnSetJava;
    private System.Windows.Forms.Button btnSetEsHome;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnStartService;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.Button btnStopService;
    private System.Windows.Forms.TextBox txtOutput;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Button btnOpenPorts;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabSettings;
		private System.Windows.Forms.TabPage tabFirewall;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Label lblFirewallRAL;
		private System.Windows.Forms.TextBox txtRemoteAddress;
		private System.Windows.Forms.TabPage tabService;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.TabPage tabLogging;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TabPage tabConfig;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.Button btnSaveConfig;
		private System.Windows.Forms.TextBox txtConfig;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtLogging;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		private System.Windows.Forms.Button btnLoadConfig;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
		private System.Windows.Forms.Label lblLastUpdatedLog;
		private System.IO.FileSystemWatcher fswLogFile;
		private System.Windows.Forms.Button btnLogMonitor;
		private System.Windows.Forms.TabControl tabConfigText;
		private System.Windows.Forms.TabPage tabYaml;
		private System.Windows.Forms.TreeView tviYaml;
		private System.Windows.Forms.TabPage tabCT;
  }
}

