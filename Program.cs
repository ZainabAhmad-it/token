using System;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace token
{
    class program
    {
        /* public static void search_keayword(string path , string word) 
         { 

             string[] line = File.ReadAllLines(path); 
             for (int i = 0; i < line.Length; i++) 
             { 
                     if (line[i].Contains(word)) 
                 { 
                     Console.WriteLine("THE KEYWORD TOKEN : {0}", word); 
                 } 
             } 
         }*/
        private static void Read(string path)
        {
            string[] line = File.ReadAllLines(path);
            char[] num = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] logic = { '{', '}', '<', '>', '=', '!' };
            char[] op = { '+', '-', '*', '/', '%', '^' };
            // Convert String File To Char Array  
            char[] token = new char[line.Length];
            for (int j = 0; j < line.Length; j++)
                token = line[j].ToCharArray();

            for (int j = 0; j < token.Length; j++) // NIMBER TOKEN 
            {
                for (int k = 0; k < num.Length; k++)
                    if (token[j] == num[k])
                    {
                        //         Console.WriteLine("THE NMBER TOKEN : {0}", num[k]); 
                    }
            }
            Console.WriteLine("---------------------------------------------------");

            for (int j = 0; j < token.Length; j++)// LOGIC TOKEN 
            {
                for (int k = 0; k < logic.Length; k++)
                    if (token[j] == logic[k])
                    {
                        //     Console.WriteLine("THE LOGIC TOKEN : {0}", logic[k]); 
                    }
            }
            Console.WriteLine("---------------------------------------------------");

            for (int j = 0; j < token.Length; j++)// operator TOKEN 
            {
                for (int k = 0; k < op.Length; k++)
                    if (token[j] == op[k])
                    {
                        //     Console.WriteLine("THE OPERATOR TOKEN : {0}", op[k]); 
                    }
            }
            for (int j = 0; j < token.Length; j++)// operator TOKEN 
                Console.WriteLine("THE OPERATOR TOKEN :", token[j]);

        }
        public static void Main(string[] args)
        {
            Read(@"C:\Users\AL Manar\Desktop\PS\text.txt");
            string[] keyword = { "for", "int", "main", "include", "using", "namespace", "return", "cout", "cin", "endl" };
            // Console.WriteLine("---------------------------------------------------"); 
            // for (int i=0; i<keyword.Length; i++) 
            // search_keayword(@"C:\Users\AL Manar\Desktop\PS\text.txt" , keyword[i]); 


        }
    }
}