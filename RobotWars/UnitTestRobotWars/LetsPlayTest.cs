﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars;

namespace UnitTestRobotWars
{
    [TestClass]
    public class LetsPlayTest
    {
        [TestMethod]
        public void LetsPlayInitialize()
        {
            string[] input = { "5 5", "1 3 N", "MMRLM", "3 3 N", "MM" };

            LetsPlay letsPlay = new LetsPlay(input);
            bool result = letsPlay.RobotWarsBeginPlay();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void MoveShip()
        {
            Coordinates arena = new Coordinates(5, 5);
            Robots enterprise = new Robots(3, 3, "N");

            enterprise.Instruction("M", arena);
            enterprise.Instruction("M", arena);
            Assert.AreEqual(3, enterprise.X);
            Assert.AreEqual(5, enterprise.Y);
        }
    }
}
