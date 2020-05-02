using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public class FileDownLoader : IFileDownLoader
    {

        public void DownlaodFile(string url, string path)
        {
            var client = new WebClient();
            client.DownloadFile(url, path);
        }

        public void DownloadFile(string v, string setupDestinationFile)
        {
            var client = new WebClient();
            client.DownloadFile(v, setupDestinationFile);
        }
    }
}
