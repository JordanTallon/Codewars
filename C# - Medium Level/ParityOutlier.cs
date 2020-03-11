/*Challenge:
You are given an array (which will have a length of at least 3, but could be very large) containing integers. 
The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. 
Write a method that takes the array as an argument and returns this "outlier" N.*/


using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
    Stack<int> odds = new Stack<int>();
    Stack<int> evens = new Stack<int>();
    for(int i = 0; i < integers.Length ;i++){
      if(integers[i]%2 == 1){evens.Push(integers[i]);}else{odds.Push(integers[i]);}
      //results found, no need to continue loop
      if(odds.Count * evens.Count > 1){break;}
    }
    return(odds.Count == 1 ? odds.Pop() : evens.Pop());
  }
}


/*Output Examples:

[2, 4, 0, 100, 4, 11, 2602, 36]
returns: 11 (the only odd number)

[160, 3, 1719, 19, 11, 13, -21]
returns: 160 (the only even number)*/
