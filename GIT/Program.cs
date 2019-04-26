using System;


namespace GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = args[0];
            //string name1 = args[1];
            //Console.WriteLine("japa " + name + (" ") + name1);

            foreach (var item in args)
            {
                Console.WriteLine("Hej ,dupcia, "+ item);
            }
        }
    }
}
