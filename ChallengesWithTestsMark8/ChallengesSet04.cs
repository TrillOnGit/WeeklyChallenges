using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers) => numbers.Sum(x => x % 2 == 0 ? x : -x);
        

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strList = { str1, str2, str3, str4 };

            return strList.Aggregate(Int32.MaxValue, 
                (currentShort, next) 
                    => currentShort > next.Length ? next.Length : currentShort);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] intList = { number3, number1, number2, number4 };
            return intList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            try
            {
                return double.Parse(input) is double;
            }
            catch (FormatException e)
            {
                return false;
            }
            catch (ArgumentNullException n)
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).ToArray().Length > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var evenArr = numbers.Where(n => n % 2 == 0);
            return !evenArr.Any() ? 0 : evenArr.Average();
        }

        public int Factorial(int number) => Enumerable.Range(1, number).Aggregate(1, (result, current) => result * current);
    }
}
