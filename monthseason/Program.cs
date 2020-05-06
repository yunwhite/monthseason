﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이번 달은 몇 월인가요: ");
            int input = int.Parse(Regex.Replace(Console.ReadLine(), @"\D", ""));
            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다");
                    break;
                default:
                    Console.WriteLine("대체 어느 행성에 살고 계십니까?");
                    break;
            }
        }
    }
}
