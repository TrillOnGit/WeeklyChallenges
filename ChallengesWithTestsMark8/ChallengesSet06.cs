using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase) => 
            !Equals(words, null) && !words.Contains(null) && (ignoreCase ? words
                    .Select(w => w.ToLower())
                    .ToList()
                    .Contains(word.ToLower())
                : words.Contains(word));
        

        public bool IsPrimeNumber(int num)
        {
            var multCount = 0;
            
            for (var i = 1; i <= num; i++) {
                if (num % i == 0)
                {
                    multCount++;
                }
            }
            return multCount == 2;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            for (var i = str.Length - 1; i >= 0; i--)
            {
                if(str.Count(x => x == str[i]) == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var currentNum = 0;
            var currentCount = 1;
            var currentHighest = 0;
            foreach (var t in numbers)
            {
                if (t == currentNum)
                {
                    currentCount++;
                }
                else
                {
                    currentNum = t;
                    if (currentCount > currentHighest)
                    {
                        currentHighest = currentCount;
                    }
                    currentCount = 1;
                }
            }
            return currentHighest >= currentCount ? currentHighest : currentCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var doubArr = Array.Empty<double>();
            
            if (elements == null || n <= 0)
            {
                return doubArr;
            }
            
            for (var i = n - 1; i < elements.Count; i += n)
            {
                doubArr = doubArr.Append(elements[i]).ToArray();
            }

            return doubArr;
        }
    }
}
