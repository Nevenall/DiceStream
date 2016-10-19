﻿using System;
using System.Linq;
using Xunit;
using DiceShow;


namespace DiceShow.Tests
{
    public class ParserTests
    {

        [Theory]
        [InlineData("2d6", "2d6")]
        [InlineData("2D6", "2d6")]
        [InlineData("2d4 2d6 2d8", "2d4, 2d6, 2d8")]
        [InlineData("2d4,2d6,2d8", "2d4, 2d6, 2d8")]
        [InlineData("2d4, 2d6, 2d8", "2d4, 2d6, 2d8")]
        [InlineData("This is a description: 2d6", "This is a description : 2d6")]
        [InlineData("This is a description : 2d6", "This is a description  : 2d6")]
        [InlineData("This is a description : 2d6 2d8", "This is a description : 2d6, 2d8")]
        public void can_parse_valid_input(string raw, string expected)
        {
            var parser = new Parser();

            var parsed = parser.Parse(raw);

            Assert.True(parsed.Roll != null, $"Parsing Errors = {string.Join(", ", parsed.Errors.Select(e => e.ToString()))}\nParsing Exception = {parsed.Exception}");
            Assert.Equal(expected, parsed.Roll.ToString());
        }

        [Theory]
        [InlineData("")]
        public void report_parsing_errors(string raw)
        {

            var parser = new Parser();

            var parsed = parser.Parse(raw);

            Assert.True(parsed.Exception != null, $"");

        }


    }
}
