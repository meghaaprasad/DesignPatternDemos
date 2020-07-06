using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternSample
{
    public class Leaf : Component
    {
        public Leaf(string name):base(name)
        {

        }
        public override void Add(Component d)
        {
            Console.WriteLine("Cannot Add to Leaf element");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) +
         "+ " + _name);
        }

        public override void Remove(Component d)
        {
            Console.WriteLine("Cannot Remove from Leaf element");
        }
    }
}
