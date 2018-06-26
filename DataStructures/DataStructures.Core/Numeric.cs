using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Core
{
    public class Numeric
    {
        public bool IsPrime(int number)
        {
            // validate
            if (number <= 1)
                return false;

            // for all numbers below number if number is evenly divisible then it's not prime
            return Enumerable.Range(2, number - 2).TakeWhile(num => number % num == 0).Count() == 0;
        }

        public List<int> GetPrimes(int number)
        {
            // validate
            if (number <= 1)
                throw new ArgumentException("Number has to be greater than 1.");

            // for all numbers below square root of the number cross out the multiples of its divisors where exactly divisible
            int max = Convert.ToInt32(Math.Floor(Math.Sqrt(number)));

            return Enumerable
                    .Range(2, max)
                    .Aggregate(Enumerable.Range(2, number - 2).ToList(), (primes, num) =>
                    {
                        // logic to cross out multiples and numvers divisors 
                        int square = num * num;
                        primes.RemoveAll(item => (item >= square && item % num == 0));         
                        return primes;
                    });
        }
    }
}
