﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        int size = 0;
        string expected = "";

        // Act
        string result = Triangle.PrintTriangle(size);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // Arrange
        int size = 3;
        string expected = "1\r\n1 2\r\n1 2 3\r\n1 2\r\n1";

        // Act
        string result = Triangle.PrintTriangle(size);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        // Arrange
        int size = 5;
        string expected = "1\r\n1 2\r\n1 2 3\r\n1 2 3 4\r\n1 2 3 4 5\r\n1 2 3 4\r\n1 2 3\r\n1 2\r\n1";

        // Act
        string result = Triangle.PrintTriangle(size);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
