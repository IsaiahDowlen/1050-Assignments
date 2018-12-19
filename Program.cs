namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                System.Console.WriteLine("Almost Chess");
                string[][] board = new string[8][];
                for (int i = 0; i < 8; i++)
                {
                    System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
                    board[i] = new string[8];
                    for (int j = 0; j < 8; j++)
                    {
                        board[i][j] = "  ";
                        if (i <= 1 || i >= 6)
                        {
                            board[i][j] = "O ";
                        }
                        System.Console.Write("| " + board[i][j]);
                    }
                    System.Console.WriteLine("|");
                }
                System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
                System.Console.WriteLine(" ");
                int cordx = 0;
                int cordy = 0;
                int destx = 0;
                int desty = 0;
                while (cordx <= 7 && cordx >= 0 && cordy <= 7 && cordy >= 0 && destx <= 7 && destx >= 0 && desty <= 7 && desty >= 0)
                {
                    System.Console.WriteLine("Enter your coordinates");
                    System.Console.WriteLine("Enter 0-7");
                    System.Console.WriteLine();
                    System.Console.Write("X-Coordinate  :   ");
                    cordx = int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine();
                    System.Console.Write("Y-Coordinate  :   ");
                    cordy = int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine();
                    System.Console.Write("X-Destination:   ");
                    destx = int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine();
                    System.Console.Write("Y-Destination:   ");
                    desty = int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine();
                    System.Console.Clear();
                    if (cordx <= 7 && cordx >= 0 && cordy <= 7 && cordy >= 0 && destx <= 7 && destx >= 0 && desty <= 7 && desty >= 0)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
                            board[i] = new string[8];
                            for (int j = 0; j < 8; j++)
                            {
                                board[i][j] = "  ";
                                if (i <= 1 || i >= 6)
                                {
                                    board[i][j] = "O ";
                                }
                                board[cordx][cordy] = "  ";
                                board[destx][desty] = "O ";
                                System.Console.Write("| " + board[i][j]);
                            }
                            System.Console.WriteLine("|");
                        }
                        System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
                    }
                }
                System.Console.ReadKey();
            }
        }
    }
}
