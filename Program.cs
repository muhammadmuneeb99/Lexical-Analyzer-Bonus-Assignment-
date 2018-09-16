using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bonus_Ass_Lexical_Analuzer_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            //please give input in this manner e.g=> using system ; int a = 4 + 5 ;

            input = Console.ReadLine();

            string[] keyword = { "using", "abstract", "class", "int", "float", "decimal", "system", "while", "if", "else", "for", "foreach", "static", "void", "public", "private", "protected" };
            string[] number_digits = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] specialCharacter = { ":", ";" };
            string[] operators = { "+", "-", "*", "/" };

            string[] strArr = input.Split(' ');
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    Console.WriteLine(strArr[i]);
            //}
            int count = 0;
            for (int i = count; i < strArr.Length; i++)
            {
                for (int j = 0; j < keyword.Length; j++)
                {
                    if (strArr[i] == keyword[j])
                    {
                        Console.WriteLine(strArr[i] + " is a Keyword");
                        count = count + 1;
                    }
                }
            }
            for (int i = count; i < strArr.Length; i++)
            {
                for (int j = 0; j < operators.Length; j++)
                {
                    if (strArr[i] == operators[j])
                    {
                        Console.WriteLine(strArr[i] + " is a operator");
                        count = count + 1;
                    }
                }
            }
            for (int i = count; i < strArr.Length; i++)
            {
                for (int j = 0; j < specialCharacter.Length; j++)
                {
                    if (strArr[i] == specialCharacter[j])
                    {
                        Console.WriteLine(strArr[i] + " is a Special Character");
                        count = count + 1;
                    }
                }
            }
            for (int i = count; i < strArr.Length; i++)
            {
                for (int j = 0; j < number_digits.Length; j++)
                {
                    string chr = strArr[i];
                    char[] chr_digit = chr.ToCharArray();
                    for (int k = 0; k < chr_digit.Length; k++)
                    {
                        if (chr_digit[k].ToString() == number_digits[j])
                        {
                            Console.WriteLine(strArr[i] + " is a number/digit Character");
                            count = count + 1;
                        }
                    }
                    
                }
            }
            
        }
    }
}
