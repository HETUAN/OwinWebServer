﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;

namespace OwinWebServer
{
    public class Startup
    {
        private static string localDir;

        static Startup()
        {
            localDir = Program.GetPath();
        }

        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.Run(HandleRequest);
        }

        private static Task HandleRequest(IOwinContext context)
        {
            try
            {
                string url = context.Request.Uri.AbsolutePath;
                string local;
                if (string.IsNullOrWhiteSpace(url.Replace("/", string.Empty)))
                {
                    local = localDir + "\\index.html";
                }
                else
                {
                    local = localDir + url.Replace("/", "\\");
                }

                FileInfo fi = new FileInfo(local);
                if (string.IsNullOrWhiteSpace(fi.Extension))
                {
                    local += @"\index.html";
                    fi = new FileInfo(local);
                }

                string contentType = ContentTypeDic.GetContentType(fi.Extension);
                byte[] bts = File.ReadAllBytes(local);
                context.Response.ContentType = contentType;
                return context.Response.WriteAsync(bts);
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "application/html";
                return context.Response.WriteAsync(ex.Message);
            }
        }
    }

    public class Startup1
    {
        private static string localDir;

        static Startup1()
        {
            localDir = Program.GetPath();
        }
        public void Configuration(IAppBuilder appBuilder)
        {
            try
            {
                Console.WriteLine(localDir);
                var fileSystem = new PhysicalFileSystem(localDir);
                var options = new FileServerOptions
                {
                    EnableDirectoryBrowsing = true,
                    FileSystem = fileSystem
                };
                appBuilder.UseFileServer(options: options);

                appBuilder.Use(async (context, next) =>
                {
                    Console.WriteLine("log");
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

    }
}
