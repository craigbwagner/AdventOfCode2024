namespace day1.Part1;

public class Part1
{
    public List<string> readInput()
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
    public List<string>[] splitLines(List<string> input)
    {
        List<string> list1 = [];
        List<string> list2 = [];

        foreach (string line in input)
        {
            string[] sequences = line.Split("   ");
            list1.Add(sequences[0]);
            list2.Add(sequences[1]);
        }
        return [list1, list2];
    }
}
