﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System;
using ImageMagick;
using Xunit;

namespace Magick.NET.Tests
{
    public partial class MagickColorMatrixTests
    {
        public class TheGetValueMethod
        {
            [Fact]
            public void ShouldThrowExceptionWhenXTooLow()
                => TestThrowsException("x", -1, 1);

            [Fact]
            public void ShouldThrowExceptionWhenXTooHigh()
                => TestThrowsException("x", 2, 1);

            [Fact]
            public void ShouldThrowExceptionWhenYTooLow()
                => TestThrowsException("y", 1, -1);

            [Fact]
            public void ShouldThrowExceptionWhenYTooHigh()
                => TestThrowsException("y", 1, 2);

            [Fact]
            public void ShouldReturnValueForValidIndexes()
            {
                var matrix = new MagickColorMatrix(1, 4);

                Assert.Equal(4, matrix.GetValue(0, 0));
            }

            private static void TestThrowsException(string paramName, int x, int y)
            {
                var matrix = new MagickColorMatrix(2);

                Assert.Throws<ArgumentOutOfRangeException>(paramName, () =>
                {
                    matrix.GetValue(x, y);
                });
            }
        }
    }
}
