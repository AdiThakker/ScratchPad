using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Core
{
    public class Strings
    {
        public List<string> GetStringsBetween()
        {
            string search = "abc {string 1} def {string 2}{string 3}";

            // need to return string1, string2, string3
            return search.Split('{')
                          .Aggregate(new List<string>(), (results, item) =>
                          {
                              if(item.Contains("}"))
                                  results.Add(String.Concat(item.TakeWhile(chr => chr != '}')));

                              return results;
                          });
        }

        public string Reverse(string item)
        {
            if (String.IsNullOrEmpty(item))
                throw new ArgumentNullException($"{nameof(item)} cannot be empty.");

            //return String.Concat(item.Reverse());
            return item.Aggregate(string.Empty, (result, chr) => String.Concat(chr, result));

        }
    }
}
