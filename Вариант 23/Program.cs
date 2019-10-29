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
             string str = Console.ReadLine();
             int otvet = 0;
            int znak = 1;
            for (int i = 0; i < str.Length; i++)
             {
            switch (str[i])
            {
            case '-':
               znak = -1;
            break;
              case '+':
              znak = 1;
              break;
            case '0':
            case '1':
             case '2':
             case '3':
             case '4':
             case '5':
            case '6':
             case '7':
             case '8':
             case '9':
             otvet = otvet + int.Parse(Convert.ToString(str[i])) * znak;
               break;
             default:
               Console.WriteLine("Неверный код");
               break;
             }
              }
                 Console.WriteLine(otvet);
             Console.ReadKey();
            }
             }
            }
           


