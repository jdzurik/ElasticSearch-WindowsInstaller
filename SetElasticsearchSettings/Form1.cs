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
using YamlUtility.Grammar;


namespace SetElasticsearchSettings
{
	 public partial class Form1 : Form
	 {
			private string ESClustername = "elasticsearch";
			public Form1()
			{
				 InitializeComponent();
				 txtJavaHome.Text = Environment.GetEnvironmentVariable("JAVA_HOME", EnvironmentVariableTarget.Machine);
				 txtESHome.Text = Environment.GetEnvironmentVariable("ES_HOME", EnvironmentVariableTarget.Machine);

				 txtMinMem.Text = Environment.GetEnvironmentVariable("ES_MIN_MEM", EnvironmentVariableTarget.Machine);
				 txtMaxMem.Text = Environment.GetEnvironmentVariable("ES_MAX_MEM", EnvironmentVariableTarget.Machine);
				 if (txtESHome.Text != "")
				 {
						fswLogFile.Path = txtESHome.Text + "\\logs\\";
						fswLogFile.NotifyFilter = NotifyFilters.LastWrite;
						fswLogFile.Filter = "elasticsearch.log";

						loadConfig();
				 }
				 fswLogFile.EnableRaisingEvents = false;
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
				 try
				 {
						DirectoryInfo di = new DirectoryInfo(txtESHome.Text + "\\logs");
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
						MessageBox.Show("Settings Saved!");
				 }
				 catch (Exception ex)
				 {
						MessageBox.Show("Could not save settings: \n" + ex.Message);
				 }

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
				 DialogResult dr = MessageBox.Show("This will Remove exsiting rules name the same \nas [Elasticsearch Discovery] [Elasticsearch HTTP] and [Elasticsearch Transport] \nis this ok?", "Confirm removal and add.", MessageBoxButtons.OKCancel);
				 if (dr == DialogResult.OK)
				 {
						try
						{
							 Type typeFWPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2", false);
							 INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
							 fwPolicy2.Rules.Remove("Elasticsearch Discovery");
							 fwPolicy2.Rules.Remove("Elasticsearch HTTP");
							 fwPolicy2.Rules.Remove("Elasticsearch Transport");

							 //Discovery
							 CreateRuleIn("Elasticsearch Discovery",
									"Elasticsearch Discovery of other nodes",
									NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP,
									"54328",
									NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN,
									fwPolicy2);
							 //Admin
							 CreateRuleIn("Elasticsearch HTTP",
									"Elasticsearch HTTP traffic",
									NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP,
									"9200-9299",
									NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN,
									fwPolicy2);
							 //Data
							 CreateRuleIn("Elasticsearch Transport",
									"Elasticsearch Data Transport node-to-node",
									NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP,
									"9300-9400",
									NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN,
									fwPolicy2);

							 // outbound rules
							 CreateRuleOut("Elasticsearch HTTP",
									"Elasticsearch HTTP traffic",
									NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP,
									"9200-9299",
									NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT,
									fwPolicy2);
							 CreateRuleOut("Elasticsearch Discovery",
								 "Elasticsearch Discovery of other nodes",
								 NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP,
								 "54328",
								 NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT,
								 fwPolicy2);
							 CreateRuleOut("Elasticsearch Transport",
									"Elasticsearch Data Transport node-to-node",
									NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP,
									"9300-9400",
									NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT,
									fwPolicy2);

							 MessageBox.Show("The firewall ports have been opened.");

						}
						catch (Exception ex)
						{
							 MessageBox.Show("Could not create firewall rules: \n" + ex.Message);
						}
				 }


			}

			private void CreateRuleIn(String RuleName, String Desc, NET_FW_IP_PROTOCOL_ Protocol, String RemotePorts, NET_FW_RULE_DIRECTION_ Direction, INetFwPolicy2 fwPolicy2)
			{

				 Type typeFWRule = Type.GetTypeFromProgID("HNetCfg.FwRule", false);
				 INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
				 newRule.Name = RuleName;
				 newRule.Description = Desc;
				 newRule.Protocol = (int)Protocol;
				 newRule.LocalPorts = RemotePorts;
				 newRule.RemoteAddresses = txtRemoteAddress.Text.Replace(" ", "").Replace("\r\n", ",");
				 newRule.Direction = Direction;
				 newRule.Enabled = true;
				 newRule.Grouping = "Elasticsearch";
				 //newRule.Profiles = fwPolicy2.CurrentProfileTypes;
				 newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
				 fwPolicy2.Rules.Add(newRule);


			}

