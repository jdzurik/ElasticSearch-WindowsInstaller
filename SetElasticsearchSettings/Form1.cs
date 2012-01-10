using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using NetFwTypeLib;
using NETCONLib;
using NATUPNPLib;
using System.Security.AccessControl;

namespace SetElasticsearchSettings
{
  public partial class Form1 : Form
  {
    private const string PROGID_OPEN_PORT = "HNetCfg.FWOpenPort";
    public Form1()
    {
      InitializeComponent();
      txtJavaHome.Text = Environment.GetEnvironmentVariable("JAVA_HOME", EnvironmentVariableTarget.Machine);
      txtESHome.Text = Environment.GetEnvironmentVariable("ES_HOME", EnvironmentVariableTarget.Machine);

      txtMinMem.Text = Environment.GetEnvironmentVariable("ES_MIN_MEM",  EnvironmentVariableTarget.Machine);
      txtMaxMem.Text = Environment.GetEnvironmentVariable("ES_MAX_MEM",  EnvironmentVariableTarget.Machine);
    }

    private void btnSetJava_Click(object sender, EventArgs e)
    {
      DialogResult dr = folderBrowserDialog1.ShowDialog();
      if (dr == DialogResult.OK)
      {
        txtJavaHome.Text = folderBrowserDialog1.SelectedPath;
      }
    }

    private void btnSetEsHome_Click(object sender, EventArgs e)
    {
      DialogResult dr = folderBrowserDialog1.ShowDialog();
      if (dr == DialogResult.OK)
      {
        txtESHome.Text = folderBrowserDialog1.SelectedPath;
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      lblSaved.Text = "Loading ...";

      DirectoryInfo di = new DirectoryInfo(txtESHome.Text +"\\logs");
      if (!di.Exists)
        di.Create();

      DirectoryInfo esdi = new DirectoryInfo(txtESHome.Text);
      DirectorySecurity myDirectorySecurity = esdi.GetAccessControl();
      string User = "NETWORK SERVICE";    
      myDirectorySecurity.AddAccessRule(new FileSystemAccessRule(User, 
                                              FileSystemRights.FullControl, AccessControlType.Allow));
      esdi.SetAccessControl(myDirectorySecurity);


      Environment.SetEnvironmentVariable("JAVA_HOME", txtJavaHome.Text, EnvironmentVariableTarget.Machine);
      Environment.SetEnvironmentVariable("ES_HOME", txtESHome.Text, EnvironmentVariableTarget.Machine);

      Environment.SetEnvironmentVariable("ES_MIN_MEM", txtMinMem.Text, EnvironmentVariableTarget.Machine);
      Environment.SetEnvironmentVariable("ES_MAX_MEM", txtMaxMem.Text, EnvironmentVariableTarget.Machine);

      lblSaved.Text = "Settings Saved!";
      
    }

    private void btnStartService_Click(object sender, EventArgs e)
    {


      using (Process proc = new Process())
      {
        proc.StartInfo.FileName = "sc";
        proc.StartInfo.UseShellExecute = false;
        proc.StartInfo.RedirectStandardOutput = true;
        proc.StartInfo.Arguments = string.Format(" start ElasticSearchService");
        proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        proc.Start();
        txtOutput.Text += "\n" + proc.StandardOutput.ReadToEnd() + DateTime.Now.ToString() + "\n\n";
        proc.WaitForExit();
      }
    }

    private void btnStopService_Click(object sender, EventArgs e)
    {
      using (Process proc = new Process())
      {
        proc.StartInfo.FileName = "sc";
        proc.StartInfo.UseShellExecute = false;
        proc.StartInfo.RedirectStandardOutput = true;
        proc.StartInfo.Arguments = string.Format(" stop ElasticSearchService");
        proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        proc.Start();
        txtOutput.Text += "\n" + proc.StandardOutput.ReadToEnd() + DateTime.Now.ToString() + "\n\n";
        proc.WaitForExit();
      }
    }

    private void btnOpenPorts_Click(object sender, EventArgs e)
    {


      INetFwOpenPort port = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWOpenPort", false)) as INetFwOpenPort;
      port.Port = 54328;
      port.Scope = NET_FW_SCOPE_.NET_FW_SCOPE_ALL;
      port.Protocol = NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
      port.Name = "Elasticsearch Discovery"; 
      port.Enabled = true;


      INetFwOpenPort port2 = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWOpenPort", false)) as INetFwOpenPort;
      port2.Port = 9200;
      port2.Scope = NET_FW_SCOPE_.NET_FW_SCOPE_ALL;
      port2.Protocol = NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
      port2.Name = "Elasticsearch Admin";
      port2.Enabled = true;


      INetFwOpenPort port3 = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWOpenPort", false)) as INetFwOpenPort;
      port3.Port = 9300;
      port3.Scope = NET_FW_SCOPE_.NET_FW_SCOPE_ALL;
      port3.Protocol = NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
      port3.Name = "Elasticsearch Data";
      port3.Enabled = true; 

      INetFwMgr mgr = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwMgr", false)) as NetFwTypeLib.INetFwMgr;
      try
      {
        mgr.LocalPolicy.CurrentProfile.GloballyOpenPorts.Add(port);
        mgr.LocalPolicy.CurrentProfile.GloballyOpenPorts.Add(port2);
        mgr.LocalPolicy.CurrentProfile.GloballyOpenPorts.Add(port3);
        lblSaved.Text = "Ports added!";
      }
      catch (Exception ex)
      {
        txtOutput.Text += "Port add failed" + ex.Message; 
      }






    }

    


  }
}
