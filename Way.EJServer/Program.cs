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
            HttpServer server = null;
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                int port = 6061;
                if (args != null && args.Length > 0)
                {
                    port = Convert.ToInt32(args[0]);
                }
                
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

                server = new HttpServer(new int[] { port }, webroot);
                Console.WriteLine($"Root:{server.Root}");

                server.RegisterHandler(new DownLoadCodeHandler());
                server.RegisterHandler(new DownLoadSimpleCodeHandler());
                server.RegisterHandler(new DownloadTableDataHandler());
                server.RegisterHandler(new ImportDataHandler());

                server.UseHttps(new X509Certificate2(Way.Lib.PlatformHelper.GetAppDirectory() + "EJServerCert.pfx", "123456"));
                Console.WriteLine($"use ssl EJServerCert.pfx");

                SessionState.Timeout = 60 * 24;

                server.Start();
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
            server?.Stop();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

      
    }
}
