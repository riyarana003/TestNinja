using System.IO;

namespace TestNinja.Mocking
{
    public interface IFileReader
    {
        string Read(string pathOfFile);
    }
    public class FileReader : IFileReader
    {
        public string Read(string pathOfFile)
        {
            return File.ReadAllText(pathOfFile);
        }
    }
}
