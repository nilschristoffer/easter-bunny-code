using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace EasterCodeBunny.Tests
{
    public class Task1B
    {
        [Fact]
        public void One_Queens_Puzzle_Should_Have_1_Solution()
        {
            // Act
            var actual = EasterCodeBunny.Task1B.QueensPuzzle.PossibleQueenFormationSolutions(1).Count();

            // Assert
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Two_Queens_Puzzle_Should_Have_0_Solutions()
        {
            // Arrange

            // Act
            var actual = EasterCodeBunny.Task1B.QueensPuzzle.PossibleQueenFormationSolutions(2).Count();

            // Assert
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Three_Queens_Puzzle_Should_Have_0_Solutions()
        {
            // Act
            var actual = EasterCodeBunny.Task1B.QueensPuzzle.PossibleQueenFormationSolutions(3).Count();

            // Assert
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Four_Queens_Puzzle_Should_Have_2_Solutions()
        {
            // Act
            var actual = EasterCodeBunny.Task1B.QueensPuzzle.PossibleQueenFormationSolutions(4).Count();

            // Assert
            Assert.Equal(2, actual);
        }

        [Fact]
        public void Eight_Queens_Puzzle_Should_Have_92_Solutions()
        {
            // Act
            var actual = EasterCodeBunny.Task1B.QueensPuzzle.PossibleQueenFormationSolutions(8).Count();

            // Assert
            Assert.Equal(92, actual);
        }
    }
}
