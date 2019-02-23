using System;
using Xunit;
using System.IO;

namespace Code.Tests
{
    public class NumbersTests
    {
        [Fact]
        public void Size_Equals100()
        {
            Numbers num=new Numbers();
            string[] n=num.numbers.Split(",");
            Assert.Equal(100, n.Length);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(7)]
        [InlineData(33)]
        [InlineData(97)]
        public void NotDivisable_EqualIndexPlusOne(int index)
        {
            Numbers numObj=new Numbers();
            string[] numArr=numObj.numbers.Split(",");
            int num=int.Parse(numArr[index]);
            Assert.Equal(index+1, num);
        }
        [Theory]
        [InlineData(3)]
        [InlineData(99)]
        public void DivisableByThree_EqualFizz(int value)
        {
            Numbers numObj=new Numbers();
            string[] numArr=numObj.numbers.Split(",");
            Assert.Equal("Fizz", numArr[value-1]);
        }
        [Theory]
        [InlineData(5)]
        [InlineData(100)]
        public void DivisableByFive_EqualFizz(int value)
        {
            Numbers numObj=new Numbers();
            string[] numArr=numObj.numbers.Split(",");
            Assert.Equal("Buzz", numArr[value-1]);
        }
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void DivisableByFiveAndThree_EqualFizzBuzz(int value)
        {
            Numbers numObj=new Numbers();
            string[] numArr=numObj.numbers.Split(",");
            System.Console.WriteLine(numObj.numbers);
            Assert.Equal("FizzBuzz", numArr[value-1]);
        }
    }
}
