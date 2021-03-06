﻿using System;
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
        private string ESConfigBase = "\\Config\\elasticsearch.yml";
        private string ESConfig = "";
        private string ESHome = "";
        private string JAVAHome = "";
        private string path = "";

        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
            JAVAHome = Environment.GetEnvironmentVariable("JAVA_HOME", EnvironmentVariableTarget.Machine);
            txtJavaHome.Text = JAVAHome;
            ESHome = Environment.GetEnvironmentVariable("ES_HOME", EnvironmentVariableTarget.Machine);
            txtESHome.Text = ESHome;
            path = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);

            txtMinMem.Text = Environment.GetEnvironmentVariable("ES_MIN_MEM", EnvironmentVariableTarget.Machine);
            txtMaxMem.Text = Environment.GetEnvironmentVariable("ES_MAX_MEM", EnvironmentVariableTarget.Machine);
            if (txtESHome.Text != "")
            {

                if (!File.Exists(ESHome + ESConfigBase))
                {
                    MessageBox.Show("Please select elasticsearch.config ...");
                    DialogResult dr = openFileDialog1.ShowDialog();
                    if (dr == DialogResult.OK)
                    {

                        ESConfig = openFileDialog1.FileName;
                    }

                }
                else {
                    ESConfig = ESHome + ESConfigBase;
                }
                txtConfigLoc.Text = ESConfig;
                loadConfig();
            }
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


                //DirectoryInfo esdi = new DirectoryInfo(txtESHome.Text);
                //DirectorySecurity myDirectorySecurity = esdi.GetAccessControl();
                //string User = "NETWORK SERVICE";
                //myDirectorySecurity.AddAccessRule(new FileSystemAccessRule(User, FileSystemRights.FullControl, AccessControlType.Allow));
                //esdi.SetAccessControl(myDirectorySecurity);

                JAVAHome = txtJavaHome.Text;
                ESHome = txtESHome.Text;
                Environment.SetEnvironmentVariable("JAVA_HOME", txtJavaHome.Text, EnvironmentVariableTarget.Machine);
                Environment.SetEnvironmentVariable("ES_HOME", txtESHome.Text, EnvironmentVariableTarget.Machine);

                //Environment.SetEnvironmentVariable("ES_MIN_MEM", txtMinMem.Text, EnvironmentVariableTarget.Machine);
                //Environment.SetEnvironmentVariable("ES_MAX_MEM", txtMaxMem.Text, EnvironmentVariableTarget.Machine);
                MessageBox.Show("Settings Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save settings: \n" + ex.Message);
            }

        }

        private void btnStartService_Click(object sender, EventArgs e)
        {
            RunServiceBat("start");
        }

        private void btnStopService_Click(object sender, EventArgs e)
        {
            RunServiceBat("stop");
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
                           "9200,9201,9202,9203,9204,9205,9206,9207,9208,9209,9210,9211,9212,9213,9214",
                           NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN,
                           fwPolicy2);
                    //Data
                    CreateRuleIn("Elasticsearch Transport",
                           "Elasticsearch Data Transport node-to-node",
                           NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP,
                           "9300,9301,9302,9303,9304,9305,9306,9307,9308,9309,9310,9311,9312,9313,9314",
                           NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN,
                           fwPolicy2);

                    // outbound rules
                    CreateRuleOut("Elasticsearch HTTP",
                           "Elasticsearch HTTP traffic",
                           NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP,
                           "9200,9201,9202,9203,9204,9205,9206,9207,9208,9209,9210,9211,9212,9213,9214",
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
                           "9300,9301,9302,9303,9304,9305,9306,9307,9308,9309,9310,9311,9312,9313,9314",
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
            newRule.Profiles = fwPolicy2.CurrentProfileTypes;
            //newRule.Interfaces = "All";
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
                using (StreamReader sr = new StreamReader(ESConfig))
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
                using (StreamWriter outfile = new StreamWriter(ESConfig))
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

        private void btnInstall_Click(object sender, EventArgs e)
        {
            RunServiceBat("install");
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            RunServiceBat("remove");
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            RunServiceBat("manager");
        }

        private void RunServiceBat(string action)
        {
            if (ESHome != "")
            {

                using (Process proc = new Process())
                {
                    proc.StartInfo.FileName = ESHome + @"\bin\elasticsearch-service.bat";
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.Arguments = string.Format(" " + action);
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.Start();
                    txtOutput.Text = "\n" + proc.StandardOutput.ReadToEnd() + "\n\r\n\r" + DateTime.Now.ToString() + "\n\r\n\r";
                    if (action == "start")
                    {
                        txtOutput.Text += "If this is the first time starting the service please use the [Manage] button if you would like it set to 'Automatic' start up.";
                    }
                    proc.WaitForExit();
                }
            }
            else
            {
                MessageBox.Show("Could not " + action + " Service ES_HOME Variable is not set: \n");
            }
        }

        private void RunInstallBat()
        {
            if (ESHome != "" && JAVAHome != "")
            {

                //string strCmdText;
                //strCmdText = "/C "+ ESHome + @"\bin\elasticsearch.bat";
                //System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                txtInstallBatOut.Text = txtInstallBatOut.Text + "A cmd window should open with the details: \n\r\n\r" + DateTime.Now.ToString() + "\n\r\n\r";
                using (Process proc = new Process())
                {
                    proc.StartInfo.FileName = "CMD.EXE"; 
                    proc.StartInfo.Arguments = "/K "+ ESHome + @"\bin\elasticsearch.bat";
                    //proc.StartInfo.UseShellExecute = true;
                    //proc.StartInfo.RedirectStandardOutput = true;
                    //proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    //proc.StartInfo.CreateNoWindow = false;

                    proc.Start();
                    
                    //proc.BeginOutputReadLine();
                    proc.WaitForExit();
                }
                
            }
            else
            {
                MessageBox.Show("Could not run elasticsearch.bat the ES_HOME Variable is not set. \n");
            }
        }

        private void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if(e.Data != null)
                SetInstallBatOutText( e.Data + "\n");
        }


        private void SetInstallBatOutText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtInstallBatOut.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetInstallBatOutText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtInstallBatOut.Text = this.txtInstallBatOut.Text + text;
            }
        }

        private void txtConfigLoc_TextChanged(object sender, EventArgs e)
        {
           
            ESConfig = txtConfigLoc.Text;
        }

        private void txtConfigLoc_Enter(object sender, EventArgs e)
        {
            if (txtConfigLoc.Text == "")
            {
                MessageBox.Show("Please select elasticsearch.config ...");
                DialogResult dr = openFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {

                    ESConfig = openFileDialog1.FileName;
                    txtConfigLoc.Text = ESConfig;
                }
            }
        }

        private void btnEsBat_Click(object sender, EventArgs e)
        {
            RunInstallBat();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblJHmsg_Click(object sender, EventArgs e)
        {

        }

        private void txtConfig_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveConfig_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter outfile = new StreamWriter(ESConfig))
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
    }
}
