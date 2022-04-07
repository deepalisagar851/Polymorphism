using System;

namespace Method_overloading
{
    class Program
    {
        public void Add()
        {
            int a = 4;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(string a, string b)
        {
            string c = a +" "+ b;
            Console.WriteLine(c);

        }
        public void Add(float a, float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add();
            p.Add(6,8);
            p.Add("Deepali","Sagar");
            p.Add(2.5f,3.6f);
            Console.ReadLine();
        }
       
    }
}
