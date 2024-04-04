using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoaAffine
{
    internal class Program
    {
        static public int stringtoint(char s)
        {
            switch (s)
            {
                case 'A': 
                    return 0;
                case 'B':
                    return 1;
                case 'C':
                    return 2;
                case 'D':
                    return 3;
                case 'E':
                    return 4;
                case 'F':
                    return 5;
                case 'G':
                    return 6;
                case 'H':
                    return 7;
                case 'I':
                    return 8;
                case 'J':
                    return 9;
                case 'K':
                    return 10;
                case 'L':
                    return 11;
                case 'M':
                    return 12;
                case 'N':
                    return 13;
                case 'O':
                    return 14;
                case 'P': 
                    return 15;
                case 'Q':
                    return 16;
                case 'R':
                    return 17;
                case 'S':
                    return 18;
                case 'T':
                    return 19;
                case 'U':
                    return 20;
                case 'V':
                    return 21;
                case 'W':
                    return 22;
                case 'X':
                    return 23;
                case 'Y':
                    return 24;
                case 'Z':
                    return 25;
                default: return 26;
            }
        }
        static public char inttostring(int i)
        {
            switch (i)
            {
                case 0:
                    return 'A';
                case 1:
                    return 'B';
                case 2:
                    return 'C';
                case 3:
                    return 'D';
                case 4:
                    return 'E';
                case 5:
                    return 'F';
                case 6:
                    return 'G';
                case 7:
                    return 'H';
                case 8:
                    return 'I';
                case 9:
                    return 'J';
                case 10:
                    return 'K';
                case 11:
                    return 'L';
                case 12:
                    return 'M';
                case 13:
                    return 'N';
                case 14:
                    return 'O';
                case 15:
                    return 'P';
                case 16:
                    return 'Q';
                case 17:
                    return 'R';
                case 18:
                    return 'S';
                case 19:
                    return 'T';
                case 20:
                    return 'U';
                case 21:
                    return 'V';
                case 22:
                    return 'W';
                case 23:
                    return 'X';
                case 24:
                    return 'Y';
                case 25:
                    return 'Z';
                default: return '0';
            }
        }

        static int ucln(int a)
        {
            int b = 26;
            while (a*b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else b = b % a;
            }
            return a + b;
        }

        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Affine Cipher");
            do
            {
                Console.Write("a: ");
                a = Convert.ToInt32(Console.ReadLine());
                if (ucln(a) != 1)
                {
                    Console.WriteLine("Wrong a, GCD(a,26) must equal to 1 ");

                }
            } while (ucln(a) != 1);
            Console.Write("b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter string you want to encryption:");
            string A = Console.ReadLine();
            string B = "";
            for(int i = 0; i < A.Length; i++)
            {
                B += inttostring((a*stringtoint(A[i])+b)%26); 
            }
            Console.WriteLine(B);
            Console.ReadKey();
        }
    }
}
