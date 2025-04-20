﻿using System;
using T2.BL;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        do
        {
            Console.WriteLine("Enter 1 to play the game.");
            Console.WriteLine("Enter 2 to exit the game.");
            option = int.Parse(Console.ReadLine());
            Console.Clear();
        } while (option != 1 && option != 2);

        if (option == 1)
        {
            bool gameRunning = true;
            int score = 0;  
            Deck obj = new Deck();

            obj.shuffle(); 
            Card card1 = obj.dealCard();  

            while (gameRunning)
            {
                int remain_check = obj.CardsLeft();
                Card card2 = obj.dealCard();

                Console.WriteLine("");
                Console.WriteLine(card1.toString());
                Console.WriteLine("");
                Console.WriteLine("********* Remaining cards = " + remain_check);
                Console.WriteLine("Enter 1 if the next card is higher.");
                Console.WriteLine("Enter 2 if the next card is lower.");

                int card_check = int.Parse(Console.ReadLine());
                Console.Clear();

                if (card_check == 1) 
                {
                    if (card2.getValue() > card1.getValue())
                    {
                        score++;
                        card1 = card2;
                    }
                    else
                    {
                        gameRunning = false;
                        Console.WriteLine("SORRY YOU LOSE! PRESS ANY KEY TO CONTINUE.");
                        Console.WriteLine("The card was = " + card2.toString());
                        Console.WriteLine("Your Score is : " + score);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                if (card_check == 2) 
                {
                    if (card2.getValue() < card1.getValue())
                    {
                        score++;
                        card1 = card2;
                    }
                    else
                    {
                        gameRunning = false;
                        Console.WriteLine("SORRY YOU LOSE! PRESS ANY KEY TO CONTINUE.");
                        Console.WriteLine("The Card was = " + card2.toString());
                        Console.WriteLine("You Score is : " + score);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                if (obj.CardsLeft() == 0 && card2 == null)
                {
                    gameRunning = false;
                    Console.WriteLine("Congrats you have scored maximum.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
        }
    }
}