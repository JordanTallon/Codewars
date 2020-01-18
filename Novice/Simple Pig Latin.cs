/*Challenge:
Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.*/

public class Kata
{
  public static string PigIt(string str)
  {
    string[] words = str.Split(' ');
    for(int i = 0; i < words.Length ; i++){
      char[] currentWord = (words[i]+" ").ToCharArray(); 
      currentWord[currentWord.Length-1] = currentWord[0]; currentWord[0] =' ';
      words[i] =  string.Join("",currentWord).Trim()+"ay";
    }
    return string.Join(" ",words);
  }

}
/*Output Examples:
PigIt("Pig latin is cool"); >= igPay atinlay siay oolcay
PigIt("Hello world !");     >= elloHay orldway !
*/
