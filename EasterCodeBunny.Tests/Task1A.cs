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
                "Påsk",
                "Forefront",
                "2021",
                "Från",
                "Easter BC"
            };

            var expected = new List<string>()
            {
                "*************",
                "* Glad      *",
                "* Påsk      *",
                "* Forefront *",
                "* 2021      *",
                "* Från      *",
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
