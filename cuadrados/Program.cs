using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SUCESIÓN_DE_N_CUADROS
{
    class Program
    {
        static void Main(string[] args)
        {
            int CAN, F, C, T, FI, FF, CI, CF;
            string linea;
            Console.Write("DIGITE UN NÚMERO MÁX=10: "); linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            FI = 2; FF = 22;
            CI = 2; CF = 77;
            for (T = 1; T <= CAN; T++)
            {
                for (F = CI; F <= CF; F++)
                {
                    Console.SetCursorPosition(F, FF); Console.Write("X");
                    Console.SetCursorPosition(F, FI); Console.Write("X");
                }
                for (C = FI; C <= FF; C++)
                {
                    Console.SetCursorPosition(CI, C); Console.Write("X");
                    Console.SetCursorPosition(CF, C); Console.Write("X");
                }
                FI = FI + 1; FF = FF - 1;
                CI = CI + 1; CF = CF - 1;
            }
            Console.WriteLine();
            Console.SetCursorPosition(25, 24); Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}
