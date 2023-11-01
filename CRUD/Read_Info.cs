using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManeger_01.CRUD
{
    public class Read_Info
    {
        char[] sta_End = new char[] {'a','p','A','P' };
       public Read_Info()
       {
            Console.WriteLine("Task : ");
            string NameTask = Console.ReadLine();

            Console.WriteLine("When Will It Start : ");
            string Start_Time = Console.ReadLine();

            Console.WriteLine("AM Or PM (A,P) ");
            char start = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i <= 3; i++)
            {
                
                    if (start == sta_End[i])
                    {  
                         Console.WriteLine("When Will It End : ");
                         string End_Time = Console.ReadLine();

                         Console.WriteLine("AM Or PM (A,P) ");
                         char End = Convert.ToChar(Console.ReadLine());

                         for (global::System.Int32 j = 0; j <= 3; j++)
                         {
                             if (End== sta_End[j])
                             {
                            Console.WriteLine("Done! Information Saved");
                        }
                         }
                }
                else
                {
                    Console.WriteLine("Please Enter TheCorrect Character (a,A,p,P)");
                    break;
                }
            }


                    Console.ReadKey();
       }
    }
}
