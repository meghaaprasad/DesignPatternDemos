using System;

namespace CompositePatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Composite Pattern Sample");
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite subroot = new Composite("subroot");
            subroot.Add(new Leaf("Leaf subroot A"));
            subroot.Add(new Leaf("Leaf subroot B"));

            root.Add(subroot);
            root.Add(new Leaf("Leaf C"));

            root.Display(1);
            Console.ReadLine();
        }
    }
}