			private void CreateRuleOut(String RuleName, String Desc, NET_FW_IP_PROTOCOL_ Protocol, String RemotePorts, NET_FW_RULE_DIRECTION_ Direction, INetFwPolicy2 fwPolicy2)
			{

				 Type typeFWRule = Type.GetTypeFromProgID("HNetCfg.FwRule", false);
				 INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
				 newRule.Name = RuleName;
				 newRule.Description = Desc;
				 newRule.Protocol = (int)Protocol;
				 newRule.RemotePorts = RemotePorts;
				 newRule.RemoteAddresses = txtRemoteAddress.Text.Replace(" ", "").Replace("\r\n", ",");
				 newRule.Direction = Direction;
				 newRule.Enabled = true;
				 newRule.Grouping = "Elasticsearch";
				 //newRule.Profiles = fwPolicy2.CurrentProfileTypes;
				 newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
				 fwPolicy2.Rules.Add(newRule);


			}

			private void btnLoadConfig_Click(object sender, EventArgs e)
			{
				 loadConfig();
			}

			private void loadConfig()
			{
				 try
				 {
						using (StreamReader sr = new StreamReader(txtESHome.Text + "\\Config\\elasticsearch.yml"))
						{
							 String line = sr.ReadToEnd();
							 txtConfig.Text = line.Replace("\n", "\r\n");
							 LoadYaml();
						}
				 }
				 catch (Exception ex)
				 {
						MessageBox.Show("The file could not be read:\n" + ex.Message);
				 }
			}
			private void btnSaveConfig_Click(object sender, EventArgs e)
			{
				 try
				 {
						using (StreamWriter outfile = new StreamWriter(txtESHome.Text + "\\Config\\elasticsearch.yml"))
						{
							 outfile.Write(txtConfig.Text.Replace("\r", ""));
							 LoadYaml();
							 MessageBox.Show("The file has been saved.");
						}
				 }
				 catch (Exception ex)
				 {
						MessageBox.Show("The file could not be saved:\n" + ex.Message);
				 }
			}

			private void fswLogFile_Changed(object sender, FileSystemEventArgs e)
			{
				 LoadLog();
				 lblLastUpdatedLog.Text = "Last Updated: " + DateTime.Now.ToShortTimeString();
			}

			private void btnLogMonitor_Click(object sender, EventArgs e)
			{
				 if (fswLogFile.EnableRaisingEvents)
				 {
						btnLogMonitor.Text = "Start Monitoring Log";
						fswLogFile.EnableRaisingEvents = false;
				 }
				 else
				 {
						LoadLog();
						btnLogMonitor.Text = "Stop Monitoring Log";
						fswLogFile.EnableRaisingEvents = true;
				 }
			}

			private void LoadLog()
			{

				 string logPath = txtESHome.Text + "\\logs\\" + ESClustername + ".log";
				 try
				 {
						
						///todo: resolve FileInfo conflict
						FileInfo fi = new FileInfo(logPath);
						if (fi.Length > 10000000)
						{
							 DialogResult dr = MessageBox.Show("This file is very large and may take a while \nto load are you sure you want to continue monitoring it?", "Confirm file Load", MessageBoxButtons.YesNo);
							 if (dr == System.Windows.Forms.DialogResult.Yes)
							 {
									using (StreamReader sr = new StreamReader(logPath))
									{
										 String line = sr.ReadToEnd();
										 txtLogging.Text = line.Replace("\n", "\r\n");
									}
							 }
							 else
							 {
									btnLogMonitor.Text = "Start Monitoring Log";
									fswLogFile.EnableRaisingEvents = false;
							 }
						}
						else
						{

							 using (FileStream stream = File.Open(logPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
							 {
									using (StreamReader sr = new StreamReader(logPath))
									{
										 String line = sr.ReadToEnd();
										 txtLogging.Text = line.Replace("\n", "\r\n");
									}
							 }

						}

				 }
				 catch (Exception ex)
				 {
						MessageBox.Show("The file [" + logPath + "] could not be read \nYou may need to stop the service to view the log:\n" + ex.Message);
				 }
			}

			private void LoadYaml()
			{

				 TextInput input = new TextInput(txtConfig.Text);
				 bool success;
				 YamlParser parser = new YamlParser();
				 YamlStream yamlStream = parser.ParseYamlStream(input, out success);
				 if (success)
				 {
						tviYaml.Nodes.Clear();
						foreach (YamlDocument doc in yamlStream.Documents)
						{
							 tviYaml.Nodes.Add(YamlEmittor.CreateNode(doc.Root));
						}
						tviYaml.ExpandAll();
						ESClustername = YamlEmittor.ClusterName;
				 }
				 else
				 {
						MessageBox.Show(parser.GetEorrorMessages());
				 }

			}

			private void tabConfigText_SelectedIndexChanged(object sender, EventArgs e)
			{
				 if ((sender as TabControl).SelectedIndex == 1)
				 {
						LoadYaml();
				 }
			}

	 }
}
