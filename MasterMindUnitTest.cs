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
    }
}