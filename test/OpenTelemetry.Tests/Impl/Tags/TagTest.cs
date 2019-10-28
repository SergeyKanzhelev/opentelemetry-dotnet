﻿// <copyright file="TagTest.cs" company="OpenTelemetry Authors">
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
using Xunit;

namespace OpenTelemetry.Tags.Test
{
    public class TagTest
    {
        [Fact]
        public void TestGetKey()
        {
            Assert.Equal("k"), Tag.Create(string.Create("k"), string.Create("v")).Key);
        }

        [Fact]
        public void TestTagEquals()
        {
            var tag1 = Tag.Create("Key"), string.Create("foo"));
            var tag2 = Tag.Create("Key"), string.Create("foo"));
            var tag3 = Tag.Create("Key"), string.Create("bar"));
            var tag4 = Tag.Create("Key2"), string.Create("foo"));
            Assert.Equal(tag1, tag2);
            Assert.NotEqual(tag1, tag3);
            Assert.NotEqual(tag1, tag4);
            Assert.NotEqual(tag2, tag3);
            Assert.NotEqual(tag2, tag4);
            Assert.NotEqual(tag3, tag4);

        }
    }
}
