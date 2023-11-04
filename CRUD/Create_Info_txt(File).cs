using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManeger_01.CRUD
{
    internal class Create_Info_txt_File_
    {
        internal Create_Info_txt_File_() 
        {
            StreamReader sr = new StreamReader(@"D:\TaskMan\Counter.txt");
            int count=Convert.ToInt32(sr.ReadLine());
            count++;
            sr.Close();

            StreamWriter sw2 = new StreamWriter(@"D:\TaskMan\Counter.txt");
            sw2.WriteLine(count);
            sw2.Close();

            StreamWriter sw = new StreamWriter($@"D:\TaskMan\{count}.txt");
            sw.WriteLine();
            sw.Close();

        }


    }


}
