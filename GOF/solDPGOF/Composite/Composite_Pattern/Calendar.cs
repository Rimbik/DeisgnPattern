using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    public class Calendar : Component
    {
        private List<Component> _children = new List<Component>();
        List<string> dispalyList = new List<string>();

        public Calendar(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override List<string> Display(int depth)
        {
            dispalyList.Add(new String('-', depth) + name);

            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }

            return dispalyList;
        }
    }
}
