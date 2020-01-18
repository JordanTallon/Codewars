/*Challenge:
You are given an array strarr of strings and an integer k. Your task is to return the first longest string consisting of k consecutive strings taken in the array.
Example:

longest_consec(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2) --> "abigailtheta"

n being the length of the string array, if n = 0 or k > n or k <= 0 return "".
Note

consecutive strings : follow one after another without an interruption
*/

using System;

public class LongestConsecutives 
{
    public static String LongestConsec(string[] strarr, int k) 
    {
      string longestString = ""; 
      for(int i = 0; i < strarr.Length-(k-1) ;i++)
      {
        string currentString = "";
        for(int l = 0; l < k; l++)
        {
          currentString += strarr[(i+l)];
        }    
        longestString = currentString.Length > longestString.Length ? currentString : longestString;
      }
      return(longestString);
    }
}

/*Example Outputs:
 LongestConsecutives(new String[] {"zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"}) >= "abigailtheta");
 LongestConsecutives(new String[] {"itvayloxrp","wkppqsztdkmvcuwvereiupccauycnjutlv","vweqilsfytihvrzlaodfixoyxvyuyvgpck"}) >= "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck"

*/
