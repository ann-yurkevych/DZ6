using SereliazationHomework;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var deserializedPath = "D:\\c# projects\\SereliazationHomework\\SereliazationHomework\\bookFileSerilization.json";
            var deserialized = File.ReadAllText(deserializedPath);
            var option = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true,
            };
            List<Book> books = JsonSerializer.Deserialize<List<Book>>(deserialized, option) ?? throw new NullReferenceException("file is empty");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            var serializedPath = "D:\\c# projects\\SereliazationHomework\\SereliazationHomework\\Test.json";
            var serialized = JsonSerializer.Serialize(books, option);
            File.WriteAllText(serializedPath, serialized);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}