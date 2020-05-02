using System.Net;

namespace TestNinja.Mocking
{
    public class InstallerHelper
    {
        public InstallerHelper(IFileDownLoader fileDownloader)
        {
            this._fileDownloader = fileDownloader;
        }
        private string _setupDestinationFile;
        private readonly IFileDownLoader _fileDownloader;

        public bool DownloadInstaller(string customerName, string installerName)
        {
            

            try
            {
                 _fileDownloader.DownloadFile(
                    string.Format("http://example.com/{0}/{1}",
                        customerName,
                        installerName),
                    _setupDestinationFile);

                return true;
            }
            catch (WebException)
            {
                return false; 
            }
        }
    }
}