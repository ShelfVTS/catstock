using System;
using System.Runtime.CompilerServices;
using System.Threading;

public static class Program
{
    private static double slime1;
    private static double predictor;
    private static int i = 0;
    private static bool l = false;
    private static bool b = false;
    private static double gloomper;
    private static double spoomper;
    private static double changePos;
    private static double changeNeg;
    private static double max = 1;
    private static double min = 1;

    private static List<double> SNumbers = new List<double>();
    private static List<double> SNumbersPos = new List<double>();
    private static List<double> SNumbersNeg = new List<double>();
    private static Random rnd = new Random();

    public static void Main()
    {

        Console.WriteLine("Enter stock from week  -" + i);
        slime1 = Convert.ToInt32(Console.ReadLine());
        
        SNumbers.Add(slime1);
        min = SNumbers.Min();
        i++;
        
        if (slime1 != 0)
        {
            Main();
            
        }
        else
        {
            Timer t = new Timer(TimerCallback, null, 0, 1000);
            Console.ReadLine();
        }
        
    }

    private static void TimerCallback(Object o)
    {
        if(min == 0)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("In TimerCallback: " + DateTime.Now);
            Update();
        }
    }

    private static void Update()
    {
        gloomper = (rnd.Next(-10, 10));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(gloomper);
        SNumbers.Add(gloomper);
        spoomper = gloomper + (SNumbers[i - 1])/3;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        if (l && b)
        {
            Console.WriteLine(predictor);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("negative " + SNumbersNeg.Average() + " || " + "positive " + SNumbersPos.Average());
        }

        if (SNumbers[i] >= SNumbers[i-1])
        {
            predictor++;
            changePos = (SNumbers[i] - SNumbers[i - 1]);
            SNumbersPos.Add((int)changePos);
            l = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(i);
        }
        if (SNumbers[i] < SNumbers[i - 1])
        {
            predictor--;
            changeNeg = (SNumbers[i] - SNumbers[i - 1]);
            SNumbersNeg.Add((int)changeNeg);
            b = true;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(i);
        }

        max = SNumbers.Max();
        i++;

        Console.WriteLine("-------------------------------------------------------------------------------------------");
    }
}