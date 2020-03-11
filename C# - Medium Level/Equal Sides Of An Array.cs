/* Challenge:
You are going to be given an array of integers. Your job is to take that array and find an index N where the sum of
the integers to the left of N is equal to the sum of the integers to the right of N. 
If there is no index that would make this happen, return -1.

For example:

Let's say you are given the array {1,2,3,4,3,2,1}:
Your function will return the index 3, because at the 3rd position of the array, the sum of left side of the index ({1,2,3})
and the sum of the right side of the index ({3,2,1}) both equal 6.

Let's look at another one.
You are given the array {1,100,50,-51,1,1}:
Your function will return the index 1, because at the 1st position of the array, the sum of left side of the index ({1})
and the sum of the right side of the index ({50,-51,1,1}) both equal 1.

Last one:
You are given the array {20,10,-80,10,10,15,35}
At index 0 the left side is {}
The right side is {10,-80,10,10,15,35}
They both are equal to 0 when added. (Empty arrays are equal to 0 in this problem)
Index 0 is the place where the left side and right side are equal.*/


using System;

public class Kata
{
  public static int FindEvenIndex(int[] arr)
  {
     for(int i = 0; i < arr.Length; i++){
      int leftSum=0;
      int rightSum=0;
      
      for(int l = i-1; l > -1; l--){
        leftSum += arr[l];
      }
      for(int r = i+1; r < arr.Length; r++){
        rightSum += arr[r];
      }
      if(leftSum == rightSum){
        return(i);
      }
    }
    return(-1);
  }
}

/*Example Outputs:
FindEvenIndex(new int[] {1,2,3,4,3,2,1}) >= 3
FindEvenIndex(new int[] {1,100,50,-51,1,1}) >= 1
FindEvenIndex(new int[] {1,2,3,4,5,6}) >= -1
FindEvenIndex(new int[] {20,10,30,10,10,15,35}) >= 3
*/
    
