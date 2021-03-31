using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterCodeBunny.Task3
{
    public static class T9
    {
        public static IList<string> Permutations(string numbers)
        {
            var permutations = new List<string>() { "" };
            foreach(char n in numbers)
            {
                var newPermutations = new List<string>();
                try
                {             
                    foreach(var letter in translations[n])
                    {
                        foreach(var permutation in permutations)
                        {
                            newPermutations.Add(permutation + letter);
                        }
                    }
                    permutations = newPermutations;
                }
                catch
                {
                    throw new Exception("Invalid sequence");
                }
            }
            return permutations;
        }

        private static readonly Dictionary<char, string> translations = new Dictionary<char, string>()
        {
            { '2', "abc" }, 
            { '3', "def" }, 
            { '4', "ghi" }, 
            { '5', "jkl" }, 
            { '6', "mno" }, 
            { '7', "pqrs" }, 
            { '8', "tuv" }, 
            { '9', "wxyz" } 
        };
    }
}
