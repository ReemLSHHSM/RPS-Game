using Rock__Paper__Scissors;
using Xunit;

namespace RPSGameTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestTie()
        {
            // Arrange
            Player player = new Player("reem");
            string playerChoice = "rock";
            RPSGame game = new RPSGame();

            // Act
            string result = game.Compare(player, playerChoice, "rock"); 

            // Assert
            
            Assert.Equal("tie", result);
        }

        [Fact]
        public void TestPlayerWins()
        {
            // Arrange
            Player player = new Player("reem");
            string playerChoice = "paper";
            RPSGame game = new RPSGame();

            // Act
            string result = game.Compare(player, playerChoice, "rock"); // Simulate AI choosing rock

            // Assert
            Assert.Equal("reem", result); // Player should win with paper over rock
        }

        [Fact]
        public void TestAIWins()
        {
            // Arrange
            Player player = new Player("reem");
            string playerChoice = "rock";
            RPSGame game = new RPSGame();

            // Act
            string result = game.Compare(player, playerChoice, "paper"); // Simulate AI choosing paper

            // Assert
            Assert.Equal("AI", result); // AI should win with paper over rock
        }


        [Fact]
        public void TestScoreUpdate()
        {
            // Arrange
            Player player = new Player("reem");
            RPSGame game = new RPSGame();
            int initialPlayerScore = player.Score;
            int initialAIScore = game.AI_score;

            // Act
            game.Compare(player, "rock", "paper"); 

            // Assert
            Assert.Equal(initialPlayerScore, player.Score); 
            Assert.Equal(initialAIScore + 1, game.AI_score); 
            
        }
    }
}
