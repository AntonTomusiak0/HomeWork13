
namespace ConsoleApp21
{
    public class Task2
    {
        public void DeleteFile(string path, string seach)
        {
            try
            {
                string[] files = Directory.GetFiles(path, seach);
                foreach (string file in files)
                {
                    File.Delete(file);
                    Console.WriteLine("Deleted file: " + file);
                }
                string[] subFolders = Directory.GetDirectories(path);
                foreach (string subFolder in subFolders)
                {
                    DeleteFile(subFolder, seach);
                    Directory.Delete(subFolder);
                    Console.WriteLine("Deleted folder: " + subFolder);
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
