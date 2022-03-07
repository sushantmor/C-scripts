using System;
/*
 * Author:
 * Sushant Mor
 * this program will print first letter of first name and last name respectively
 */

namespace name_starshape_github
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            Console.WriteLine("Enter your First Name:");
            string fname = Console.ReadLine();

            string firstname = fname.Substring(0, 1);

            Console.WriteLine("Enter your Last Name:");
            string lname = Console.ReadLine();

            string lastname = lname.Substring(0, 1);

            char ffn = char.Parse(firstname);

            char lln = char.Parse(lastname);

            while (ffn == 'a' || lln == 'a' || ffn == 'A' || lln == 'A')
            {
                for (row = 0; row <= 7; row++)
                {
                    for (column = 0; column <= 7; column++)
                    {
                        if (((column == 1 || column == 5) && row != 0) ||
                             ((row == 0 || row == 3) && (column > 1 && column < 5)))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;

            }

            while (ffn == 'b' || lln == 'b' || ffn == 'B' || lln == 'B')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (column == 1 || ((row == 0 || row == 3 || row == 6) && (column < 5 && column > 1)) || (column == 5 && (row != 0 && row != 3 && row != 6)))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'c' || lln == 'c' || ffn == 'C' || lln == 'C')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if ((column == 1 && (row != 0 && row != 6)) || ((row == 0 || row == 6) && (column > 1 && column < 5)) || (column == 5 && (row == 1 || row == 5)))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'd' || lln == 'd' || ffn == 'D' || lln == 'D')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 5)) || (column == 5 && row != 0 && row != 6))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'e' || lln == 'e' || ffn == 'E' || lln == 'E')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 6)) || (row == 3 && column > 1 && column < 5))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'f' || lln == 'f' || ffn == 'F' || lln == 'F')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (column == 1 || (row == 0 && column > 1 && column < 6) || (row == 3 && column > 1 && column < 5))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'g' || lln == 'g' || ffn == 'G' || lln == 'G')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if ((column == 1 && row != 0 && row != 6) || ((row == 0 || row == 6) && column > 1 && column < 5) || (row == 3 && column > 2 && column < 6) || (column == 5 && row != 0 && row != 2 && row != 6))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'h' || lln == 'h' || ffn == 'H' || lln == 'H')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if ((column == 1 || column == 5) || (row == 3 && column > 1 && column < 6))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'i' || lln == 'i' || ffn == 'I' || lln == 'I')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (column == 3 || (row == 0 && column > 0 && column < 6) || (row == 6 && column > 0 && column < 6))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'j' || lln == 'j' || ffn == 'J' || lln == 'J')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if ((column == 4 && row != 6) || (row == 0 && column > 2 && column < 6) || (row == 6 && column == 3) || (row == 5 && column == 2))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'k' || lln == 'k' || ffn == 'K' || lln == 'K')
            {
                int j = 5, i = 0;
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (column == 1 || ((row == column + 1) && column != 0))
                            Console.Write("*");

                        else if (row == i && column == j)
                        {
                            Console.Write("*");
                            i = i + 1;
                            j = j - 1;
                        }
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'l' || lln == 'l' || ffn == 'L' || lln == 'L')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (column == 1 || (row == 6 && column != 0 && column < 6))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'm' || lln == 'm' || ffn == 'M' || lln == 'M')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (column == 1 || column == 5 || (row == 2 && (column == 2 || column == 4)) || (row == 3 && column == 3))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'n' || lln == 'n' || ffn == 'N' || lln == 'N')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (column == 1 || column == 5 || (row == column && column != 0 && column != 6))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'o' || lln == 'o' || ffn == 'O' || lln == 'O')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (((column == 1 || column == 5) && row != 0 && row != 6) || ((row == 0 || row == 6) && column > 1 && column < 5))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'p' || lln == 'p' || ffn == 'P' || lln == 'P')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (column == 1 || ((row == 0 || row == 3) && column > 0 && column < 5) || ((column == 5 || column == 1) && (row == 1 || row == 2)))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'q' || lln == 'q' || ffn == 'Q' || lln == 'Q')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if ((column == 1 && row != 0 && row != 6) || (row == 0 && column > 1 && column < 5) || (column == 5 && row != 0 && row != 5) || (row == 6 && column > 1 && column < 4) || (column == row - 1 && row > 3))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
            }

            while (ffn == 'r' || lln == 'r' || ffn == 'R' || lln == 'R')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (column == 1 || ((row == 0 || row == 3) && column > 1 && column < 5) || (column == 5 && row != 0 && row < 3) || (column == row - 1 && row > 2))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
            }

            while (ffn == 's' || lln == 's' || ffn == 'S' || lln == 'S')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (((row == 0 || row == 3 || row == 6) && column > 1 && column < 5) || (column == 1 && (row == 1 || row == 2 || row == 6)) || (column == 5 && (row == 0 || row == 4 || row == 5)))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 't' || lln == 't' || ffn == 'T' || lln == 'T')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (column == 3 || (row == 0 && column > 0 && column < 6))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'u' || lln == 'u' || ffn == 'U' || lln == 'U')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (((column == 1 || column == 5) && row != 6) || (row == 6 && column > 1 && column < 5))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'v' || lln == 'v' || ffn == 'V' || lln == 'V')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (((column == 1 || column == 5) && row < 5) || (row == 6 && column == 3) || (row == 5 && (column == 2 || column == 4)))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'w' || lln == 'w' || ffn == 'W' || lln == 'W')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (((column == 1 || column == 5) && row < 6) || ((row == 5 || row == 4) && column == 3) || (row == 6 && (column == 2 || column == 4)))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'x' || lln == 'x' || ffn == 'X' || lln == 'X')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (((column == 1 || column == 5) && (row > 4 || row < 2)) || row == column && column > 0 && column < 6 || (column == 2 && row == 4) || (column == 4 && row == 2))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'y' || lln == 'y' || ffn == 'Y' || lln == 'Y')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (((column == 1 || column == 5) && row < 2) || row == column && column > 0 && column < 4 || (column == 4 && row == 2) || ((column == 3) && row > 3))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

            while (ffn == 'z' || lln == 'z' || ffn == 'Z' || lln == 'Z')
            {
                for (row = 0; row <= 6; row++)
                {
                    for (column = 0; column <= 6; column++)
                    {
                        if (((row == 0 || row == 6) && column >= 0 && column <= 6) || row + column == 6)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                break;
            }

        }
    }
}
