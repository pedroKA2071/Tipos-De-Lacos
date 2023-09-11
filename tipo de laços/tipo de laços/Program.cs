using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipo_de_laços
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\r\n  _____   _                          _           _                           \r\n |_   _| (_)  _ __   ___   ___    __| |  ___    | |     __ _   __   ___   ___\r\n   | |   | | | '_ \\ / _ \\ (_-<   / _` | / -_)   | |__  / _` | / _| / _ \\ (_-<\r\n   |_|   |_| | .__/ \\___/ /__/   \\__,_| \\___|   |____| \\__,_| \\__| \\___/ /__/\r\n             |_|                                               )_)           \r\n");
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1- do while\n2- for\n3- switch\n4- array\nescolha a opçao" );
            Console.Write("\n");
            menu = int.Parse( Console.ReadLine() );
            Console.Clear();

            if (menu == 1)
            {
                int contador = 4;

                do
                {
                    Console.WriteLine(" Do While " + contador);
                    contador++;
                } while (contador <= 3);

                // O DO While vai executar a operaçao pelo menos uma vez, mesmo se estiver errado como o caso acima //



            }
            else if (menu == 2)
            {
                for (int contador2 = 0; contador2 <= 100000; contador2++)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(" O Gui é lindo ");
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" O Gui é lindo ");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" O Gui é lindo ");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine(" O Gui é lindo ");
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(" O Gui é lindo ");
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" O Gui é lindo ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(" O Gui é lindo ");
                }
            }
            else if (menu == 3)
            {
                int pedro;
                Console.WriteLine("\n");
                Console.WriteLine("Escolha de 0 a 3");
                Console.WriteLine("\n");

                pedro = int.Parse( Console.ReadLine() );
                
                switch (pedro) 
                {
                    case 0:
                        Console.WriteLine("Voce é viado");
                        break;
                    case 1:
                        Console.WriteLine("EU SOU GAY ");
                        break;
                    case 2:
                        Console.WriteLine("ai BIXAAA");
                        break;
                    case 3:
                        Console.WriteLine("Para de ser baiano");
                        break;
                    default:
                        Console.WriteLine("Colaca Algo valido POHA, EU EM PARA DE SER PAULIN");
                        break;

                }
            }
            Console.WriteLine("Press Enter To Finish");
            Console.ReadKey();
        }
    }
}
