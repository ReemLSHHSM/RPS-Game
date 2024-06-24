# Rock, Paper, Scissors Game

This is a simple console-based Rock, Paper, Scissors game implemented in C#.

## Overview

The game consists of two main classes:
1. `Player`: Represents a player in the game.
2. `RPSGame`: Manages the game logic, including AI moves and score tracking.

## How to Play

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or your preferred C# IDE.
3. Build and run the program.
4. Follow the on-screen instructions to play the game against the AI.

## Project Structure

- **Rock__Paper__Scissors/**: Contains the C# source code files.
  - `Program.cs`: Entry point of the application.
  - `Player.cs`: Defines the Player class with methods for input and move selection.
  - `RPSGame.cs`: Implements the game logic including AI moves and score tracking.
- **RPS_Game.Tests/**: Contains unit tests for the game.
  - `UnitTest1.cs`: Includes Xunit tests to verify game functionality.

## Unit Tests

The `RPS_Game.Tests` project includes unit tests to verify the following:
- Correct determination of the winner in each round based on player moves.
- Accurate updating of scores after each round.

## Running Unit Tests

1. Open the solution in Visual Studio.
2. Build the solution.
3. Open Test Explorer.
4. Run all tests to ensure the game logic is functioning as expected.


### Game Logic
- `TestTie`: Ensures the game correctly detects a tie.
- `TestPlayerWins`: Validates that the player wins based on move comparison.
- `TestAIWins`: Confirms that the AI wins based on move comparison.
- `TestScoreUpdate`: Checks if scores are updated correctly after each round.


