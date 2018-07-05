using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Way.EntityDB;
using Way.EntityDB.Design.Actions;
using Way.EntityDB.Design.Services;
using Way.Lib.ScriptRemoting;

namespace Way.EJServer
{
    public class Program
    {
      
        public static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                int port = 6061;
                if (args != null && args.Length > 0)
                {
                    port = Convert.ToInt32(args[0]);
                }

                ScriptRemotingServer.RegisterHandler(new DownLoadCodeHandler());
                ScriptRemotingServer.RegisterHandler(new DownLoadSimpleCodeHandler());
                ScriptRemotingServer.RegisterHandler(new DownloadTableDataHandler());
                ScriptRemotingServer.RegisterHandler(new ImportDataHandler());

                ScriptRemotingServer.UseHttps(new X509Certificate(Way.Lib.PlatformHelper.GetAppDirectory() + "EJServerCert.pfx", "123456"));
                Console.WriteLine($"use ssl EJServerCert.pfx");
                Console.WriteLine($"server starting at port:{port}...");
                var webroot = $"{Way.Lib.PlatformHelper.GetAppDirectory()}Port{port}";

                if (!System.IO.Directory.Exists(webroot))
                {
                    System.IO.Directory.CreateDirectory(webroot);
                }

                if (System.IO.File.Exists($"{webroot}/main.html") == false)
                {
                    System.IO.File.WriteAllText($"{webroot}/main.html", "<html><body controller=\"Way.EJServer.MainController\"></body></html>");
                }
                Console.WriteLine($"path:{webroot}");

                SessionState.Timeout = 60 * 24;

                ScriptRemotingServer.Start(port, webroot, 1);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            while (true)
            {
                Console.Write("Web>");
                var line = Console.ReadLine();
                if(line == null)
                {
                    //是在后台运行的
                    while(true)
                    {
                        System.Threading.Thread.Sleep(10000000);
                    }
                }
                else if (line == "exit")
                    break;
            }
            ScriptRemotingServer.Stop();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

      
    }
}
