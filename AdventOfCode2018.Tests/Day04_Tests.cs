﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2018.Tests
{
    [TestClass()]
    public class Day04_Tests
    {
        [TestMethod()]
        public void ResolvePart1__BaseStatement()
        {
            Day04 day04 = new Day04();

            string result = day04.ResolvePart1(new string[] {
                "[1518-11-01 00:00] Guard #10 begins shift",
                "[1518-11-01 00:05] falls asleep",
                "[1518-11-01 00:25] wakes up",
                "[1518-11-01 00:30] falls asleep",
                "[1518-11-01 00:55] wakes up",
                "[1518-11-01 23:58] Guard #99 begins shift",
                "[1518-11-02 00:40] falls asleep",
                "[1518-11-02 00:50] wakes up",
                "[1518-11-03 00:05] Guard #10 begins shift",
                "[1518-11-03 00:24] falls asleep",
                "[1518-11-03 00:29] wakes up",
                "[1518-11-04 00:02] Guard #99 begins shift",
                "[1518-11-04 00:36] falls asleep",
                "[1518-11-04 00:46] wakes up",
                "[1518-11-05 00:03] Guard #99 begins shift",
                "[1518-11-05 00:45] falls asleep",
                "[1518-11-05 00:55] wakes up",
            });

            Assert.AreEqual("240", result);
        }

        [TestMethod()]
        public void ResolvePart1__BaseStatementUnsorted()
        {
            Day04 day04 = new Day04();

            string result = day04.ResolvePart1(new string[] {
                "[1518-11-04 00:36] falls asleep",
                "[1518-11-04 00:46] wakes up",
                "[1518-11-05 00:03] Guard #99 begins shift",
                "[1518-11-01 00:05] falls asleep",
                "[1518-11-01 00:25] wakes up",
                "[1518-11-02 00:40] falls asleep",
                "[1518-11-01 00:30] falls asleep",
                "[1518-11-03 00:29] wakes up",
                "[1518-11-02 00:50] wakes up",
                "[1518-11-03 00:05] Guard #10 begins shift",
                "[1518-11-03 00:24] falls asleep",
                "[1518-11-01 00:00] Guard #10 begins shift",
                "[1518-11-04 00:02] Guard #99 begins shift",
                "[1518-11-05 00:45] falls asleep",
                "[1518-11-01 00:55] wakes up",
                "[1518-11-01 23:58] Guard #99 begins shift",
                "[1518-11-05 00:55] wakes up",
            });

            Assert.AreEqual("240", result);
        }


        [TestMethod()]
        public void ResolvePart2__BaseStatement()
        {
            Day04 day04 = new Day04();

            string result = day04.ResolvePart2(new string[] {
                "[1518-11-01 00:00] Guard #10 begins shift",
                "[1518-11-01 00:05] falls asleep",
                "[1518-11-01 00:25] wakes up",
                "[1518-11-01 00:30] falls asleep",
                "[1518-11-01 00:55] wakes up",
                "[1518-11-01 23:58] Guard #99 begins shift",
                "[1518-11-02 00:40] falls asleep",
                "[1518-11-02 00:50] wakes up",
                "[1518-11-03 00:05] Guard #10 begins shift",
                "[1518-11-03 00:24] falls asleep",
                "[1518-11-03 00:29] wakes up",
                "[1518-11-04 00:02] Guard #99 begins shift",
                "[1518-11-04 00:36] falls asleep",
                "[1518-11-04 00:46] wakes up",
                "[1518-11-05 00:03] Guard #99 begins shift",
                "[1518-11-05 00:45] falls asleep",
                "[1518-11-05 00:55] wakes up",
            });

            Assert.AreEqual("4455", result);
        }

        [TestMethod()]
        public void ResolvePart2__BaseStatementUnsorted()
        {
            Day04 day04 = new Day04();

            string result = day04.ResolvePart2(new string[] {
                "[1518-11-04 00:36] falls asleep",
                "[1518-11-04 00:46] wakes up",
                "[1518-11-05 00:03] Guard #99 begins shift",
                "[1518-11-01 00:05] falls asleep",
                "[1518-11-01 00:25] wakes up",
                "[1518-11-02 00:40] falls asleep",
                "[1518-11-01 00:30] falls asleep",
                "[1518-11-03 00:29] wakes up",
                "[1518-11-02 00:50] wakes up",
                "[1518-11-03 00:05] Guard #10 begins shift",
                "[1518-11-03 00:24] falls asleep",
                "[1518-11-01 00:00] Guard #10 begins shift",
                "[1518-11-04 00:02] Guard #99 begins shift",
                "[1518-11-05 00:45] falls asleep",
                "[1518-11-01 00:55] wakes up",
                "[1518-11-01 23:58] Guard #99 begins shift",
                "[1518-11-05 00:55] wakes up",
            });

            Assert.AreEqual("4455", result);
        }
    }
}