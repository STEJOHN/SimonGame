using System;
using System.Collections.Generic;
using System.Threading;
using static SimonGame.Board;



namespace SimonGame
{

    public class Game
    {

        public Random Random = new Random();
        private int Score;
        public static readonly List<ArrowInput> Arrows = new List<ArrowInput>();


        public void Simon()

        {

            UI gui = new UI();
            gui.StartSeq();
            while (true)
            {
                Thread.Sleep(150);
                Arrows.Add((ArrowInput)Random.Next(1, 5));
                gui.DrawMap();
                for (var i = 0; i < Arrows.Count; i++)
                {

                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (Arrows[i] != ArrowInput.Up)
                                goto GameOver;
                            break;

                        case ConsoleKey.RightArrow:
                            if (Arrows[i] != ArrowInput.Right)
                                goto GameOver;
                            break;

                        case ConsoleKey.DownArrow:
                            if (Arrows[i] != ArrowInput.Down)
                                goto GameOver;
                            break;

                        case ConsoleKey.LeftArrow:
                            if (Arrows[i] != ArrowInput.Left)
                                goto GameOver;
                            break;

                        case ConsoleKey.Escape:
                            Console.Clear();
                            gui.Exit();
                            return;
                        default: continue;
                    }
                    EndSwitch(i);
                }
            }



            void EndSwitch(int i)
            {
                Score++;
                gui.ClearAll();
                gui.Draw(boardMap[(int)Arrows[i]]);
                Thread.Sleep(150);
                gui.ClearAll();
                gui.Draw(boardMap[default]);
            }
        GameOver:
            Console.Clear();
            gui.GameOver();
            Console.WriteLine("YOUR SCORE :" + Score);
        }

    }
}
