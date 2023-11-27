Console.Write("Enter numbers separated by hyphen: ");
var input = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
Console.WriteLine(Consecutive(input));

string Consecutive(int[] numbers)
{
    for (var i = 0; i < numbers.Length - 1; i++)
    {
        if (numbers[i] + 1 != numbers[i + 1])
        {
            return "Not Consecutive";
        }
    }
    return "Consecutive";
}