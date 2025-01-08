namespace day1.Part1;

public class Part1
{
    public static List<string> ReadInput()
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
    public static List<string>[] SplitLines(List<string> input)
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
    public static List<int[]> SplitSequences(List<string> input)
    {
        List<int[]> arrayOfDigits = [];

        foreach (string sequence in input)
        {
            char[] digitsAsChars = sequence.ToCharArray();
            int[] digitsAsInts = Array.ConvertAll<char, int>(digitsAsChars, c => (int)char.GetNumericValue(c));
            arrayOfDigits.Add(digitsAsInts);
        }
        // foreach (var item in arrayOfDigits)
        // {
        //     foreach (var n in item)
        //     {
        //         Console.WriteLine(n);
        //     }
        // }
        return arrayOfDigits;
    }
    public static List<int[]> SortSequences(List<int[]> unsortedColumnSequences)
    {
        List<int[]> sortedColumnSequences = [];
        int i, temp, swapCounter;
        bool swapped;

        foreach (int[] sequence in unsortedColumnSequences)
        {
            swapped = true;
            swapCounter = 0;
            while (swapped == true)
            {
                for (i = 0; i < 4; i++)
                {
                    if (sequence[i] > sequence[i + 1])
                    {
                        swapCounter++;
                        temp = sequence[i];
                        sequence[i] = sequence[i + 1];
                        sequence[i + 1] = temp;
                    }
                }

                if (swapCounter == 0)
                {
                    swapped = false;
                }
                else
                {
                    swapCounter = 0;
                }
            }
            sortedColumnSequences.Add(sequence);
        }

        return sortedColumnSequences;
    }

    public static int CompareColumns(List<int[]> leftColumnSorted, List<int[]> rightColumnSorted)
    {
        int totalDifference = 0;
        for (int i = 0; i < leftColumnSorted.Count && i < rightColumnSorted.Count; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                totalDifference += Math.Abs(leftColumnSorted[i][j] - rightColumnSorted[i][j]);
            }
        }
        return totalDifference;
    }
}
