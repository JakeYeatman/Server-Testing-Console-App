using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RDSWebAPI.Models;

namespace ServerTesterApplication.ExternalAPIConnections
{
    public class RDSAPI_Test
    {
        private const string _KEY = "5ab3cc97a8d11a00017332a7852539f8365d470ca14b116b5cdc57a3";
        private static string xml = Environment.CurrentDirectory + "\\event.xml";

        static string url = String.Format(@"http://api.rdscyber.com/API/ANPR");

        public static void TestANPR()
        {
            using(StreamReader streamReader = new StreamReader(xml))
            {
                string allXml = streamReader.ReadToEnd();
                Console.WriteLine(allXml);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                byte[] bytes;
                bytes = System.Text.Encoding.ASCII.GetBytes(allXml);
                request.ContentType = "text/xml; encoding='utf-8'";
                request.ContentLength = bytes.Length;
                request.Method = "POST";
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                HttpWebResponse response;
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine(response.StatusCode);
                }
                else
                {
                    Console.WriteLine(response.StatusCode);
                }
            }
        }
    }
}
