namespace day1.Part1;

public class Part1
{
    public static List<string> readInput()
    {
        List<string> inputLines = [];
        try
        {
            StreamReader sr = new StreamReader("./Part1Input.txt");
            string? line = sr.ReadLine();
            while (line != null)
            {
                inputLines.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine("Could not read file. Exception: " + e.Message);
        }
        return inputLines;
    }
}
