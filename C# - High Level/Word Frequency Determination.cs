/*Challenge:
Write a function that, given a string of text (possibly with punctuation and line-breaks), returns an array of the top-3 most occurring words, in descending order of the number of occurrences.
Assumptions:

A word is a string of letters (A to Z) optionally containing one or more apostrophes (') in ASCII. (No need to handle fancy punctuation.)
Matches should be case-insensitive, and the words in the result should be lowercased.
Ties may be broken arbitrarily.

If a text contains fewer than three unique words, then either the top-2 or top-1 words should be returned,
or an empty array if a text contains no words.*/


using System;
using System.Linq;
using System.Collections.Generic;
public class TopWords
{
    public static List<string> Top3(string s)
    {
      s= new string(s.Select(c => ",/._!;@-:?".Contains(c) ? ' ' : c).ToArray());
      
      Dictionary<string,int> words = s.ToLower().Split(" ",StringSplitOptions.RemoveEmptyEntries)
      .Where(w=> w.Any(x => char.IsLetter(x))).GroupBy(tag => tag).ToDictionary(g => g.Key,g => g.Count());
      
      words = words.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);  
      return words.Keys.Take(3).ToList();
    }
}

/*Example Output:
top_3_words("In a village of La Mancha, the name of which I have no desire to call to
mind, there lived not long since one of those gentlemen that keep a lance
in the lance-rack, an old buckler, a lean hack, and a greyhound for
coursing. An olla of rather more beef than mutton, a salad on most
nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra
on Sundays, made away with three-quarters of his income.")
# => ["a", "of", "on"]

top_3_words("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e")
# => ["e", "ddd", "aa"]

top_3_words("  //wont won't won't")
# => ["won't", "wont"]*/
