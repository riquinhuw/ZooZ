using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZooZ.Repositorios
{
    class RepositorioEgg
    {
        public RepositorioEgg() { }
        public static Thread t = new Thread(LogomarcaEasterEgg);
        public void EasterEgg()
        {

            string resposta;
            Console.WriteLine("Wow você chegou aqui, são {0} e você já conseguiu achar isso!\nCHOOSE YOUR DESTINE:", DateTime.Now.ToString("h:mm:ss tt"));
            resposta = Console.ReadLine();

            if (resposta == "tetris")
            {
                t.Start();
                Tetris();
            }
            else { if (resposta == "mario") { t.Start(); Mario(); } }

        }


        #region EasterEgg
        
        static public void LogomarcaEasterEgg()
        {
            int i = 0;
            int x = 0;
            string fila1, fila2, fila3, fila4, fila5, fila6;

            fila1 = (@" __________   ____ ______");
            fila2 = (@"|___  / __ \ / __ \___  /");
            fila3 = (@"   / / |  | | |  | | / / ");
            fila4 = (@"  / /| |  | | |  | |/ /  ");
            fila5 = (@" / /_| |__| | |__| / /__ ");
            fila6 = (@"/_____\____/ \____/_____|");

            for (; i <= 50; i++)
            {



                Console.Clear();
                for (x = 0; x <= 24; x++)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(fila1[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(fila2[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(fila3[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(fila4[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(fila5[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(fila6[x]);
                }
                Console.Write("\n");
                Thread.Sleep(200);
                //parte 2


                Console.Clear();
                for (x = 0; x <= 24; x++)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(fila1[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(fila2[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(fila3[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(fila4[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(fila5[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(fila6[x]);
                }
                Console.Write("\n");
                Thread.Sleep(200);

                //parte 3

                Console.Clear();
                for (x = 0; x <= 24; x++)
                {

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(fila1[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(fila2[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(fila3[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(fila4[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(fila5[x]);
                }
                Console.Write("\n");
                for (x = 0; x <= 24; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(fila6[x]);
                }
                Console.Write("\n");
                Thread.Sleep(200);





            }
            Console.SetCursorPosition(0, 7);

            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(@" _____"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"___ "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"  ___ "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"_____"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\n");
            //Console.Write(@"|__  /"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@" _ \"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@" /   \"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"__  /"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\n");
            //Console.Write(@"  / / "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"| | |"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@" | | "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"|/ / "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\n");
            //Console.Write(@" / /| "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"|_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@" |_| "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"/ /_ "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\n");
            //Console.Write(@"/____\"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"___/"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@" \___/"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"____\"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("\n");
            //Console.Write("\n\n");
            //Console.ResetColor();
            //Thread.Sleep(250);
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(@" _____"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"___ "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"  ___ "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"_____"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n");
            //Console.Write(@"|__  /"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@" _ \"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@" /   \"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"__  /"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n");
            //Console.Write(@"  / / "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"| | |"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@" | | "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"|/ / "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n");
            //Console.Write(@" / /| "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"|_| |"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@" |_| "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"/ /_ "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n");
            //Console.Write(@"/____\"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"___/"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@" \___/"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"____\"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n");
            //Console.Write("\n\n");
            //Console.ResetColor();
            //Thread.Sleep(250);



            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(@" ________ "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"  ___ _____"); Console.Write("\n"); Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(@"|__  / _ \"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@" / _ \__  /"); Console.Write("\n"); Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(@"  / / | | "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"| | | |/ / "); Console.Write("\n"); Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(@" / /| |_| "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"| |_| / /_ "); Console.Write("\n"); Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(@"/____\___/"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@" \___/____|"); Console.Write("\n"); Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write("\n\n");
            //Console.ResetColor();
            //Thread.Sleep(250);
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(@" ________ "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"  ___ _____"); Console.Write("\n"); Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(@"|__  / _ \"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@" / _ \__  /"); Console.Write("\n"); Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(@"  / / | | "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"| | | |/ / "); Console.Write("\n"); Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(@" / /| |_| "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"| |_| / /_ "); Console.Write("\n"); Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(@"/____\___/"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@" \___/____|"); Console.Write("\n"); Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write("\n\n");
            //Console.ResetColor();
            //Thread.Sleep(250);
        }
        #endregion

        #region nada
        //easter egg
        public static void Tetris()
        {
            Console.Beep(658, 125);
            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Console.Beep(990, 250);
            Console.Beep(880, 500);
            Console.Beep(880, 250);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 750);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(250);
            Console.Beep(1188, 500);
            Console.Beep(1408, 250);
            Console.Beep(1760, 500);
            Console.Beep(1584, 250);
            Console.Beep(1408, 250);
            Console.Beep(1320, 750);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(500);
            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Console.Beep(990, 250);
            Console.Beep(880, 500);
            Console.Beep(880, 250);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 750);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(250);
            Console.Beep(1188, 500);
            Console.Beep(1408, 250);
            Console.Beep(1760, 500);
            Console.Beep(1584, 250);
            Console.Beep(1408, 250);
            Console.Beep(1320, 750);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(500);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 1000);
            Console.Beep(440, 1000);
            Console.Beep(419, 1000);
            Console.Beep(495, 1000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 500);
            Console.Beep(660, 500);
            Console.Beep(880, 1000);
            Console.Beep(838, 2000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 1000);
            Console.Beep(440, 1000);
            Console.Beep(419, 1000);
            Console.Beep(495, 1000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 500);
            Console.Beep(660, 500);
            Console.Beep(880, 1000);
            Console.Beep(838, 2000);
        }
        public static void Mario()
        {
            Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
        }
        #endregion
    }
}
