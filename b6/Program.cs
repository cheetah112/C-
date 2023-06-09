using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CGO_ThucHanh1
{
    class SnakeGameNe
    {
        #region parameter
        public Random rand = new Random();
        public ConsoleKeyInfo keypress = new ConsoleKeyInfo();
        int score, headX, headY, fruitX, fruitY, nTail, fruitPoint;
        int topScore = 0;
        int[] TailX = new int[100];
        int[] TailY = new int[100];
        const int height = 20;
        const int width = 60;
        const int panel = 10;
        bool gameOver, reset, isprinted, horizontal, vertical;
        string dir, pre_dir;
        #endregion

        void ShowBanner()
        {
            Console.SetWindowSize(width, height + panel);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false; 
            Console.WriteLine("===SNAKE GAME===");
            Console.WriteLine("Press any key to play");
            Console.WriteLine("Tips: - Press P key to PAUSE game");
            Console.WriteLine("      - Press R key to RESET game");
            Console.WriteLine("      - Press Q key to QUIT game");

            keypress = Console.ReadKey(true);
            if (keypress.Key == ConsoleKey.Q){
                Console.Clear();
                Environment.Exit(0);
            }
            Console.Clear();
        }
        
        //Cài đặt thông số ban đầu
        void Setup()
        {
            dir = "RIGHT"; pre_dir = "";  
            score = 0; nTail = 0;
            gameOver = reset = isprinted = false;
            headX = width/2; 
            headY = height/2; 
            randonQua();
        }
        
        void randonQua() {
            fruitX = rand.Next(1, width - 1);
            fruitY = rand.Next(1, height - 1);
            fruitPoint = rand.Next(1,4);
        }

        //Cập nhật màn hình
        void Update() { 
            while(!gameOver)
            {
                CheckInput();
                Logic();
                Console.WriteLine("Press P key to PAUSE game"); 
                Console.WriteLine("Press Q key to QUIT game"); 
                Render();
                if (reset) break;

                if(score <= 5) Thread.Sleep(60);
                else if(score <= 10) Thread.Sleep(40);
                else if(score <=20) Thread.Sleep(30);
                else Thread.Sleep(20);

            }
            if (gameOver) Lose();
        }


        void CheckInput() {
            while (Console.KeyAvailable)
            {

                keypress = Console.ReadKey(true);
                pre_dir = dir;
                switch (keypress.Key)
                {
                    case ConsoleKey.Q: Environment.Exit(0); break;
                    case ConsoleKey.P: dir = "STOP"; break; 
                    case ConsoleKey.LeftArrow: dir="LEFT"; break;
                    case ConsoleKey.RightArrow: dir = "RIGHT"; break;
                    case ConsoleKey.UpArrow: dir="UP"; break;
                    case ConsoleKey.DownArrow: dir="DOWN"; break;
                }
            }
        
        }

        void Logic() {
            int preX = TailX[0], preY = TailY[0];
            int tempX, tempY;

            if(dir != "STOP")
            {
                TailX[0] = headX; TailY[0] = headY;

                for(int i=1; i< nTail; i++)
                {
                    tempX = TailX[i]; tempY = TailY[i];
                    TailX[i] = preX; TailY[i] = preY;
                    preX = tempX; preY = tempY;
                }
            }
            switch (dir)
            {
                case "RIGHT": headX++; break;
                case "LEFT": headX--; break;
                case "DOWN": headY++; break;
                case "UP": headY--; break;
                case "STOP":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Render();
                            Console.WriteLine("Game pause!");
                            Console.WriteLine("- Press P key to RESUME game");
                            Console.WriteLine("- Press R key to RESET game");
                            Console.WriteLine("- Press Q key to QUIT game");

                            keypress = Console.ReadKey(true);
                            if (keypress.Key == ConsoleKey.Q)
                                Environment.Exit(0);
                            if(keypress.Key == ConsoleKey.R)
                            {
                                reset = true; break; 
                            }
                            if (keypress.Key == ConsoleKey.P)
                                Console.Clear();
                                break;  
                        }
                    }
                    dir = pre_dir; break;
            }

            if (headX <= 0 || headX >= width - 1 ||
                headY <= 0 || headY >= height - 1) gameOver = true;
            else gameOver = false;
            if(headX == fruitX && headY == fruitY)
            {
                score += fruitPoint; 
                if(fruitPoint == 1) nTail++;
                else nTail += 2;
                randonQua();
            }

            if (((dir == "LEFT" && pre_dir != "UP") && (dir == "LEFT" && pre_dir != "DOWN")) ||
                ((dir == "RIGHT" && pre_dir != "UP") && (dir == "RIGHT" && pre_dir != "DOWN")))
                horizontal = true;
            else horizontal = false;

            if (((dir == "UP" && pre_dir != "LEFT") && (dir == "UP" && pre_dir != "RIGHT")) ||
                ((dir == "DOWN" && pre_dir != "LEFT") && (dir == "DOWN" && pre_dir != "RIGHT")))
                vertical = true;
            else vertical = false;

            for(int i=1; i < nTail; i++)
            {
                if(headX == TailX[i] && headY == TailY[i])
                {
                    if (horizontal || vertical) gameOver = false;
                    else gameOver = true;
                }
                if (fruitX == TailX[i] && fruitY == TailY[i])
                    randonQua();
            }
        }

        void Render() {
            Console.SetCursorPosition(0, 0);
            for(int i=0; i< height; i++)
            {
                for(int j=0; j< width; j++)
                {
                    if (i == 0 || i == height - 1)
                        Console.Write("-");
                    else if(j==0 || j == width - 1)
                        Console.Write("|");
                    else if (j == fruitX && i == fruitY)
                        {
                            switch(fruitPoint) {
                                case 1: Console.Write("1"); break;
                                case 2: Console.Write("2"); break;
                                case 3: Console.Write("3"); break;
                                default : Console.Write("$"); break;
                            }
                        }
                    else if( j == headX  && i == headY)
                        Console.Write("e");
                    else
                    {
                        isprinted = false;
                        for(int k=0; k < nTail; k++)
                        {
                            if(TailX[k]== j && TailY[k] == i)
                            {
                                Console.Write("~");
                                isprinted = true;
                            }
                        }
                        if (!isprinted) Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your score: "+ score);  
            Console.WriteLine("Top score: " + topScore);       
        }
        void Lose() {
            Console.Clear();
            if(score > topScore) topScore = score;
            Console.WriteLine("YOU DIED");
            Console.WriteLine("YOUR SCORE: " + score);
            Console.WriteLine("TOP SCORE : " + topScore);
            Console.WriteLine("      - Press R key to RESET game");
            Console.WriteLine("      - Press Q key to QUIT game");

            while (true) { 
                keypress = Console.ReadKey(true);
                if (keypress.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                if (keypress.Key == ConsoleKey.R)
                    reset = true; break;
            }
        }

        static void Main(string[] args)
        {
            SnakeGameNe snakegame = new SnakeGameNe();
            snakegame.ShowBanner();
            while (true)
            {
                snakegame.Setup();
                snakegame.Update();
                Console.Clear();
            }
        }
    }
}
