/*Complete the solution so that it strips all text that follows any of a set of comment markers passed in. 
Any whitespace at the end of the line should also be stripped out.

Example:

Given an input string of:
apples, pears # and bananas
grapes
bananas !apples

The output expected would be:
apples, pears
grapes
bananas

- This challenge was surprisingly easy considering only 245 other people out of 13,229 managed to complete it.*/

using System.Linq;
using System.Text.RegularExpressions;
public class StripCommentsSolution
{
    public static string StripComments(string text, string[] commentSymbols)
    {
        string[] lines = text.Split('\n');
       
        for(int i = 0; i < lines.Length ;i++){
          foreach(string s in commentSymbols){
              lines[i] = lines[i].Contains(s) ? lines[i].Substring(0, lines[i].IndexOf(s)).TrimEnd() : lines[i].TrimEnd();
            }}
            
        return string.Join("\n",lines);
    }
  
}
