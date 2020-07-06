using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternSample
{
    public abstract class Component
    {
        protected string _name;

        // Constructor

        public Component(string name)
        {
            this._name = name;
        }

        public abstract void Add(Component d);
        public abstract void Remove(Component d);
        public abstract void Display(int indent);
    }
}
