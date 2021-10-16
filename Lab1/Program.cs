using System;
using System.Collections.Generic;
using Ann;
using core;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AnnLog.I().log("Введите три параметра: a, b и c");
                AnnLog.I().write();
                //Console.WriteLine("Введите три параметра: a, b и c");
                //AnnLog.I().write("Введите три параметра: a, b и c");
                float a = float.Parse(Console.ReadLine());
                float b = float.Parse(Console.ReadLine());
                float c = float.Parse(Console.ReadLine());


                //AnnLog.I().write("Введенное уравнение: " + b + "x" + " + " + c + " = 0");

                AnnLog.I().log("Введенное уравнение: " + a + "x^2" + " + " + b + "x" + " + " + c + " = 0");

                Quadratic equation = new Quadratic();
                List<float> arr = equation.Solve(a, b, c);
                AnnLog.I().log("Корни уравнения: " + string.Join(" ", arr));
            }
            catch (AnnException e)
            {
                AnnLog.I().log(e.Message);
            }
            AnnLog.I().write();
            Console.ReadKey();
        }
    }
}
