using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars;

namespace UnitTestRobotWars
{
    [TestClass]
    public class RobotTest
    {
        [TestMethod]
        public void GetNewDirection()
        {
            Coordinates areaSize = new Coordinates(5,5);

            Robots myRobot = new Robots (3,3,"N");
            myRobot.Instruction("L", areaSize);
            Assert.AreEqual("W", myRobot.Direction);
            myRobot.Instruction("L", areaSize);
            myRobot.Instruction("L", areaSize);
            Assert.AreEqual("E", myRobot.Direction);
            myRobot.Instruction("R", areaSize);
            myRobot.Instruction("R", areaSize);
            myRobot.Instruction("R", areaSize);
            Assert.AreEqual("N", myRobot.Direction);
        }

        [TestMethod]
        public void GetNewLocation()
        {
            Coordinates areaSize = new Coordinates(5, 5);
            Robots myRobot = new Robots(3, 3, "N");
            myRobot.Instruction("R", areaSize);
            myRobot.Instruction("M", areaSize);
            Assert.AreEqual(4, myRobot.X);
        }

        [TestMethod]
        public void CheckInvalidLocation()
        {
            Coordinates areaSize = new Coordinates(5,5);
            Robots myRobot = new Robots(3, 3, "N");
            myRobot.Instruction("M", areaSize);
            myRobot.Instruction("M", areaSize);
            bool result = myRobot.Instruction("M", areaSize);
            Assert.AreEqual(false, result);
        }

    }
}