using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class Program
{
    static long cases(StringBuilder sb)
    {
        string input = sb.ToString();
        long score = 0;
        if (input == "CHU")
        {
            score += 0;
            
        }
        else if (input == "TEL")
        {
            score += 1;
        }
        else if (input == "OFT")
        {
            score += 2;
        }
        else if (input == "IVA")
        {
            score += 3;
        }
        else if (input == "EMY")
        {
            score += 4;
        }
        else if (input == "VNB")
        {
            score += 5;
        }
        else if (input == "POQ")
        {
            score += 6;
        }
        else if (input == "ERI")
        {
            score += 7;
        }
        else if (input == "CAD")
        {
            score += 8;
        }
        else if (input == "K-A")
        {
            score += 9;
        }
        else if (input == "IIA")
        {
            score += 10;
        }
        else if (input == "YLO")
        {
            score += 11;
        }
        else if (input == "PLA")
        {
            score += 12;
        }
        return score;
    }
    static void Main()
    {
        string input = Console.ReadLine();
        long localScore = 0;
        char[] charr = input.ToCharArray();
        StringBuilder sb = new StringBuilder();
        if (charr.Length == 3)
        {
            
            for (int i = 0; i < 3; i++)
            {
                
                sb.Append(charr[i]);
               
            }
            localScore = cases(sb);
            sb.Remove(0, sb.Length);
            Console.WriteLine(localScore);
        }
        if (charr.Length == 6)
        {
            long insideScore = 0;
            for (int i = 0; i < 3; i++)
            {
                sb.Append(charr[i]);
               
            }
            localScore = cases(sb);
            insideScore += localScore * 13;
            sb.Remove(0, sb.Length);

            for (int i = 3; i < 6; i++)
            {
                sb.Append(charr[i]);
               
            }
            localScore = cases(sb);
            insideScore += localScore;
            sb.Remove(0, sb.Length);
            Console.WriteLine(insideScore);
        }
        if (charr.Length == 9)
        {
            long insideScore = 0;
            for (int i = 0; i < 3; i++)
            {
                sb.Append(charr[i]);
               
            }
            
             localScore = cases(sb);
             insideScore += localScore * 13 * 13;
             sb.Remove(0, sb.Length);
            for (int i = 3; i < 6; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13;
            sb.Remove(0, sb.Length);
            for (int i = 6; i < 9; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore;
            sb.Remove(0, sb.Length);
            Console.WriteLine(insideScore);
        }
        if (charr.Length == 12)
        {
            BigInteger insideScore = 0;
            for (int i = 0; i < 3; i++)
            {
                sb.Append(charr[i]);

            }

            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 3; i < 6; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 6; i < 9; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13;
            sb.Remove(0, sb.Length);
            for (int i = 9; i < 12; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore;
            sb.Remove(0, sb.Length);
            Console.WriteLine(insideScore);
        }
        if (charr.Length == 15)
        {
            BigInteger insideScore = 0;
            for (int i = 0; i < 3; i++)
            {
                sb.Append(charr[i]);

            }

            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 3; i < 6; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 6; i < 9; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 9; i < 12; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13;
            sb.Remove(0, sb.Length);
            for (int i = 12; i < 15; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore;
            sb.Remove(0, sb.Length);
            Console.WriteLine(insideScore);
        }
        if (charr.Length == 18)
        {
            BigInteger insideScore = 0;
            for (int i = 0; i < 3; i++)
            {
                sb.Append(charr[i]);

            }

            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 3; i < 6; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 6; i < 9; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 9; i < 12; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 12; i < 15; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13;
            sb.Remove(0, sb.Length);
            for (int i = 15; i < 18; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore;
            sb.Remove(0, sb.Length);
            Console.WriteLine(insideScore);
        }
        if (charr.Length == 21)
        {
            BigInteger insideScore = 0;
            for (int i = 0; i < 3; i++)
            {
                sb.Append(charr[i]);

            }

            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 3; i < 6; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 6; i < 9; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 9; i < 12; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 12; i < 15; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 15; i < 18; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13;
            sb.Remove(0, sb.Length);
            for (int i = 18; i < 21; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore;
            sb.Remove(0, sb.Length);
            Console.WriteLine(insideScore);
        }
        if (charr.Length == 24)
        {
            BigInteger insideScore = 0;
            for (int i = 0; i < 3; i++)
            {
                sb.Append(charr[i]);

            }

            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 3; i < 6; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 6; i < 9; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 9; i < 12; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 12; i < 15; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 15; i < 18; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 18; i < 21; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13;
            sb.Remove(0, sb.Length);
            for (int i = 21; i < 24; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore;
            sb.Remove(0, sb.Length);
            Console.WriteLine(insideScore);
        }
        if (charr.Length == 27)
        {
            BigInteger insideScore = 0;
            for (int i = 0; i < 3; i++)
            {
                sb.Append(charr[i]);

            }

            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13 * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 3; i < 6; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 6; i < 9; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 9; i < 12; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 12; i < 15; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 15; i < 18; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 18; i < 21; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13 * 13;
            sb.Remove(0, sb.Length);
            for (int i = 21; i < 24; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore * 13;
            sb.Remove(0, sb.Length);
            for (int i = 24; i < 27; i++)
            {
                sb.Append(charr[i]);
            }
            localScore = cases(sb);
            insideScore += localScore;
            sb.Remove(0, sb.Length);
            Console.WriteLine(insideScore);
        }
        if (input.Length == 0)
        {
            Console.WriteLine("0");
        }
        

    }
}
