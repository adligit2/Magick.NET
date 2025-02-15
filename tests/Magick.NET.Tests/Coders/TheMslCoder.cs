﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System.IO;
using ImageMagick;
using Xunit;

namespace Magick.NET.Tests
{
    public class TheMslCoder
    {
        [Fact]
        public void ShouldBeDisabled()
        {
            using var memStream = new MemoryStream();
            using var writer = new StreamWriter(memStream);
            writer.Write(@"
                <?xml version=""1.0"" encoding=""UTF-8""?>
                <image>
                    <read filename=""/tmp/text.gif"" />
                </image>");

            writer.Flush();

            memStream.Position = 0;

            var settings = new MagickReadSettings
            {
                Format = MagickFormat.Msl,
            };
            using var image = new MagickImage();

            Assert.Throws<MagickPolicyErrorException>(() => image.Read(memStream, settings));
        }
    }
}
