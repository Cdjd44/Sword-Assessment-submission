namespace Assessment
{
    using System.IO;
    using System.Text;

    public class InputFile
    {
        public string getFile(string pathToFile)
        {
            string FileText = File.ReadAllText(pathToFile).Replace("\r\n", " ").Replace("\t", "").Replace(" ", "");
            return FileText;
        }
    }
}