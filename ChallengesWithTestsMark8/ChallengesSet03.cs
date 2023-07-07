using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals) => vals.Any(x => x == false);

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var upperChar = false;
            var lowerChar = false;
            var numChar = false;
            foreach (var digit in password)
            {
                if (char.IsUpper(digit))
                {
                    upperChar = true;
                }
                else if (char.IsLower(digit))
                {
                    lowerChar = true;
                }
                else if (char.IsDigit(digit))
                {
                    numChar = true;
                }
            }

            return upperChar && lowerChar && numChar;
        }

        public char GetFirstLetterOfString(string val) => val[0];

        public char GetLastLetterOfString(string val) => val[^1];

        public decimal Divide(decimal dividend, decimal divisor) => divisor != 0 ? dividend / divisor : 0;

        public int LastMinusFirst(int[] nums) => nums[^1] - nums[0];

        public int[] GetOddsBelow100() => Enumerable.Range(1, 100).Where(x => x % 2 != 0).ToArray();

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var index = 0; index < words.Length; index++)
            {
                words[index] = words[index].ToUpper();
            }
        }
    }
}
