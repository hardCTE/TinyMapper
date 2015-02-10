﻿using System;
using System.IO;
using Nelibur.ObjectMapper.Core.Extensions;
using Xunit;

namespace UnitTests.Core.Extensions
{
    public sealed class TypeExtensionsTests
    {
        [Fact]
        public void HasDefaultCtor_MemoryStream_True()
        {
            Assert.True((typeof(MemoryStream)).HasDefaultCtor());
        }

        [Fact]
        public void HasDefaultCtor_String_False()
        {
            Assert.False((typeof(string)).HasDefaultCtor());
        }

        [Fact]
        public void IsNullable_NotNullable_False()
        {
            Assert.False(typeof(int).IsNullable());
        }

        [Fact]
        public void IsNullable_Nullable_True()
        {
            Assert.True(typeof(int?).IsNullable());
        }
    }
}