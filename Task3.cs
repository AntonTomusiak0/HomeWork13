
namespace ConsoleApp21
{
    public class Task3
    {
        public void DisplayStuff(string path)
        {
            int lev = 0;
            try
            {
                string[] files = System.IO.Directory.GetFiles(path);
                foreach (string file in files)
                {
                    Console.WriteLine(new string(' ', lev * 2) + "File: " + System.IO.Path.GetFileName(file));
                }

                string[] subFolders = System.IO.Directory.GetDirectories(path);
                foreach (string subFolder in subFolders)
                {
                    Console.WriteLine(new string(' ', lev * 2) + "Folder: " + System.IO.Path.GetFileName(subFolder));
                    DisplayFolderContents(subFolder, lev + 1);
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
