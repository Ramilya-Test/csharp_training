﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("space");
            group.Footer = "space";
            group.Header = "space";
            app.Groups.Create(group);
        }
        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Footer = "";
            group.Header = "";
            app.Groups.Create(group);
        }
    }
}
