﻿using System;

namespace cs07_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs07_PASKAITA!");
            #region TEORIJA - panašu, kad bus kartojimas, ne teorija
            #endregion

            PineTree();
            //Classwork1();
            //Classwork2();
            //Classwork3();
            //Classwork4();
            //Classwork5();
            //Classwork6();
        }

        public static void PineTree()
        {
            // Nusipieškime eglutę iš žvaigždučių, nes anksčiau praleidau ¯\_(ツ)_/¯ 
            Console.WriteLine("Vartotojau kokio dydžio bus tavo eglutė? (eilučių)");
            int starSize = int.Parse(Console.ReadLine());

            for (int x = 1; x <= starSize*2+1; x+=2)        // <-- nenaudokite šito sprendimo kaip pavyzdžio
            {                                               //     bet paaiškinu kodėl *2+1, nes x žingsnis yra +2 (todtodėl starsize*2)
                int space = ((starSize*2+1) - x) / 2 + 1;   //     +1, nes, nes skaičiuojame nuo 1
                Console.WriteLine(" ");                     //     esu įsitikinęs, kad google galima rasti žmoniškesnį sprendimą
                for (int j = 0; j < space; j++)
                {
                    Console.Write("❄️");
                }
                for (int i = 0; i < x; i++)
                {
                    Console.Write("⭐️");
                }
                for (int j = 0; j < space; j++)
                {
                    Console.Write("❄️");
                }
                //if (x % 2 == 0) Console.Write("");
            }
            // Nežinau kažkokia kreiva eglutė gaunasi.
        }

        public static void Classwork1()
        {

        }

        public static void Classwork2()
        {

        }

        public static void Classwork3()
        {

        }

        public static void Classwork4()
        {

        }

        public static void Classwork5()
        {

        }

        public static void Classwork6()
        {

        }

    }
}

