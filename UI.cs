using System;
using System.Threading;
using static SimonGame.Board;
using static SimonGame.Game;


namespace SimonGame
{
    public class UI
    {

        public void Title()
        {
            Console.WriteLine(@"
 .----------------.  .----------------.  .----------------.  .----------------.  .-----------------.      
| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |      
| |    _______   | || |     _____    | || | ____    ____ | || |     ____     | || | ____  _____  | |      
| |   /  ___  |  | || |    |_   _|   | || ||_   \  /   _|| || |   .'    `.   | || ||_   \|_   _| | |      
| |  |  (__ \_|  | || |      | |     | || |  |   \/   |  | || |  /  .--.  \  | || |  |   \ | |   | |      
| |   '.___`-.   | || |      | |     | || |  | |\  /| |  | || |  | |    | |  | || |  | |\ \| |   | |      
| |  |`\____) |  | || |     _| |_    | || | _| |_\/_| |_ | || |  \  `--'  /  | || | _| |_\   |_  | |      
| |  |_______.'  | || |    |_____|   | || ||_____||_____|| || |   `.____.'   | || ||_____|\____| | |      
| |              | || |              | || |              | || |              | || |              | |      
| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |      
 '----------------'  '----------------'  '----------------'  '----------------'  '----------------'       
        .----------------.  .----------------.  .----------------.  .----------------.                    
       | .--------------. || .--------------. || .--------------. || .--------------. |                   
       | |    _______   | || |      __      | || |  ____  ____  | || |    _______   | |                   
       | |   /  ___  |  | || |     /  \     | || | |_  _||_  _| | || |   /  ___  |  | |                   
       | |  |  (__ \_|  | || |    / /\ \    | || |   \ \  / /   | || |  |  (__ \_|  | |                   
       | |   '.___`-.   | || |   / ____ \   | || |    \ \/ /    | || |   '.___`-.   | |                   
       | |  |`\____) |  | || | _/ /    \ \_ | || |    _|  |_    | || |  |`\____) |  | |                   
       | |  |_______.'  | || ||____|  |____|| || |   |______|   | || |  |_______.'  | |                   
       | |              | || |              | || |              | || |              | |                   
       | '--------------' || '--------------' || '--------------' || '--------------' |                   
        '----------------'  '----------------'  '----------------'  '----------------'                    
");

        }

        public void Exit()
        {
            Console.WriteLine(@"
                                                                                  
 \_/ _       |_   _.     _    _.     o _|_  _|_ |_   _    _   _. ._ _   _         
  | (_) |_|  | | (_| \/ (/_  (_| |_| |  |_   |_ | | (/_  (_| (_| | | | (/_  o o o 
                               |                          _|                      
");
        }

        public void GameOver()
        {
            Console.WriteLine(@"
 +-+-+-+-+-+ +-+-+-+ +-+-+-+-+ +-+ +-+ +-+
 |S|O|R|R|Y| |Y|O|U| |L|O|S|T| |!| |!| |!|
 +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ +-+ +-+ ");


        }

        public void ClearAll()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine();
            Console.WriteLine();
            var left = Console.CursorLeft;
            var top = Console.CursorTop;
            Draw(boardMap[default]);
            Console.SetCursorPosition(left, top);
        }

        public void DrawMap()
        {
            foreach (ArrowInput v in Arrows)
            {
                ClearAll();
                Draw(boardMap[(int)v]);
                Thread.Sleep(150);
                ClearAll();
                Draw(boardMap[default]);
                TimeSpan.FromMilliseconds(100);
            }
            ClearAll();
            Draw(boardMap[default]);
        }
        public void StartSeq()
        {

            Title();
            Thread.Sleep(3000);
            Console.Clear();

            Console.CursorVisible = false;
            ClearAll();
            Draw(boardMap[default]);
        }

        public void Draw(string @str)
        {
            var left = Console.CursorLeft;
            var top = Console.CursorTop;
            for (var i = 0; i < str.Length; i++)
            {
                var c = str[i];
                if (c is '\n')
                {
                    Console.SetCursorPosition(left, ++top);
                }
                else
                {
                    Console.Write(c);
                }


            }
        }
    }
}
