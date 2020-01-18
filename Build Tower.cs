/*Challenge:
Build Tower

Build Tower by the following given argument:
number of floors (integer and always greater than 0).

Tower block is represented as *
for example, a tower of 3 floors looks like below
  '  *  ', 
  ' *** ', 
  '*****'
*/

public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
    string[] tower = new string[nFloors];
    for(int i = 0; i < nFloors; i++)
    {
      tower[i] = new string('*',(i*2)+1);
      string spacing = new string(' ',(nFloors-(i+1)));
      tower[i] = spacing + tower[i] + spacing;
    }
    return tower;
  }
}


/*Example Output:

Kata.TowerBuilder(6) > = [
                          '     *     ', 
                          '    ***    ', 
                          '   *****   ', 
                          '  *******  ', 
                          ' ********* ', 
                          '***********'
                         ]
  */
