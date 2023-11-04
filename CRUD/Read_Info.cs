using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManeger_01.CRUD
{
    internal class Save_Info
    {
        internal Save_Info() 
        {

        }
        
    }
    internal class Read_Info 
    {
        public Read_Info()
        {
            Console.WriteLine("Task : ");
            string NameTask = Console.ReadLine();
                            
            
            Console.WriteLine("When Will It Start : ");
            double Start_Time =Convert.ToDouble( Console.ReadLine());           
                      
             Console.WriteLine("When Will It End : ");
             double End_Time = Convert.ToDouble(Console.ReadLine());
             

             StreamReader Save_Count = new StreamReader(@"D:\TaskMan\Counter.txt");
             var Count = Save_Count.ReadLine();
             Save_Count.Close();
             StreamWriter Save_Information = new StreamWriter($@"D:\TaskMan\{Count}.txt");
            string start_AP;
            string end_AP;
            if (Start_Time>=12)
            {
                 
                start_AP=Start_Time.ToString() + " " + "PM";
            }
            else
            {
                start_AP = Start_Time.ToString() + " " + "AM";
            }
            if (End_Time>=12) 
            {
                end_AP = End_Time.ToString() +" "+ "PM";
            }
            else
            {
                end_AP = End_Time.ToString() + " " + "AM";
            }
            
             string[] Property_Task_title = new string[] { "Task : ", "Start Time : " , "End Time : "};
            string[] Property_Task = new string[] { NameTask, start_AP, end_AP };

             Console.WriteLine("Done! Information Saved");

            for (global::System.Int32 k = 0; k < Property_Task.Length; k++)
            {
                 Save_Information.Write(Property_Task_title[k]);
                 Save_Information.WriteLine(Property_Task[k]);
            }
             Save_Information.Close();
                             
            Console.ReadKey();
        }
    }
}
