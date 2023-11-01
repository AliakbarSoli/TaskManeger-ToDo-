using System;

public class Class1
{
    public Class1()
    {

        //int[] ints = new int[];
        Console.WriteLine("Task : ");
        string NameTask = Console.ReadLine();

        Console.WriteLine("When Will It Start : ");
        string Start_Time = Console.ReadLine();

        Console.WriteLine("AM Or PM (A,P) ");
        char start = Convert.ToChar(Console.ReadLine());
        switch (start)
        {
            case 'a':
                Class2 class2 = new Class2();
                break;
            default:
                break;
        }


            
        
        Console.ReadKey();
    }
}
