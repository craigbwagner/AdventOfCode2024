using day1.Part1;

List<string> part1InputList = Part1.ReadInput();
List<string>[] comparisonSequences = Part1.SplitLines(part1InputList);
List<int[]> leftColumnIntegers = Part1.SplitSequences(comparisonSequences[0]);
List<int[]> rightColumnIntegers = Part1.SplitSequences(comparisonSequences[1]);
