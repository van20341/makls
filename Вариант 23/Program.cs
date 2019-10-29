using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вариант_23
{
    class Program
    {




        static void Main(string[] args)
        {
              Console.WriteLine("Введите строку S:\n"); 
char[] S = Console.ReadLine().ToCharArray(); 
 Console.WriteLine("\nВведите строку S0:\n"); 
 char[] S0 = Console.ReadLine().ToCharArray(); 
int range = S0.Length; 
int j = 0; 


 for (int i = 0; i <= S.Length - 1; i++) 
 { 
if (S[i] == S0[j]) 
 { 
j++; 
 } 
 else 
 { 
 continue; 
 } 
 if (range == (j)) 
 break; 
 } 
if (range == (j)) 
{ 
 Console.WriteLine("Строка S0 содержится в строке S"); 
 } 
 else  { 
 Console.WriteLine("Строка S0 не содержится в строке S"); 
} 
{ 
 Console.ReadKey(); 
} 
 } 
} 
} 