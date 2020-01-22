/*Challenge:
In this kata you have to create all permutations of an input string and remove duplicates, if present. 
This means, you have to shuffle all letters from the input in all possible orders.

using System;
using System.Collections.Generic;
class Permutations
{
   public static List<string> SinglePermutations(string s)
   { 
     List<string> w = new List<string>();
     permutate(s.ToCharArray(),0,s.Length-1,ref w);
     return w;
   }
   
   static void permutate(char[] letters, int l, int r, ref List<string> list)
   {
      if(l==r){
      string p = string.Concat(letters);
      if(!list.Contains(p)){list.Add(p);}
      }
      else {
        for(int i = l; i <= r ; i++){
          Swap(ref letters[l],ref letters[i]);
          permutate(letters,l+1,r,ref list);
          Swap(ref letters[l],ref letters[i]);
        }
      }
   }
  
  static void Swap(ref char a, ref char b){
      char temp = a;
      a = b;
      b = temp;
  }
}

/*Example Output:
Permutations.SinglePermutations("a"); // => new List {"a"}
Permutations.SinglePermutations("ab"); // => new List {"ab", "ba"}
Permutations.SinglePermutations("aabb"); // => new List {"aabb", "abab", "abba", "baab", "baba", "bbaa"}
*/
