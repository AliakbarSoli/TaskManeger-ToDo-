using System;

public class Class2
{
	public Class2()
	{

        Console.WriteLine("When Will It End : ");
        string End_Time = Console.ReadLine();

        Console.WriteLine("AM Or PM (A,P) ");
        char End = Convert.ToChar(Console.ReadLine());

        StreamWriter sw = new StreamWriter(@"E:\Task\Task_01.txt");
        sw.Write("Task : ");
        //sw.WriteLine(NameTask);
        sw.Close();

    }
}
