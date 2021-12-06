using System;
using Xunit;

namespace Model.Tests
{
    public class TestConversion
    {
        [Fact]
        public void Equals_DifferentConversionsWithNoParameters_ReturnsTrue()
        {
            var expected = new Conversion();

            var actual = new Conversion();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddExecution_AddsANewExecutionToCurrentConversion_ReturnsTrue()
        {
            var expected = 1;

            var converion = new Conversion();
            var executionToAdd = new Execution(99, DateTime.Parse("01-01-2020 12:00:00"));

            converion.AddExecution(executionToAdd);
            var actual = converion.Executions.Count;

            Assert.Equal(expected, actual);
        }
    }
}
