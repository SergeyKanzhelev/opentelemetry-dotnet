// <copyright file="TagKeyTest.cs" company="OpenTelemetry Authors">
// Copyright 2018, OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
using System;
using Xunit;

namespace OpenTelemetry.Tags.Test
{
    public class TagKeyTest
    {
        [Fact]
        public void TestMaxLength()
        {
            Assert.Equal(255, string.MaxLength);
        }

        [Fact]
        public void TestGetName()
        {
            Assert.Equal("foo", "foo").Name);
        }

        [Fact]
        public void Create_AllowTagKeyNameWithMaxLength()
        {
            var chars = new char[string.MaxLength];
            for (var i = 0; i < chars.Length; i++)
            {
                chars[i] = 'k';
            }

            var key = new String(chars);
            Assert.Equal(key, key).Name);
        }

        [Fact]
        public void Create_DisallowTagKeyNameOverMaxLength()
        {
            var chars = new char[string.MaxLength + 1];
            for (var i = 0; i < chars.Length; i++)
            {
                chars[i] = 'k';
            }

            var key = new String(chars);
            Assert.Throws<ArgumentOutOfRangeException>(() => key));
        }

        [Fact]
        public void Create_DisallowUnprintableChars()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => "\u02ab\u03cd"));
        }

        [Fact]
        public void CreateString_DisallowEmpty()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ""));
        }

        [Fact]
        public void TestTagKeyEquals()
        {
            var key1 = "foo");
            var key2 = "foo");
            var key3 = "bar");
            Assert.Equal(key1, key2);
            Assert.NotEqual(key3, key1);
            Assert.NotEqual(key3, key2);

        }
    }
}
