using System.Collections.Generic;
using Xunit;

namespace EasterCodeBunny.Tests
{
    public class Task3
    {
        [Fact]
        public void Should_Result_In_3_Permutations_If_One_Number_With_Three_Letters()
        {
            // Act
            var actual = EasterCodeBunny.Task3.T9.Permutations("2").Count;

            // Assert
            Assert.Equal(3, actual);
        }

        [Fact]
        public void Should_Result_In_12_Permutations_If_Two_Numbers_With_Three_And_Four_Letters()
        {
            // Act
            var actual = EasterCodeBunny.Task3.T9.Permutations("27").Count;

            // Assert
            Assert.Equal(12, actual);
        }

        [Fact]
        public void Should_Result_In_27_Permutations_If_Three_Numbers_With_Three_Letters_Each()
        {
            // Act
            var actual = EasterCodeBunny.Task3.T9.Permutations("234").Count;

            // Assert
            Assert.Equal(27, actual);
        }
    }
}
