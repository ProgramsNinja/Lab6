using System.Text;
using Лаб11;

public class Program
{
    public static void Main()
    {
        IFile file = new FileProxy("_|_|_|_text.txt");

        var size = file.GetSize();
        var path = file.GetPath();
        var bytes = file.Show();

        Console.WriteLine($"Size: {size}");
        Console.WriteLine($"Path: {path}");
        Console.WriteLine($"Show: {Encoding.UTF8.GetString(bytes)}");
    }
}