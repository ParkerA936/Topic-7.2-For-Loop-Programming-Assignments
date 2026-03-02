namespace Topic_7._2___For_Loop_Programming_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part2();
        }
        public static void Part1()
        {

            //assignment 1
            for (int i = 10; i >= 0; i= i-1)
            {
                Console.WriteLine(i);
               
                
            } 
            Console.WriteLine("Blastoff!");
        }
        public static void Part2()
        { Console.WriteLine("x\t\ty");
            //Assignment 2
            for (int i = -10; i <= 10; i = i + 2)
            {
               
                Console.WriteLine(i + "\t\t" + (i * i) );
            }
        }
        public static void Part3()
        {
            //assignment 3
            string name;
            Console.WriteLine("what is your name");
            name= Console.ReadLine();





        }
    }
}
