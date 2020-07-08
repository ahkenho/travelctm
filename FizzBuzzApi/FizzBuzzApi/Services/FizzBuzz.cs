using System;
using System.Collections.Generic;

namespace FizzBuzzApi.Services
{
    public class FizzBuzz
    {
        public static List<string> Go(int input)
        {
            List<string> results = new List<string>();

            for(var i = 1; i <= input; i++)
            {
                var resultString = string.Empty;
                if (i % 3 == 0) { resultString = "Fizz"; }
                else if(i % 5 == 0) { resultString = "Buzz"; }
                else if(i % 15 == 0) { resultString = "FizzBuzz"; }
                else { resultString = i.ToString(); }

                results.Add(resultString);
            }

            return results;
        }
    }
}
