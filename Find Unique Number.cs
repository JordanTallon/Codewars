/*Challenge:
There is an array with some numbers. All numbers are equal except for one. Try to find it!

findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55*/

using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
   foreach(int n in numbers){ if(numbers.Count(x => x == n)==1){return(n);}}
   return(-1);
  }
}

/* Example Outputs:
GetUnique({1, 2, 2, 2}) >= 1
GetUnique({-2, 2, 2, 2}) >= -2
GetUnique({11, 11, 14, 11, 11}) >= 14
*/
