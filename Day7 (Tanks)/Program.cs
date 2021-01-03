using System;
using MyClassLib.WordOfTank;

namespace Day7__Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank[] USSR = new Tank[5] { new Tank("103"), new Tank("216"), new Tank("514"), new Tank("725"), new Tank("007") };
            Tank[] Reich = new Tank[5] { new Tank("453"), new Tank("867"), new Tank("646"), new Tank("373"), new Tank("013") };
            var winner = new bool[5];
            for (int i =0; i< 5; i++)
            {
                winner[i] = USSR[i] * Reich[i];
            }
            foreach(var el in winner)
            {
                Console.WriteLine(el);
            }
        }
    }
}
