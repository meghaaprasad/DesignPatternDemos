using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternSample
{
    public class Composite : Component
    {
        public Composite(string name) : base(name)
        {

        }
        List<Component> _children = new List<Component>();

        public override void Add(Component d)
        {
            _children.Add(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) +
        "+ " + _name);

            foreach (var item in _children)
            {
                item.Display(indent++);
            }
        }

        public override void Remove(Component d)
        {
            _children.Remove(d);
        }
    }
}
