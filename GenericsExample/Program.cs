using System;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FinalTest<int> obj = new FinalTest<int>();
            obj.Add(10);
        }
    }
    public class FinalTest<T> where T : struct
    {
         public string value { get; set; }
        public void Add(T input)
        {
            this.value = input;
        }

    }
}
