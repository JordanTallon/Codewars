   /*Challenge :
   Write a function called that takes a string of parentheses, and determines 
   if the order of the parentheses is valid. The function should return true if the string is valid,
   and false if it's invalid.*/
  
public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        while(input.Contains('(') && input.Contains(')'))
        {
          int index = input.IndexOf('(');
          bool closed = false;
          for(int i = index; i < input.Length;i++)
          {
            if(input[i] == ')'){input = input.Remove(i,1); input = input.Remove(index,1);closed = true;break;}
          }
          if(!closed){return false;}
        }
        return !(input.Contains('(') || input.Contains(')')); 
    }
}
/*Output Examples
"(z)"              =>  true
")((x)))"          =>  false
"("               =>  false
"((h))(((t)(e))())"  =>  true
