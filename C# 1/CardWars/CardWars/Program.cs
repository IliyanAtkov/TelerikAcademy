using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


class Program
{
    static void Main(string[] args)
    {
        long n = int.Parse(Console.ReadLine());
        string firstPlayerCard = "";
        string secondPlayerCard = "";
        BigInteger playerOneGamesWon = 0;
        BigInteger playerTwoGamesWon = 0;
        BigInteger playerOnePoints = 0;
        BigInteger playerTwoPoints = 0;
        long drawnZcardFirst = 0;
        long drawnYcardFirst = 0;
        long drawnZcardSecond = 0;
        long drawnYcardSecond = 0;
        bool xcardByPlayerOne = false;
        bool xcardByPlayerTwo = false;
        
        

        for (int i = 0; i < n; i++)
        {

            drawnZcardFirst = 0;
            drawnYcardFirst = 0;
            drawnZcardSecond = 0;
            drawnYcardSecond = 0;


            for (int f = 1; f <= 3; f++)
            {
                firstPlayerCard = Console.ReadLine();
                switch (firstPlayerCard)
                {
                    case "A":
                        playerOnePoints += 1;
                        break;
                    case "K":
                        playerOnePoints += 13;
                        break;
                    case "Q":
                        playerOnePoints += 12;
                        break;
                    case "J":
                        playerOnePoints += 11;
                        break;
                    case "Z":
                        if (drawnZcardFirst == 0)
                        {
                            playerOnePoints *= 2;
                            drawnZcardFirst++;
                        }
                        else if (drawnZcardFirst == 1)
                        {
                            playerOnePoints *= 4;
                            drawnZcardFirst++;
                        }
                        else if (drawnZcardFirst == 2)
                        {
                            playerOnePoints *= 8;
                            drawnZcardFirst++;
                        }

                        break;

                    case "Y":
                        if (drawnYcardFirst == 0)
                        {
                            playerOnePoints -= 200;
                            drawnYcardFirst++;
                        }
                        else if (drawnYcardFirst == 1)
                        {
                            playerOnePoints -= 400;
                            drawnYcardFirst++;
                        }
                        else if (drawnYcardFirst == 2)
                        {
                            playerOnePoints -= 600;
                            drawnYcardFirst++;
                        }
                        break;
                    case "X":
                        xcardByPlayerOne = true;
                        break;
                    case "2":
                        playerOnePoints += 10;
                        break;
                    case "3":
                        playerOnePoints += 9;
                        break;
                    case "4":
                        playerOnePoints += 8;
                        break;
                    case "5":
                        playerOnePoints += 7;
                        break;
                    case "6":
                        playerOnePoints += 6;
                        break;
                    case "7":
                        playerOnePoints += 5;
                        break;
                    case "8":
                        playerOnePoints += 4;
                        break;
                    case "9":
                        playerOnePoints += 3;
                        break;
                    case "10":
                        playerOnePoints += 2;
                        break;
                }

            }
            for (int s = 1; s <= 3; s++)
            {
                secondPlayerCard = Console.ReadLine();

                switch (secondPlayerCard)
                {
                    case "A":
                        playerTwoPoints += 1;
                        break;
                    case "K":
                        playerTwoPoints += 13;
                        break;
                    case "Q":
                        playerTwoPoints += 12;
                        break;
                    case "J":
                        playerTwoPoints += 11;
                        break;
                    case "Z":
                        if (drawnZcardSecond == 0)
                        {
                            playerTwoPoints *= 2;
                            drawnZcardSecond++;
                        }
                        else if (drawnZcardSecond == 1)
                        {
                            playerTwoPoints *= 4;
                            drawnZcardSecond++;
                        }
                        else if (drawnZcardSecond == 2)
                        {
                            playerTwoPoints *= 8;
                            drawnZcardSecond++;
                        }

                        break;

                    case "Y":
                        if (drawnYcardSecond == 0)
                        {
                            playerTwoPoints -= 200;
                            drawnYcardSecond++;
                        }
                        else if (drawnYcardSecond == 1)
                        {
                            playerTwoPoints -= 400;
                            drawnYcardSecond++;
                        }
                        else if (drawnYcardSecond == 2)
                        {
                            playerTwoPoints -= 600;
                            drawnYcardSecond++;
                        }
                        break;
                    case "X":
                        xcardByPlayerTwo = true;
                        break;
                    case "2":
                        playerTwoPoints += 10;
                        break;
                    case "3":
                        playerTwoPoints += 9;
                        break;
                    case "4":
                        playerTwoPoints += 8;
                        break;
                    case "5":
                        playerTwoPoints += 7;
                        break;
                    case "6":
                        playerTwoPoints += 6;
                        break;
                    case "7":
                        playerTwoPoints += 5;
                        break;
                    case "8":
                        playerTwoPoints += 4;
                        break;
                    case "9":
                        playerTwoPoints += 3;
                        break;
                    case "10":
                        playerTwoPoints += 2;
                        break;
                }

            }
            if (xcardByPlayerOne == true && xcardByPlayerTwo == true)
            {
                playerOnePoints += 50;
                playerTwoPoints += 50;

            }
            else if (xcardByPlayerOne == true && xcardByPlayerTwo == false)
            {
                playerOneGamesWon += 1;
            }
            else if (xcardByPlayerOne == false && xcardByPlayerTwo == true)
            {
                playerTwoGamesWon += 1;
            }
            if (playerOnePoints > playerTwoPoints)
            {
                playerOneGamesWon += 1;
            }
            else if (playerOnePoints < playerTwoPoints)
            {
                playerTwoGamesWon += 1;
            }
            else if (playerOnePoints == playerTwoPoints)
            {
                playerOneGamesWon += 0;
                playerTwoGamesWon += 0;
                
            }
         


        }
        if (xcardByPlayerOne)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
            
        }
        else if (xcardByPlayerTwo)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");
            
        }



        else if (playerOnePoints > playerTwoPoints)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", playerOnePoints);
            Console.WriteLine("Games won: {0}", playerOneGamesWon);
        }
        else if (playerOnePoints < playerTwoPoints)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", playerTwoPoints);
            Console.WriteLine("Games won: {0}", playerTwoGamesWon);
            
        }
        else if (playerOnePoints == playerTwoPoints)
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", playerOnePoints);
            
        }


    }
    }

