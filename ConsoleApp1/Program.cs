namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World! its nory test ");
            Console.WriteLine("We Love Reem ");
            Console.WriteLine("PLZ enter YES Or NO ");

            var reemLove = Console.ReadLine().ToUpper();

            if(reemLove == "yse")
            {
                Console.WriteLine("<3");
            }
            else
            {
                Console.WriteLine("LALA");
            }

        }
    }
}