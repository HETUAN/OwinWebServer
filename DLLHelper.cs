using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebServer
{
    /// <summary>
    /// 反射Dll
    /// </summary>
    public class DLLHelper
    {
        /// <summary>
        /// 根据名称获取DLL 
        /// "Microsoft.Owin, Version=3.0.1.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed"
        /// "Microsoft.Owin.Host.HttpListener, Version=3.0.1.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed"
        /// "Microsoft.Owin.Hosting, Version=3.0.1.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed"
        /// "Owin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f0ebd12fd5e55cc5"
        /// </summary>
        /// <param name="name">dll名称</param>
        /// <returns>引用</returns>
        public static Assembly GetDll(string name)
        {
            string dlldir = string.Empty;
            switch (name)
            {
                case "Owin":
                    dlldir = "OwinWebServer.DLL.Owin.dll";
                    break;
                case "Microsoft.Owin":
                    dlldir = "OwinWebServer.DLL.Microsoft.Owin.dll";
                    break;
                case "Microsoft.Owin.Host.HttpListener":
                    dlldir = "OwinWebServer.DLL.Microsoft.Owin.Host.HttpListener.dll";
                    break;
                case "Microsoft.Owin.Hosting":
                    dlldir = "OwinWebServer.DLL.Microsoft.Owin.Hosting.dll";
                    break;
                case "Microsoft.Owin.FileSystems":
                    dlldir = "OwinWebServer.DLL.Microsoft.Owin.FileSystems.dll";
                    break;
                case "Microsoft.Owin.StaticFiles":
                    dlldir = "OwinWebServer.DLL.Microsoft.Owin.StaticFiles.dll";
                    break;
                default:
                    return null;
            }

            if (dlldir == string.Empty)
            {
                return null; 
            }

            try
            {
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(dlldir))
                {
                    var bytes = new byte[stream.Length];
                    stream.Read(bytes, 0, (int)stream.Length);

                    // 加载资源文件中的dll,代替加载失败的程序集
                    return Assembly.Load(bytes);
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
