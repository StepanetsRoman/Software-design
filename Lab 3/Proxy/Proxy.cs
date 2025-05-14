
namespace Proxy
{
    public class SmartTextReader
    {
        public List<List<char>> ReadFile(string path)
        {
            var lines = File.ReadAllLines(path);
            return lines.Select(line => line.ToList()).ToList();
        }
    }

    public class SmartTextChecker : SmartTextReader
    {
        public new List<List<char>> ReadFile(string path)
        {
            Console.WriteLine("Відкриття файлу...");
            var data = base.ReadFile(path);
            Console.WriteLine($"Рядків: {data.Count}, Символів: {data.Sum(line => line.Count)}");
            Console.WriteLine("Файл успішно прочитано і закрито.");
            return data;
        }
    }

    public class SmartTextReaderLocker : SmartTextReader
    {
        private readonly string pattern;
        public SmartTextReaderLocker(string pattern) => this.pattern = pattern;

        public new List<List<char>> ReadFile(string path)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(path, pattern))
            {
                Console.WriteLine("Access denied!");
                return new List<List<char>>();
            }
            return base.ReadFile(path);
        }
    }
}
