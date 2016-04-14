using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace OwinWebServer
{
    /// <summary>
    /// 程序入口
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 网页的运行路径
        /// </summary>
        private static string path = string.Empty;

        /// <summary>
        /// 网站本地运行网址
        /// </summary>
        private static string local = string.Empty;

        /// <summary>
        /// Initializes static members of the <see cref="Program" /> class.
        /// </summary>
        static Program()
        {
            // 这个绑定事件必须要在引用到ConsoleApplication1这个程序集的方法之前,注意是方法之前,不是语句之间,就算语句是在方法最后一行,在进入方法的时候就会加载程序集,如果这个时候没有绑定事件,则直接抛出异常,或者程序终止了
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
        }

        /// <summary>
        /// 由于程序解析Json文档时会使用Newtonsoft.Json.dll
        /// 但是在控制台程序发布时必须随身携带此DLL
        /// 所以为了方便讲DLL打包进入Exe中便有了以下方法
        /// 使用时将DLL作为资源放入项目的解决方案中并在属性栏中将其生成属性设置为‘嵌入的资源’（注意不是只添加引用）
        /// 此程序会在引用找不到时在自身的EXE中反编译出Newtonsoft.Json.dll保证程序正常运行
        /// </summary>
        /// <param name="sender">事件的触发者</param>
        /// <param name="args">参数</param>
        /// <returns>反射出的Newtonsoft对象</returns>
        private static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            var assName = new AssemblyName(args.Name).Name;
            return DLLHelper.GetDll(assName);
        }

        /// <summary>
        /// 获取网页运行路径
        /// </summary>
        /// <returns>静态网页路径</returns>
        public static string GetPath()
        {
            return path;
        }

        /// <summary>
        /// 获取本地运行网址
        /// </summary>
        /// <returns>本地运行网址</returns>
        public static string GetLocal()
        {
            return local;
        }

        /// <summary>
        /// 程序入口方法
        /// </summary>
        /// <param name="args">传入静态文件地址和网站地址（先后有序）</param>
        private static void Main(string[] args)
        {
            int len = args.Length;
            if (len <= 0)
            {
                path = Environment.CurrentDirectory;
                local = "http://localhost:8181";
            }
            else if (len == 1)
            {
                if (string.IsNullOrWhiteSpace(args[0]))
                {
                    path = Environment.CurrentDirectory;
                }
                else
                {
                    path = args[0];
                }
                local = "http://localhost:8181";
            }
            else
            {
                if (string.IsNullOrWhiteSpace(args[0]))
                {
                    path = Environment.CurrentDirectory;
                }
                else
                {
                    path = args[0];
                }
                if (string.IsNullOrWhiteSpace(args[1]))
                {
                    local = "http://localhost:8181";
                }
                else
                {
                    local = args[1];
                }
            }
            Console.WriteLine(local);
            Console.WriteLine(path);
            try
            {
                //var startOpts = new StartOptions(local) { };
                var startOpts = new StartOptions();
                startOpts.Urls.Add(local);
                //startOpts.Urls.Add(local.Replace("localhost","127.0.0.1"));
                using (WebApp.Start<Startup>(startOpts))
                {
                    Console.WriteLine("Server run at " + local + " , press Enter to exit.");
                    System.Diagnostics.Process.Start("explorer.exe", local);
                    string input = string.Empty;
                    do
                    {
                        input = Console.ReadLine();
                    } while (input != "exit");
                    Console.WriteLine("Server has stopped, press Enter to exit.");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
