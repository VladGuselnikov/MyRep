using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace tdd
{
    public class NewFile
    {
        public string way;
        public NewFile()
        {
            way = @"D:\ПОЛИТЕХ\ПИ12А-8сем\vertify15\лабы\tdd\tdd\bin\Debug\myfile.txt";

        }
        public void SetWay(string p)
        {
            way = p;
        }

        public void MakeNew()
        {
            FileStream fs = File.Create(way);
            fs.Close();

            StreamWriter sw = new StreamWriter(way);
            sw.WriteLine("0000000000");
            sw.Close();
        }
    }
}
