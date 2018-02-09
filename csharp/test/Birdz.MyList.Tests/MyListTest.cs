using System;
using Xunit;

namespace Birdz.MyList.Tests
{
    public class MyListTest
    {
        private readonly MyList _list;

        public MyListTest()
        {
            _list = new MyList();
        }

        [Fact]
        public void AnEmptyList_ShouldHaveNotElement()
        {
            // Act
            
            // Arrange
            
            // Assert
            Assert.Equal(0, _list.Count());
        }

        [Fact]
        public void GivenEmptyList_WhenAddOneElement_ThenListShouldHaveCountToOne()
        {
            // Act
            var element = "Element";
            
            // Arrange
            _list.Add(element);
            
            //Assert
            Assert.Equal(1, _list.Count());
        }

        [Fact]
        public void GivenListWithOneElement_WhenAddAnOtherElement_ThenShouldHaveTwoElement()
        {
            // Act
            var initialElement = "InitElement";
            var newElement = "NewOne";
            _list.Add(initialElement);
            
            // Arrange
            _list.Add(newElement);
            
            //Assert
            Assert.Equal(2, _list.Count());
        }

        [Fact]
        public void GivenListWithOneElement_WhenGetFirstElement_ThenShouldReturnTheElement()
        {
            // Act
            var element = "Element";
            _list.Add(element);
            
            // Arrange
            var result = _list[0];
            
            //Assert
            Assert.Equal(element, result);
        }

        [Fact]
        public void GivenListWithTwoElement_WhenGetTheSecondElement_ThenShouldReturnTheSecondElement()
        {
            // Act
            var element = "Element";
            var secondElement = "qwerty";
            _list.Add(secondElement);
            _list.Add(element);
            
            // Arrange
            var result = _list[1];
            
            //Assert
            Assert.Equal(secondElement, result);
        }
    }
}
