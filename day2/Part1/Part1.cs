namespace day2.Part1;

public class Part1
{
    public static List<string> ReadInput()
    {
        List<string> inputLines = [];
        try
        {
            StreamReader sr = new StreamReader("./Part1/Part1Input.txt");
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

    public static List<int[]> SplitSequences(List<string> inputStrings)
    {
        List<int[]> sequencesAsArrays = [];

        foreach (string sequence in inputStrings)
        {
            string[] splitSequence = sequence.Split(" ");
            int[] splitSequenceAsInts = Array.ConvertAll(splitSequence, int.Parse);
            sequencesAsArrays.Add(splitSequenceAsInts);
        }

        return sequencesAsArrays;
    }

}
