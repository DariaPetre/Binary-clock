using System.Diagnostics.CodeAnalysis;

namespace Binary_clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime Timp = DateTime.Now;

            string stringTimp = Timp.ToString("HH:mm:ss");
            Console.WriteLine(stringTimp);
            stringTimp = stringTimp.Replace(":", "");

            int intTimp = int.Parse(stringTimp);

            Console.WriteLine("H H M M S S");

            int[,] clock = new int[4, 6];
            int col = 5;
           
            for (int i = 0; i < 6; i++)
            {
                int cif = intTimp % 10;
                intTimp /= 10;

                string binaryCif = Convert.ToString(cif, 2);
                int binary = Convert.ToInt32(binaryCif);
                int row = 3;
                do
                {
                    clock[row, col] = binary % 10;
                    binary /= 10;
                    row--;
                } while (binary > 0);

                 col--;
            }

            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i == 0 && j % 2 == 0)
                        Console.Write(" ");
                    else if(i == 1 && j == 0)
                        Console.Write(" ");
                    else if (clock[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("O");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("O");
                    }
                    Console.Write(" ");
                }
              Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}