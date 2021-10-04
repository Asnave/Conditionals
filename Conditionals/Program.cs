using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static int score = 0;
        static int lives = 3;
        static bool oneUpGained = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");

            ShowHUD();
            score = score + 1000000;
            // if player didnt gain a 1Up......
            if(oneUpGained == false)
            {
                //..... then check for 1,000,000 points (1Up award)
                if (score >= 100000)
                {
                    lives = lives + 1; // award a 1Up
                    oneUpGained = true;
                }
            }

            ShowHUD();

            Console.ReadKey(true);
        }
       static void ShowHUD()

        {
           
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Lives: " + lives);
        }


    }
}
