using System;

namespace DelegateDemo
{
    public delegate void AddDelegate(int a, int b);
    public delegate void SubDelegate(int a, int b);
    public delegate void StringDelegate(string str);
    class Operations
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine("Addition: " + (a + b));
        }
        public void SubNums(int a, int b)
        {
            Console.WriteLine("Substraction: " + (a - b));
        }
        public void Greet(string str)
        {
            Console.WriteLine(str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with delegates:");
            Operations operations = new Operations();
            //operations.AddNums(10, 5);
            //operations.SubNums(10, 5);
            AddDelegate ad = new AddDelegate(operations.AddNums);
            ad.Invoke(10, 5);
            SubDelegate sd = new SubDelegate(operations.SubNums);
            sd(10, 5);
            StringDelegate strd = new StringDelegate(operations.Greet);
            strd.Invoke("Hello");
        }
    }
}