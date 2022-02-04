using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CASINO_RICK_AND_ROLL
{
    class AnimationForWheel
    {
        //this page is used for getting an animation in the game spin the wheel
        //this page is also used for storing the spin the wheel help command
        public void STW_help()
        { 
            Console.Clear();
            Console.WriteLine("Bet money on a color and if the '<==' icon lands on your colour");
            Console.WriteLine("you win. The wining amount gets multiplied by your earing amount");
            Console.WriteLine("which you upgrade in the store.");
            Console.WriteLine("Press enter to return...");
            Console.ReadLine();
            
        }
        public void Animation_Red() 
        {
            Random rnd = new Random();
            for (int i = rnd.Next(5, 8); i > 0; i--)
            {
                int time = 428;


                Console.Clear();//Frame 1

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red; //red should be on the bot row 4. 9 frames is needed
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame2

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame3

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame4

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame5
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame6
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");

                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame7
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//filler Frame

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame8

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();
            }


            Thread.Sleep(2000);

            Console.Clear();//Frame9

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");           
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");           
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");      
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");          
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################] <==");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void Animation_Green()
        {
            Random rnd = new Random();
            for (int i = rnd.Next(5, 8); i > 0; i--)
            {
                int time = 428;


                Console.Clear();//Frame 1

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red; //red should be on the bot row 4. 9 frames is needed
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame2

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame3

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame4

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame5
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame6
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");

                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame7
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//filler Frame

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame8

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);
            }

            Console.Clear();//Frame 1

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Red; //red should be on the bot row 4. 9 frames is needed
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################] <==");
            Console.WriteLine("[#######################]");

            Thread.Sleep(2000);

            Console.Clear();//Frame2

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################] <==");
            Console.WriteLine("[#######################]");

            Thread.Sleep(2000);

            Console.Clear();//Frame3

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################] <==");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");

            Thread.Sleep(2000);

            Console.Clear();//Frame4

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################] <==");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Gray;

        }
        public void Animation_Blue()
        {
            Random rnd = new Random();
            for (int i = rnd.Next(5, 8); i > 0; i--)
            {
                int time = 428;


                Console.Clear();//Frame 1

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red; //red should be on the bot row 4. 9 frames is needed
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame2

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame3

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame4

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame5
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame6
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");

                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame7
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//filler Frame

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################] <==");
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);

                Console.Clear();//Frame8

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[#######################]");


                Console.WriteLine("[#######################]");
                Console.WriteLine("[#######################] <==");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[#######################]");

                Thread.Sleep(time);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Red; //red should be on the bot row 4. 9 frames is needed
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################] <==");
            Console.WriteLine("[#######################]");

            Thread.Sleep(2000);

            Console.Clear();//Frame2

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################] <==");
            Console.WriteLine("[#######################]");

            Thread.Sleep(2000);

            Console.Clear();//Frame3

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################] <==");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");

            Thread.Sleep(2000);

            Console.Clear();//Frame4

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################] <==");
            Console.WriteLine("[#######################]");

            Thread.Sleep(2000);

            Console.Clear();//Frame5
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################] <==");
            Console.WriteLine("[#######################]");

            Thread.Sleep(2000);

            Console.Clear();//Frame6
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");

            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");


            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################] <==");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");

            Thread.Sleep(2000);

            Console.Clear();//Frame7
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[#######################]");
            Console.WriteLine("[#######################] <==");
            Console.WriteLine("[#######################]");

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Clear();
        }
    }
    
}
