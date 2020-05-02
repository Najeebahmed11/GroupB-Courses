namespace TestNinja.Mocking
{
    public interface IFileDownLoader
    {
        void DownlaodFile(string url, string path);
        void DownloadFile(string v, string setupDestinationFile);
    }
}