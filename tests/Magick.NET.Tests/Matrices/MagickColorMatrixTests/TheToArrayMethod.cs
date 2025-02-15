﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using ImageMagick;
using Xunit;

namespace Magick.NET.Tests
{
    public partial class MagickColorMatrixTests
    {
        public class TheToArrayMethod
        {
            [Fact]
            public void ShouldReturnArray()
            {
                var matrix = new MagickColorMatrix(1, 6);

                Assert.Equal(new double[] { 6 }, matrix.ToArray());
            }
        }
    }
}
