using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace word_remove
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
           
            Console.WriteLine("Enter the string ");
            var userInput = Console.ReadLine();
            var statement = userInput;
            var result = word_remove(statement);
           Console.WriteLine("Your statement without vowels is :" + result);
           
        }
        public static string word_remove(string statement)
        {
         var res = "";
            for (int i = 0; i < statement.Length; i ++)
            {
           
                if (statement[i] == 'a' || statement[i] == 'e' || statement[i] == 'i' || statement[i] == 'o' || statement[i] == 'u')
                {
                continue;
                }
                if (statement[i] == 'A' || statement[i] == 'E' || statement[i] == 'I' || statement[i] == 'O' || statement[i] == 'U') {
                continue;
                }
                else {
                res += statement[i];
                }
            }
            return res;
        }
    }
}
