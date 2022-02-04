using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASINO_RICK_AND_ROLL
{
    class Program
    {
    //important values
    //The users money starts at 1000$ when you open the game.
    float account_balance = 1000;
    string Username;
    float BJ_earning = 2;
    float STW_earning = 2;
    //rnd makes it possible for me to generate random numbers
    Random rnd = new Random();

        static void Main(string[] args)
        {
            
            Program P = new Program();
            AnimationForWheel A = new AnimationForWheel();
            //welcomes the user to the casino
            Console.WriteLine("Welcome to Casino Rick and Roll");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            //askes for the users name

            Console.WriteLine("To make this experience more personal would you please enter your name?");
            P.Username = Console.ReadLine();
            Console.Clear();
            P.Menu(); //calls the Menu method

        }

        public void Menu() 
        {
            Console.Clear();
            //Prints your name and account balance 
            Console.WriteLine("Hello " + Username + ". Your account balance is $" + account_balance);

            //gives you the game libary and item-shop 
            Console.WriteLine("Press 1 to play Blackjack");
            Console.WriteLine("press 2 to play spin the wheel \n" +
                "press 3 to enter the shop");

            //Inputs so you can get directed to the right method
            String Menu_Input = Console.ReadLine();

            int Int_Menu_input = Convert.ToInt32(Menu_Input);

            //Calls the right method
            switch (Int_Menu_input) 
            {
                case 1:
                    BlackJackV2();
                    break;

                case 2:
                    spin_the_wheel();
                    break;

                case 3:
                    shop();
                    break;

                default:
                    Menu();
                    break;
            }
        }

        public void shop() 
        {
            Console.Clear();
            //tells the user it's account balance and that how the store works
            Console.WriteLine($"Welcome to the store!" + 
                "\nYour account balance is $" + account_balance +
                "\nSee the avalable upgrades marked in green down below \n");
            //checks if the user has already bought the upgrade if the user has bought the upgrade it gets marked in white, otherwise it gets maked in green
            if(BJ_earning == 2) //run this if the user hasnt bought any other upgrades
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("BlackJack 3x Earnings $600");
                Console.ResetColor();
            }
            else //run this if the player has already bought the upgrade
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("BlackJack 3x Earnings $600");
                Console.ResetColor();
            }

            if (BJ_earning == 3) //checks if the player has bought the 3x upgrade
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("BlackJack 4x Earnings $1200");
                Console.ResetColor();
            }
            else if (BJ_earning == 4) //run this if the 4x upgrade is bought
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("BlackJack 4x Earnings $1200");
                Console.ResetColor();
            }
            else //run this if the 3x upgrade isn't bought yet
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("BlackJack 4x Earnings $1200");
                Console.ResetColor();
            }
            Console.WriteLine("\n" +
                "========================================================================================================================\n");
            //upgrades for STW

            if (STW_earning == 2) //run this if the user hasnt bought any other upgrades
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Spin The Wheel 3x Earnings $600");
                Console.ResetColor();
            }
            else //run this if the player has already bought the upgrade
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Spin The Wheel 3x Earnings $600");
                Console.ResetColor();
            }

            if (STW_earning == 3) //checks if the player has bought the 3x upgrade
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Spin The Wheel 4x Earnings $1200");
                Console.ResetColor();
            }
            else if (STW_earning == 4) //run this if the 4x upgrade is bought
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Spin The Wheel 4x Earnings $1200");
                Console.ResetColor();
            }
            else //run this if the 3x upgrade isn't bought yet
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Spin The Wheel 4x Earnings $1200");
                Console.ResetColor();
            }

            //buy menu where the user can select the upgrade it want't to buy

            Console.WriteLine("To buy avalable upgrades press:");
            switch (BJ_earning)
            {
                case 2:
                    Console.WriteLine("Press 1 to upgrade to BlackJack x3");
                    break;
                case 3:
                    Console.WriteLine("Press 1 to upgrade to BlackJack x4");
                    break;
            }

            Console.WriteLine("To buy avalable upgrades press:");
            switch (BJ_earning)
            {
                case 2:
                    Console.WriteLine("Press 2 to upgrade to Spin The Wheel x3 \n \n Press 3 to enter the menu");
                    break;
                case 3:
                Console.WriteLine("Press 2 to upgrade to Spin The Wheel x4 \n \n Press 3 to enter the menu");
                    break;
            }
            //makes so the user only can input the right options
            string[] valid = new string[] { "1", "2", "3" };
            string ShopInput = Console.ReadLine();
            if (valid.Any(ShopInput.Contains))
            {
                //makes so the program doesn't crash when inputing a false command
                //converts the user choise into a int so it can used in a switch 
                int shopinput = Convert.ToInt32(ShopInput);

                switch(shopinput)
                {
                    
                    case 1:
                    //checks what upgrade is unlocked and makes so you upgrade the right upgrade
                    switch (BJ_earning)
                    {
                        case 2:
                        if (account_balance >= 600)
                        {
                            //removes 600 form the account balance
                            account_balance -= 600;
                            //upgrades the earning  amount
                            BJ_earning += 1;
                            //reloads the page
                            shop();
                        }
                        else //if user doesnt have enought money to buy the upgrade.
                        {
                            Console.WriteLine("you don't have enough money to buy this upgrade");
                            shop();
                        }
                            break;

                        case 3:
                        if (account_balance >= 1200)
                        {
                            //removes 600 form the account balance
                            account_balance -= 1200;
                            //upgrades the earning  amount
                            BJ_earning += 1;
                            //reloads the page
                            shop();
                        }
                        else //if user doesnt have enought money to buy the upgrade.
                        {
                            Console.WriteLine("you don't have enough money to buy this upgrade");
                            shop();
                        }
                            break;

                        default:
                                Console.WriteLine("you've maxed out this upgrade \n" +
                                    "Press enter to continue...");
                                Console.ReadLine();
                                shop();
                            break;
                    }
                    break;
                    case 2:
                        //checks what upgrade is unlocked and makes so you upgrade the right upgrade
                        switch (STW_earning)
                        {
                            case 2:
                                if (account_balance >= 600)
                                {
                                    //removes 600 form the account balance
                                    account_balance -= 600;
                                    //upgrades the earning  amount
                                    STW_earning += 1;
                                    //reloads the page
                                    shop();
                                }
                                else //if user doesnt have enought money to buy the upgrade.
                                {
                                    Console.WriteLine("you don't have enough money to buy this upgrade");
                                    shop();
                                }
                                break;

                            case 3:
                                if (account_balance >= 1200)
                                {
                                    //removes 600 form the account balance
                                    account_balance -= 1200;
                                    //upgrades the earning  amount
                                    STW_earning += 1;
                                    //reloads the page
                                    shop();
                                }
                                else //if user doesnt have enought money to buy the upgrade.
                                {
                                    Console.WriteLine("you don't have enough money to buy this upgrade");
                                    shop();
                                }
                                break;

                            default:
                                Console.WriteLine("you've maxed out this upgrade \n" +
                                    "Press enter to continue...");
                                Console.ReadLine();
                                shop();
                                break;
                        }
                        break;
                    case 3:
                        Menu();
                        break;
                }
            }
            else
            {
                //if the user inputs a false input instead of crashing the shop reloads
                shop();
            }


        }

        public void spin_the_wheel() //Code for spin the wheel
        {
            Program P = new Program();

            AnimationForWheel STW = new AnimationForWheel();

            Console.Clear();
            Console.WriteLine("Would you like a tutorial before we start? If so write help");
            Console.WriteLine("Welcome to Spin the wheel " + Username + ". You have a total of $" + account_balance + " to bet"); //welcomes the user and tells them their account balance
            Console.WriteLine("Your earnings are " + STW_earning + "x");
            //input for bet amount
            String STW_Bet = Console.ReadLine();
            if (STW_Bet == "help")
            {
                STW.STW_help();
            }
            Console.Clear();

            int Int_STW_Bet = Convert.ToInt32(STW_Bet);
            if (Int_STW_Bet == 0) //checks so that the bet is larger than 0
            {
                Console.Clear();
                Console.WriteLine("No, silly. You can't play with $0. Get back when you have some real spending power!");
                Console.WriteLine("press enter to return to the menu");
                Menu();
            }
            if (Int_STW_Bet <= account_balance)//makes sure the user have more money than their bet
            {
                Console.WriteLine("Your bet is " + Int_STW_Bet + "$");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }
            else //returns the user to the menu
            {
                Console.WriteLine("You can't bet more than you own");
                Console.WriteLine("Press enter to return to the menu...");
                Console.ReadLine();
                Menu();
            }
            Console.Clear();

            //The main game
            Retry:
            //gives the user a the choise to bet
            Console.WriteLine("Type 'R' to bet on red");
            Console.WriteLine("Type 'G' to bet on green");
            Console.WriteLine("Type 'B' to bet on blue");

            //Checks if their choise is valid

            string[] Valid = new string[] {"r", "g", "b", "R", "G", "B" };
            string[] red = new string[] { "r", "R" };
            string[] green = new string[] { "g", "G" };
            string[] blue = new string[] { "b", "B" };

            

            string STW_choise = Console.ReadLine();
            Console.Clear();

            //checks if user input is valid
            if (Valid.Any(STW_choise.Contains))
            {
                
                //makes a random number from 1 to 3
                int STW1to3 = rnd.Next(1, 4);
                switch (STW1to3)
                {
                    case 1:
                        STW.Animation_Red();
                        break;

                    case 2:
                        STW.Animation_Green();
                        break;

                    case 3:
                        STW.Animation_Blue();
                        break;
                }
                // checks if the user was right
                if (red.Any(STW_choise.Contains)) 
                {
                    //if user guessed right
                    if (STW1to3 == 1)
                    {
                        default_:
                        //calculates the users winnings
                        float STW_winnings = Int_STW_Bet * P.STW_earning;
                        account_balance += STW_winnings;
                        // tells the user that the user has won
                        Console.Clear();
                        Console.WriteLine("You won $" + STW_winnings + "!");
                        Console.WriteLine("Your account balance is $" + account_balance);
                        //askes the user if it wants to play again
                        Console.WriteLine("Press 1 to play again or press 2 to return to menu");
                        int ContinueOrNot = Convert.ToInt32(Console.ReadLine());

                        switch (ContinueOrNot) 
                        {
                            case 1:
                                spin_the_wheel();
                                break;
                            case 2:
                                Menu();
                                break;
                            default:
                                goto default_;
                        }

                    }
                    else  //if user was wrong
                    {
                        default_:
                        Console.Clear();
                        switch (STW1to3)
                        {
                            case 1:
                                Console.WriteLine("It landed on red!");
                                break;

                            case 2:
                                Console.WriteLine("It landed on green!");
                                break;

                            case 3:
                                Console.WriteLine("It landed on blue!");
                                break;
                        }
                        Console.WriteLine("You lost -$" + Int_STW_Bet);
                        Console.WriteLine("Press 1 to play again or press 2 to return to menu");
                        int ContinueOrNot = Convert.ToInt32(Console.ReadLine());

                        switch (ContinueOrNot)
                        {
                            case 1:
                                spin_the_wheel();
                                break;
                            case 2:
                                Menu();
                                break;
                            default:
                                goto default_; 
                        }

                    }
                }
                else if (green.Any(STW_choise.Contains)) 
                {
                    //if user guessed right
                    if (STW1to3 == 2)
                    {
                    default_:
                        //calculates the users winnings
                        float STW_winnings = Int_STW_Bet * P.STW_earning;
                        account_balance += STW_winnings;
                        // tells the user that the user has won
                        Console.Clear();
                        Console.WriteLine("You won $" + STW_winnings + "!");
                        Console.WriteLine("Your account balance is $" + account_balance);
                        //askes the user if it wants to play again
                        Console.WriteLine("Press 1 to play again or press 2 to return to menu");
                        int ContinueOrNot = Convert.ToInt32(Console.ReadLine());

                        switch (ContinueOrNot)
                        {
                            case 1:
                                spin_the_wheel();
                                break;
                            case 2:
                                Menu();
                                break;
                            default:
                                goto default_;
                        }

                    }
                    else  //if user was wrong
                    {
                    default_:
                        Console.Clear();
                        switch (STW1to3)
                        {
                            case 1:
                                Console.WriteLine("It landed on red!");
                                break;

                            case 2:
                                Console.WriteLine("It landed on green!");
                                break;

                            case 3:
                                Console.WriteLine("It landed on blue!");
                                break;
                        }
                        Console.WriteLine("You lost -$" + Int_STW_Bet);
                        Console.WriteLine("Press 1 to play again or press 2 to return to menu");
                        int ContinueOrNot = Convert.ToInt32(Console.ReadLine());

                        switch (ContinueOrNot)
                        {
                            case 1:
                                spin_the_wheel();
                                break;
                            case 2:
                                Menu();
                                break;
                            default:
                                goto default_;
                        }

                    }
                }
                else if (blue.Any(STW_choise.Contains))
                {
                    //if user guessed right
                    if (STW1to3 == 3)
                    {
                    default_:
                        //calculates the users winnings
                        float STW_winnings = Int_STW_Bet * P.STW_earning;
                        account_balance += STW_winnings;
                        // tells the user that the user has won
                        Console.Clear();
                        Console.WriteLine("You won $" + STW_winnings + "!");
                        Console.WriteLine("Your account balance is $" + account_balance);
                        //askes the user if it wants to play again
                        Console.WriteLine("Press 1 to play again or press 2 to return to menu");
                        int ContinueOrNot = Convert.ToInt32(Console.ReadLine());

                        switch (ContinueOrNot)
                        {
                            case 1:
                                spin_the_wheel();
                                break;
                            case 2:
                                Menu();
                                break;
                            default:
                                goto default_;
                        }

                    }
                    else  //if user was wrong
                    {
                    default_:
                        Console.Clear();
                        switch (STW1to3)
                        {
                            case 1:
                                Console.WriteLine("It landed on red!");
                                break;

                            case 2:
                                Console.WriteLine("It landed on green!");
                                break;

                            case 3:
                                Console.WriteLine("It landed on blue!");
                                break;
                        }
                        Console.WriteLine("You lost -$" + Int_STW_Bet);
                        Console.WriteLine("Press 1 to play again or press 2 to return to menu");
                        int ContinueOrNot = Convert.ToInt32(Console.ReadLine());

                        switch (ContinueOrNot)
                        {
                            case 1:
                                spin_the_wheel();
                                break;
                            case 2:
                                Menu();
                                break;
                            default:
                                goto default_;
                        }

                    }
                }

            }
            else 
            {
                Console.WriteLine("Invalid input press enter to try again.");
                Console.ReadLine();
                Console.Clear();
                goto Retry;
            }

        }

        public void BlackJack_help() 
        {
            //clears the console
            Console.Clear(); //a how to play this game
            Console.WriteLine("This is like normal blackjack but not quite. The goal is to reach a card value of 21 or be closer than the dealer.");
            Console.WriteLine("A game consists of a maximum 4 rounds 2 of them are mandatory. You can chose if you want to play your deck or grab another card after the second round.");
            Console.WriteLine("The same goes for the dealer. If you win your bet amount gets multiplied by the Earning value which you can upgrade in the shop");
            Console.WriteLine("press enter to play...");
            BlackJack();
        }

        //enum for card types (this is for BJ)
        public enum CardType 
        {
            Clubs,
            Spades,
            Diamonds,
            Hearts,
        };
        //emun for card values (this is for BJ)
        public enum CardValue 
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
        };
        public void BlackJackV2() 
        {
            Console.Clear();
            //player betting amount
            Console.WriteLine("How much would you like to bet " + Username + "?");
            int blackJackBet = Convert.ToInt32(Console.ReadLine());
            //checks for invalid betting amounts
            //asks you if invalid if you want to try again or return to the menu
            if (blackJackBet > account_balance) 
            {
                Console.Clear();
                Console.WriteLine("You can't bet more than is in your bank account \n do you wish to try again press: 1 \n do you wish to return to the menu press: 2");
                int tryAgainOrGoToTheMenu = Convert.ToInt32(Console.ReadLine());
                switch (tryAgainOrGoToTheMenu) 
                {
                    case 1:
                        BlackJackV2();
                        break;
                    case 2:
                        Menu();
                        break;
                }
            }
            //makes so you must bet more than $1
            else if (blackJackBet < 1) 
            {
                Console.Clear();
                Console.WriteLine("you need to bet more than $1 \n do you wish to try again press: 1 \n do you wish to return to the menu press: 2");
                int tryAgainOrGoToTheMenu = Convert.ToInt32(Console.ReadLine());
                switch (tryAgainOrGoToTheMenu)
                {
                    case 1:
                        BlackJackV2();
                        break;
                    case 2:
                        Menu();
                        break;
                }
            }

            //clears the console so the code is clear for the black jack game
            Console.Clear();
            //value for player and dealers hand
            int playerHand = 0;
            int dealerHand = 0;
            bool playerHold = false;
            bool dealerHold = false;
            while (playerHand < 21) 
            {
                //number for card value and card type
                int numberForCardValue = rnd.Next(0, 13);
                int numberForCardType = rnd.Next(0, 4);

                //number for card value and card type for the dealer
                int numberForCardValueDealer = rnd.Next(0, 13);
                int numberForCardTypeDealer = rnd.Next(0, 4);
            //add the card value if the player isn't holding
            if (playerHold == false)
                {
                    switch ((CardValue)numberForCardValue) //adds the value of the card you got into your card value int
                    {
                    case CardValue.Ace:
                        playerHand += 11;
                        break;
                    case CardValue.Two:
                        playerHand += 2;
                        break;
                    case CardValue.Three:
                        playerHand += 3;
                        break;
                    case CardValue.Four:
                        playerHand += 4;
                        break;
                    case CardValue.Five:
                        playerHand += 5;
                        break;
                    case CardValue.Six:
                        playerHand += 6;
                        break;
                    case CardValue.Seven:
                        playerHand += 7;
                        break;
                    case CardValue.Eight:
                        playerHand += 8;
                        break;
                    case CardValue.Nine:
                        playerHand += 9;
                        break;

                    case CardValue.Ten:
                    case CardValue.Jack:
                    case CardValue.Queen:
                    case CardValue.King:
                        playerHand += 10;
                        break;
                    }
                }
                
            //add the card value if dealer isnt holding
            if (dealerHold == false) 
                {
                //adds the card value to the dealer 
                    switch ((CardValue)numberForCardValueDealer)
                    {
                    case CardValue.Ace:
                        dealerHand += 11;
                        break;
                    case CardValue.Two:
                        dealerHand += 2;
                        break;
                    case CardValue.Three:
                        dealerHand += 3;
                        break;
                    case CardValue.Four:
                        dealerHand += 4;
                        break;
                    case CardValue.Five:
                        dealerHand += 5;
                        break;
                    case CardValue.Six:
                        dealerHand += 6;
                        break;
                    case CardValue.Seven:
                        dealerHand += 7;
                        break;
                    case CardValue.Eight:
                        dealerHand += 8;
                        break;
                    case CardValue.Nine:
                        dealerHand += 9;
                        break;

                    case CardValue.Ten:
                    case CardValue.Jack:
                    case CardValue.Queen:
                    case CardValue.King:
                        dealerHand += 10;
                        break;
                    }
                }

                Console.WriteLine("\n" +
                "========================================================================================================================\n");
                //prints out what the user got
                Console.WriteLine("Your hand:\n");
                //adds colours to represent the cards the player got
                switch (numberForCardType)
                {
                    case 0:
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        break;

                    case 2:
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }

                Console.Write((CardValue)numberForCardValue + " of " + ((CardType)numberForCardType));
                Console.ResetColor();
                Console.WriteLine("\n Your hand value: " + playerHand);
                Console.WriteLine("\n" +
                "========================================================================================================================\n");
                Console.WriteLine("Dealers hand:\n");
                //prints out what the dealer got
                //adds colours to represent the cards the dealer got
                switch (numberForCardTypeDealer)
                {
                    case 0:
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        break;

                    case 2:
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }

                Console.Write((CardValue)numberForCardValueDealer + " of " + ((CardType)numberForCardTypeDealer));
                Console.ResetColor();
                Console.WriteLine("\n Dealer hand value: " + dealerHand);
                Console.WriteLine("\n" +
                "========================================================================================================================\n");
                if (dealerHand >= 17) //if dealers hand is 17 or over the dealer should hold
                {
                    dealerHold = !dealerHold;
                }
                else if (dealerHand > 21)
                {
                    Console.WriteLine("Congratulations you won!");
                    //puts the money the user has won into it's bank account
                    account_balance += (BJ_earning * blackJackBet);
                    //asks user if they want to play again
                    Console.WriteLine("your account balance is $" + account_balance + "\n+$" + (BJ_earning * blackJackBet));
                    Console.WriteLine("Do you wish to play again? \n" +
                    "(y/n)");
                    string playAgainOrNo = Console.ReadLine();
                    if (playAgainOrNo == "y")
                    {
                        BlackJackV2();
                    }
                    else
                    {
                        Menu();
                    }
                }


                if (playerHand > 21) 
                {
                    Console.WriteLine("You lost");
                    //removes the earnings from the user
                    account_balance -= blackJackBet;
                    //asks user if they want to play again
                    Console.WriteLine("your account balance is $" + account_balance + "\n -$" + blackJackBet);
                    Console.WriteLine("Do you wish to play again? \n" +
                    "(y/n)");
                    string playAgainOrNo = Console.ReadLine();
                    if (playAgainOrNo == "y")
                    {
                        BlackJackV2();
                    }
                    else 
                    {
                        Menu();
                    }
                }
                //when player is holding the dealer should check if it was closest to 21 and yet under 21
                if (playerHold == true) 
                {
                    if (dealerHand > 21) 
                    {
                        Console.WriteLine("Congratulations you won!");
                        //puts the money the user has won into it's bank account
                        account_balance += (BJ_earning * blackJackBet);
                        //asks user if they want to play again
                        Console.WriteLine("your account balance is $" + account_balance + "\n+$" + (BJ_earning * blackJackBet));
                        Console.WriteLine("Do you wish to play again? \n" +
                        "(y/n)");
                        string playAgainOrNo = Console.ReadLine();
                        if (playAgainOrNo == "y")
                        {
                            BlackJackV2();
                        }
                        else
                        {
                            Menu();
                        }
                    }
                    else if (playerHand < dealerHand) 
                    {
                        Console.WriteLine("You lost");
                        //removes the earnings from the user
                        account_balance -= blackJackBet;
                        //asks user if they want to play again
                        Console.WriteLine("your account balance is $" + account_balance + "\n -$" + blackJackBet);
                        Console.WriteLine("Do you wish to play again? \n" +
                        "(y/n)");
                        string playAgainOrNo = Console.ReadLine();
                        if (playAgainOrNo == "y")
                        {
                            BlackJackV2();
                        }
                        else
                        {
                            Menu();
                        }
                    }
                }
                //if it becomes a tie
                if (dealerHold == true)
                {
                    if (playerHold == true) 
                    {
                        if (playerHand == dealerHand) 
                        {
                            Console.WriteLine("Tie");
                            //asks user if they want to play again
                            Console.WriteLine("your account balance is $" + account_balance);
                            Console.WriteLine("Do you wish to play again? \n" +
                            "(y/n)");
                            string playAgainOrNo = Console.ReadLine();
                            if (playAgainOrNo == "y")
                            {
                                BlackJackV2();
                            }
                            else
                            {
                                Menu();
                            }
                        }
                    }
                }
                //asks the user if it wants to hold. Only ask when the user is not already holding
                if (playerHold == false)
                {
                    Console.WriteLine("Do you wish to stand? \n" +
                        "(y/n)");
                      string playerStand = Console.ReadLine();
                      if (playerStand == "y") 
                      {
                        playerHold = true;
                      }
                }
                //if user is already holding just print out "press enter to continue..." and await an input
                else
                {
                    Console.WriteLine("press enter to continue...");
                    Console.ReadLine();
                }
                

                Console.Clear();
                
            }
            
        }


        //old version of BlackJack (outdated)
        public void BlackJack()
        {
            //clears the console
            Console.Clear();

            //Welcomes the user to the game
            Console.WriteLine("Would you like a tutorial before we start? If so write help");
            Console.WriteLine("Welcome to BlackJack " + Username + ". You have a total of $" + account_balance + " to bet");
            Console.WriteLine("Your earnings are " + BJ_earning + "x");
            Console.WriteLine("How much would you like to bet?");

            //input for bet amount
            String BJ_Bet = Console.ReadLine();
            if (BJ_Bet == "help") 
            {
                BlackJack_help();
            }
            Console.Clear();
            int Int_BJ_Bet = Convert.ToInt32(BJ_Bet);

            //If statment that makes it so you can't bet more than you have in your account
            if (Int_BJ_Bet == 0) 
            {
                Console.Clear();
                Console.WriteLine("No, silly. You can't play with 0$. Get back when you have some real spending power!");
                Console.WriteLine("press enter to return to the menu");
                Menu();
            }
            if (Int_BJ_Bet <= account_balance) 
            {
                Console.WriteLine("Your bet is " + Int_BJ_Bet + "$");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("You can't bet more than you own");
                Console.WriteLine("Press enter to return to the menu...");
                Console.ReadLine();
                Menu();
            }
            Console.Clear();
            
            //starting amount
            int BJpl = 0;
            int BJdl = 0;

            //start io the game
            Console.WriteLine("Bet amount " + Int_BJ_Bet + "$");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dealer: " + BJdl);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Username + ": " + BJpl);
            Console.WriteLine();
            Console.WriteLine("press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            //random cards value 1-10
            int BJplR1 = rnd.Next(1, 11);
            int BJdlR1 = rnd.Next(1, 11);

            int BJplsum1 = BJplR1 + BJpl;
            int BJdlsum1 = BJdlR1 + BJdl;

            Console.WriteLine("Bet amount " + Int_BJ_Bet + "$");
            Console.WriteLine();
            Console.WriteLine("+" + BJdlR1);
            Console.WriteLine("Dealer: " + BJdlsum1);
            Console.WriteLine();
            Console.WriteLine("+" + BJplR1);
            Console.WriteLine(Username + ": " + BJplsum1);
            Console.WriteLine();
            Console.WriteLine("press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            //random cards value 1-10
            int BJplR2 = rnd.Next(1, 11);
            int BJdlR2 = rnd.Next(1, 11);

            int BJplsum2 = BJplR1 + BJpl + BJplR2;
            int BJdlsum2 = BJdlR1 + BJdl + BJdlR2;

            Console.WriteLine("Bet amount " + Int_BJ_Bet + "$");
            Console.WriteLine();
            Console.WriteLine("+" + BJdlR2);
            Console.WriteLine("Dealer: " + BJdlsum2);
            Console.WriteLine();
            Console.WriteLine("+" + BJplR2);
            Console.WriteLine(Username + ": " + BJplsum2);
            Console.WriteLine();
            Console.WriteLine("Do you want to Draw another card? (y/n)");
            string BJ_YesNo = Console.ReadLine();



            if (BJ_YesNo == "y") // Y
            {
                int BJplR3 = rnd.Next(1, 11);
                int BJplsum3 = BJplR1 + BJpl + BJplR2 + BJplR3;
                //if the dealers card value is or under 16 he draws another card 
                if (BJdlsum2 < 17)
                {
                    int BJdlR3 = rnd.Next(1, 11);


                    int BJdlsum3 = BJdlR1 + BJdl + BJdlR2 + BJdlR3;

                    Console.Clear();
                    Console.WriteLine("Bet amount " + Int_BJ_Bet + "$");
                    Console.WriteLine();
                    Console.WriteLine("+" + BJdlR3);
                    Console.WriteLine("Dealer: " + BJdlsum3);
                    Console.WriteLine();
                    Console.WriteLine("+" + BJplR3);
                    Console.WriteLine(Username + ": " + BJplsum3);
                    Console.WriteLine();
                    Console.WriteLine("press enter to continue...");
                    Console.ReadLine();

                    //if player wants to move on to round 4
                    Console.WriteLine("Do you want to Draw another card? (y/n)");
                    String BJ_YesNo2 = Console.ReadLine();

                    //round 4
                    //player draws another card
                    if (BJ_YesNo2 == "y")  //Y Y
                    {
                    int BJplR4 = rnd.Next(1, 11);
                    int BJplsum4 = BJplR4 +BJplR1 + BJpl + BJplR2 + BJplR3;
                        
                        if (BJdlsum3 < 17)  //if dealers cards < 17
                        {
                            int BJdlR4 = rnd.Next(1, 11);
                            int BJdlsum4 = BJdlR4 + BJdlR1 + BJdl + BJdlR2 + BJdlR3;

                            Console.Clear();
                            Console.WriteLine("Bet amount " + Int_BJ_Bet + "$");
                            Console.WriteLine();
                            Console.WriteLine("+" + BJdlR4);
                            Console.WriteLine("Dealer: " + BJdlsum4);
                            Console.WriteLine();
                            Console.WriteLine("+" + BJplR4);
                            Console.WriteLine(Username + ": " + BJplsum4);
                            Console.WriteLine();
                            Console.WriteLine("press enter to continue...");
                            Console.ReadLine();

                            //ending
                            //select a winner
                            if (BJdlsum4 > 21) //if dealer is over 21
                            {
                                if (BJplsum4 > 21) //if both the player and the dealer is over 21 (tie)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Tie! You've won/lost 0$");
                                    Console.WriteLine("Current account balance is " + account_balance);
                                    Console.WriteLine("press 1 to play again");
                                    Console.WriteLine("Press 2 to return to the menu");

                                    string BJ_YesNo3 = Console.ReadLine();
                                    int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                    switch (yesnoBJcontinue)
                                    {
                                        case 1:
                                            BlackJack();
                                            break;
                                        case 2:
                                            Menu();
                                            break;
                                        default:
                                            Console.WriteLine("input error");
                                            break;
                                    }
                                }
                                else//the dealer is over 21 but not the player (win) 
                                {
                                    Console.Clear();
                                    //times your bet by the earning amount
                                    float win_amount = (Int_BJ_Bet * BJ_earning);
                                    Console.WriteLine("You've won " + win_amount + "$");

                                    account_balance += win_amount;

                                    Console.WriteLine("Current account balance is " + account_balance);
                                    Console.WriteLine("press 1 to play again");
                                    Console.WriteLine("Press 2 to return to the menu");

                                    string BJ_YesNo3 = Console.ReadLine();
                                    int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                    switch (yesnoBJcontinue)
                                    {
                                        case 1:
                                            BlackJack();
                                            break;
                                        case 2:
                                            Menu();
                                            break;
                                        default:
                                            Console.WriteLine("input error");
                                            break;
                                    }
                                }
                            }
                            else if (BJplsum4 > 21) //if the player is over 21 (loss)
                            {
                                Console.Clear();
                                Console.WriteLine("You've lost -" + BJ_Bet + "$");

                                account_balance -= Int_BJ_Bet;

                                Console.WriteLine("Current account balance is " + account_balance);
                                Console.WriteLine("press 1 to play again");
                                Console.WriteLine("Press 2 to return to the menu");

                                string BJ_YesNo3 = Console.ReadLine();
                                int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                switch (yesnoBJcontinue)
                                {
                                    case 1:
                                        BlackJack();
                                        break;
                                    case 2:
                                        Menu();
                                        break;
                                    default:
                                        Console.WriteLine("input error");
                                        break;
                                }
                            }
                            if (BJplsum4 > BJdlsum4) //if the player is closer to 21 than the dealer (win)
                            {
                                Console.Clear();
                                //times your bet by the earning amount
                                float win_amount = (Int_BJ_Bet * BJ_earning);
                                Console.WriteLine("You've won " + win_amount + "$");

                                account_balance += win_amount;

                                Console.WriteLine("Current account balance is " + account_balance);
                                Console.WriteLine("press 1 to play again");
                                Console.WriteLine("Press 2 to return to the menu");

                                string BJ_YesNo3 = Console.ReadLine();
                                int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                switch (yesnoBJcontinue)
                                {
                                    case 1:
                                        BlackJack();
                                        break;
                                    case 2:
                                        Menu();
                                        break;
                                    default:
                                        Console.WriteLine("input error");
                                        break;
                                }
                            }
                            else //if the dealer is closer to 21  (loss)
                            {
                                Console.Clear();
                                Console.WriteLine("You've lost -" + BJ_Bet + "$");

                                account_balance -= Int_BJ_Bet;

                                Console.WriteLine("Current account balance is " + account_balance);
                                Console.WriteLine("press 1 to play again");
                                Console.WriteLine("Press 2 to return to the menu");

                                string BJ_YesNo3 = Console.ReadLine();
                                int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                switch (yesnoBJcontinue)
                                {
                                    case 1:
                                        BlackJack();
                                        break;
                                    case 2:
                                        Menu();
                                        break;
                                    default:
                                        Console.WriteLine("input error");
                                        break;
                                }
                            }

                        }
                        else //if dealers cards > 17
                        {
                            Console.Clear();
                            Console.WriteLine("Bet amount " + Int_BJ_Bet + "$");
                            Console.WriteLine();
                            Console.WriteLine("No cards drawn");
                            Console.WriteLine("Dealer: " + BJdlsum3);
                            Console.WriteLine();
                            Console.WriteLine("+" + BJplR4);
                            Console.WriteLine(Username + ": " + BJplsum4);
                            Console.WriteLine();
                            Console.WriteLine("press enter to continue...");
                            Console.ReadLine();

                            //ending
                            //select a winner
                            if (BJdlsum3 > 21) //if dealer is over 21
                            {
                                if (BJplsum4 > 21) //if both the player and the dealer is over 21 (tie)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Tie! You've won/lost 0$");
                                    Console.WriteLine("Current account balance is " + account_balance);
                                    Console.WriteLine("press 1 to play again");
                                    Console.WriteLine("Press 2 to return to the menu");

                                    string BJ_YesNo3 = Console.ReadLine();
                                    int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                    switch (yesnoBJcontinue)
                                    {
                                        case 1:
                                            BlackJack();
                                            break;
                                        case 2:
                                            Menu();
                                            break;
                                        default:
                                            Console.WriteLine("input error");
                                            break;
                                    }
                                }
                                else//the dealer is over 21 but not the player (win) 
                                {
                                    Console.Clear();
                                    //times your bet by the earning amount
                                    float win_amount = (Int_BJ_Bet * BJ_earning);
                                    Console.WriteLine("You've won " + win_amount + "$");

                                    account_balance += win_amount;

                                    Console.WriteLine("Current account balance is " + account_balance);
                                    Console.WriteLine("press 1 to play again");
                                    Console.WriteLine("Press 2 to return to the menu");

                                    string BJ_YesNo3 = Console.ReadLine();
                                    int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                    switch (yesnoBJcontinue)
                                    {
                                        case 1:
                                            BlackJack();
                                            break;
                                        case 2:
                                            Menu();
                                            break;
                                        default:
                                            Console.WriteLine("input error");
                                            break;
                                    }
                                }
                            }
                            else if (BJplsum4 > 21) //if the player is over 21 (loss)
                            {
                                Console.Clear();
                                Console.WriteLine("You've lost -" + BJ_Bet + "$");

                                account_balance -= Int_BJ_Bet;

                                Console.WriteLine("Current account balance is " + account_balance);
                                Console.WriteLine("press 1 to play again");
                                Console.WriteLine("Press 2 to return to the menu");

                                string BJ_YesNo3 = Console.ReadLine();
                                int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                switch (yesnoBJcontinue)
                                {
                                    case 1:
                                        BlackJack();
                                        break;
                                    case 2:
                                        Menu();
                                        break;
                                    default:
                                        Console.WriteLine("input error");
                                        break;
                                }
                            }
                            if (BJplsum4 > BJdlsum3) //if the player is closer to 21 than the dealer (win)
                            {
                                Console.Clear();
                                //times your bet by the earning amount
                                float win_amount = (Int_BJ_Bet * BJ_earning);
                                Console.WriteLine("You've won " + win_amount + "$");

                                account_balance += win_amount;

                                Console.WriteLine("Current account balance is " + account_balance);
                                Console.WriteLine("press 1 to play again");
                                Console.WriteLine("Press 2 to return to the menu");

                                string BJ_YesNo3 = Console.ReadLine();
                                int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                switch (yesnoBJcontinue)
                                {
                                    case 1:
                                        BlackJack();
                                        break;
                                    case 2:
                                        Menu();
                                        break;
                                    default:
                                        Console.WriteLine("input error");
                                        break;
                                }
                            }
                            else //if the dealer is closer to 21  (loss)
                            {
                                Console.Clear();
                                Console.WriteLine("You've lost -" + BJ_Bet + "$");

                                account_balance -= Int_BJ_Bet;

                                Console.WriteLine("Current account balance is " + account_balance);
                                Console.WriteLine("press 1 to play again");
                                Console.WriteLine("Press 2 to return to the menu");

                                string BJ_YesNo3 = Console.ReadLine();
                                int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                switch (yesnoBJcontinue)
                                {
                                    case 1:
                                        BlackJack();
                                        break;
                                    case 2:
                                        Menu();
                                        break;
                                    default:
                                        Console.WriteLine("input error");
                                        break;
                                }
                            }

                        }//end r4 player move


                    }
                    else if (BJ_YesNo2 == "n") // Y N
                    {
                        //if dealers cards < 17
                        if (BJdlsum3 < 17) 
                        {
                            //checks if player > dealer
                            if (BJdlsum3 < BJplsum3)
                            {
                                //checks if player is over 21
                                if (BJplsum3 <= 21) 
                                {
                                    int BJdlR4 = rnd.Next(1, 11);
                                    int BJdlsum4 = BJdlR4 + BJdlR1 + BJdl + BJdlR2 + BJdlR3;

                                    Console.Clear();
                                    Console.WriteLine("Bet amount " + Int_BJ_Bet + "$");
                                    Console.WriteLine();
                                    Console.WriteLine("+" + BJdlR4);
                                    Console.WriteLine("Dealer: " + BJdlsum4);
                                    Console.WriteLine();
                                    Console.WriteLine("+" + BJplR3);
                                    Console.WriteLine(Username + ": " + BJplsum3);
                                    Console.WriteLine();
                                    Console.WriteLine("press enter to continue...");
                                    Console.ReadLine();
                                    //ending
                                    //select a winner
                                    if (BJdlsum4 > 21) //if dealer is over 21
                                    {
                                        if (BJplsum3 > 21) //if both the player and the dealer is over 21 (tie)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Tie! You've won/lost 0$");
                                            Console.WriteLine("Current account balance is " + account_balance);
                                            Console.WriteLine("press 1 to play again");
                                            Console.WriteLine("Press 2 to return to the menu");

                                            string BJ_YesNo3 = Console.ReadLine();
                                            int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                            switch (yesnoBJcontinue)
                                            {
                                                case 1:
                                                    BlackJack();
                                                    break;
                                                case 2:
                                                    Menu();
                                                    break;
                                                default:
                                                    Console.WriteLine("input error");
                                                    break;
                                            }
                                        }
                                        else//the dealer is over 21 but not the player (win) 
                                        {
                                            Console.Clear();
                                            //times your bet by the earning amount
                                            float win_amount = (Int_BJ_Bet * BJ_earning);
                                            Console.WriteLine("You've won " + win_amount + "$");

                                            account_balance += win_amount;

                                            Console.WriteLine("Current account balance is " + account_balance);
                                            Console.WriteLine("press 1 to play again");
                                            Console.WriteLine("Press 2 to return to the menu");

                                            string BJ_YesNo3 = Console.ReadLine();
                                            int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                            switch (yesnoBJcontinue)
                                            {
                                                case 1:
                                                    BlackJack();
                                                    break;
                                                case 2:
                                                    Menu();
                                                    break;
                                                default:
                                                    Console.WriteLine("input error");
                                                    break;
                                            }
                                        }
                                    }
                                    else if (BJplsum3 > 21) //if the player is over 21 (loss)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You've lost -" + BJ_Bet + "$");

                                        account_balance -= Int_BJ_Bet;

                                        Console.WriteLine("Current account balance is " + account_balance);
                                        Console.WriteLine("press 1 to play again");
                                        Console.WriteLine("Press 2 to return to the menu");

                                        string BJ_YesNo3 = Console.ReadLine();
                                        int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                        switch (yesnoBJcontinue)
                                        {
                                            case 1:
                                                BlackJack();
                                                break;
                                            case 2:
                                                Menu();
                                                break;
                                            default:
                                                Console.WriteLine("input error");
                                                break;
                                        }
                                    }
                                    if (BJplsum3 > BJdlsum4) //if the player is closer to 21 than the dealer (win)
                                    {
                                        Console.Clear();
                                        //times your bet by the earning amount
                                        float win_amount = (Int_BJ_Bet * BJ_earning);
                                        Console.WriteLine("You've won " + win_amount + "$");

                                        account_balance += win_amount;

                                        Console.WriteLine("Current account balance is " + account_balance);
                                        Console.WriteLine("press 1 to play again");
                                        Console.WriteLine("Press 2 to return to the menu");

                                        string BJ_YesNo3 = Console.ReadLine();
                                        int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                        switch (yesnoBJcontinue)
                                        {
                                            case 1:
                                                BlackJack();
                                                break;
                                            case 2:
                                                Menu();
                                                break;
                                            default:
                                                Console.WriteLine("input error");
                                                break;
                                        }
                                    }
                                    else //if the dealer is closer to 21  (loss)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You've lost -" + BJ_Bet + "$");

                                        account_balance -= Int_BJ_Bet;

                                        Console.WriteLine("Current account balance is " + account_balance);
                                        Console.WriteLine("press 1 to play again");
                                        Console.WriteLine("Press 2 to return to the menu");

                                        string BJ_YesNo3 = Console.ReadLine();
                                        int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                        switch (yesnoBJcontinue)
                                        {
                                            case 1:
                                                BlackJack();
                                                break;
                                            case 2:
                                                Menu();
                                                break;
                                            default:
                                                Console.WriteLine("input error");
                                                break;
                                        }
                                    }

                                }
                                else //if it's certant that the dealer wins if he's not over 21 in card value 
                                {//ending
                                    Console.Clear();
                                    Console.WriteLine("Bet amount " + Int_BJ_Bet + "$");
                                    Console.WriteLine();
                                    Console.WriteLine("No cards were drawn");
                                    Console.WriteLine("Dealer: " + BJdlsum3);
                                    Console.WriteLine();
                                    Console.WriteLine("No cards were drawn");
                                    Console.WriteLine(Username + ": " + BJplsum3);
                                    Console.WriteLine();
                                    Console.WriteLine("press enter to continue...");
                                    Console.ReadLine();
                                    //select a winner
                                    if (BJdlsum3 > 21) //if dealer is over 21
                                    {
                                        if (BJplsum3 > 21) //if both the player and the dealer is over 21 (tie)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Tie! You've won/lost 0$");
                                            Console.WriteLine("Current account balance is " + account_balance);
                                            Console.WriteLine("press 1 to play again");
                                            Console.WriteLine("Press 2 to return to the menu");

                                            string BJ_YesNo3 = Console.ReadLine();
                                            int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                            switch (yesnoBJcontinue)
                                            {
                                                case 1:
                                                    BlackJack();
                                                    break;
                                                case 2:
                                                    Menu();
                                                    break;
                                                default:
                                                    Console.WriteLine("input error");
                                                    break;
                                            }
                                        }
                                        else//the dealer is over 21 but not the player (win) 
                                        {
                                            Console.Clear();
                                            //times your bet by the earning amount
                                            float win_amount = (Int_BJ_Bet * BJ_earning);
                                            Console.WriteLine("You've won " + win_amount + "$");

                                            account_balance += win_amount;

                                            Console.WriteLine("Current account balance is " + account_balance);
                                            Console.WriteLine("press 1 to play again");
                                            Console.WriteLine("Press 2 to return to the menu");

                                            string BJ_YesNo3 = Console.ReadLine();
                                            int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                            switch (yesnoBJcontinue)
                                            {
                                                case 1:
                                                    BlackJack();
                                                    break;
                                                case 2:
                                                    Menu();
                                                    break;
                                                default:
                                                    Console.WriteLine("input error");
                                                    break;
                                            }
                                        }
                                    }
                                    else if (BJplsum3 > 21) //if the player is over 21 (loss)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You've lost -" + BJ_Bet + "$");

                                        account_balance -= Int_BJ_Bet;

                                        Console.WriteLine("Current account balance is " + account_balance);
                                        Console.WriteLine("press 1 to play again");
                                        Console.WriteLine("Press 2 to return to the menu");

                                        string BJ_YesNo3 = Console.ReadLine();
                                        int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                        switch (yesnoBJcontinue)
                                        {
                                            case 1:
                                                BlackJack();
                                                break;
                                            case 2:
                                                Menu();
                                                break;
                                            default:
                                                Console.WriteLine("input error");
                                                break;
                                        }
                                    }
                                    if (BJplsum3 > BJdlsum3) //if the player is closer to 21 than the dealer (win)
                                    {
                                        Console.Clear();
                                        //times your bet by the earning amount
                                        float win_amount = (Int_BJ_Bet * BJ_earning);
                                        Console.WriteLine("You've won " + win_amount + "$");

                                        account_balance += win_amount;

                                        Console.WriteLine("Current account balance is " + account_balance);
                                        Console.WriteLine("press 1 to play again");
                                        Console.WriteLine("Press 2 to return to the menu");

                                        string BJ_YesNo3 = Console.ReadLine();
                                        int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                        switch (yesnoBJcontinue)
                                        {
                                            case 1:
                                                BlackJack();
                                                break;
                                            case 2:
                                                Menu();
                                                break;
                                            default:
                                                Console.WriteLine("input error");
                                                break;
                                        }
                                    }
                                    else //if the dealer is closer to 21  (loss)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You've lost -" + BJ_Bet + "$");

                                        account_balance -= Int_BJ_Bet;

                                        Console.WriteLine("Current account balance is " + account_balance);
                                        Console.WriteLine("press 1 to play again");
                                        Console.WriteLine("Press 2 to return to the menu");

                                        string BJ_YesNo3 = Console.ReadLine();
                                        int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                        switch (yesnoBJcontinue)
                                        {
                                            case 1:
                                                BlackJack();
                                                break;
                                            case 2:
                                                Menu();
                                                break;
                                            default:
                                                Console.WriteLine("input error");
                                                break;
                                        }
                                    }
                                }
                            }
                            else //if it's bad to play
                            {//ending
                                Console.Clear();
                                Console.WriteLine("Bet amount " + Int_BJ_Bet + "$");
                                Console.WriteLine();
                                Console.WriteLine("No cards were drawn");
                                Console.WriteLine("Dealer: " + BJdlsum3);
                                Console.WriteLine();
                                Console.WriteLine("No cards were drawn");
                                Console.WriteLine(Username + ": " + BJplsum3);
                                Console.WriteLine();
                                Console.WriteLine("press enter to continue...");
                                Console.ReadLine();
                                //select a winner
                                if (BJdlsum3 > 21) //if dealer is over 21
                                {
                                    if (BJplsum3 > 21) //if both the player and the dealer is over 21 (tie)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Tie! You've won/lost 0$");
                                        Console.WriteLine("Current account balance is " + account_balance);
                                        Console.WriteLine("press 1 to play again");
                                        Console.WriteLine("Press 2 to return to the menu");

                                        string BJ_YesNo3 = Console.ReadLine();
                                        int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                        switch (yesnoBJcontinue)
                                        {
                                            case 1:
                                                BlackJack();
                                                break;
                                            case 2:
                                                Menu();
                                                break;
                                            default:
                                                Console.WriteLine("input error");
                                                break;
                                        }
                                    }
                                    else//the dealer is over 21 but not the player (win) 
                                    {
                                        Console.Clear();
                                        //times your bet by the earning amount
                                        float win_amount = (Int_BJ_Bet * BJ_earning);
                                        Console.WriteLine("You've won " + win_amount + "$");

                                        account_balance += win_amount;

                                        Console.WriteLine("Current account balance is " + account_balance);
                                        Console.WriteLine("press 1 to play again");
                                        Console.WriteLine("Press 2 to return to the menu");

                                        string BJ_YesNo3 = Console.ReadLine();
                                        int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                        switch (yesnoBJcontinue)
                                        {
                                            case 1:
                                                BlackJack();
                                                break;
                                            case 2:
                                                Menu();
                                                break;
                                            default:
                                                Console.WriteLine("input error");
                                                break;
                                        }
                                    }
                                }
                                else if (BJplsum3 > 21) //if the player is over 21 (loss)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You've lost -" + BJ_Bet + "$");

                                    account_balance -= Int_BJ_Bet;

                                    Console.WriteLine("Current account balance is " + account_balance);
                                    Console.WriteLine("press 1 to play again");
                                    Console.WriteLine("Press 2 to return to the menu");

                                    string BJ_YesNo3 = Console.ReadLine();
                                    int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                    switch (yesnoBJcontinue)
                                    {
                                        case 1:
                                            BlackJack();
                                            break;
                                        case 2:
                                            Menu();
                                            break;
                                        default:
                                            Console.WriteLine("input error");
                                            break;
                                    }
                                }
                                if (BJplsum3 > BJdlsum3) //if the player is closer to 21 than the dealer (win)
                                {
                                    Console.Clear();
                                    //times your bet by the earning amount
                                    float win_amount = (Int_BJ_Bet * BJ_earning);
                                    Console.WriteLine("You've won " + win_amount + "$");

                                    account_balance += win_amount;

                                    Console.WriteLine("Current account balance is " + account_balance);
                                    Console.WriteLine("press 1 to play again");
                                    Console.WriteLine("Press 2 to return to the menu");

                                    string BJ_YesNo3 = Console.ReadLine();
                                    int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                    switch (yesnoBJcontinue)
                                    {
                                        case 1:
                                            BlackJack();
                                            break;
                                        case 2:
                                            Menu();
                                            break;
                                        default:
                                            Console.WriteLine("input error");
                                            break;
                                    }
                                }
                                else //if the dealer is closer to 21  (loss)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You've lost -" + BJ_Bet + "$");

                                    account_balance -= Int_BJ_Bet;

                                    Console.WriteLine("Current account balance is " + account_balance);
                                    Console.WriteLine("press 1 to play again");
                                    Console.WriteLine("Press 2 to return to the menu");

                                    string BJ_YesNo3 = Console.ReadLine();
                                    int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                    switch (yesnoBJcontinue)
                                    {
                                        case 1:
                                            BlackJack();
                                            break;
                                        case 2:
                                            Menu();
                                            break;
                                        default:
                                            Console.WriteLine("input error");
                                            break;
                                    }
                                }
                            }
                        }
                        else //if dealers cards > 17
                        {//ending
                            Console.Clear();
                            Console.WriteLine("Bet amount " + Int_BJ_Bet + "$");
                            Console.WriteLine();
                            Console.WriteLine("No cards were drawn");
                            Console.WriteLine("Dealer: " + BJdlsum3);
                            Console.WriteLine();
                            Console.WriteLine("No cards were drawn");
                            Console.WriteLine(Username + ": " + BJplsum3);
                            Console.WriteLine();
                            Console.WriteLine("press enter to continue...");
                            Console.ReadLine();
                            //select a winner
                            if (BJdlsum3 > 21) //if dealer is over 21
                            {
                                if (BJplsum3 > 21) //if both the player and the dealer is over 21 (tie)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Tie! You've won/lost 0$");
                                    Console.WriteLine("Current account balance is " + account_balance);
                                    Console.WriteLine("press 1 to play again");
                                    Console.WriteLine("Press 2 to return to the menu");

                                    string BJ_YesNo3 = Console.ReadLine();
                                    int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                    switch (yesnoBJcontinue)
                                    {
                                        case 1:
                                            BlackJack();
                                            break;
                                        case 2:
                                            Menu();
                                            break;
                                        default:
                                            Console.WriteLine("input error");
                                            break;
                                    }
                                }
                                else//the dealer is over 21 but not the player (win) 
                                {
                                    Console.Clear();
                                    //times your bet by the earning amount
                                    float win_amount = (Int_BJ_Bet * BJ_earning);
                                    Console.WriteLine("You've won " + win_amount + "$");

                                    account_balance += win_amount;

                                    Console.WriteLine("Current account balance is " + account_balance);
                                    Console.WriteLine("press 1 to play again");
                                    Console.WriteLine("Press 2 to return to the menu");

                                    string BJ_YesNo3 = Console.ReadLine();
                                    int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                    switch (yesnoBJcontinue)
                                    {
                                        case 1:
                                            BlackJack();
                                            break;
                                        case 2:
                                            Menu();
                                            break;
                                        default:
                                            Console.WriteLine("input error");
                                            break;
                                    }
                                }
                            }
                            else if (BJplsum3 > 21) //if the player is over 21 (loss)
                            {
                                Console.Clear();
                                Console.WriteLine("You've lost -" + BJ_Bet + "$");

                                account_balance -= Int_BJ_Bet;

                                Console.WriteLine("Current account balance is " + account_balance);
                                Console.WriteLine("press 1 to play again");
                                Console.WriteLine("Press 2 to return to the menu");

                                string BJ_YesNo3 = Console.ReadLine();
                                int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                switch (yesnoBJcontinue)
                                {
                                    case 1:
                                        BlackJack();
                                        break;
                                    case 2:
                                        Menu();
                                        break;
                                    default:
                                        Console.WriteLine("input error");
                                        break;
                                }
                            }
                            if (BJplsum3 > BJdlsum3) //if the player is closer to 21 than the dealer (win)
                            {
                                Console.Clear();
                                //times your bet by the earning amount
                                float win_amount = (Int_BJ_Bet * BJ_earning);
                                Console.WriteLine("You've won " + win_amount + "$");

                                account_balance += win_amount;

                                Console.WriteLine("Current account balance is " + account_balance);
                                Console.WriteLine("press 1 to play again");
                                Console.WriteLine("Press 2 to return to the menu");

                                string BJ_YesNo3 = Console.ReadLine();
                                int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                switch (yesnoBJcontinue)
                                {
                                    case 1:
                                        BlackJack();
                                        break;
                                    case 2:
                                        Menu();
                                        break;
                                    default:
                                        Console.WriteLine("input error");
                                        break;
                                }
                            }
                            else //if the dealer is closer to 21  (loss)
                            {
                                Console.Clear();
                                Console.WriteLine("You've lost -" + BJ_Bet + "$");

                                account_balance -= Int_BJ_Bet;

                                Console.WriteLine("Current account balance is " + account_balance);
                                Console.WriteLine("press 1 to play again");
                                Console.WriteLine("Press 2 to return to the menu");

                                string BJ_YesNo3 = Console.ReadLine();
                                int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                switch (yesnoBJcontinue)
                                {
                                    case 1:
                                        BlackJack();
                                        break;
                                    case 2:
                                        Menu();
                                        break;
                                    default:
                                        Console.WriteLine("input error");
                                        break;
                                }
                            }
                        }
                        

                    }
                }
                else
                {
                    //if dealers cards > 17
                    Console.Clear();
                    Console.WriteLine("Bet amount " + Int_BJ_Bet + "$");
                    Console.WriteLine();
                    Console.WriteLine("No cards drawn");
                    Console.WriteLine("Dealer: " + BJdlsum2);
                    Console.WriteLine();
                    Console.WriteLine("+" + BJplR3);
                    Console.WriteLine(Username + ": " + BJplsum3);
                    Console.WriteLine();
                    Console.WriteLine("press enter to continue...");
                    Console.ReadLine();

                    //ending

                    //select a winner
                    if (BJdlsum2 > 21) //if dealer is over 21
                    {
                        if (BJplsum3 > 21) //if both the player and the dealer is over 21 (tie)
                        {
                            Console.Clear();
                            Console.WriteLine("Tie! You've won/lost 0$");
                            Console.WriteLine("Current account balance is " + account_balance);
                            Console.WriteLine("press 1 to play again");
                            Console.WriteLine("Press 2 to return to the menu");

                            string BJ_YesNo3 = Console.ReadLine();
                            int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                            switch (yesnoBJcontinue)
                            {
                                case 1:
                                    BlackJack();
                                    break;
                                case 2:
                                    Menu();
                                    break;
                                default:
                                    Console.WriteLine("input error");
                                    break;
                            }
                        }
                        else//the dealer is over 21 but not the player (win) 
                        {
                            Console.Clear();
                            //times your bet by the earning amount
                            float win_amount = (Int_BJ_Bet * BJ_earning);
                            Console.WriteLine("You've won " + win_amount + "$");

                            account_balance += win_amount;

                            Console.WriteLine("Current account balance is " + account_balance);
                            Console.WriteLine("press 1 to play again");
                            Console.WriteLine("Press 2 to return to the menu");

                            string BJ_YesNo3 = Console.ReadLine();
                            int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                            switch (yesnoBJcontinue)
                            {
                                case 1:
                                    BlackJack();
                                    break;
                                case 2:
                                    Menu();
                                    break;
                                default:
                                    Console.WriteLine("input error");
                                    break;
                            }
                        }
                    }
                    else if (BJplsum3 > 21) //if the player is over 21 (loss)
                    {
                        Console.Clear();
                        Console.WriteLine("You've lost -" + BJ_Bet + "$");

                        account_balance -= Int_BJ_Bet;

                        Console.WriteLine("Current account balance is " + account_balance);
                        Console.WriteLine("press 1 to play again");
                        Console.WriteLine("Press 2 to return to the menu");

                        string BJ_YesNo3 = Console.ReadLine();
                        int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                        switch (yesnoBJcontinue)
                        {
                            case 1:
                                BlackJack();
                                break;
                            case 2:
                                Menu();
                                break;
                            default:
                                Console.WriteLine("input error");
                                break;
                        }
                    }
                    if (BJplsum3 > BJdlsum2) //if the player is closer to 21 than the dealer (win)
                    {
                        Console.Clear();
                        //times your bet by the earning amount
                        float win_amount = (Int_BJ_Bet * BJ_earning);
                        Console.WriteLine("You've won " + win_amount + "$");

                        account_balance += win_amount;

                        Console.WriteLine("Current account balance is " + account_balance);
                        Console.WriteLine("press 1 to play again");
                        Console.WriteLine("Press 2 to return to the menu");

                        string BJ_YesNo3 = Console.ReadLine();
                        int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                        switch (yesnoBJcontinue)
                        {
                            case 1:
                                BlackJack();
                                break;
                            case 2:
                                Menu();
                                break;
                            default:
                                Console.WriteLine("input error");
                                break;
                        }
                    }
                    else //if the dealer is closer to 21  (loss)
                    {
                        Console.Clear();
                        Console.WriteLine("You've lost -" + BJ_Bet + "$");

                        account_balance -= Int_BJ_Bet;

                        Console.WriteLine("Current account balance is " + account_balance);
                        Console.WriteLine("press 1 to play again");
                        Console.WriteLine("Press 2 to return to the menu");

                        string BJ_YesNo3 = Console.ReadLine();
                        int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                        switch (yesnoBJcontinue)
                        {
                            case 1:
                                BlackJack();
                                break;
                            case 2:
                                Menu();
                                break;
                            default:
                                Console.WriteLine("input error");
                                break;
                        }
                    }
                }
            }
            else if (BJ_YesNo == "n") // N
            {
                if (BJdlsum2 < 17)
                {
                    int BJdlR3 = rnd.Next(1, 11);
                    int BJdlsum3 = BJdlR1 + BJdl + BJdlR2 + BJdlR3;

                    Console.Clear();
                    Console.WriteLine("Bet amount " + Int_BJ_Bet + "$");
                    Console.WriteLine();
                    Console.WriteLine("+" + BJdlR3);
                    Console.WriteLine("Dealer: " + BJdlsum3);
                    Console.WriteLine();
                    Console.WriteLine("No cards drawn");
                    Console.WriteLine(Username + ": " + (BJplsum2));
                    Console.WriteLine();
                    Console.WriteLine("press enter to continue...");
                    Console.ReadLine();

                    if (BJdlsum3 < 17) //if it's best for the dealer to move on to round 4
                    {
                        int BJdlR4 = rnd.Next(1, 11);
                        int BJdlsum4 = BJdlR1 + BJdl + BJdlR2 + BJdlR3 + BJdlR4;

                        Console.Clear();
                        Console.WriteLine("Bet amount " + Int_BJ_Bet + "$");
                        Console.WriteLine();
                        Console.WriteLine("+" + BJdlR4);
                        Console.WriteLine("Dealer: " + BJdlsum4);
                        Console.WriteLine();
                        Console.WriteLine("No cards drawn");
                        Console.WriteLine(Username + ": " + (BJplsum2));
                        Console.WriteLine();
                        Console.WriteLine("press enter to continue...");
                        Console.ReadLine();
                    }
                    else//ending
                    {
                        //select a winner
                        if (BJdlsum3 > 21) //if dealer is over 21
                        {
                            if (BJplsum2 > 21) //if both the player and the dealer is over 21 (tie)
                            {
                                Console.Clear();
                                Console.WriteLine("Tie! You've won/lost 0$");
                                Console.WriteLine("Current account balance is " + account_balance);
                                Console.WriteLine("press 1 to play again");
                                Console.WriteLine("Press 2 to return to the menu");

                                string BJ_YesNo3 = Console.ReadLine();
                                int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                switch (yesnoBJcontinue)
                                {
                                    case 1:
                                        BlackJack();
                                        break;
                                    case 2:
                                        Menu();
                                        break;
                                    default:
                                        Console.WriteLine("input error");
                                        break;
                                }
                            }
                            else//the dealer is over 21 but not the player (win) 
                            {
                                Console.Clear();
                                //times your bet by the earning amount
                                float win_amount = (Int_BJ_Bet * BJ_earning);
                                Console.WriteLine("You've won " + win_amount + "$");

                                account_balance += win_amount;

                                Console.WriteLine("Current account balance is " + account_balance);
                                Console.WriteLine("press 1 to play again");
                                Console.WriteLine("Press 2 to return to the menu");

                                string BJ_YesNo3 = Console.ReadLine();
                                int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                                switch (yesnoBJcontinue)
                                {
                                    case 1:
                                        BlackJack();
                                        break;
                                    case 2:
                                        Menu();
                                        break;
                                    default:
                                        Console.WriteLine("input error");
                                        break;
                                }
                            }
                        }
                        else if (BJplsum2 > 21) //if the player is over 21 (loss)
                        {
                            Console.Clear();
                            Console.WriteLine("You've lost -" + BJ_Bet + "$");

                            account_balance -= Int_BJ_Bet;

                            Console.WriteLine("Current account balance is " + account_balance);
                            Console.WriteLine("press 1 to play again");
                            Console.WriteLine("Press 2 to return to the menu");

                            string BJ_YesNo3 = Console.ReadLine();
                            int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                            switch (yesnoBJcontinue)
                            {
                                case 1:
                                    BlackJack();
                                    break;
                                case 2:
                                    Menu();
                                    break;
                                default:
                                    Console.WriteLine("input error");
                                    break;
                            }
                        }
                        if (BJplsum2 > BJdlsum3) //if the player is closer to 21 than the dealer (win)
                        {
                            Console.Clear();
                            //times your bet by the earning amount
                            float win_amount = (Int_BJ_Bet * BJ_earning);
                            Console.WriteLine("You've won " + win_amount + "$");

                            account_balance += win_amount;

                            Console.WriteLine("Current account balance is " + account_balance);
                            Console.WriteLine("press 1 to play again");
                            Console.WriteLine("Press 2 to return to the menu");

                            string BJ_YesNo3 = Console.ReadLine();
                            int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                            switch (yesnoBJcontinue)
                            {
                                case 1:
                                    BlackJack();
                                    break;
                                case 2:
                                    Menu();
                                    break;
                                default:
                                    Console.WriteLine("input error");
                                    break;
                            }
                        }
                        else //if the dealer is closer to 21  (loss)
                        {
                            Console.Clear();
                            Console.WriteLine("You've lost -" + BJ_Bet + "$");

                            account_balance -= Int_BJ_Bet;

                            Console.WriteLine("Current account balance is " + account_balance);
                            Console.WriteLine("press 1 to play again");
                            Console.WriteLine("Press 2 to return to the menu");

                            string BJ_YesNo3 = Console.ReadLine();
                            int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                            switch (yesnoBJcontinue)
                            {
                                case 1:
                                    BlackJack();
                                    break;
                                case 2:
                                    Menu();
                                    break;
                                default:
                                    Console.WriteLine("input error");
                                    break;
                            }
                        }
                    }
                }
                else//ending
                {
                    //select a winner
                    if (BJdlsum2 > 21) //if dealer is over 21
                    {
                        if (BJplsum2 > 21) //if both the player and the dealer is over 21 (tie)
                        {
                            Console.Clear();
                            Console.WriteLine("Tie! You've won/lost 0$");
                            Console.WriteLine("Current account balance is " + account_balance);
                            Console.WriteLine("press 1 to play again");
                            Console.WriteLine("Press 2 to return to the menu");

                            string BJ_YesNo3 = Console.ReadLine();
                            int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                            switch (yesnoBJcontinue)
                            {
                                case 1:
                                    BlackJack();
                                    break;
                                case 2:
                                    Menu();
                                    break;
                                default:
                                    Console.WriteLine("input error");
                                    break;
                            }
                        }
                        else//the dealer is over 21 but not the player (win) 
                        {
                            Console.Clear();
                            //times your bet by the earning amount
                            float win_amount = (Int_BJ_Bet * BJ_earning);
                            Console.WriteLine("You've won " + win_amount + "$");

                            account_balance += win_amount;

                            Console.WriteLine("Current account balance is " + account_balance);
                            Console.WriteLine("press 1 to play again");
                            Console.WriteLine("Press 2 to return to the menu");

                            string BJ_YesNo3 = Console.ReadLine();
                            int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                            switch (yesnoBJcontinue)
                            {
                                case 1:
                                    BlackJack();
                                    break;
                                case 2:
                                    Menu();
                                    break;
                                default:
                                    Console.WriteLine("input error");
                                    break;
                            }
                        }
                    }
                    else if (BJplsum2 > 21) //if the player is over 21 (loss)
                    {
                        Console.Clear();
                        Console.WriteLine("You've lost -" + BJ_Bet + "$");

                        account_balance -= Int_BJ_Bet;

                        Console.WriteLine("Current account balance is " + account_balance);
                        Console.WriteLine("press 1 to play again");
                        Console.WriteLine("Press 2 to return to the menu");

                        string BJ_YesNo3 = Console.ReadLine();
                        int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                        switch (yesnoBJcontinue)
                        {
                            case 1:
                                BlackJack();
                                break;
                            case 2:
                                Menu();
                                break;
                            default:
                                Console.WriteLine("input error");
                                break;
                        }
                    }
                    if (BJplsum2 > BJdlsum2) //if the player is closer to 21 than the dealer (win)
                    {
                        Console.Clear();
                        //times your bet by the earning amount
                        float win_amount = (Int_BJ_Bet * BJ_earning);
                        Console.WriteLine("You've won " + win_amount + "$");

                        account_balance += win_amount;

                        Console.WriteLine("Current account balance is " + account_balance);
                        Console.WriteLine("press 1 to play again");
                        Console.WriteLine("Press 2 to return to the menu");

                        string BJ_YesNo3 = Console.ReadLine();
                        int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                        switch (yesnoBJcontinue)
                        {
                            case 1:
                                BlackJack();
                                break;
                            case 2:
                                Menu();
                                break;
                            default:
                                Console.WriteLine("input error");
                                break;
                        }
                    }
                    else //if the dealer is closer to 21  (loss)
                    {
                        Console.Clear();
                        Console.WriteLine("You've lost -" + BJ_Bet + "$");

                        account_balance -= Int_BJ_Bet;

                        Console.WriteLine("Current account balance is " + account_balance);
                        Console.WriteLine("press 1 to play again");
                        Console.WriteLine("Press 2 to return to the menu");

                        string BJ_YesNo3 = Console.ReadLine();
                        int yesnoBJcontinue = Convert.ToInt32(BJ_YesNo3);
                        switch (yesnoBJcontinue)
                        {
                            case 1:
                                BlackJack();
                                break;
                            case 2:
                                Menu();
                                break;
                            default:
                                Console.WriteLine("input error");
                                break;
                        }
                    }
                }// end of ending
            }



        }
    }
}
