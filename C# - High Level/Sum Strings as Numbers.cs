
/*
Challenge : Given the string representations of two integers, return the string representation of the sum of those integers.

Originally from the challenge title and description, it sounded like a pretty easy to solve problem,
but that wasn't the case as it wanted to solve numbers in such a large range even a 64bit long wasn't able to hold them.
My solution was to split each number into 2 longs add them up individually then "stitch" them back together whilst handling remainders.*/

using System;
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
     if(a == ""){return(b);} if(b == ""){return(a);}
     
     int longestNumber = a.Length > b.Length ? a.Length : b.Length;
     a = a.Length != longestNumber ? new string('0',longestNumber -a.Length) + a : a;
     b = b.Length != longestNumber ? new string('0',longestNumber -b.Length) + b : b;  
     
     //splitting each string into 2 parts, with flooring / ceiling to handle the odd numbers
     long a1 = Convert.ToInt64(a.Substring(0,(int)Math.Ceiling(a.Length/2.0f)));
     long a2 = Convert.ToInt64(a.Substring((int)Math.Ceiling(a.Length/2.0f),(int)MathF.Floor(a.Length/2.0f)));
     long b1 = Convert.ToInt64(b.Substring(0,(int)Math.Ceiling(b.Length/2.0f)));
     long b2=  Convert.ToInt64(b.Substring((int)Math.Ceiling(b.Length/2.0f),(int)MathF.Floor(b.Length/2.0f)));
     
     //total sum of each part
     long aTotal = (a1+b1);
     long bTotal = (a2+b2);
     
     //remainders 
     longestNumber = a2 > b2 ? (""+a2).Length : (""+b2).Length;
     if((""+(a2+b2)).Length > longestNumber){
         long deduct = Convert.ToInt64("1" + new string('0',(""+(a2+b2)).Length-1));
         bTotal-=deduct; aTotal+=1;
     } 
     
     return aTotal +""+ bTotal;
    }
}

/*Output Examples:
123+456 = 579
712569312664357328695151392 + 8100824045303269669937 = 712577413488402631964821329
50095301248058391139327916261 + 81055900096023504197206408605 = 131151201344081895336534324866
*/
