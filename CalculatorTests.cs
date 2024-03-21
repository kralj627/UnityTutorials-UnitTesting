using NUnit.Framework;
using UnityEngine;

public class CalculatorTests
{
    [Test]
    public void Add_TwoPlusTwo_ReturnsFour()
    {
        // Arrange
        var a = 2;
        var b = 2;

        // Act
        var result = Calculator.Add(a, b);

        // Assert
        Assert.AreEqual(4, result);
    }

    [Test]
    public void Subtract_FiveMinusThree_ReturnsTwo()
    {
        // Arrange
        var a = 5;
        var b = 3;

        // Act
        var result = Calculator.Subtract(a, b);

        // Assert
        Assert.AreEqual(2, result);
    }
}
