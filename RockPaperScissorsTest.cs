using NUnit.Framework;
using System;
using RockPaperScissors;

namespace RockPaperScissors
{
    [TestFixture]
    public class RockPaperScissorsEvaluatorTest
    {
        TestCase
        public void getWinningMoveTest()
        {
            // Given
            String input = "rock";
            String expected = "paper";
            RockPaperScissorsEvaluator rps = new RockPaperScissorsEvaluator();

            // When
            String actual = rps.getWinningMove(input);

            // Then
            Assert.assertEquals(expected, actual);
        }

        @Test
        public void getLosingMoveTest()
        {
            // Given
            String input = "rock";
            String expected = "scissor";
            RockPaperScissorsEvaluator rps = new RockPaperScissorsEvaluator();

            // When
            String actual = rps.getLosingMove(input);

            // Then
            Assert.assertEquals(expected, actual);
        }

        @Test
        public void getWinnerTest()
        {
            // Given
            String input1 = "rock";
            String input2 = "scissors";
            String expected = "rock";
            RockPaperScissorsEvaluator rps = new RockPaperScissorsEvaluator();

            // When
            String actual = rps.getWinner(input1, input2);

            // Then
            Assert.assertEquals(expected, actual);
        }
    }
}