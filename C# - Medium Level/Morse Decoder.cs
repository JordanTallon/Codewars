/*Challenge:
Your task is to implement a function that would take the morse code as input and return a decoded human-readable string.

For example:

MorseCodeDecoder.Decode(".... . -.--   .--- ..- -.. .")
//should return "HEY JUDE"

NOTE: For coding purposes you have to use ASCII characters . and -, not Unicode characters.*/

using NUnit.Framework;

class MorseCodeDecoder
{
	public static string Decode(string morseCode)
	{
	   string[] morseWords = morseCode.Split(' ');
	   for(int i = 0; i < morseWords.Length;i++) {  
	   morseWords[i] = morseWords[i].Length ==0? "¬" : MorseCode.Get(morseWords[i]);}
	   return string.Join("",morseWords).Replace("¬¬"," ").Replace("¬","").Trim();
	}
}



/*Example Output:
MorseCodeDecoder(".... . .-.. .-.. ---  .-- --- .-. .-.. -..") >= "Hello World"
*/
