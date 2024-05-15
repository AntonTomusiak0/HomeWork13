namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: ");
            string path = Console.ReadLine();
            Console.WriteLine("Input: ");
            string seach = Console.ReadLine();
            Task1 task1 = new Task1();
            List<string> files = task1.FindFiles(path, seach);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("Input: ");
            string path2 = Console.ReadLine();
            Console.WriteLine("Input: ");
            string seach2 = Console.ReadLine();
            Task2 task2 = new Task2();
            task2.DeleteFile(path2, seach2);
            Console.WriteLine("Input: ");
            string path3 = Console.ReadLine();
            Task3 task3 = new Task3();
            task3.DisplayStuff(path3);
        }
    }
}