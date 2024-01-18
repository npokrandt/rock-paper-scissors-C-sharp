using System;

namespace RockPaperScissors{
    class Gameplay{

        public static void PlayGame(){
            string[] AIoptions = {"rock", "paper", "scissors"};
            Console.WriteLine("Welcome to rock, paper, scissors!");

            //record the user's item 
            Console.WriteLine("Your Turn! Please type 'rock', 'paper', or 'scissors': ");
            string userItemInput = Console.ReadLine() ?? "";
            string userItem = userItemInput.ToLower();
            while (true){

                if (userItem == "rock"){
                    break;
                } else if (userItem == "paper"){
                    break;
                } else if (userItem == "scissors"){
                    break;
                } else {
                    Console.WriteLine("Incorrect answer! Please type 'rock', 'paper', or 'scissors':");
                    userItemInput = Console.ReadLine() ?? "";
                    userItem = userItemInput.ToLower();
                }
            }

            var rand = new Random();

            string AIguess = AIoptions[rand.Next(3)];
            Console.WriteLine(AIguess);
            //Console.WriteLine(userItem);

            //now, compare the two guesses and award the winner
            if (AIguess == userItem){
                GameEnd.tie();
            } else if (AIguess == "rock"){
                if (userItem == "scissors"){
                    GameEnd.AIwin();
                } else if (userItem == "paper"){
                    GameEnd.userWin();
                }
            } else if (AIguess == "paper"){
                if (userItem == "scissors"){
                    GameEnd.userWin();
                } else if (userItem == "rock"){
                    GameEnd.AIwin();
                }
            } else if (AIguess == "scissors"){
                if (userItem == "rock"){
                    GameEnd.userWin();
                } else if (userItem == "paper"){
                    GameEnd.AIwin();
                }
            }

            //prompt to start game
            //user is prompted for rock, paper, or scissors
            //AI randomly chooses one
            //winner is declared and their win total upped

            //possibly store data in a csv file or something, and give the option to reset at some point
        }
    }
}