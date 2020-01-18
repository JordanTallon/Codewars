/*Challenge:
Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.
Rules for a smiling face:
-Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
-A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
-Every smiling face must have a smiling mouth that should be marked with either ) or D.
No additional characters are allowed except for those mentioned.
Valid smiley face examples:
:) :D ;-D :~)
Invalid smiley faces:
;( :> :} :]
*/

public static class Kata
{
  public static int CountSmileys(string[] smileys) 
  {
    int count = 0;
    foreach(string s in smileys)
    {
    if(s.Length ==1 || (!s.Contains(":")  && !s.Contains(";"))|| s.Contains(" D")|| s.Contains(" )")){continue;}
    count += s.Contains('D') || s.Contains(')') ? 1 : 0;
    }
    return count;
  }
}

/*Example Outputs
countSmileys([':)', ';(', ';}', ':-D']) >= 2;
countSmileys([';D', ':-(', ':-)', ';~)']) >= 3;
countSmileys([';]', ':[', ';*', ':$', ';-D']) >= 1;
