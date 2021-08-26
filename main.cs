using System;

class Program {
  public static void Main (string[] args) {
    bool playing = true;
    var random = new Random();
    Console.WriteLine ("Danny's Number Guessing Game\n------------------------------\n");
    Console.WriteLine ("Rules:\nYou have 10 guesses. After each guess, the game will tell you if your guess is too high or too low. If you guess the number within 10 guesses, you win! If you use up all 10 guesses, you lose.");
    
    while (playing) {
      int numOfGuesses = 0;
      int randomNum;
      string choice;
      bool win = false;
      Console.WriteLine ("\n------------------------------\n1. Easy (1-10)\n2. Medium (1-100)\n3. Hard (1-1000)\n4. Exit");
      Console.Write ("Pick a difficulty: ");
      int difficulty = Convert.ToInt32(Console.ReadLine());

      switch (difficulty) {
        case 1:
          randomNum = random.Next(1, 10);
          while (numOfGuesses < 10){
            Console.Write ("Guess a number: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == randomNum) {
              win = true;
              Console.Write("You win!\nPlay again? (Y/N): ");
              choice = Console.ReadLine();
              if (choice.ToLower() == "y") {
                break;
              } else {
                playing = false;
                break;
              }
            } else if (guess < randomNum) {
              Console.WriteLine("Too low!");
              numOfGuesses++;
            } else {
              Console.WriteLine("Too high!");
              numOfGuesses++;
            }
          }
          if (!win) {
            Console.Write("Sorry, you lost!\nPlay again?(Y/N): ");
            choice = Console.ReadLine();
            if (choice.ToLower() == "n") {
              playing = false;
            }
          }
          break;
        case 2:
          randomNum = random.Next(1, 100);
          while (numOfGuesses < 10){
            Console.Write ("Guess a number: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == randomNum) {
              win = true;
              Console.Write("You win!\nPlay again? (Y/N): ");
              choice = Console.ReadLine();
              if (choice.ToLower() == "y") {
                break;
              } else {
                playing = false;
                break;
              }
            } else if (guess < randomNum) {
              Console.WriteLine("Too low!");
              numOfGuesses++;
            } else {
              Console.WriteLine("Too high!");
              numOfGuesses++;
            }
          }
          if (!win) {
            Console.Write("Sorry, you lost!\nPlay again?(Y/N): ");
            choice = Console.ReadLine();
            if (choice.ToLower() == "n") {
              playing = false;
            }
          }
          break;
        case 3:
          randomNum = random.Next(1, 1000);
          while (numOfGuesses < 10){
            Console.Write ("Guess a number: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == randomNum) {
              win = true;
              Console.Write("You win!\nPlay again? (Y/N): ");
              choice = Console.ReadLine();
              if (choice.ToLower() == "y") {
                break;
              } else {
                playing = false;
                break;
              }
            } else if (guess < randomNum) {
              Console.WriteLine("Too low!");
              numOfGuesses++;
            } else {
              Console.WriteLine("Too high!");
              numOfGuesses++;
            }
          }
          if (!win) {
            Console.Write("Sorry, you lost!\nPlay again?(Y/N): ");
            choice = Console.ReadLine();
            if (choice.ToLower() == "n") {
              playing = false;
            }
          }
          break;
        case 4:
          playing = false;
          break;
        default:
          Console.WriteLine ("Please enter a valid number. ");
          break;
      }
    }
  }
}