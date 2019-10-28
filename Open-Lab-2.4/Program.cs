using System;

namespace Open_Lab_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm legs = new Farm();
            Console.WriteLine(Convert.ToInt32(legs.GetLegsCount(2, 1, 7)));
        }
    }
}
