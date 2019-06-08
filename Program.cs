class Program
{
    static void Main(string[] args)
    {
        string words = "";

        foreach (string word in args)
        {
            words = words + " " + word;
        }

        System.Console.WriteLine(words + " thinks this is very cool!");
    }
}
