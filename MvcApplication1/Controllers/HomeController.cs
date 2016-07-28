using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string aa(string aa = "test xml")
        {
            StreamReader sr = new StreamReader(Request.InputStream);
            string xml = sr.ReadToEnd();
            string fileName = Server.MapPath("/Content") + "\\" + "aa.xml";
           
            System.IO.File.WriteAllText(fileName, xml);
           
            
            return "Response from service : " +xml;
        }

        /// <summary>
        /// Copies the contents of input to output. Doesn't close either stream.
        /// </summary>
        public static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[8 * 1024];
            int len;
            while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, len);
            }
        }
    }
}
