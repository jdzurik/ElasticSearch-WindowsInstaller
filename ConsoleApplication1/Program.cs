using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace ConsoleApplication1
{
  class Program
  {
   public static StreamWriter outputStream;
   public static Process proc = new Process();
    static void Main(string[] args)
    {

      String JavaHome = Environment.GetEnvironmentVariable("JAVA_HOME",  EnvironmentVariableTarget.Machine);
     String ESHome = Environment.GetEnvironmentVariable("ES_HOME",  EnvironmentVariableTarget.Machine);

     String ESMinM = Environment.GetEnvironmentVariable("ES_MIN_MEM", EnvironmentVariableTarget.Machine);
     String ESMaxM = Environment.GetEnvironmentVariable("ES_MAX_MEM", EnvironmentVariableTarget.Machine);
     

      if (!File.Exists(ESHome + @"\logs\WindowsServiceOuputArgs.txt"))
      {
        FileStream fs = File.Create(ESHome + @"\logs\WindowsServiceOuputArgs.txt");
        fs.Close();
        fs.Dispose();
      }
     outputStream = new StreamWriter(ESHome + @"\logs\WindowsServiceOuput.txt", true);
     outputStream.AutoFlush = true;
     //try
     //{

      //proc.StartInfo.WorkingDirectory = string.Format(@"C:\elasticsearch\bin\");
      //proc.StartInfo.FileName = @"C:\elasticsearch\bin\elasticsearch.bat";
      proc.StartInfo.FileName = JavaHome+@"\bin\java";
      //proc.StartInfo.ErrorDialog = true;
      proc.StartInfo.UseShellExecute = false;
      proc.StartInfo.RedirectStandardOutput = true;
      proc.StartInfo.RedirectStandardError = true;

      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("-Xms{0} ", ESMinM);
      sb.AppendFormat("-Xmx{0} ", ESMaxM );
      sb.AppendFormat("-Xss128k ");
      sb.AppendFormat("-XX:+UseParNewGC ");
      sb.AppendFormat("-XX:+UseConcMarkSweepGC ");
      sb.AppendFormat("-XX:+CMSParallelRemarkEnabled ");
      sb.AppendFormat("-XX:SurvivorRatio=8 ");
      sb.AppendFormat("-XX:MaxTenuringThreshold=1 ");
      sb.AppendFormat("-XX:CMSInitiatingOccupancyFraction=75 ");
      sb.AppendFormat("-XX:+UseCMSInitiatingOccupancyOnly ");
      sb.AppendFormat("-XX:+HeapDumpOnOutOfMemoryError ");
      sb.AppendFormat("-Delasticsearch ");
      sb.AppendFormat("-Des-foreground=yes ");
      sb.AppendFormat("-Des.path.home=\"{0}\" ", ESHome);
      sb.AppendFormat("-cp \";{0}/lib/*;{0}/lib/sigar/*\" ", ESHome);
      sb.AppendFormat("\"org.elasticsearch.bootstrap.ElasticSearch\" ");
      sb.AppendFormat("-server ");
      string arg = sb.ToString();
      //using (StreamWriter outfile =
      //    new StreamWriter(ESHome + @"\logs\WindowsServiceOuputArgs.txt", false))
      //{
      //  outfile.Write(arg);
      //}
      proc.StartInfo.Arguments = arg;
      //proc.StartInfo.CreateNoWindow = true;
      proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
      proc.OutputDataReceived += new DataReceivedEventHandler(OnDataReceived);
      proc.ErrorDataReceived += new DataReceivedEventHandler(OnDataReceived);
      proc.Start();
      proc.BeginOutputReadLine();
      proc.BeginErrorReadLine();
      //proc.WaitForExit();
      //}
      //catch (Exception ex)
      //{
      //  using (StreamWriter outfile =
      //   new StreamWriter(ESHome + @"\logs\WindowsServiceOuputArgs.txt", true))
      //  {
      //    outfile.Write("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
      //  }
      //}

    }
    public static void OnDataReceived(object Sender, DataReceivedEventArgs e)
    {
      if ((e.Data != null) && (outputStream != null))
        outputStream.WriteLine(e.Data +" : " + DateTime.Now.ToString());
    }
  }
}
