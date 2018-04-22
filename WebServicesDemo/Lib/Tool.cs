using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServicesDemo.Lib
{
    public class Tool
    {
        public static void WriteResult(string callback, string result)
        {
            HttpContext.Current.Response.HeaderEncoding = System.Text.Encoding.UTF8;
            HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF8;
            HttpContext.Current.Response.Write(callback + "(" + result + ")");
            HttpContext.Current.Response.End();
        }

    }
}