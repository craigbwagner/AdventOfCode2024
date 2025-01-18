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

    public static int CountSafeReports(List<int[]> sequencesAsArrays)
    {
        int safeReportsCounter = 0;

        foreach (int[] reportSequence in sequencesAsArrays)
        {
            bool isSafe = false;
            string reportPattern = CheckIncreasingOrDecreasing(reportSequence);
            if (reportPattern == "increasing" || reportPattern == "decreasing")
            {
                isSafe = CheckGradualChange(reportSequence);
            }

            if (isSafe == true)
            {
                safeReportsCounter++;
            }
        }

        return safeReportsCounter;
    }

    static string CheckIncreasingOrDecreasing(int[] reportSequence)
    {
        bool isIncreasing = true;
        bool isDecreasing = true;

        for (int i = 1; i < reportSequence.Length; i++)
        {
            if (isIncreasing == true && reportSequence[i] < reportSequence[i - 1])
            {
                isIncreasing = false;
            }
            else if (isDecreasing == true && reportSequence[i] > reportSequence[i - 1])
            {
                isDecreasing = false;
            }
        }

        if (isIncreasing == true)
        {
            return "increasing";
        }
        else if (isDecreasing == true)
        {
            return "decreasing";
        }
        else
        {
            return "no pattern";
        }
    }

    static bool CheckGradualChange(int[] reportSequence)
    {
        bool isGradual = true;

        for (int i = 1; i < reportSequence.Length; i++)
        {
            int sequenceDifferential = Math.Abs(reportSequence[i] - reportSequence[i - 1]);
            if (sequenceDifferential == 0 || sequenceDifferential > 3)
            {
                isGradual = false;
            }
        }

        return isGradual;
    }
}
