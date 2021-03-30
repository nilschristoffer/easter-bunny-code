using System;
using System.Collections.Generic;
using Xunit;

namespace EasterCodeBunny.Tests
{
    public class Task1A
    {
        [Fact]
        public void It_Should_Print_List_Of_Strings_In_Rectangle()
        {
            // Arrange
            var input = new List<string>()
            {
                "Glad",
                "P�sk",
                "Forefront",
                "2021",
                "Fr�n",
                "Easter BC"
            };

            var expected = new List<string>()
            {
                "*************",
                "* Glad      *",
                "* P�sk      *",
                "* Forefront *",
                "* 2021      *",
                "* Fr�n      *",
                "* Easter BC *",
                "*************"
            };

            // Act
            var actual = EasterCodeBunny.Task1A.HappyEaster.Rectanglize(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
