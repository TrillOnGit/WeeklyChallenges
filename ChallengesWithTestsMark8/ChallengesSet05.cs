using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            var num = numbers.OrderBy(x => x).ToArray();
            return numbers.SequenceEqual(num);
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var num = 0;
            if (numbers == null) return num;
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    num += numbers[i + 1];
                }
            }
            return num;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null) return "";
            words = words.Select(x => x.Trim()).Where(x => x != "").ToArray();
            return string.Join(" ", words) + (words.Length > 0 ? "." : "");
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            
            List<double> storeArr = new List<double>();

            if (elements == null) return storeArr.ToArray();
            
            for (int i = 3; i < elements.Count; i += 4)
            {
                storeArr.Add(elements[i]);
            }

            return storeArr.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
