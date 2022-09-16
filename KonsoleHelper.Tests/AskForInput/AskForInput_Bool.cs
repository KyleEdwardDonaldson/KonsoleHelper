﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KonsoleHelper;

namespace KonsoleHelper.Tests.AskForInput
{
    [TestFixture]
    public class AskForInput_Char
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        [TestCase("")]
        [TestCase("Custom - what input would you like?")]
        public void ShouldPrintRequestForInput(string request)
        {
        }

        [Test]
        public void ShouldCallReadLine()
        {
        }

        [Test]
        public void Empty_ShouldRecallReadLineUntilNotEmpty()
        {

        }

        [Test]
        public void String_ShouldPrintInvalidInputMessage()
        {

        }

        [Test]
        public void String_ShouldRecallReadLine()
        {

        }
    }
}