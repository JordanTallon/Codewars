/*Challenge:
You have to create a function that takes a positive integer number and returns the next bigger number formed by the same digits:*/

using System;
using System.Linq;
public class Kata
{
    public static long NextBiggerNumber(long n)
    { 
    long n2 = n+1;
    string s =  String.Concat(n.ToString().OrderBy(c => c));
    char[] nums = s.ToCharArray(); Array.Reverse(nums);
    string p = new string(nums);
    //skip over unsolveable
    if(s.Distinct().Count() == 1 || p == n.ToString()){ return -1;}  
    while(String.Concat(n2.ToString().OrderBy(c => c)) != s){
       n2++;
       if(n2-n > 9999999){return -1;}
     }
     return(n2);
    }
}


/*Example Output:
12 ==> 21
513 ==> 531
2017 ==> 2071
111 ==> -1
