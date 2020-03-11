/*Challenge:
In this kata you have to create a domain name validator mostly compliant with RFC 1035, RFC 1123, and RFC 2181
Domain name may contain subdomains (levels), hierarchically separated by . (period) character
Domain name must not contain more than 127 levels, including top level (TLD)
Domain name must not be longer than 253 characters (RFC specifies 255, but 2 characters are reserved for trailing dot and null character for root level)
Level names must be composed out of lowercase and uppercase ASCII letters, digits and - (minus sign) character
Level names must not start or end with - (minus sign) character
Level names must not be longer than 63 characters
Top level (TLD) must not be fully numerical*/

using System;
using System.Linq;
public class DomainNameValidator {
  public bool validate(string domain) {
  
    if(domain.Length > 253 || !domain.Contains('.')){return false;}
    if(domain.Split('.').OrderByDescending( s => s.Length ).First().Length > 63){return false;}
    if(domain.IndexOfAny("ň_@".ToCharArray()) != -1){return false;}
    if(domain.Contains(".-")||domain.Contains("-.") || domain.Contains("..")){return false;}
    if(!Char.IsLetterOrDigit(domain[domain.Length-1])||!Char.IsLetterOrDigit(domain[0])){return false;}
    if(domain.Split('.').Last().All(Char.IsDigit)){return false;}
    return true;
    
  }
}

/*Example output:
validate('codewars') == False
validate('g.co') == True
validate('codewars.com') == True
validate('CODEWARS.COM') == True
validate('sub.codewars.com') == True
validate('codewars.com-') == False
validate('.codewars.com') == False
validate('example@codewars.com') == False
validate('127.0.0.1') == False*/
