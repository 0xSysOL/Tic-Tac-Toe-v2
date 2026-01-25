using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Program.Logic
{
    internal class SoundFunctions
    {

        static public void ClickSound()
        {

            short frequency = 250;
            short duration = 100;
            Console.Beep(frequency, duration);


        }
        static public void PlayDrawSound()
        {
            int drawFrequency = 330;

            Console.Beep(drawFrequency, 150);


            Thread.Sleep(80);


            Console.Beep(drawFrequency, 150);


            Thread.Sleep(100);

            Console.Beep(293, 800);

        }
        static public void PlayWinSound()
        {
            int[] melody = { 523, 659, 784, 1046 };
            int[] durations = { 100, 100, 100, 400 };

            for (int i = 0; i < melody.Length; i++)
            {
                Console.Beep(melody[i], durations[i]);
                if (i < melody.Length - 1) Thread.Sleep(20);
            }

            Thread.Sleep(50);

            for (int j = 0; j < 3; j++)
            {
                Console.Beep(1046, 100);
                Thread.Sleep(30);
            }
        }
        static public void PlayRestartSound()
        {
            Console.Beep(440, 50);
            Console.Beep(880, 100);
        }
    }
}
