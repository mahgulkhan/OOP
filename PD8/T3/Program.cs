using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("_________________________________________________________________________________________________________");
            Console.WriteLine("$$$$$$$$    $$            $$          $$$$$     $      $$$      $$       $$         $$$$$     $$      $$ ");
            Console.WriteLine("$$     $$   $$           $$$$      $$      $$   $    $$         $$      $ $$      $$      $$  $$    $$   ");
            Console.WriteLine("$$     $$   $$          $$  $$    $$            $  $$           $$     $$  $     $$           $$  $$     ");
            Console.WriteLine("$$$$$$$$$   $$         $$    $    $$            $$$ $$          $$    $$   $$    $$           $$$$$$     ");
            Console.WriteLine("$$      $$  $$         $$$$$$$$    $        $   $    $$         $$    $$$$$$$$   $$       $$  $$    $$   ");
            Console.WriteLine("$$      $$  $$        $$      $$   $$      $$   $      $$  $$   $$   $$      $$   $$     $$   $$     $$  ");
            Console.WriteLine("$$$$$$$$    $$$$$$$$ $$        $$     $$$$$     $       $$   $$$    $$        $$    $$$$$     $$      $$$");
            Console.WriteLine("_________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;

            Deck deck = new Deck();
            deck.Shuffle();

            BlackjackHand bjh_player = new BlackjackHand();
            BlackjackHand dealer = new BlackjackHand();

            bjh_player.addaCard(deck.DealCard());
            bjh_player.addaCard(deck.DealCard()); //pllayer aur dealer dono k pass 2 cards hain per person

            dealer.addaCard(deck.DealCard());
            dealer.addaCard(deck.DealCard());

            Console.WriteLine("Your cards are:");
            bjh_player.showHand();
            Console.WriteLine("");

            Console.WriteLine("Total Count: " + bjh_player.getBlackjackValue());

            Console.WriteLine("The Dealer has these cards:");
            dealer.showHand(false);
            Console.WriteLine("");

            while (true)
            {
                Console.Write("Enter 'H' for Hit or 'S' for Stand: ");
                string choice = Console.ReadLine();

                if (choice == "H")
                {
                    Card newCard = deck.DealCard();
                    Console.Write("You drew: " + newCard.toString());

                    Console.WriteLine("");
                    bjh_player.addaCard(newCard);

                    Console.WriteLine("Your cards are :");
                    bjh_player.showHand();
                    Console.WriteLine("");

                    Console.WriteLine("Total are: " + bjh_player.getBlackjackValue());

                    if (bjh_player.getBlackjackValue() > 21)
                    {
                        Console.WriteLine("You have been busted! Dealer wins T_T.");
                        return;
                    }
                }
                else if (choice == "S")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input.Please enter 'H' or 'S'");
                }
            }
            Console.WriteLine("Dealer has revealed the hand:");
            dealer.showHand();

            while (dealer.getBlackjackValue() <17)
            {
                Card newCard = deck.DealCard();
                Console.WriteLine("Dealer has drawn: " + newCard.toString());
                dealer.addaCard(newCard);
                Console.WriteLine("");
            }

            Console.WriteLine("Dealer's final hand  has the folowing cards:");
            dealer.showHand();

            Console.WriteLine("Dealer's Total Score is : " + dealer.getBlackjackValue());

            int playerscore = bjh_player.getBlackjackValue();
            int dealerscore = dealer.getBlackjackValue();

            if(dealerscore> 21 ||playerscore > dealerscore)
            {
                Console.WriteLine("Congratulations!! You Won ( UWU )");
            }

            else if(playerscore == dealerscore)
            {
                Console.WriteLine("OOPS, it's a tie T_T");
            }
            else
            {
                Console.WriteLine("Dealer has won! You LOSE T_T");
            }
        }
    }
}
