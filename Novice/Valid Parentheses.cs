   /*Challenge :
   Write a function called that takes a string of parentheses, and determines 
   if the order of the parentheses is valid. The function should return true if the string is valid,
   and false if it's invalid.*/
  
  public class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '(' && input[i] != ')') { continue; }
                bool closed = false;
                if (input[i] == '(') { for (int h = i; h < (input.Length); h++) { if (input[h] == ')') { closed = true; } } }
                if (input[i] == ')') { for (int h = i; h > -1; h--) { if (input[h] == '(') { closed = true; } } }
                if (!closed){return false;}
            }
            return true;
        }
    }
    
/*Output Examples
"(z)"              =>  true
")((x)))"          =>  false
"("               =>  false
"((h))(((t)(e))())"  =>  true
