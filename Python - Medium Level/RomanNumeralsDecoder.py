# Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer. You don't need to validate the form of the Roman numeral.

# Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately, starting with the leftmost digit and skipping any 0s. So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII). The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.

# Example:

# solution('XXI'); // should return 21


def solution(roman):
    roman = roman.replace("CM","900 ").replace("CD","400 ").replace("XC","90 ").replace("XL","40 ").replace("IX","9 ").replace("IV","4 ")
    roman = roman.replace("M","1000 ").replace("D","500 ").replace("C","100 ").replace("L","50 ").replace("X","10 ").replace("V","5 ").replace("I","1 ")
    return sum(int(i) for i in roman.split())