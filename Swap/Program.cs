namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number(a): ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a ="+a);
            
            Console.WriteLine("Enter second number(b):");
            
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("b =" + b);
            Console.WriteLine("After Swap: ");
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a ="+ a);
            Console.WriteLine("b = " + b);
        }
    }
}