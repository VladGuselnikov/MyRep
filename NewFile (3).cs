using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace tdd
{
    public class NewFile
    {
        int sl_count;
        public string way, sl;
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

        public void OverWrite()
        {
            int i;


            StreamReader sr = new StreamReader(way);
            sl = sr.ReadToEnd();
            sr.Close();
            sl_count = sl.Length - 2;
            StreamWriter sw = new StreamWriter(way);
            // sw.Dispose();

            for (i = 0; i < sl_count; i++)
                sw.Write("1");
            sw.Close();
            sw = new StreamWriter(way);
            for (i = 0; i < sl_count; i++)
                sw.Write("2");
            sw.Close();
        }
    }
}
