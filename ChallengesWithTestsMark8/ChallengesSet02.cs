using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
            //throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
            //return vals.Count() % 2 == 0; <- Should be slightly less efficient
            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers != null && numbers.Any() ? numbers.Min() + numbers.Max() : 0;
            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var l1 = str1.Length;
            var l2 = str2.Length;
            return l1 <= l2 ? l1 : l2;
            //throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if (numbers != null) return numbers.Sum();
            return 0;
            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            return numbers?.Aggregate(0, (total, next) => next % 2 == 0 ? total + next : total) ?? 0;
            //throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers != null && numbers.Sum() % 2 != 0;
            //throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number % 2 == 0 && number >= 1 ? number / 2 : (number % 2 == 1 ? (number - 1) / 2 : 0);
            //throw new NotImplementedException();
        }
    }
}