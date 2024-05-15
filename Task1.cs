
namespace ConsoleApp21
{
    public class Task1
    {
        public List<string> FindFiles(string path, string seachpath)
        {
            List<string> temp = new List<string>();
            try
            {
                string[] files = Directory.GetFiles(path, seachpath);
                temp.AddRange(files);

                string[] subFolders = Directory.GetDirectories(path);
                foreach (string subFolder in subFolders)
                {
                    temp.AddRange(FindFiles(subFolder, seachpath));
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
            return temp;
        }
    }
}

