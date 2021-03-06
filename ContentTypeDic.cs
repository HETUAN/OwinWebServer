﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebServer
{
    /// <summary>
    /// Http请求使用的静态文件类型字典类（待完善）
    /// </summary>
    public static class ContentTypeDic
    {
        /// <summary>
        /// 静态构造函数
        /// </summary>
        static ContentTypeDic()
        {
            TypeDic.Add(".001", "application/x-001");
            TypeDic.Add(".301", "application/x-301");
            TypeDic.Add(".323", "text/h323");
            TypeDic.Add(".906", "application/x-906");
            TypeDic.Add(".907", "drawing/907");
            TypeDic.Add(".a11", "application/x-a11");
            TypeDic.Add(".acp", "audio/x-mei-aac");
            TypeDic.Add(".ai", "application/postscript");
            TypeDic.Add(".aif", "audio/aiff");
            TypeDic.Add(".aifc", "audio/aiff");
            TypeDic.Add(".aiff", "audio/aiff");
            TypeDic.Add(".anv", "application/x-anv");
            TypeDic.Add(".asa", "text/asa");
            TypeDic.Add(".asf", "video/x-ms-asf");
            TypeDic.Add(".asp", "text/asp");
            TypeDic.Add(".asx", "video/x-ms-asf");
            TypeDic.Add(".au", "audio/basic");
            TypeDic.Add(".avi", "video/avi");
            TypeDic.Add(".awf", "application/vnd.adobe.workflow");
            TypeDic.Add(".biz", "text/xml");
            TypeDic.Add(".bmp", "application/x-bmp");
            TypeDic.Add(".bot", "application/x-bot");
            TypeDic.Add(".c4t", "application/x-c4t");
            TypeDic.Add(".c90", "application/x-c90");
            TypeDic.Add(".cal", "application/x-cals");
            TypeDic.Add(".cat", "application/s-pki.seccat");
            TypeDic.Add(".cdf", "application/x-netcdf");
            TypeDic.Add(".cdr", "application/x-cdr");
            TypeDic.Add(".cel", "application/x-cel");
            TypeDic.Add(".cer", "application/x-x509-ca-cert");
            TypeDic.Add(".cg4", "application/x-g4");
            TypeDic.Add(".cgm", "application/x-cgm");
            TypeDic.Add(".cit", "application/x-cit");
            TypeDic.Add(".class", "java/*");
            TypeDic.Add(".cml", "text/xml");
            TypeDic.Add(".cmp", "application/x-cmp");
            TypeDic.Add(".cmx", "application/x-cmx");
            TypeDic.Add(".cot", "application/x-cot");
            TypeDic.Add(".crl", "application/pkix-crl");
            TypeDic.Add(".crt", "application/x-x509-ca-cert");
            TypeDic.Add(".csi", "application/x-csi");
            TypeDic.Add(".css", "text/css");
            TypeDic.Add(".cut", "application/x-cut");
            TypeDic.Add(".dbf", "application/x-dbf");
            TypeDic.Add(".dbm", "application/x-dbm");
            TypeDic.Add(".dbx", "application/x-dbx");
            TypeDic.Add(".dcd", "text/xml");
            TypeDic.Add(".dcx", "application/x-dcx");
            TypeDic.Add(".der", "application/x-x509-ca-cert");
            TypeDic.Add(".dgn", "application/x-dgn");
            TypeDic.Add(".dib", "application/x-dib");
            TypeDic.Add(".dll", "application/x-msdownload");
            TypeDic.Add(".doc", "application/msword");
            TypeDic.Add(".dot", "application/msword");
            TypeDic.Add(".drw", "application/x-drw");
            TypeDic.Add(".dtd", "text/xml");
            TypeDic.Add(".dwf", "Model/vnd.dwf");

            // TypeDic.Add(".dwf", "application/x-dwf");
            TypeDic.Add(".dwg", "application/x-dwg");
            TypeDic.Add(".dxb", "application/x-dxb");
            TypeDic.Add(".dxf", "application/x-dxf");
            TypeDic.Add(".edn", "application/vnd.adobe.edn");
            TypeDic.Add(".emf", "application/x-emf");
            TypeDic.Add(".eml", "message/rfc822");
            TypeDic.Add(".ent", "text/xml");
            TypeDic.Add(".epi", "application/x-epi");
            TypeDic.Add(".eps", "application/x-ps");

            // TypeDic.Add(".eps", "application/postscript");
            TypeDic.Add(".etd", "application/x-ebx");
            TypeDic.Add(".exe", "application/x-msdownload");
            TypeDic.Add(".fax", "image/fax");
            TypeDic.Add(".fdf", "application/vnd.fdf");
            TypeDic.Add(".fif", "application/fractals");
            TypeDic.Add(".fo", "text/xml");
            TypeDic.Add(".frm", "application/x-frm");
            TypeDic.Add(".g4", "application/x-g4");
            TypeDic.Add(".gbr", "application/x-gbr");
            TypeDic.Add(".gcd", "application/x-gcd");
            TypeDic.Add(".gif", "image/gif");
            TypeDic.Add(".gl2", "application/x-gl2");
            TypeDic.Add(".gp4", "application/x-gp4");
            TypeDic.Add(".hgl", "application/x-hgl");
            TypeDic.Add(".hmr", "application/x-hmr");
            TypeDic.Add(".hpg", "application/x-hpgl");
            TypeDic.Add(".hpl", "application/x-hpl");
            TypeDic.Add(".hqx", "application/mac-binhex40");
            TypeDic.Add(".hrf", "application/x-hrf");
            TypeDic.Add(".hta", "application/hta");
            TypeDic.Add(".htc", "text/x-component");
            TypeDic.Add(".htm", "text/html");
            TypeDic.Add(".html", "text/html");
            TypeDic.Add(".htt", "text/webviewhtml");
            TypeDic.Add(".htx", "text/html");
            TypeDic.Add(".icb", "application/x-icb");
            TypeDic.Add(".ico", "image/x-icon");

            // TypeDic.Add(".ico", "application/x-ico");
            TypeDic.Add(".iff", "application/x-iff");
            TypeDic.Add(".ig4", "application/x-g4");
            TypeDic.Add(".igs", "application/x-igs");
            TypeDic.Add(".iii", "application/x-iphone");
            TypeDic.Add(".img", "application/x-img");
            TypeDic.Add(".ins", "application/x-internet-signup");
            TypeDic.Add(".isp", "application/x-internet-signup");
            TypeDic.Add(".IVF", "video/x-ivf");
            TypeDic.Add(".java", "java/*");
            TypeDic.Add(".jfif", "image/jpeg");
            TypeDic.Add(".jpe", "image/jpeg");

            // TypeDic.Add(".jpe", "application/x-jpe");
            TypeDic.Add(".jpeg", "image/jpeg");

            // TypeDic.Add(".jpg", "image/jpeg");
            // TypeDic.Add(".jpg", "application/x-jpg");
            TypeDic.Add(".js", "application/x-javascript");
            TypeDic.Add(".jsp", "text/html");
            TypeDic.Add(".la1", "audio/x-liquid-file");
            TypeDic.Add(".lar", "application/x-laplayer-reg");
            TypeDic.Add(".latex", "application/x-latex");
            TypeDic.Add(".lavs", "audio/x-liquid-secure");
            TypeDic.Add(".lbm", "application/x-lbm");
            TypeDic.Add(".lmsff", "audio/x-la-lms");
            TypeDic.Add(".ls", "application/x-javascript");
            TypeDic.Add(".ltr", "application/x-ltr");
            TypeDic.Add(".m1v", "video/x-mpeg");
            TypeDic.Add(".m2v", "video/x-mpeg");
            TypeDic.Add(".m3u", "audio/mpegurl");
            TypeDic.Add(".m4e", "video/mpeg4");
            TypeDic.Add(".mac", "application/x-mac");
            TypeDic.Add(".man", "application/x-troff-man");
            TypeDic.Add(".math", "text/xml");
            TypeDic.Add(".mdb", "application/msaccess");

            // TypeDic.Add(".mdb", "application/x-mdb");
            TypeDic.Add(".mfp", "application/x-shockwave-flash");
            TypeDic.Add(".mht", "message/rfc822");
            TypeDic.Add(".mhtml", "message/rfc822");
            TypeDic.Add(".mi", "application/x-mi");
            TypeDic.Add(".mid", "audio/mid");
            TypeDic.Add(".midi", "audio/mid");
            TypeDic.Add(".mil", "application/x-mil");
            TypeDic.Add(".mml", "text/xml");
            TypeDic.Add(".mnd", "audio/x-musicnet-download");
            TypeDic.Add(".mns", "audio/x-musicnet-stream");
            TypeDic.Add(".mocha", "application/x-javascript");
            TypeDic.Add(".movie", "video/x-sgi-movie");
            TypeDic.Add(".mp1", "audio/mp1");
            TypeDic.Add(".mp2", "audio/mp2");
            TypeDic.Add(".mp2v", "video/mpeg");
            TypeDic.Add(".mp3", "audio/mp3");
            TypeDic.Add(".mp4", "video/mp4");
            TypeDic.Add(".mpa", "video/x-mpg");
            TypeDic.Add(".mpd", "application/-project");
            TypeDic.Add(".mpe", "video/x-mpeg");
            TypeDic.Add(".mpeg", "video/mpg");
            TypeDic.Add(".mpg", "video/mpg");
            TypeDic.Add(".mpga", "audio/rn-mpeg");
            TypeDic.Add(".mpp", "application/-project");
            TypeDic.Add(".mps", "video/x-mpeg");
            TypeDic.Add(".mpt", "application/-project");
            TypeDic.Add(".mpv", "video/mpg");
            TypeDic.Add(".mpv2", "video/mpeg");
            TypeDic.Add(".mpw", "application/s-project");
            TypeDic.Add(".mpx", "application/-project");
            TypeDic.Add(".mtx", "text/xml");
            TypeDic.Add(".mxp", "application/x-mmxp");
            TypeDic.Add(".net", "image/pnetvue");
            TypeDic.Add(".nrf", "application/x-nrf");
            TypeDic.Add(".nws", "message/rfc822");
            TypeDic.Add(".odc", "text/x-ms-odc");
            TypeDic.Add(".out", "application/x-out");
            TypeDic.Add(".p10", "application/pkcs10");
            TypeDic.Add(".p12", "application/x-pkcs12");
            TypeDic.Add(".p7b", "application/x-pkcs7-certificates");
            TypeDic.Add(".p7c", "application/pkcs7-mime");
            TypeDic.Add(".p7m", "application/pkcs7-mime");
            TypeDic.Add(".p7r", "application/x-pkcs7-certreqresp");
            TypeDic.Add(".p7s", "application/pkcs7-signature");
            TypeDic.Add(".pc5", "application/x-pc5");
            TypeDic.Add(".pci", "application/x-pci");
            TypeDic.Add(".pcl", "application/x-pcl");
            TypeDic.Add(".pcx", "application/x-pcx");
            TypeDic.Add(".pdf", "application/pdf");
            TypeDic.Add(".pdx", "application/vnd.adobe.pdx");
            TypeDic.Add(".pfx", "application/x-pkcs12");
            TypeDic.Add(".pgl", "application/x-pgl");
            TypeDic.Add(".pic", "application/x-pic");
            TypeDic.Add(".pko", "application-pki.pko");
            TypeDic.Add(".pl", "application/x-perl");
            TypeDic.Add(".plg", "text/html");
            TypeDic.Add(".pls", "audio/scpls");
            TypeDic.Add(".plt", "application/x-plt");
            TypeDic.Add(".png", "image/png");

            // TypeDic.Add(".png", "application/x-png");
            TypeDic.Add(".pot", "applications-powerpoint");
            TypeDic.Add(".ppa", "application/vs-powerpoint");
            TypeDic.Add(".ppm", "application/x-ppm");
            TypeDic.Add(".pps", "application-powerpoint");
            TypeDic.Add(".ppt", "applications-powerpoint");

            // TypeDic.Add(".ppt", "application/x-ppt");
            TypeDic.Add(".pr", "application/x-pr");
            TypeDic.Add(".prf", "application/pics-rules");
            TypeDic.Add(".prn", "application/x-prn");
            TypeDic.Add(".prt", "application/x-prt");
            TypeDic.Add(".ps", "application/x-ps");

            // TypeDic.Add(".ps", "application/postscript");
            TypeDic.Add(".ptn", "application/x-ptn");
            TypeDic.Add(".pwz", "application/powerpoint");
            TypeDic.Add(".r3t", "text/vnd.rn-realtext3d");
            TypeDic.Add(".ra", "audio/vnd.rn-realaudio");
            TypeDic.Add(".ram", "audio/x-pn-realaudio");
            TypeDic.Add(".ras", "application/x-ras");
            TypeDic.Add(".rat", "application/rat-file");
            TypeDic.Add(".rdf", "text/xml");
            TypeDic.Add(".rec", "application/vnd.rn-recording");
            TypeDic.Add(".red", "application/x-red");
            TypeDic.Add(".rgb", "application/x-rgb");
            TypeDic.Add(".rjs", "application/vnd.rn-realsystem-rjs");
            TypeDic.Add(".rjt", "application/vnd.rn-realsystem-rjt");
            TypeDic.Add(".rlc", "application/x-rlc");
            TypeDic.Add(".rle", "application/x-rle");
            TypeDic.Add(".rm", "application/vnd.rn-realmedia");
            TypeDic.Add(".rmf", "application/vnd.adobe.rmf");
            TypeDic.Add(".rmi", "audio/mid");
            TypeDic.Add(".rmj", "application/vnd.rn-realsystem-rmj");
            TypeDic.Add(".rmm", "audio/x-pn-realaudio");
            TypeDic.Add(".rmp", "application/vnd.rn-rn_music_package");
            TypeDic.Add(".rms", "application/vnd.rn-realmedia-secure");
            TypeDic.Add(".rmvb", "application/vnd.rn-realmedia-vbr");
            TypeDic.Add(".rmx", "application/vnd.rn-realsystem-rmx");
            TypeDic.Add(".rnx", "application/vnd.rn-realplayer");
            TypeDic.Add(".rp", "image/vnd.rn-realpix");
            TypeDic.Add(".rpm", "audio/x-pn-realaudio-plugin");
            TypeDic.Add(".rsml", "application/vnd.rn-rsml");
            TypeDic.Add(".rt", "text/vnd.rn-realtext");
            TypeDic.Add(".rtf", "application/msword");

            // TypeDic.Add(".rtf", "application/x-rtf");
            TypeDic.Add(".rv", "video/vnd.rn-realvideo");
            TypeDic.Add(".sam", "application/x-sam");
            TypeDic.Add(".sat", "application/x-sat");
            TypeDic.Add(".sdp", "application/sdp");
            TypeDic.Add(".sdw", "application/x-sdw");
            TypeDic.Add(".sit", "application/x-stuffit");
            TypeDic.Add(".slb", "application/x-slb");
            TypeDic.Add(".sld", "application/x-sld");
            TypeDic.Add(".slk", "drawing/x-slk");
            TypeDic.Add(".smi", "application/smil");
            TypeDic.Add(".smil", "application/smil");
            TypeDic.Add(".smk", "application/x-smk");
            TypeDic.Add(".snd", "audio/basic");
            TypeDic.Add(".sol", "text/plain");
            TypeDic.Add(".sor", "text/plain");
            TypeDic.Add(".spc", "application/x-pkcs7-certificates");
            TypeDic.Add(".spl", "application/futuresplash");
            TypeDic.Add(".spp", "text/xml");
            TypeDic.Add(".ssm", "application/streamingmedia");
            TypeDic.Add(".sst", "application-pki.certstore");
            TypeDic.Add(".stl", "application/-pki.stl");
            TypeDic.Add(".stm", "text/html");
            TypeDic.Add(".sty", "application/x-sty");
            TypeDic.Add(".svg", "text/xml");
            TypeDic.Add(".swf", "application/x-shockwave-flash");
            TypeDic.Add(".tdf", "application/x-tdf");
            TypeDic.Add(".tg4", "application/x-tg4");
            TypeDic.Add(".tga", "application/x-tga");
            TypeDic.Add(".tif", "image/tiff");

            // TypeDic.Add(".tif", "application/x-tif");
            TypeDic.Add(".tiff", "image/tiff");
            TypeDic.Add(".tld", "text/xml");
            TypeDic.Add(".top", "drawing/x-top");
            TypeDic.Add(".torrent", "application/x-bittorrent");
            TypeDic.Add(".tsd", "text/xml");
            TypeDic.Add(".txt", "text/plain");
            TypeDic.Add(".uin", "application/x-icq");
            TypeDic.Add(".uls", "text/iuls");
            TypeDic.Add(".vcf", "text/x-vcard");
            TypeDic.Add(".vda", "application/x-vda");
            TypeDic.Add(".vdx", "application/vnd.visio");
            TypeDic.Add(".vml", "text/xml");
            TypeDic.Add(".vpg", "application/x-vpeg005");
            TypeDic.Add(".vsd", "application/vnd.visio");

            // TypeDic.Add(".vsd", "application/x-vsd");
            TypeDic.Add(".vss", "application/vnd.visio");
            TypeDic.Add(".vst", "application/vnd.visio");

            // TypeDic.Add(".vst", "application/x-vst");
            TypeDic.Add(".vsw", "application/vnd.visio");
            TypeDic.Add(".vsx", "application/vnd.visio");
            TypeDic.Add(".vtx", "application/vnd.visio");
            TypeDic.Add(".vxml", "text/xml");
            TypeDic.Add(".wav", "audio/wav");
            TypeDic.Add(".wax", "audio/x-ms-wax");
            TypeDic.Add(".wb1", "application/x-wb1");
            TypeDic.Add(".wb2", "application/x-wb2");
            TypeDic.Add(".wb3", "application/x-wb3");
            TypeDic.Add(".wbmp", "image/vnd.wap.wbmp");
            TypeDic.Add(".wiz", "application/msword");
            TypeDic.Add(".wk3", "application/x-wk3");
            TypeDic.Add(".wk4", "application/x-wk4");
            TypeDic.Add(".wkq", "application/x-wkq");
            TypeDic.Add(".wks", "application/x-wks");
            TypeDic.Add(".wm", "video/x-ms-wm");
            TypeDic.Add(".wma", "audio/x-ms-wma");
            TypeDic.Add(".wmd", "application/x-ms-wmd");
            TypeDic.Add(".wmf", "application/x-wmf");
            TypeDic.Add(".wml", "text/vnd.wap.wml");
            TypeDic.Add(".wmv", "video/x-ms-wmv");
            TypeDic.Add(".wmx", "video/x-ms-wmx");
            TypeDic.Add(".wmz", "application/x-ms-wmz");
            TypeDic.Add(".wp6", "application/x-wp6");
            TypeDic.Add(".wpd", "application/x-wpd");
            TypeDic.Add(".wpg", "application/x-wpg");
            TypeDic.Add(".wpl", "application/-wpl");
            TypeDic.Add(".wq1", "application/x-wq1");
            TypeDic.Add(".wr1", "application/x-wr1");
            TypeDic.Add(".wri", "application/x-wri");
            TypeDic.Add(".wrk", "application/x-wrk");
            TypeDic.Add(".ws", "application/x-ws");
            TypeDic.Add(".ws2", "application/x-ws");
            TypeDic.Add(".wsc", "text/scriptlet");
            TypeDic.Add(".wsdl", "text/xml");
            TypeDic.Add(".wvx", "video/x-ms-wvx");
            TypeDic.Add(".xdp", "application/vnd.adobe.xdp");
            TypeDic.Add(".xdr", "text/xml");
            TypeDic.Add(".xfd", "application/vnd.adobe.xfd");
            TypeDic.Add(".xfdf", "application/vnd.adobe.xfdf");
            TypeDic.Add(".xhtml", "text/html");
            TypeDic.Add(".xls", "application/-excel");

            // TypeDic.Add(".xls", "application/x-xls");
            TypeDic.Add(".xlw", "application/x-xlw");
            TypeDic.Add(".xml", "text/xml");
            TypeDic.Add(".xpl", "audio/scpls");
            TypeDic.Add(".xq", "text/xml");
            TypeDic.Add(".xql", "text/xml");
            TypeDic.Add(".xquery", "text/xml");
            TypeDic.Add(".xsd", "text/xml");
            TypeDic.Add(".xsl", "text/xml");
            TypeDic.Add(".xslt", "text/xml");
            TypeDic.Add(".xwd", "application/x-xwd");
            TypeDic.Add(".x_b", "application/x-x_b");
            TypeDic.Add(".x_t", "application/x-x_t");
        }

        /// <summary>
        /// 根据文件后缀获取文件http响应类型
        /// </summary>
        /// <param name="key">Key Name</param>
        /// <returns>ContentType</returns>
        public static string GetContentType(string key)
        {
            if (ContentTypeDic.TypeDic.Keys.Contains(key))
            {
                return ContentTypeDic.TypeDic[key];
            }
            else
            {
                return "application/octet-stream";
            }
        }

        /// <summary>
        /// 字典
        /// </summary>
        private static Dictionary<string, string> TypeDic = new Dictionary<string, string>();
    }
}
