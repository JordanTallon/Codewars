using System;

public class Kata
{
  public static int DuplicateCount(string str)
  {
    str = str.ToLower();
    string duplicates = "";
    for(int i = 0; i < str.Length; i++)
    {   
      if(duplicates.Contains(str[i])) {continue;}
      string prev = str.Substring(0,i);
      if(prev.Contains(str[i])) 
      {
        duplicates+=str[i];
      }
    }
    return duplicates.Length;
  }
}
