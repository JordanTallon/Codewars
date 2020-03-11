/*Challenge:
Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words.
You should return an array of all the anagrams or an empty array if there are none. For example:
anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']*/

using System;
using System.Linq;
using System.Collections.Generic;
public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    List<string> found = new List<string>(); 
    foreach(string w in words){
    if(String.Concat(w.OrderBy(c => c)) == String.Concat(word.OrderBy(c => c))){found.Add(w);}}  
    return found;
  }
}

/*Example Output:
Anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']) => ['carer', 'racer']
*/
