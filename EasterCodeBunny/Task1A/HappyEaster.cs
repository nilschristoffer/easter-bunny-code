using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterCodeBunny.Task1A
{
    public static class HappyEaster
    {
        public static IList<string> Rectanglize(IEnumerable<string> words)
        {
            var longestWordLength = words.Select(w => w.Length).Max();

            var tobBottomBorder = AppendChars("", '*', longestWordLength + 4);

            var rectangle = new List<string> { tobBottomBorder };
            foreach(var word in words)
            {
                rectangle.Add("* " + AppendChars(word, ' ', longestWordLength) + " *");
            }
            rectangle.Add(tobBottomBorder);

            return rectangle;
        }

        private static string AppendChars(string word, char c, int totalLength)
        {
            while(word.Length < totalLength) word += c;
            return word;
        }
    }
}
