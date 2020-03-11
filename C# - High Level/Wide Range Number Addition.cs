/*Challenge: 
Write a function that returns the sum of two stupidly large numbers as a string
*/

using System;
using System.Collections.Generic;
public class Kata
{
  public static string Add(string a, string b)
  {
    int longestNumber = a.Length > b.Length ? a.Length : b.Length;
    a = a.Length != longestNumber ? new string('0',longestNumber -a.Length) + a : a;
    b = b.Length != longestNumber ? new string('0',longestNumber -b.Length) + b : b;  
     
    List<string> aStrings = new List<String>();
    List<string> bStrings = new List<String>();
    
    for (int i = 0; i < a.Length; i += 9) 
       aStrings.Add(a.Substring(i, a.Length - i < 9 ? a.Length - i : 9));
    for (int i = 0; i < b.Length; i += 9) 
       bStrings.Add(b.Substring(i, b.Length - i < 9 ? b.Length - i : 9));
    
    string totalSum = "";
    aStrings.Reverse();
    bStrings.Reverse();
    int remainder = 0;
    for(int i = 0; i < aStrings.Count; i++)
    { 
       double aSum = Convert.ToInt64(aStrings[i]);
       double bSum = Convert.ToInt64(bStrings[i]);
       double sum = aSum+bSum + remainder;
       remainder = 0;
       
       longestNumber = aSum > bSum ? (""+aSum).Length : (""+bSum).Length;
       if((""+(aSum+bSum)).Length > longestNumber){
           if(i<aStrings.Count-1)
           {
             double deduct = Convert.ToInt64("1" + new string('0',(""+(aSum+bSum)).Length-1));
             sum-=deduct; remainder=1;
           }
       }
           
       if((""+sum).Length < aStrings[i].Length)
       {totalSum =  new string('0',aStrings[i].Length-(""+sum).Length) + sum + totalSum;}
       else
       {totalSum = sum + totalSum;}
  
    }
    return  totalSum;
  }
}

/*Example Outputs:
854694587458967459867923420398420394845873945734985374844444
+ 
333333333333439439483948394839834938493843948394839432322229
= 
1188027920792406899351871815238255333339717894129824807166673
---------------------------------------------------------------
666666665656566666666565656666666656565666666665656566666666
+ 
464646464646464644646464646464646464646464646463463463463466
= 
1131313130303031311313030303131313121212131313129120030130132
---------------------------------------------------------------
987429134712934876249385134781395873198472398562384958739845234859234758913759182357398457398474598237459823745928347538
+
835743829547328954732895474893754893753281957319857432958432548937859483265893274891378593187431583942678439217431924789
=
1823172964260263830982280609675150766951754355882242391698277783797094242179652457248777050585906182180138262963360272327
*/
