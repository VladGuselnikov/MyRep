﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tdd;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSetWay()
        {
            var test_file = new NewFile();

            test_file.SetWay(@"D:\ПОЛИТЕХ\ПИ12А-8сем\vertify15\лабы\tdd\tdd\bin\Debug\myfile.txt");
            string result = test_file.way;
            Assert.IsTrue(result==@"D:\ПОЛИТЕХ\ПИ12А-8сем\vertify15\лабы\tdd\tdd\bin\Debug\myfile.txt");

        }
        [TestMethod]
        public void TestMakeNew()
        {
            var test_file = new NewFile();
            test_file.MakeNew();
            var result = test_file.way;
            Assert.IsTrue(result == @"D:\ПОЛИТЕХ\ПИ12А-8сем\vertify15\лабы\tdd\tdd\bin\Debug\myfile.txt");


        }

        [TestMethod]
        public void TestOverWrite()
        {
            var test_file = new NewFile();
            test_file.OverWrite();
            var result = test_file.sl;
            Assert.IsTrue(result == "0000000000\r\n");


        }

        [TestMethod]
        public void TestDelFile()
        {
            var test_file = new NewFile();
            test_file.DelFile();
            var result = test_file.way;
            Assert.IsTrue(result == @"D:\ПОЛИТЕХ\ПИ12А-8сем\vertify15\лабы\tdd\tdd\bin\Debug\myfile.txt");

        }
    }
}
