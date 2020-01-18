//Challenge : Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

using System.Collections.Generic;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    List<int> toReturn = new List<int>();
    for(int i = 0; i < arr.Length; i++)
    {
      if(arr[i] != 0){toReturn.Add(arr[i]);}
    }
    while(toReturn.Count < arr.Length){  toReturn.Add(0);}
    return(toReturn.ToArray());
  }
}

/* Example Outputs:
MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
*/
