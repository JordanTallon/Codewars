/* Challenge: Create a function taking a positive integer as its parameter and returning a string containing the Roman Numeral representation of that 
integer.

Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a 
value of zero. In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; 
or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.*/

using System;

public class RomanConvert
{
  public static string Solution(int n)
  {
    string s = "";
    s+= Replace(1000,"M",ref n);
    s+= Replace(900,"CM",ref n);
    s+= Replace(500,"D",ref n);
    s+= Replace(400,"CD",ref n);
    s+= Replace(100,"C",ref n);
    s+= Replace(90,"XC",ref n);
    s+= Replace(50,"L",ref n);
    s+= Replace(40,"XL",ref n);
    s+= Replace(10,"X",ref n);
    s+= Replace(9,"IX",ref n);
    s+= Replace(5,"V",ref n);
    s+= Replace(4,"IV",ref n);
    s+= Replace(1,"I",ref n);

    return(s);
  }
  
  static string Replace(int number,string roman, ref int n)
  {
      string s = "";
      for(int i = 0; i < n/number; i++){s += roman;}
      n -=  number*(n/number);
      return(s);
  }
}

/* Example Output
Solution(1954) => "MCMLIV"
Solution(1990) => "MCMXC"
Solution(2008) => "MMVIII"*/
