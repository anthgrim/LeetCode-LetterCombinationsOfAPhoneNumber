namespace LetterCombination
{
  class Program
  {
    public class Solution
    {
      public static List<string> LetterCombination(string digits)
      {
        var result = new List<string>();

        if (String.IsNullOrEmpty(digits))
        {
          Console.WriteLine("Digits is null or empty");
          return result;
        }

        var isValidDigit = Int32.TryParse(digits, out int digit);
        if (!isValidDigit)
        {
          Console.WriteLine("Invalid digits");
          return result;
        }

        var mappings = new Dictionary<char, string>();
        mappings.Add('0', "");
        mappings.Add('1', "");
        mappings.Add('2', "abc");
        mappings.Add('3', "def");
        mappings.Add('4', "ghi");
        mappings.Add('5', "jkl");
        mappings.Add('6', "mno");
        mappings.Add('7', "pqrs");
        mappings.Add('8', "tuv");
        mappings.Add('9', "wxyz");

        GetCombination(result, digits, "", 0, mappings);

        return result;
      }

      private static void GetCombination (List<string> result, string digits, string current, int index, Dictionary<char, string> mapping)
      {
        if (index == digits.Length)
        {
          result.Add(current);
          return;
        }

        string letters = mapping[digits[index]];

        for (var i = 0; i < letters.Length; i++)
        {
          GetCombination(result, digits, current + letters[i], index + 1, mapping);
        }

        return;
      }

      public static void LoopList(List<string> list)
      {
        if (list.Count() == 0)
        {
          Console.WriteLine("List is empty");
        } else
        {
          foreach (var item in list)
          {
            Console.Write($"{item} ");
          }
          Console.WriteLine("\n");
        }
      }

    }
    static void Main(string[] args)
    {
      var possibleCombinations = Solution.LetterCombination("23");
      Solution.LoopList(possibleCombinations);
    }
  }
}