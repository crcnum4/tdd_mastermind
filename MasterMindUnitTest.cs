using NUnit.Framework;
using Mastermind.Service;

namespace Tests
{
    public class Tests
    {
        Game game = new Game(new CodeGenerator(), new GameStatus(), new GameInputValidator());
        [Test]
        public void ThrowExceptionIfAttemptLenghtIsMoreThan4()
        {
            game.code = new int[]{1,2,3,4};
            var input = new int[]{1,2,3,4,5};
            Assert.Throws<System.ArgumentException>(() => game.CheckScore(input));
        }
        [Test]
        public void ThrowExceptionIfAttemptLengthIsLessThan4()
        {
            
        }
        [Test]
        public void ThrowExceptionIfNumberInAttemptArrayIsGreaterThan6()
        {
            
        }
        [Test]
        public void ThrowExceptionIfNumberInAttemptArrayIsLessThan1()
        {
            
        }
        [Test]
        public void ThrowExceptionIfAllNumbersInAttemptArrayAreNotUnique()
        {
            
        }

        [Test]
        public void IfGameIsWon_ReturnGameStatusIsWonTrue()
        {
            
        }

        [Test]
        public void If3NumbersAreCorrect_ReturnGameStatusCorrectNumsIs3()
        {
            
        }
        [Test]
        public void If2NumbersAreInCorrectPosition_ReturnGameStatusCorrectPositionsIs2()
        {
            
        }
        [Test]
        public void CorrectNumbersShouldIgnoreCorrectPositions()
        {
            
        }
    }
}