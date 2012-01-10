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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtJavaHome = new System.Windows.Forms.TextBox();
      this.txtESHome = new System.Windows.Forms.TextBox();
      this.btnSetJava = new System.Windows.Forms.Button();
      this.btnSetEsHome = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.lblSaved = new System.Windows.Forms.Label();
      this.btnStartService = new System.Windows.Forms.Button();
      this.btnStopService = new System.Windows.Forms.Button();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.txtMaxMem = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.txtMinMem = new System.Windows.Forms.TextBox();
      this.btnOpenPorts = new System.Windows.Forms.Button();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.68354F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.31645F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.txtJavaHome, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtESHome, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnSetJava, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnSetEsHome, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnSave, 2, 4);
      this.tableLayoutPanel1.Controls.Add(this.txtOutput, 1, 6);
      this.tableLayoutPanel1.Controls.Add(this.lblSaved, 1, 5);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.btnOpenPorts, 2, 5);
      this.tableLayoutPanel1.Controls.Add(this.btnStartService, 2, 6);
      this.tableLayoutPanel1.Controls.Add(this.btnStopService, 0, 6);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 7;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 342);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Java Home";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 30);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(103, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "ElasticSearch Home";
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
      // txtJavaHome
      // 
      this.txtJavaHome.Dock = System.Windows.Forms.DockStyle.Top;
      this.txtJavaHome.Location = new System.Drawing.Point(120, 3);
      this.txtJavaHome.Name = "txtJavaHome";
      this.txtJavaHome.Size = new System.Drawing.Size(351, 20);
      this.txtJavaHome.TabIndex = 6;
      // 
      // txtESHome
      // 
      this.txtESHome.Dock = System.Windows.Forms.DockStyle.Top;
      this.txtESHome.Location = new System.Drawing.Point(120, 33);
      this.txtESHome.Name = "txtESHome";
      this.txtESHome.Size = new System.Drawing.Size(351, 20);
      this.txtESHome.TabIndex = 7;
      // 
      // btnSetJava
      // 
      this.btnSetJava.Location = new System.Drawing.Point(477, 3);
      this.btnSetJava.Name = "btnSetJava";
      this.btnSetJava.Size = new System.Drawing.Size(123, 23);
      this.btnSetJava.TabIndex = 8;
      this.btnSetJava.Text = "Set Java Directory";
      this.btnSetJava.UseVisualStyleBackColor = true;
      this.btnSetJava.Click += new System.EventHandler(this.btnSetJava_Click);
      // 
      // btnSetEsHome
      // 
      this.btnSetEsHome.Location = new System.Drawing.Point(477, 33);
      this.btnSetEsHome.Name = "btnSetEsHome";
      this.btnSetEsHome.Size = new System.Drawing.Size(123, 23);
      this.btnSetEsHome.TabIndex = 9;
      this.btnSetEsHome.Text = "Set ES Directory";
      this.btnSetEsHome.UseVisualStyleBackColor = true;
      this.btnSetEsHome.Click += new System.EventHandler(this.btnSetEsHome_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(477, 123);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(114, 23);
      this.btnSave.TabIndex = 10;
      this.btnSave.Text = "Save Settings";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // txtOutput
      // 
      this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtOutput.Location = new System.Drawing.Point(120, 186);
      this.txtOutput.Multiline = true;
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtOutput.Size = new System.Drawing.Size(351, 153);
      this.txtOutput.TabIndex = 14;
      // 
      // lblSaved
      // 
      this.lblSaved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblSaved.AutoSize = true;
      this.lblSaved.Location = new System.Drawing.Point(471, 150);
      this.lblSaved.Name = "lblSaved";
      this.lblSaved.Size = new System.Drawing.Size(0, 13);
      this.lblSaved.TabIndex = 12;
      // 
      // btnStartService
      // 
      this.btnStartService.Location = new System.Drawing.Point(477, 186);
      this.btnStartService.Name = "btnStartService";
      this.btnStartService.Size = new System.Drawing.Size(114, 23);
      this.btnStartService.TabIndex = 11;
      this.btnStartService.Text = "Start Service";
      this.btnStartService.UseVisualStyleBackColor = true;
      this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
      // 
      // btnStopService
      // 
      this.btnStopService.Location = new System.Drawing.Point(3, 186);
      this.btnStopService.Name = "btnStopService";
      this.btnStopService.Size = new System.Drawing.Size(111, 23);
      this.btnStopService.TabIndex = 13;
      this.btnStopService.Text = "Stop Service";
      this.btnStopService.UseVisualStyleBackColor = true;
      this.btnStopService.Click += new System.EventHandler(this.btnStopService_Click);
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.12903F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.87096F));
      this.tableLayoutPanel2.Controls.Add(this.txtMaxMem, 0, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(120, 93);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(351, 24);
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
      this.tableLayoutPanel3.Location = new System.Drawing.Point(120, 63);
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
      // btnOpenPorts
      // 
      this.btnOpenPorts.Location = new System.Drawing.Point(477, 153);
      this.btnOpenPorts.Name = "btnOpenPorts";
      this.btnOpenPorts.Size = new System.Drawing.Size(111, 23);
      this.btnOpenPorts.TabIndex = 17;
      this.btnOpenPorts.Text = "Open Firewall Ports";
      this.btnOpenPorts.UseVisualStyleBackColor = true;
      this.btnOpenPorts.Click += new System.EventHandler(this.btnOpenPorts_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(605, 342);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "ElasticSearch Service Settings";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
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
    private System.Windows.Forms.Label lblSaved;
    private System.Windows.Forms.Button btnStopService;
    private System.Windows.Forms.TextBox txtOutput;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Button btnOpenPorts;
  }
}

